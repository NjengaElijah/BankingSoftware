using Moshi_Bank.Models;
using System;
using System.Windows.Forms;  
namespace Moshi_Bank.Views
{
    public partial class LoanSettings : Form
    {
        public LoanSettings()
        {
            InitializeComponent(); API.filter(txtLIR, txtLSC);
        }
        private void btnUpdateLSC_Click(object sender, EventArgs e)
        {
            if (!txtLSC.Text.Trim().Equals(String.Empty))
            {
                try
                {
                    Moshi_Bank.API.Controllers.LoansData.UpdateStandingCharge(Convert.ToDouble(txtLSC.Text));
                    initComp();
                }
                catch (Exception ex)
                {
                    API.Message(ex.Message, MessageBoxIcon.Information);
                    return;
                }
            }
        }
        private void btnUpdateLIR_Click(object sender, EventArgs e)
        {
            if (!txtLIR.Text.Trim().Equals(String.Empty))
            {
                try
                {
                    Moshi_Bank.API.Controllers.LoansData.UpdateInterest(Convert.ToDouble(txtLIR.Text));
                    initComp();
                }
                catch (Exception ex)
                {
                    API.Message(ex.Message, MessageBoxIcon.Information);
                    return;
                }
            }
        }
        private void LoanSettings_Load(object sender, EventArgs e)
        {
            initComp();
        }
        LoanData ld = null;
        private void initComp()
        {
            datagridSupportDocs.Rows.Clear();
            ld = Moshi_Bank.API.Controllers.LoansData.GetLoanData();
            datagridSupportDocs.Rows.Add("Interest Rate", ld.InterestRate);
            txtLIR.Text = ld.InterestRate.ToString();
            txtLSC.Text = ld.StandingCharge.ToString();
            datagridSupportDocs.Rows.Add("Standing Charge", ld.StandingCharge);
        }
    }
}
