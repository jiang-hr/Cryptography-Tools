using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cryptography_Tools.hash
{
    public partial class Hash_Form : Form
    {
        public Hash_Form()
        {
            InitializeComponent();
        }

        private void Hash_Form_Load(object sender, EventArgs e)
        {

        }

        private void Md5_button_Click(object sender, EventArgs e)
        {
            md5.Md5_Form md5_Form = new md5.Md5_Form();
            md5_Form.Show();
            this.Close();
        }
    }
}
