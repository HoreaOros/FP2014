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
        enum Operator { Plus, Minus, Inmultire, Impartire, Rest };
        Operator op = Operator.Plus;
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

            try
            {
                opLeft = int.Parse(txtOpStg.Text);
                opRight = int.Parse(txtOpDr.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Oops! Something went wrong!\nThis is really embarassing.", "Mesaj", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

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

        private void txtOpStg_TextChanged(object sender, EventArgs e)
        {
            string ops = "+";
            switch (op)
            {
                case Operator.Plus:
                    ops = "+";
                    break;
                case Operator.Minus:
                    ops = "-";
                    break;
                case Operator.Inmultire:
                    ops = "*";
                    break;
                case Operator.Impartire:
                    ops = "/";
                    break;
                case Operator.Rest:
                    ops = "%";
                    break;
                default:
                    break;
            }
            this.txtExpresie.Text = this.txtOpStg.Text + " " + ops + " " +  this.txtOpDr.Text;

        }

        private void txtOpDr_TextChanged(object sender, EventArgs e)
        {
            this.txtExpresie.Text = this.txtOpStg.Text + " " + this.txtOpDr.Text;
        }

        private void rbtPlus_CheckedChanged(object sender, EventArgs e)
        {
            op = Operator.Plus;
        }

        private void rbtMinus_CheckedChanged(object sender, EventArgs e)
        {
            op = Operator.Minus;
        }

        private void rbtInmultire_CheckedChanged(object sender, EventArgs e)
        {
            op = Operator.Inmultire;
        }

        private void rbtImpartire_CheckedChanged(object sender, EventArgs e)
        {
            op = Operator.Impartire;
        }

        private void rbtRest_CheckedChanged(object sender, EventArgs e)
        {
            op = Operator.Rest;
        }
    }
}
