using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cryptography_Tools
{
    public partial class Main_Form : Form
    {
        public Main_Form()
        {
            InitializeComponent();
        }

        private void SmallTools_button_Click(object sender, EventArgs e)
        {
            var smallTools_Form = new smalltools.SmallTools_Form();
            smallTools_Form.Show();
        }

        private void Main_Form_Load(object sender, EventArgs e)
        {
            //Do nothing!!!
        }

        private void Rsa_button_Click(object sender, EventArgs e)
        {
            var rsa_Form = new rsa.Rsa_Form();
            rsa_Form.Show();
        }

        private void Hash_button_Click(object sender, EventArgs e)
        {
            var hash_Form = new hash.Hash_Form();
            hash_Form.Show();
        }

        private void Coding_button_Click(object sender, EventArgs e)
        {

        }
    }
}
