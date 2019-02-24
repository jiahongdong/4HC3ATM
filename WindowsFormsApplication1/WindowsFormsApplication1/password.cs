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
    public partial class password : Form
    {
        public password()
        {
            InitializeComponent();
        }

        private void lblPin1_Click(object sender, EventArgs e)
        {

        }

        private void passwordNum1_Click(object sender, EventArgs e)
        {
            lblPin1.Text = lblPin1.Text + "1";
        }

        private void passwordNum2_Click(object sender, EventArgs e)
        {
            lblPin1.Text = lblPin1.Text + "2";
        }

        private void passwordNum3_Click(object sender, EventArgs e)
        {
            lblPin1.Text = lblPin1.Text + "3";
        }

        private void passwordNum4_Click(object sender, EventArgs e)
        {
            lblPin1.Text = lblPin1.Text + "4";
        }

        private void passwordNum5_Click(object sender, EventArgs e)
        {
            lblPin1.Text = lblPin1.Text + "5";
        }

        private void passwordNum6_Click(object sender, EventArgs e)
        {
            lblPin1.Text = lblPin1.Text + "6";
        }

        private void passwordNum7_Click(object sender, EventArgs e)
        {
            lblPin1.Text = lblPin1.Text + "7";
        }

        private void passwordNum8_Click(object sender, EventArgs e)
        {
            lblPin1.Text = lblPin1.Text + "8";
        }

        private void passwordNum9_Click(object sender, EventArgs e)
        {
            lblPin1.Text = lblPin1.Text + "9";
        }

        private void passwordNum0_Click(object sender, EventArgs e)
        {
            lblPin1.Text = lblPin1.Text + "0";
        }

        private void button11_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void passwordCancel_Click(object sender, EventArgs e)
        {
            DialogResult iExit;
            iExit = MessageBox.Show("Confirm you want to exit", "ATM system", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (iExit == DialogResult.Yes)
            {
                start link = new start();
                this.Hide();
                link.ShowDialog();
            }
        }

        private void passwordClear_Click(object sender, EventArgs e)
        {
            lblPin1.Text = " ";
        }

        private void passwordEnter_Click(object sender, EventArgs e)
        {
            DialogResult invalidpassword;
            mainMenu link = new mainMenu();
            if (lblPin1.Text.Equals("1357"))
            {
                this.Hide();
                link.ShowDialog(); 
            }
            else
            {
                invalidpassword = MessageBox.Show("Password is wrong");
                passwordClear_Click(sender, e);
                passwordback_Click(sender, e);
            }
        }

        private void passwordback_Click(object sender, EventArgs e)
        {
            if (lblPin1.Text.Length != 0)
            {
                lblPin1.Text = lblPin1.Text.Remove(lblPin1.Text.Length - 1, 1);
            }
            else { }
        }

        private void EnterPassword_Click(object sender, EventArgs e)
        {

        }
    }
}
