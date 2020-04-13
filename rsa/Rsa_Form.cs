using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cryptography_Tools.rsa
{
    public partial class Rsa_Form : Form
    {
        private RsaMath rsaMath;

        public Rsa_Form()
        {
            InitializeComponent();
        }

        private bool IsArrayDigit(string args)
        {
            var arrayDigit = args.Split("\r\n".ToCharArray());
            foreach (var x in arrayDigit)
            {
                //分割之后，index为奇数的string会把"\r\n"变成空字符串！！！
                if (IsDigit(x) || x == "")
                {
                    continue;
                }
                return false;
            }
            return true;
        }

        private bool IsDigit(string arg)
        {
            if (arg == "")
            {
                return false;
            }
            foreach (var x in arg)
            {
                if (x >= '0' && x <= '9')
                {
                    continue;
                }
                return false;
            }
            return true;
        }

        private BigInteger ToInteger(string arg)
        {
            BigInteger bigInteger = BigInteger.Zero;
            foreach (var x in arg)
            {
                bigInteger *= 10;
                bigInteger += x - '0';
            }
            return bigInteger;
        }

        private void Rsa_Form_Load(object sender, EventArgs e)
        {
            rsaMath = new RsaMath();
        }

        private void PrimeP_label_Click(object sender, EventArgs e)
        {
            PrimeP_label.ForeColor = PrimeP_label.ForeColor == Color.Black ? Color.Red : Color.Black;
        }

        private void PrimeP_textBox_TextChanged(object sender, EventArgs e)
        {
            if (IsDigit(PrimeP_textBox.Text))
            {
                PrimeP_label.ForeColor = Color.Red;
            }
            else
            {
                PrimeP_label.ForeColor = Color.Black;
            }
        }

        private void PrimeQ_label_Click(object sender, EventArgs e)
        {
            PrimeQ_label.ForeColor = PrimeQ_label.ForeColor == Color.Black ? Color.Red : Color.Black;
        }
        private void PrimeQ_textBox_TextChanged(object sender, EventArgs e)
        {
            if (IsDigit(PrimeQ_textBox.Text))
            {
                PrimeQ_label.ForeColor = Color.Red;
            }
            else
            {
                PrimeQ_label.ForeColor = Color.Black;
            }
        }

        private void PhiN_label_Click(object sender, EventArgs e)
        {
            PhiN_label.ForeColor = PhiN_label.ForeColor == Color.Black ? Color.Red : Color.Black;
        }

        private void PhiN_textBox_TextChanged(object sender, EventArgs e)
        {
            if (IsDigit(PhiN_textBox.Text))
            {
                PhiN_label.ForeColor = Color.Red;
            }
            else
            {
                PhiN_label.ForeColor = Color.Black;
            }
        }

        private void ModN_label_Click(object sender, EventArgs e)
        {
            ModN_label.ForeColor = ModN_label.ForeColor == Color.Black ? Color.Red : Color.Black;
        }

        private void ModN_textBox_TextChanged(object sender, EventArgs e)
        {
            if (IsDigit(ModN_textBox.Text))
            {
                ModN_label.ForeColor = Color.Red;
            }
            else
            {
                ModN_label.ForeColor = Color.Black;
            }
        }

        private void ExpE_label_Click(object sender, EventArgs e)
        {
            ExpE_label.ForeColor = ExpE_label.ForeColor == Color.Black ? Color.Red : Color.Black;
        }


        private void ExpE_textBox_TextChanged(object sender, EventArgs e)
        {
            if (IsDigit(ExpE_textBox.Text))
            {
                ExpE_label.ForeColor = Color.Red;
            }
            else
            {
                ExpE_label.ForeColor = Color.Black;
            }
        }

        private void ExpD_label_Click(object sender, EventArgs e)
        {
            ExpD_label.ForeColor = ExpD_label.ForeColor == Color.Black ? Color.Red : Color.Black;
        }

        private void ExpD_textBox_TextChanged(object sender, EventArgs e)
        {
            if (IsDigit(ExpD_textBox.Text))
            {
                ExpD_label.ForeColor = Color.Red;
            }
            else
            {
                ExpD_label.ForeColor = Color.Black;
            }
        }

        private void ExpDp_label_Click(object sender, EventArgs e)
        {
            ExpDp_label.ForeColor = ExpDp_label.ForeColor == Color.Black ? Color.Red : Color.Black;
        }

        private void ExpDp_textBox_TextChanged(object sender, EventArgs e)
        {
            if (IsDigit(ExpDp_textBox.Text))
            {
                ExpDp_label.ForeColor = Color.Red;
            }
            else
            {
                ExpDp_label.ForeColor = Color.Black;
            }
        }

        private void ExpDq_label_Click(object sender, EventArgs e)
        {
            ExpDq_label.ForeColor = ExpDq_label.ForeColor == Color.Black ? Color.Red : Color.Black;
        }

        private void ExpDq_textBox_TextChanged(object sender, EventArgs e)
        {
            if (IsDigit(ExpDq_textBox.Text))
            {
                ExpDq_label.ForeColor = Color.Red;
            }
            else
            {
                ExpDq_label.ForeColor = Color.Black;
            }
        }

        private void TextM_label_Click(object sender, EventArgs e)
        {
            TextM_label.ForeColor = TextM_label.ForeColor == Color.Black ? Color.Red : Color.Black;
        }

        private void TextM_textBox_TextChanged(object sender, EventArgs e)
        {
            if (TextM_textBox.Text != "" && IsArrayDigit(TextM_textBox.Text))
            {
                TextM_label.ForeColor = Color.Red;
                var arrayDigit = TextM_textBox.Text.Split("\r\n".ToCharArray());
                int index = arrayDigit.Where(x => x != "").Count();
                var BigIntegerArray = new BigInteger[index];
                index = 0;
                foreach (string x in arrayDigit)
                {
                    if (x == "")
                    {
                        continue;
                    }
                    BigIntegerArray[index] = ToInteger(x);
                    index++;
                }
                rsaMath.Enable.m = true;
                rsaMath.Num.m = BigIntegerArray;
            }
            else
            {
                TextM_label.ForeColor = Color.Black;
                rsaMath.Enable.m = false;
                rsaMath.Num.m = null;
            }
        }

        private void CryptC_label_Click(object sender, EventArgs e)
        {
            CryptC_label.ForeColor = CryptC_label.ForeColor == Color.Black ? Color.Red : Color.Black;
        }

        private void CryptC_textBox_TextChanged(object sender, EventArgs e)
        {
            if (CryptC_textBox.Text != "" && IsArrayDigit(CryptC_textBox.Text))
            {
                CryptC_label.ForeColor = Color.Red;
                var arrayDigit = CryptC_textBox.Text.Split("\r\n".ToCharArray());
                int index = arrayDigit.Where(x => x != "").Count();
                var BigIntegerArray = new BigInteger[index];
                index = 0;
                foreach (string x in arrayDigit)
                {
                    if (x == "")
                    {
                        continue;
                    }
                    BigIntegerArray[index] = ToInteger(x);
                    index++;
                }
                rsaMath.Enable.c = true;
                rsaMath.Num.c = BigIntegerArray;
            }
            else
            {
                CryptC_label.ForeColor = Color.Black;
                rsaMath.Enable.c = false;
                rsaMath.Num.c = null;
            }
        }
    }
}
