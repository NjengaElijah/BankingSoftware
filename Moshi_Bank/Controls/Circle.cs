using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Moshi_Bank.Controls
{
    public partial class Circle : PictureBox
    {
        public Circle()
        {
            InitializeComponent();
            makeround(this);
            this.Resize += Circle_Resize;
        }

        void Circle_Resize(object sender, EventArgs e)
        {
            Width = Height;
            makeround(this);
        }
        public void makeround(PictureBox PictureBox)
        {
            System.Drawing.Drawing2D.GraphicsPath gp = new System.Drawing.Drawing2D.GraphicsPath();
            gp.AddEllipse(0, 0, PictureBox.Width, PictureBox.Height);
            Region r = new Region(gp);
            PictureBox.Region = r;

        }
    }
}
