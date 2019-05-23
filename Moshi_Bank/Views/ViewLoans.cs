using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Moshi_Bank.Views
{
    public partial class ViewLoans : Form
    {
        public ViewLoans()
        {
            InitializeComponent();
            API.filter(txtAccNo, txtLoanNo);
        }

        private void ViewLoans_Load(object sender, EventArgs e)
        {
            cboAction.SelectedIndex = 0;
        }
        private void cboAction_SelectedIndexChanged(object sender, EventArgs e)
        {
            Invoke(new MethodInvoker(() =>
            {
                if (cboAction.SelectedIndex == 0)
                {
                    dgvLoans.DataSource = Client.database.SelectForDataGridView("SELECT * FROM v_all_loans;", null, null);
                }
                else
                {
                    dgvLoans.DataSource = Client.database.SelectForDataGridView("SELECT * FROM v_all_loans WHERE Status = '" + cboAction.Text + "';", null, null);
                }
            }));
        }

        private void dgvLoans_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Models.Loan loan = API.Controllers.Loans.FindById(dgvLoans[0, e.RowIndex].Value);
            Models.Account account = null;
            if (loan != null)
            {
                account = API.Controllers.Accounts.FetchByAccountNumber(loan.Account.Number);
            }
            Models.SimpleInterest si = new Models.SimpleInterest((decimal)loan.Principal, (decimal)loan.Rate, loan.Time, (decimal)loan.StandingCharge);
            si.Calculate();
            SimpleInterestLoan sil = new SimpleInterestLoan(account, loan, si);
            sil.ShowDialog();
        }

        private void btnAccNo_Click(object sender, EventArgs e)
        {
            Invoke(new MethodInvoker(() =>
            {
                if (cboAction.SelectedIndex == 0)
                {
                    dgvLoans.DataSource = Client.database.SelectForDataGridView(
                        "SELECT * FROM v_all_loans WHERE `Acc.No` = @acc;"
                        , new List<string> { "@acc" }, new List<object> { txtAccNo.Text });
                }
                else
                {
                    dgvLoans.DataSource = Client.database.SelectForDataGridView(
                        "SELECT * FROM v_all_loans WHERE Status = '" + cboAction.Text + "' AND `Acc.No` = @acc;"
                        , new List<string> { "@acc" }, new List<object> { txtAccNo.Text });
                }
            }));
        }

        private void btnLoanNo_Click(object sender, EventArgs e)
        {
            Invoke(new MethodInvoker(() =>
            {
                dgvLoans.DataSource = Client.database.SelectForDataGridView(
                           "SELECT * FROM v_all_loans WHERE `#` = @ln;"
                           , new List<string> { "@ln" }, new List<object> { txtLoanNo.Text });

            }));
        }
    }
}
