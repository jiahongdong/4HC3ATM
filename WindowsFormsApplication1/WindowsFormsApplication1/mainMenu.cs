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
    public partial class mainMenu : Form
    {
        public mainMenu()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblFast_Click(object sender, EventArgs e)
        {
            quickCash link = new quickCash();
            this.Hide();
            link.ShowDialog();
        }

        private void lblCash_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {

        }

        private void lblBalance_Click(object sender, EventArgs e)
        {
            balance link = new balance();
            this.Hide();
            link.ShowDialog(); 
        }

        private void mainReturnCard_Click(object sender, EventArgs e)
        {
            start link = new start();
            this.Hide();
            link.ShowDialog();

        }

        private void lblWith_Click(object sender, EventArgs e)
        {
            withdrawal link = new withdrawal();
            this.Hide();
            link.ShowDialog();
        }

        private void lblTransfer_Click(object sender, EventArgs e)
        {

        }

        private void lblDep_Click(object sender, EventArgs e)
        {
            deposit link = new deposit();
            this.Hide();
            link.ShowDialog();
        }

        private void lblLoan_Click(object sender, EventArgs e)
        {

        }

        private void lblPrint_Click(object sender, EventArgs e)
        {

        }
    }
}
