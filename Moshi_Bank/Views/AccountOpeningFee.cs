using System;
using System.Windows.Forms;
using Moshi_Bank.Models;
namespace Moshi_Bank.Views
{
    public partial class AccountOpeningFee : Form
    {
        public AccountOpeningFee()
        {
            InitializeComponent();
        }

        private void AccountOpeningFee_Load(object sender , EventArgs e)
        {
            LoadData();
        }
        void LoadData()
        {
            cboAccType.Items.Clear();
            datagridFees.DataSource = Client.database.SelectForDataGridView("SELECT att.Description,Amount FROM fee as f inner join account_types as att on att.Id = f.`Type` ;" , null , null);
            cboAccType.Items.AddRange(new object[] { "Current Account" , "Fixed Deposit" });
        }
        private void btnSaveFee_Click(object sender , EventArgs e)
        {
            try
            {
                API.Controllers.Fees.Update(new Fee { AccountType = cboAccType.SelectedIndex , Amount = Convert.ToDouble(txtFee.Text) });
                API.Message("Saved Successfully.." , MessageBoxIcon.Information);
                txtFee.Clear();
                LoadData();
            }
            catch (Exception ex)
            {
                API.Message(ex.Message , MessageBoxIcon.Error);
                return;
            }
        }
    }
}
