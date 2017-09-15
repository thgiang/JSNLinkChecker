using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JSNLinkChecker
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void txtUrl_TextChanged(object sender, EventArgs e)
        {
            if (txtUrl.Text.Trim() != "")
            {
                btnCheck.Enabled = true;
            }
            else
            {
                btnCheck.Enabled = false;
            }
        }
    }
}
