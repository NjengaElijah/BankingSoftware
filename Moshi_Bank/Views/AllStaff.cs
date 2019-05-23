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
    public partial class AllStaff : Form
    {
        public AllStaff()
        {
            InitializeComponent();
        }

        private void AllStaff_Load(object sender, EventArgs e)
        {
            DataRefresh();
        }
        void DataRefresh()
        {

            dgvStaff.DataSource =
                Client.database.SelectForDataGridView("SELECT st.Id AS 'Staff Id',l.`Level`, st.Names,st.NationalId,st.Email FROM staff AS st INNER JOIN levels AS l ON st.`Level` = l.Id;", null, null);
            comboBox1.SelectedIndex = 0;
        }
        private Staff Staff { get; set; }
        private void dgvStaff_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Staff = API.Controllers.Staffs.FindByStaffNo(dgvStaff[0, e.RowIndex].Value);
            if (Staff != null)
            {
                pictureBox1.Image = API.ImageFromByte(Staff.UserPhoto);
            }
        }

        private void btnChangePassword_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Trim().Equals(String.Empty))
            {
                API.Message("Please Provide a password", MessageBoxIcon.Information);
            }
            else
            {
                try
                {
                    API.Controllers.Staffs.UpdatePassword(textBox1.Text, Staff.Id);
                    API.Message("Password Updated Successfully", MessageBoxIcon.Information);

                    DataRefresh();
                }
                catch (Exception ex)
                {
                    API.Message(ex.Message, MessageBoxIcon.Error);
                    return;
                }

            }
        }

        private void btnUpdateLevel_Click(object sender, EventArgs e)
        {
            try
            {
                API.Controllers.Staffs.UpdateLevel(comboBox1.SelectedIndex + 1, Staff.Id);
                API.Message("Level Changed Successfully", MessageBoxIcon.Information);

                DataRefresh();
            }
            catch (Exception ex)
            {
                API.Message(ex.Message, MessageBoxIcon.Error);
                return;
            }
        }
    }
}
