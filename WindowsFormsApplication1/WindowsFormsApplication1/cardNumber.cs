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
    public partial class cardNumber : Form
    {
        public cardNumber()
        {
            InitializeComponent();
        }

        private void cardNumpad_Enter(object sender, EventArgs e)
        {

        }

        private void cardNumBox1_Enter(object sender, EventArgs e)
        {

        }
        private void lblPin_Click(object sender, EventArgs e)
        {

        }

        private void cardNum1_Click(object sender, EventArgs e)
        {
            lblPin.Text = lblPin.Text + "1";
        }

        private void cardNum2_Click(object sender, EventArgs e)
        {
            lblPin.Text = lblPin.Text + "2";
        }

        private void cardNum3_Click(object sender, EventArgs e)
        {
            lblPin.Text = lblPin.Text + "3";
        }

        private void cardNum4_Click(object sender, EventArgs e)
        {
            lblPin.Text = lblPin.Text + "4";
        }

        private void cardNum5_Click(object sender, EventArgs e)
        {
            lblPin.Text = lblPin.Text + "5";
        }

        private void cardNum6_Click(object sender, EventArgs e)
        {
            lblPin.Text = lblPin.Text + "6";
        }

        private void cardNum7_Click(object sender, EventArgs e)
        {
            lblPin.Text = lblPin.Text + "7";
        }

        private void cardNum8_Click(object sender, EventArgs e)
        {
            lblPin.Text = lblPin.Text + "8";
        }

        private void cardNum9_Click(object sender, EventArgs e)
        {
            lblPin.Text = lblPin.Text + "9";
        }

        private void cardNum0_Click(object sender, EventArgs e)
        {
            lblPin.Text = lblPin.Text + "0";
        }

        private void cardClear_Click(object sender, EventArgs e)
        {
            lblPin.Text = " ";
        }

        private void cardBack_Click(object sender, EventArgs e)
        {
            if (lblPin.Text.Length != 0){
                lblPin.Text = lblPin.Text.Remove(lblPin.Text.Length - 1, 1);
            }
            else {}
        }

        private void btnPassword_Click(object sender, EventArgs e)
        {
            DialogResult invalidcard;
            password link = new password();
            if (lblPin.Text.Length == 8)
            {
                this.Hide();
                link.ShowDialog();
            }
            else
            {
               invalidcard = MessageBox.Show("Invalid card number");
                cardClear_Click(sender, e);
                cardBack_Click(sender, e);
            }
        }

        private void cardCancel_Click(object sender, EventArgs e)
        {
            DialogResult iExit;
            iExit = MessageBox.Show("Confirm you want to exit", "ATM system", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            
            if(iExit == DialogResult.Yes)
            {
                start link = new start();
                this.Hide();
                link.ShowDialog();
            }
        }

        private void EnterCard_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button11_Click(object sender, EventArgs e)
        {

        }
    }
}
