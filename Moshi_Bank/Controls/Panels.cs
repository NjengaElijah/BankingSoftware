using System;
using System.Drawing;
using System.Windows.Forms;
namespace Moshi_Bank.Contols
{
    public partial class Panels : UserControl
    {
        public delegate void evt(object sender, EventArgs e);
        public event evt Clicked;
        public Panels()
        {
            InitializeComponent();

            BackColor = BColor;
            pictureBox1.BackColor = BColor;

            //TabIndexChanged += pictureBox1_MouseEnter; 
            this.GotFocus += Panels_GotFocus;
            this.LostFocus += Panels_LostFocus;
            this.Click += Panels_Click;
            //label1.Click += base.OnClick(null, new EventArgs()); ;
            label1.Click += Panels_Click;
            pictureBox1.Click += Panels_Click;

            pictureBox1.MouseEnter += pictureBox1_MouseEnter;
            this.MouseEnter += pictureBox1_MouseEnter;
            label1.MouseEnter += pictureBox1_MouseEnter;

            pictureBox1.MouseLeave += pictureBox1_MouseLeave;
            this.MouseLeave += pictureBox1_MouseLeave;
            label1.MouseLeave += pictureBox1_MouseLeave;TabIndex = 1;
        }



        void Panels_Click(object sender, EventArgs e)
        {
            if (Clicked != null)
                Clicked(sender, e);
        }
        void Panels_LostFocus(object sender, EventArgs e)
        {
            BorderStyle = BorderStyle.None;
        }

        void Panels_GotFocus(object sender, EventArgs e)
        {
            BorderStyle = BorderStyle.FixedSingle;
        }

        void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            if (!Focused)
                BorderStyle = BorderStyle.None;
        }

        void pictureBox1_MouseEnter(object sender, EventArgs e)
        {
            if (!Focused)
                BorderStyle = BorderStyle.FixedSingle;
        }
        private Color HooverColor = Color.Gray;
        private Color BColor = Color.White;
        /// <summary>
        /// Sets The Icon For the Control
        /// </summary>

        public Image Icon
        {
            get
            {
                return pictureBox1.Image;
            }
            set
            {
                pictureBox1.Image = value;
            }
        }
        public Color MouseHooverColor
        {
            get
            {
                return HooverColor;
            }
            set
            {
                HooverColor = value;
            }
        }
        public Color BackgroundColor
        {
            get
            {
                return BColor;
            }
            set
            {
                BColor = value; pictureBox1.BackColor = value;
            }
        }
        public override Color BackColor
        {
            get
            {
                return BackgroundColor;
            }
            set
            {
                BackgroundColor = value;
            }
        }
        public PictureBoxSizeMode ImageSizeMode
        {
            get
            {
                return pictureBox1.SizeMode;
            }
            set
            {
                pictureBox1.SizeMode = value;
            }
        }
        public string Description
        {
            get
            {
                return label1.Text;
            }
            set
            {
                label1.Text = value;
            }
        }

        public Color TitleColor
        {
            get { return label1.BackColor; }
            set { label1.BackColor = value; }
        }
        public Color TextColor
        {
            get { return label1.ForeColor; }
            set { label1.ForeColor = value; }
        }



        private void Panels_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
