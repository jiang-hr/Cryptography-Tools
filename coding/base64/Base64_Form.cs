using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Cryptography_Tools.smalltools.base64
{
    public partial class Base64_Form : Form
    {
        private string chance = "Base64";

        public Base64_Form()
        {
            InitializeComponent();
        }

        private void Base64_Form_Load(object sender, EventArgs e)
        {

        }

        private void Encode_textBox_TextChanged(object sender, EventArgs e)
        {
            if (Encode_textBox.Text == "错误的输入，请重新输入decode!")
            {
                return;
            }
            switch (chance)
            {
                case "Base64":
                    Decode_textBox.Text = Base64.EncodeBase64("utf-8", Encode_textBox.Text);
                    break;
                case "Base32":
                    Decode_textBox.Text = Base32.EncodeBase32("utf-8", Encode_textBox.Text);
                    break;
            }
        }

        private void Decode_textBox_TextChanged(object sender, EventArgs e)
        {
            switch (chance)
            {
                case "Base64":
                    Encode_textBox.Text = Base64.DecodeBase64("utf-8", Decode_textBox.Text);
                    break;
                case "Base32":
                    Encode_textBox.Text = Base32.DecodeBase32("utf-8", Decode_textBox.Text);
                    break;
            }
        }

        private void Base64_button_Click(object sender, EventArgs e)
        {
            this.chance = "Base64";
            this.Text = "现在为Base64加/解密";
        }

        private void Base32_button_Click(object sender, EventArgs e)
        {
            this.chance = "Base32";
            this.Text = "现在为Base32加/解密";
        }

        private void Base16_button_Click(object sender, EventArgs e)
        {
            this.chance = "Base16";
            this.Text = "现在为Base16加/解密";
        }
    }
}
