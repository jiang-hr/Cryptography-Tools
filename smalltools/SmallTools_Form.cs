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
            //Do Nothing!
        }


        private void Rc4_button_Click(object sender, EventArgs e)
        {
            rc4.Rc4_Form rc4_Form = new rc4.Rc4_Form();
            rc4_Form.Show();
            this.Close();
        }

        private void Log_textBox_TextChanged(object sender, EventArgs e)
        {
            //Do nothing!!!
        }
    }
}
