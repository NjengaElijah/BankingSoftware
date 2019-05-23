using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Moshi_Bank.Models;

namespace Moshi_Bank.Views
{
    public partial class TransactionCharges : Form
    {
        public TransactionCharges()
        {
            InitializeComponent();
            API.filter(txtCharge , txtMaxVal , txtMinVal);
        }
        Dictionary<String , int> transactionChargeRange;
        Dictionary<String , int> transactionTypes;
        private void TransactionCharges_Load(object sender , EventArgs e)
        {
            transactionTypes = new Dictionary<string , int>();
            cboTransactionType.Items.AddRange(new String[] { "WITHDRAW" , "SEND_RECEIVE" });
            transactionTypes.Add("WITHDRAW" , 2);
            transactionTypes.Add("SEND_RECEIVE" , 3);
            LoadData();
        }
        private void LoadData()
        {
            try
            {

                transactionChargeRange = API.Controllers.TransactionCharges.LoadRanges();
                int cs = API.Controllers.Settings.GetChargingSystem();
                lblSystem.Text = API.Controllers.Settings.GetChargingSystem(cs);
                cboChargingSystem.SelectedIndex = cs - 1;
                cboPercentageRange.DataSource = transactionChargeRange.Keys.ToList();
                dgvTransactionCharges.DataSource =
                    Client.
                    database.
                    SelectForDataGridView(
                        "SELECT tc.`Id`,tc.`MinValue` as 'From',tc.`MaxValue` as 'To',tc.`Charge`,tc.`Percentage`,tt.`Description` FROM transaction_charges as tc inner join transaction_types as tt on tc.TransactionType = tt.Id" , null , null);

            }
            catch (Exception ex)
            {
                API.Message(ex.Message , MessageBoxIcon.Error);
                return;
            }
        }
        private void btnNewCharge_Click(object sender , EventArgs e)
        {
            if (txtCharge.Text.Trim().Equals(String.Empty) || txtMaxVal.Text.Trim().Equals(String.Empty) || txtMinVal.Text.Trim().Equals(String.Empty))
            {
                API.Message("Please Fill All Parameters" , MessageBoxIcon.Warning);
            }
            else if (!transactionTypes.ContainsKey(cboTransactionType.Text))
            {
                API.Message("An error has occured while matching values contact admin" , MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    TransactionCharge transactionCharge = new TransactionCharge
                    {
                        MaxValue = Convert.ToDouble(txtMaxVal.Text) ,
                        MinValue = Convert.ToDouble(txtMinVal.Text) ,
                        Charge = Convert.ToDouble(txtCharge.Text) ,
                        TransactionType = transactionTypes[cboTransactionType.Text]
                    };
                    API.Controllers.TransactionCharges.Create(transactionCharge);
                    API.Message("Transaction Created Successfully " + transactionCharge.MaxValue , MessageBoxIcon.Information);
                    this.LoadData();
                }
                catch (Exception ex)
                {
                    API.Message(ex.Message , MessageBoxIcon.Error);
                    return;
                }
            }

        }

        private void btnSavePercentage_Click(object sender , EventArgs e)
        {
            try
            {
                API.
                    Controllers.
                    TransactionCharges.
                    UpdatePercentage(transactionChargeRange[cboPercentageRange.Text] , numPercentage.Value);
                API.Message("Updated Successfully" , MessageBoxIcon.Information);
                LoadData();
            }
            catch (Exception ex)
            {
                API.Message(ex.Message , MessageBoxIcon.Error);
                return;
            }
        }

        private void btnUpdateChargingSystem_Click(object sender , EventArgs e)
        {
            try
            {
                API.Controllers.Settings.SaveChargingSystem(cboChargingSystem.SelectedIndex + 1);
                API.Message(
                    "Charging System Changes To : "
                    + API.Controllers.Settings.GetChargingSystem(cboChargingSystem.SelectedIndex + 1) ,
                    MessageBoxIcon.Information
                    );
                LoadData();
            }
            catch (Exception ex)
            {
                API.Message(ex.Message , MessageBoxIcon.Information);
                return;
            }
        }
        String transId;
        private void dgvTransactionCharges_RowEnter(object sender , DataGridViewCellEventArgs e)
        {
            txtCharge.Text = dgvTransactionCharges[3 , e.RowIndex].Value.ToString();
            transId = dgvTransactionCharges[0 , e.RowIndex].Value.ToString();
            txtMaxVal.Text = dgvTransactionCharges[2 , e.RowIndex].Value.ToString();
            txtMinVal.Text = dgvTransactionCharges[1 , e.RowIndex].Value.ToString();
            cboTransactionType.Text = dgvTransactionCharges[5 , e.RowIndex].Value.ToString();

        }

        private void cboPercentageRange_SelectedIndexChanged(object sender , EventArgs e)
        {

        }

        private void btnUpdateExisting_Click(object sender , EventArgs e)
        {
            try
            {
                API.
                    Controllers.
                    TransactionCharges.
                   UpdateValue(Convert.ToInt32(transId) , Convert.ToDouble(txtCharge.Text));
                API.Message("Updated Successfully " + transId, MessageBoxIcon.Information);
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
