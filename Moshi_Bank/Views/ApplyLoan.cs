using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Moshi_Bank.Models;

namespace Moshi_Bank.Views
{
    public partial class ApplyLoan : Form
    {
        private List<Models.Guarantor> Guarantors = new List<Models.Guarantor>();
        private List<SupportDocument> SupportDocs = new List<SupportDocument>();
        Loan loan = new Loan();
        SimpleInterest si = new SimpleInterest();
        LoanData ld = null;
        public ApplyLoan()
        {
            InitializeComponent();
            si.DataChanged += Si_DataChanged;
            ld = API.Controllers.LoansData.GetLoanData();
            si.Rate = (decimal)ld.InterestRate;
            numericUpDown1.Value = 1;

        }

        private void Si_DataChanged(params object[] data)
        {
            datagridSI.Rows.Clear();
            loan.Principal = si.Principal;
            loan.Interest = si.Interest;
            loan.Rate = si.Rate;
            loan.MonthlyAmount = si.MonthlyAmount;
            loan.Amount = si.Amount;
            loan.Time = si.Time;
            loan.Balance = si.Amount;

            datagridSI.Rows.Add("Principal", si.Principal);
            datagridSI.Rows.Add("Rate", si.Rate + "%");
            datagridSI.Rows.Add("Time", si.Time + " (Months)");
            datagridSI.Rows.Add("Interest", si.Interest);
            datagridSI.Rows.Add("Monthly Amount", si.MonthlyAmount);

        }

        private void lnkAddGuarantor_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Guarantor guarantorD = new Guarantor();
            Models.Guarantor guarantor = guarantorD.GetGuarantor();

            if (guarantor.User.Id == findUser1.User.Id)
            {
                API.Message("You cannot be your own guarantor..", MessageBoxIcon.Warning);
            }
            else if (guarantor.User != null)
            {
                Guarantors.Add(guarantor);
                dgvGuarantors.Rows.Add(Guarantors.Count, guarantor.User.Names, guarantor.User.NationalId);
            }
        }

        private void lnkAddSD_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SupportDocument doc = new SupportDocument();
            SupportDocuments supportDocs = new SupportDocuments(doc);
            SupportDocs.Add(supportDocs.GetDocumentSupport());
            datagridSupportDocs.Rows.Add(SupportDocs.Count, doc.Description);
        }


        private void ApplyLoan_Load(object sender, EventArgs e)
        {
            ld = API.Controllers.LoansData.GetLoanData();
            API.filter(txtPrincipal, txtRate);
            txtRate.Text = Convert.ToString(ld.InterestRate);
            lblStandingCharge.Text = "Standing Charge " + ld.StandingCharge + "%";
        }

        private void findUser1_FoundUser(Account account, User user, object sender, EventArgs e)
        {
            txtAccNames.Text = "" + account.Names;
            txtAccBalance.Text = "" + account.Balance;
            if (hasExistingLoans(account.Number))
            {
                btnApply.Enabled = false;
            }
            else
            {
                btnApply.Enabled = true;
            }
        }
        bool hasExistingLoans(String accNo)
        {
            List<Loan> loans = API.Controllers.Loans.FindByAccountNumber(accNo);
            bool hasIncomplete = false;
            foreach (Loan l in loans)
            {
                if (l.Status != Loan.STATUS.COMPLETE)
                {
                    API.Message("An existing loan that is not complete was found !\nLoan Number #"+l.Id, MessageBoxIcon.Warning);
                    hasIncomplete = true;
                    break;
                }
            }
            return hasIncomplete;
        }
        private void btnApply_Click(object sender, EventArgs e)
        {
            if (findUser1.Account != null)
            {
                try
                {
                    if (hasExistingLoans(findUser1.Account.Number))
                    {
                        return;
                    }
                    else
                    {
                        loan.Account = findUser1.Account;
                        loan.Description = txtLoanDescription.Text;

                        loan.GUID = Guid.NewGuid().ToString();
                        loan.Status = Loan.STATUS.PENDING;
                        API.Controllers.Loans.Create(loan);
                        loan = API.Controllers.Loans.FindByGuid(loan.GUID);

                        for (int x = 0; x < Guarantors.Count; x++)
                        {
                            Guarantors[x].Loan = loan;
                        }

                        for (int x = 0; x < SupportDocs.Count; x++)
                        {
                            SupportDocs[x].Loan = loan;
                        }

                        API.Controllers.Loans.SupportDocuments.SaveSupportDocs(SupportDocs);
                        API.Controllers.Loans.Guarantors.SaveGuarantors(Guarantors);
                        API.Message("Loan Saved Successfully", MessageBoxIcon.Information);
                        SimpleInterestLoan sil = new SimpleInterestLoan(findUser1.Account, loan, si);
                        sil.ShowDialog();
                    }
                }
                catch (Exception ex)
                {
                    API.Message(ex.Message, MessageBoxIcon.Error);
                    return;
                }
            }
            else
            {
                API.Message("You Must First Select An Account", MessageBoxIcon.Error);
            }
        }

        private void txtPrincipal_TextChanged(object sender, EventArgs e)
        {
            try
            {
                txtStandingCharge.Text = Convert.ToString(Convert.ToDouble(txtPrincipal.Text) * (ld.StandingCharge / 100));
                loan.StandingCharge = Convert.ToDecimal(txtPrincipal.Text) * (decimal)(ld.StandingCharge / 100);
                si.Time = (int)numericUpDown1.Value;
                si.Principal = Convert.ToDecimal(txtPrincipal.Text);
                si.Calculate();
            }
            catch
            {

            }
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            si.Time = (int)numericUpDown1.Value;
            si.Principal = Convert.ToDecimal(txtPrincipal.Text);
            si.Calculate();
        }
    }
}
