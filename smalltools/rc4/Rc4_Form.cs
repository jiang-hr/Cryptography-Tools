using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cryptography_Tools.smalltools.rc4
{
    public partial class Rc4_Form : Form
    {
        private Rc4 rc4;

        public Rc4_Form()
        {
            InitializeComponent();
        }

        private void Rc4_Form_Load(object sender, EventArgs e)
        {
            this.rc4 = new Rc4();
            rc4.inil(key_textBox.Text);
        }

        private void encrypt_button_Click(object sender, EventArgs e)
        {
            rc4.inil(key_textBox.Text);
            decrypt_textBox.Text = rc4.Crypt(encrypt_textBox.Text);
        }

        private void decrypt_button_Click(object sender, EventArgs e)
        {
            rc4.inil(key_textBox.Text);
            encrypt_textBox.Text = rc4.Crypt(decrypt_textBox.Text);
        }

        private void key_textBox_TextChanged(object sender, EventArgs e)
        {
            rc4.inil(key_textBox.Text);
        }

        private void encrypt_textBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void decrypt_textBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
