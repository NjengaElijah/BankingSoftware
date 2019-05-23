using Moshi_Bank.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Moshi_Bank.Views
{
    public partial class LoanMoreDetails : Form
    {
        public LoanMoreDetails(Loan loan)
        {
            InitializeComponent();Loan = loan;
        }
        public Loan Loan { get; set; }
        public SupportDocument Doc { get; set; }
        public Models.Guarantor Guarantor { get; set; }
        private void LoanMoreDetails_Load(object sender, EventArgs e)
        {
            List<Models.Guarantor> guarantors = API.Controllers.Loans.Guarantors.LoanGuarantors(Loan.Id);
            List<Models.SupportDocument> docs = API.Controllers.Loans.SupportDocuments.SupportDocs(Loan.Id);
            gc.Text = guarantors.Count.ToString();
            sdc.Text = docs.Count.ToString();

            foreach (Models.Guarantor g in guarantors)
            {
                g.User = API.Controllers.Users.FindById(g.User.Id);
                datagrid1.Rows.Add(g.User.Names, g.User.NationalId, g.User.Address);
            }
            foreach (Models.SupportDocument doc in docs)
            {
                datagrid2.Rows.Add(doc.Description,API.ImageFromByte(doc.Document));
            }
        }
    }
}
