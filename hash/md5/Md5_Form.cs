using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cryptography_Tools.hash.md5
{
    public partial class Md5_Form : Form
    {
        public Md5_Form()
        {
            InitializeComponent();
        }

        private void Md5_Form_Load(object sender, EventArgs e)
        {
            //Do nothing!
        }

        private void Md5_textBox_TextChanged(object sender, EventArgs e)
        {
            if (IsCapital_checkBox.Checked)
            {
                Md5_textBox.Text = Md5_textBox.Text.ToUpper();
            }
            else
            {
                Md5_textBox.Text = Md5_textBox.Text.ToLower();
            }
        }

        private void Input_textBox_TextChanged(object sender, EventArgs e)
        {
            //Do nothing!
        }

        private void IsCapital_checkBox_CheckedChanged(object sender, EventArgs e)
        {
            if (IsCapital_checkBox.Checked)
            {
                Md5_textBox.Text = Md5_textBox.Text.ToUpper();
            }
            else
            {
                Md5_textBox.Text = Md5_textBox.Text.ToLower();
            }
        }

        private void BeginText_button_Click(object sender, EventArgs e)
        {
            try
            {
                string str = Input_textBox.Text;
                Md5_textBox.Text = Md5.GeneratStringMD5(str);
            }
            catch (Exception exp)
            {
                Md5_textBox.Text = exp.Message;
            }
        }

        private void Stream_textBox_TextChanged(object sender, EventArgs e)
        {
            //Do nothing!
        }

        private void Stream_button_Click(object sender, EventArgs e)
        {
            string str = Stream_textBox.Text;
            try
            {
                FileStream fileStream = File.OpenRead(str);
                Md5_textBox.Text = Md5.GenerateStreamMD5(fileStream);
            }
            catch (Exception exp)
            {
                Md5_textBox.Text = exp.Message;
            }
        }
    }
}
