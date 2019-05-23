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
    public partial class Title : UserControl
    {
        public Title()
        {
            InitializeComponent();
        }
        public string TitleText
        {
            get
            {
                return label12.Text;
            }
            set
            {
                label12.Text = value;
            }
        }
        public Panel Panel
        {
            get
            {
                return panel6;
            }
            set
            {
                panel6 = value;
            }
        }
        public Color LineColor
        {
            get
            {
                return panel6.BackColor;
            }
            set
            {
                panel6.BackColor = value;
            }
        }
        public Font TextFont
        {
            get
            {
                return label12.Font;
            }
            set
            {
                label12.Font = value;
            }
        }
        public Color TextColor
        {
            get
            {
                return label12.ForeColor;
            }
            set
            {
                label12.ForeColor = value;
            }
        }
    }
}
