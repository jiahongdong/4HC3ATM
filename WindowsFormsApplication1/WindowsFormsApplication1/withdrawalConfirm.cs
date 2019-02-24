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
    public partial class withdrawalConfirm : Form
    {
        public withdrawalConfirm()
        {
            InitializeComponent();
        }

        private void withdrawalConfirmClose_Click(object sender, EventArgs e)
        {
            Close();
            withdrawal link = new withdrawal();
            this.Hide();
            link.ShowDialog();
        }

        private void withdrawConfirmBalance_Click(object sender, EventArgs e)
        {
            Close();
            balance link = new balance();
            this.Hide();
            link.ShowDialog();
        }

        private void withdrawConfirmReturnCard_Click(object sender, EventArgs e)
        {
            start link = new start();
            this.Hide();
            link.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
            mainMenu link = new mainMenu();
            this.Hide();
            link.ShowDialog();
        }
    }
}
