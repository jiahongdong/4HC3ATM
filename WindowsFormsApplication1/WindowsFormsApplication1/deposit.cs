using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class deposit : Form
    {
        public deposit()
        {
            InitializeComponent();
        }

        private void EnterAmountDepo_Click(object sender, EventArgs e)
        {

        }

        private void lblPin3_Click(object sender, EventArgs e)
        {

        }

        private void depoNum1_Click(object sender, EventArgs e)
        {
            lblPin3.Text = lblPin3.Text + "1";
        }

        private void depoNum2_Click(object sender, EventArgs e)
        {
            lblPin3.Text = lblPin3.Text + "2";
        }

        private void depoNum3_Click(object sender, EventArgs e)
        {
            lblPin3.Text = lblPin3.Text + "3";
        }

        private void depoNum4_Click(object sender, EventArgs e)
        {
            lblPin3.Text = lblPin3.Text + "4";
        }

        private void depoNum5_Click(object sender, EventArgs e)
        {
            lblPin3.Text = lblPin3.Text + "5";
        }

        private void depoNum6_Click(object sender, EventArgs e)
        {
            lblPin3.Text = lblPin3.Text + "6";
        }

        private void depoNum7_Click(object sender, EventArgs e)
        {
            lblPin3.Text = lblPin3.Text + "7";
        }

        private void depoNum8_Click(object sender, EventArgs e)
        {
            lblPin3.Text = lblPin3.Text + "8";
        }

        private void depoNum9_Click(object sender, EventArgs e)
        {
            lblPin3.Text = lblPin3.Text + "9";
        }

        private void depoNum0_Click(object sender, EventArgs e)
        {
            lblPin3.Text = lblPin3.Text + "0";
        }

        private void depoCancel_Click(object sender, EventArgs e)
        {
            Close();
            mainMenu link = new mainMenu();
            this.Hide();
            link.ShowDialog();
        }

        private void depoClear_Click(object sender, EventArgs e)
        {
            lblPin3.Text = " ";
        }

        private void depoBack_Click(object sender, EventArgs e)
        {
            if (lblPin3.Text.Length != 0)
            {
                lblPin3.Text = lblPin3.Text.Remove(lblPin3.Text.Length - 1, 1);
            }
            else { }
        }

        private void depoEnter_Click(object sender, EventArgs e)
        {
            DialogResult invalidAmount;
            int i = Convert.ToInt32(lblPin3.Text);
            if (i%20==0||i%50==0||i%10==0||i%5==0||i%100==0)
            {
                toAccount link = new toAccount();
                this.Hide();
                link.ShowDialog();
            }
            else
            {
                invalidAmount = MessageBox.Show("Amount must be multiple of 5,10,20,50,100");
                depoClear_Click(sender, e);
                depoBack_Click(sender, e);
            }
        }

        
    }
}
