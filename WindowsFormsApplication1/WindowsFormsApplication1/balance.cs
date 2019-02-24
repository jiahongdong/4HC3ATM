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
    public partial class balance : Form
    {
        public balance()
        {
            InitializeComponent();
        }

        private void balanceGoBack_Click(object sender, EventArgs e)
        {
            Close();
            mainMenu link = new mainMenu();
            this.Hide();
            link.ShowDialog();
        }

        private void balanceReturnCard_Click(object sender, EventArgs e)
        {
            start link = new start();
            this.Hide();
            link.ShowDialog();
        }
    }
}
