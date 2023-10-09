using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace backcolorV2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void cbMor_CheckedChanged(object sender, EventArgs e)
        {
            if (cbPurple.Checked == true)
            {
                this.BackColor = Color.Purple;
            }
            else
            {
                this.BackColor = Color.White;
            }
        }

        private void cbMavi_CheckedChanged(object sender, EventArgs e)
        {
            if (cbBlue.Checked == true)
            {
                this.BackColor = Color.Blue;
            }
            else
            {
                this.BackColor = Color.White;
            }
        }

        private void cbYellow_CheckedChanged(object sender, EventArgs e)
        {
            if (cbYellow.Checked == true)
            {
                this.BackColor = Color.Yellow;
            }
            else
            {
                this.BackColor = Color.White;
            }
        }

        private void cbYesil_CheckedChanged(object sender, EventArgs e)
        {
            if (cbGreen.Checked == true)
            {
                this.BackColor = Color.Green;
            }
            else
            {
                this.BackColor = Color.White;
            }
        }

        private void cbsiyah_CheckedChanged(object sender, EventArgs e)
        {
            if (cbBlack.Checked == true)
            {
                this.BackColor = Color.Black;
            }
            else
            {
                this.BackColor = Color.White;
            }
        }
    }
    
}
