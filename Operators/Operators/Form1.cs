using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Operators
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCalcul_Click(object sender, EventArgs e)
        {
            int opLeft = 0, opRight = 0;
            int rezultat = 0;
            opLeft = int.Parse(txtOpStg.Text);
            opRight = int.Parse(txtOpDr.Text);

            if (rbtPlus.Checked)
                rezultat = opLeft + opRight;
            else if (rbtMinus.Checked)
            {
                rezultat = opLeft - opRight;
            }
            else if (rbtInmultire.Checked)
            {
                rezultat = opLeft * opRight;
            }
            else if (rbtImpartire.Checked)
            {
                rezultat = opLeft / opRight;
            }
            else if (rbtRest.Checked)
            {
                rezultat = opLeft % opRight;       
            }

            this.txtRezultat.Text = rezultat.ToString();
        }
    }
}
