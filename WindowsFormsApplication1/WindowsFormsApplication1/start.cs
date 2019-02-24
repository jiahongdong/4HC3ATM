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
    public partial class start : Form
    {
        public start()
        {
            InitializeComponent();
        }

        private void startPressAnywhere_Click(object sender, EventArgs e)
        {
            cardNumber link = new cardNumber();
            this.Hide();
            link.ShowDialog();
        }
    }
}
