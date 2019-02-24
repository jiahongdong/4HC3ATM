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
    public partial class toAccount : Form
    {
        public toAccount()
        {
            InitializeComponent();
        }

        private void quickCashBox1_Enter(object sender, EventArgs e)
        {

        }

        private void toSaving_Click(object sender, EventArgs e)
        {
            Close();
            depositSuccessful link = new depositSuccessful();
            this.Hide();
            link.ShowDialog();
        }

        private void toChecking_Click(object sender, EventArgs e)
        {
            Close();
            depositSuccessful link = new depositSuccessful();
            this.Hide();
            link.ShowDialog();
        }
    }
}
