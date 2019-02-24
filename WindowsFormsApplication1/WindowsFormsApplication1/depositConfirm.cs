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
    public partial class depositConfirm : Form
    {
        public depositConfirm()
        {
            InitializeComponent();
        }

        private void depositConfirmAnother_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void depositConfirmReturnCard_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void depositConfirmBalance_Click(object sender, EventArgs e)
        {
            balance link = new balance();
            link.ShowDialog();
        }
            
    }
}
