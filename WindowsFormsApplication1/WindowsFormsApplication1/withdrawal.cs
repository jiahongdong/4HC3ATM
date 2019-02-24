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
    public partial class withdrawal : Form
    {
        public withdrawal()
        {
            InitializeComponent();
        }

        private void with80_Click(object sender, EventArgs e)
        {
            withdrawalConfirm link = new withdrawalConfirm();
            this.Hide();
            link.ShowDialog();
        }

        private void amountNum1_Click(object sender, EventArgs e)
        {
            lblPin2.Text = lblPin2.Text + "1";
        }

        private void amountNum2_Click(object sender, EventArgs e)
        {
            lblPin2.Text = lblPin2.Text + "2";
        }

        private void amountNum3_Click(object sender, EventArgs e)
        {
            lblPin2.Text = lblPin2.Text + "3";
        }

        private void amountNum4_Click(object sender, EventArgs e)
        {
            lblPin2.Text = lblPin2.Text + "4";
        }

        private void amountNum5_Click(object sender, EventArgs e)
        {
            lblPin2.Text = lblPin2.Text + "5";
        }

        private void amountNum6_Click(object sender, EventArgs e)
        {
            lblPin2.Text = lblPin2.Text + "6";
        }

        private void amountNum7_Click(object sender, EventArgs e)
        {
            lblPin2.Text = lblPin2.Text + "7";
        }

        private void amountNum8_Click(object sender, EventArgs e)
        {
            lblPin2.Text = lblPin2.Text + "8";
        }

        private void amountNum9_Click(object sender, EventArgs e)
        {
            lblPin2.Text = lblPin2.Text + "9";
        }

        private void amountNum0_Click(object sender, EventArgs e)
        {
            lblPin2.Text = lblPin2.Text + "0";
        }

        private void amountCancel_Click(object sender, EventArgs e)
        {
            Close();
            mainMenu link = new mainMenu();
            this.Hide();
            link.ShowDialog();
        }

        private void amountClear_Click(object sender, EventArgs e)
        {
            lblPin2.Text = " ";
        }

        private void amountback_Click(object sender, EventArgs e)
        {
            if (lblPin2.Text.Length != 0)
            {
                lblPin2.Text = lblPin2.Text.Remove(lblPin2.Text.Length - 1, 1);
            }
            else { }
        }

        private void with20_Click(object sender, EventArgs e)
        {
            withdrawalConfirm link = new withdrawalConfirm();
            this.Hide();
            link.ShowDialog();
        }

        private void with40_Click(object sender, EventArgs e)
        {
            withdrawalConfirm link = new withdrawalConfirm();
            this.Hide();
            link.ShowDialog();
        }

        private void with60_Click(object sender, EventArgs e)
        {
            withdrawalConfirm link = new withdrawalConfirm();
            this.Hide();
            link.ShowDialog();
        }

        private void with100_Click(object sender, EventArgs e)
        {
            withdrawalConfirm link = new withdrawalConfirm();
            this.Hide();
            link.ShowDialog();
        }

        private void with120_Click(object sender, EventArgs e)
        {
            withdrawalConfirm link = new withdrawalConfirm();
            this.Hide();
            link.ShowDialog();
        }

        private void with140_Click(object sender, EventArgs e)
        {
            withdrawalConfirm link = new withdrawalConfirm();
            this.Hide();
            link.ShowDialog();
        }

        private void with160_Click(object sender, EventArgs e)
        {
            withdrawalConfirm link = new withdrawalConfirm();
            this.Hide();
            link.ShowDialog();
        }

        private void with180_Click(object sender, EventArgs e)
        {
            withdrawalConfirm link = new withdrawalConfirm();
            this.Hide();
            link.ShowDialog();
        }

        private void with200_Click(object sender, EventArgs e)
        {
            withdrawalConfirm link = new withdrawalConfirm();
            this.Hide();
            link.ShowDialog();
        }

        private void amountEnter_Click(object sender, EventArgs e)
        {
            DialogResult invalidAmount;
            int i = Convert.ToInt32(lblPin2.Text);
            if (i % 20 == 0)
            {
                withdrawalConfirm link = new withdrawalConfirm();
                this.Hide();
                link.ShowDialog();
            }
            else
            {
                invalidAmount = MessageBox.Show("Amount must be multiple of 20");
                amountClear_Click(sender, e);
                amountback_Click(sender, e);
            }
        }

        private void lblPin2_Click(object sender, EventArgs e)
        {

        }
    }
}
