using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BA_Dashboard
{
    public partial class row_0_col_0_RIght_UC : UserControl
    {
        public bool onDrag { get; set; }
        public row_0_col_0_RIght_UC()
        {
            InitializeComponent();
            onDrag = false;
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                onDrag = true;
            }
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (onDrag)
            {
                this.panel1.Height = pictureBox1.Top + e.Y;
                this.panel1.Width = pictureBox1.Left + e.X;

                pictureBox1.Top = this.panel1.Height - pictureBox1.Height;
                pictureBox1.Left = this.panel1.Width - pictureBox1.Width;
            }
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            if (onDrag)
            {
                onDrag = false;
            }
        }
    }
}
