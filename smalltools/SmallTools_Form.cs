using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cryptography_Tools.smalltools
{
    public partial class SmallTools_Form : Form
    {

        public SmallTools_Form()
        {
            InitializeComponent();
        }

        private void SmallTools_Form_Load(object sender, EventArgs e)
        {
            
        }

        private void Base64_button_Click(object sender, EventArgs e)
        {
            base64.Base64_Form base64_Form = new base64.Base64_Form();
            base64_Form.Show();
            this.Close();
        }
    }
}
