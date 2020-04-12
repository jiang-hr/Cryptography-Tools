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
            rc4 = new Rc4();
            rc4.Inil(Key_textBox.Text);
        }

        private void Encrypt_button_Click(object sender, EventArgs e)
        {
            rc4.Inil(Key_textBox.Text);
            if (Base64_checkBox.Checked)
            {
                var encrypt = rc4.Crypt(Encrypt_textBox.Text.ToCharArray());
                var temp = base64.Base64.EncodeBase64("utf-8", new string(encrypt));
                Decrypt_textBox.Text = temp;
            }
            else if (Hex_checkBox.Checked)
            {
                Decrypt_textBox.Text = new string(rc4.HexCrypt(Encrypt_textBox.Text));
            }
        }

        private void Decrypt_button_Click(object sender, EventArgs e)
        {
            rc4.Inil(Key_textBox.Text);
            if (Base64_checkBox.Checked)
            {
                var decrypt = base64.Base64.DecodeBase64("utf-8", Decrypt_textBox.Text);
                Encrypt_textBox.Text = new string(rc4.Crypt(decrypt.ToCharArray()));
            }
            else if (Hex_checkBox.Checked)
            {
                var decrypt = new char[Decrypt_textBox.Text.Length / 2];
                for(int i = 0; i < decrypt.Length; i++)
                {
                    char first = Decrypt_textBox.Text[2 * i];
                    char last = Decrypt_textBox.Text[2 * i + 1];
                    char[] a = { first, last };
                    decrypt[i] = rc4.AntiHex(new string(a));
                }
                Encrypt_textBox.Text = new string(rc4.Crypt(decrypt));
            }
        }

        private void Key_textBox_TextChanged(object sender, EventArgs e)
        {
            rc4.Inil(Key_textBox.Text);
        }

        private void Encrypt_textBox_TextChanged(object sender, EventArgs e)
        {
            //Do nothing.
        }

        private void Decrypt_textBox_TextChanged(object sender, EventArgs e)
        {
            //Still do nothing.
        }

        private void Base64_checkBox_CheckedChanged(object sender, EventArgs e)
        {
            if (Hex_checkBox.Checked == Base64_checkBox.Checked)
            {
                Hex_checkBox.Checked = !Hex_checkBox.Checked;
            }
        }

        private void Hex_checkBox_CheckedChanged(object sender, EventArgs e)
        {
            if (Base64_checkBox.Checked == Hex_checkBox.Checked)
            {
                Base64_checkBox.Checked = !Base64_checkBox.Checked;
            }
        }
    }
}