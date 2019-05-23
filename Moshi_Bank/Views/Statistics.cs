using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using Moshi_Bank.Models;
using MySql.Data.MySqlClient;
using System.Threading.Tasks;
namespace Moshi_Bank.Views
{
    public partial class Statistics : Form
    {
        public Statistics()
        {
            InitializeComponent();

            chartDW.ChartAreas[0].AxisX.MajorGrid.LineColor = Color.White;
            chartDW.ChartAreas[0].AxisY.MajorGrid.LineColor = Color.White;
            chartDW.ChartAreas[0].AxisX2.MajorGrid.LineColor = Color.Gainsboro;
            chartDW.ChartAreas[0].AxisY2.MajorGrid.LineColor = Color.Gainsboro;
        }
        Account account = API.Controllers.Accounts.FetchByAccountNumber(0);
        private void Stats_Load(object sender, EventArgs e)
        {
            try
            {
                if (account != null)
                {
                    lblSystemBalance.Text = account.Balance + "";
                    datagrid1.DataSource =
                        Client.
                        database.
                        SelectForDataGridView(
                            "select Code,Type,Credit,DateStamp from system_transactions WHERE `AccountNumber` = @acc;"
                            , new Client.SQL().ParameterRange("@acc")
                            , new Client.SQL().ValuesRange(account.Number));
                }


                datagridFixedDep.DataSource =
                    Client.
                    database.
                    SelectForDataGridView("select count(*) as 'No Of Accounts' , sum(accounts.Balance) as 'Total Balances' from accounts where accounts.`Type` = 1"
                    , null
                    , null);

                datagridSavingsAccount.DataSource =
                    Client.
                    database.
                    SelectForDataGridView(
                        "select count(*) as 'No Of Accounts' , sum(accounts.Balance) as 'Total Balances' from accounts where accounts.`Type` = 0"
                        , null
                        , null);

                datagridTotals.DataSource =
                    Client.
                    database.
                    SelectForDataGridView(
                        "select count(*) as 'Total No Of Accounts' , sum(accounts.Balance) as 'Total Balances' from accounts where accounts.`Type` >= 0"
                        , null
                        , null);
                List<double> credits = new List<double>();
                List<double> debits = new List<double>();
                double credit = 0, debit = 0;
                DataGridViewRow dataRow = new DataGridViewRow();
                MySqlDataReader dataX = Client.database.executeQuerry("select * from dt");
                List<String> dates = new List<String>();
                while (dataX.Read())
                {
                    dates.Add(dataX[0].ToString());
                }
                dataX.Close();
                foreach (object date in dates)
                {
                    MySqlDataReader dataY = Client.database.executeQuerry("select sum(credit) as c,sum(debit) as d from credits_debits where `Day` = '" + date + "';");
                    while (dataY.Read())
                    {
                        credits.Add(dataY.GetDouble("c"));
                        debits.Add(dataY.GetDouble("d"));
                    }
                    dataY.Close();
                }

                for (int x = 0; x < dates.Count; x++)
                {
                    chartDW.Series[0].Points.AddXY(x, credits[x]);
                    credit += credits[x];
                    debit += debits[x];
                    chartDW.Series[1].Points.AddXY(x, debits[x]);
                    dgvDailySubSummary.Rows.Add(dates[x], credits[x], -debits[x], null, credits[x] - debits[x]);
                }
                dgvDailySubSummary.Rows.Add("TOTALS", credit, -debit, null, credit - debit);



            }
            catch (Exception ex)
            {
                API.Message(ex.Message, MessageBoxIcon.Error);
                return;
            }
            finally
            {

                Client.database.CloseConnection();
                Client.database.OpenConnection();
            }
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            datagrid2.DataSource =
                               Client.
                               database.
                               SelectForDataGridView(
                                   "select Code,Type,Credit,DateStamp from system_transactions WHERE `AccountNumber` = @acc and days = @days;"
                                   , new Client.SQL().ParameterRange("@acc", "@days")
                                   , new Client.SQL().ValuesRange(account.Number,dateTimePicker1.Text));
        }
    }
}
