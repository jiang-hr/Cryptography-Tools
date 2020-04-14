using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Cryptography_Tools.basicTools;

namespace Cryptography_Tools.rsa
{
    public partial class Rsa_Form : Form
    {
        private RsaMath rsaMath;
        private readonly Color clickLabelColor = Color.Green;
        private readonly Color defaultLabelColor = Color.Black;
        private readonly Color textBoxtoLabelColor = Color.Red;
        private readonly Color getValueColor = Color.Blue;

        public Rsa_Form()
        {
            InitializeComponent();
        }

        private void Rsa_Form_Load(object sender, EventArgs e)
        {
            rsaMath = new RsaMath();
        }

        private void PrimeP_label_Click(object sender, EventArgs e)
        {
            PrimeP_label.ForeColor = PrimeP_label.ForeColor == defaultLabelColor ? clickLabelColor : defaultLabelColor;
        }

        private void PrimeP_textBox_TextChanged(object sender, EventArgs e)
        {
            if (BigIntegerTools.IsDigit(PrimeP_textBox.Text))
            {
                PrimeP_label.ForeColor = textBoxtoLabelColor;
                BigInteger bigInteger = BigIntegerTools.ToInteger(PrimeP_textBox.Text);
                rsaMath.Enable.p = true;
                rsaMath.Num.p = bigInteger;
            }
            else
            {
                PrimeP_label.ForeColor = defaultLabelColor;
                rsaMath.Enable.p = false;
                rsaMath.Num.p = BigInteger.Zero;
            }
        }

        private void PrimeQ_label_Click(object sender, EventArgs e)
        {
            PrimeQ_label.ForeColor = PrimeQ_label.ForeColor == defaultLabelColor ? clickLabelColor : defaultLabelColor;
        }
        private void PrimeQ_textBox_TextChanged(object sender, EventArgs e)
        {
            if (BigIntegerTools.IsDigit(PrimeQ_textBox.Text))
            {
                PrimeQ_label.ForeColor = textBoxtoLabelColor;
                BigInteger bigInteger = BigIntegerTools.ToInteger(PrimeQ_textBox.Text);
                rsaMath.Enable.q = true;
                rsaMath.Num.q = bigInteger;
            }
            else
            {
                PrimeQ_label.ForeColor = defaultLabelColor;
                rsaMath.Enable.q = false;
                rsaMath.Num.q = BigInteger.Zero;
            }
        }

        private void PhiN_label_Click(object sender, EventArgs e)
        {
            PhiN_label.ForeColor = PhiN_label.ForeColor == defaultLabelColor ? clickLabelColor : defaultLabelColor;
        }

        private void PhiN_textBox_TextChanged(object sender, EventArgs e)
        {
            if (BigIntegerTools.IsDigit(PhiN_textBox.Text))
            {
                PhiN_label.ForeColor = textBoxtoLabelColor;
                BigInteger bigInteger = BigIntegerTools.ToInteger(PhiN_textBox.Text);
                rsaMath.Enable.phi_n = true;
                rsaMath.Num.phi_n = bigInteger;
            }
            else
            {
                PhiN_label.ForeColor = defaultLabelColor;
                rsaMath.Enable.phi_n = false;
                rsaMath.Num.phi_n = BigInteger.Zero;
            }
        }

        private void ModN_label_Click(object sender, EventArgs e)
        {
            ModN_label.ForeColor = ModN_label.ForeColor == defaultLabelColor ? clickLabelColor : defaultLabelColor;
        }

        private void ModN_textBox_TextChanged(object sender, EventArgs e)
        {
            if (BigIntegerTools.IsDigit(ModN_textBox.Text))
            {
                ModN_label.ForeColor = textBoxtoLabelColor;
                BigInteger bigInteger = BigIntegerTools.ToInteger(ModN_textBox.Text);
                rsaMath.Enable.n = true;
                rsaMath.Num.n = bigInteger;
            }
            else
            {
                ModN_label.ForeColor = defaultLabelColor;
                rsaMath.Enable.n = false;
                rsaMath.Num.n = BigInteger.Zero;
            }
        }

        private void ExpE_label_Click(object sender, EventArgs e)
        {
            ExpE_label.ForeColor = ExpE_label.ForeColor == defaultLabelColor ? clickLabelColor : defaultLabelColor;
        }


        private void ExpE_textBox_TextChanged(object sender, EventArgs e)
        {
            if (BigIntegerTools.IsDigit(ExpE_textBox.Text))
            {
                ExpE_label.ForeColor = textBoxtoLabelColor;
                BigInteger bigInteger = BigIntegerTools.ToInteger(ExpE_textBox.Text);
                rsaMath.Enable.e = true;
                rsaMath.Num.e = bigInteger;
            }
            else
            {
                ExpE_label.ForeColor = defaultLabelColor;
                rsaMath.Enable.n = false;
                rsaMath.Num.n = BigInteger.Zero;
            }
        }

        private void ExpD_label_Click(object sender, EventArgs e)
        {
            ExpD_label.ForeColor = ExpD_label.ForeColor == defaultLabelColor ? clickLabelColor : defaultLabelColor;
        }

        private void ExpD_textBox_TextChanged(object sender, EventArgs e)
        {
            if (BigIntegerTools.IsDigit(ExpD_textBox.Text))
            {
                ExpD_label.ForeColor = textBoxtoLabelColor;
                BigInteger bigInteger = BigIntegerTools.ToInteger(ExpD_textBox.Text);
                rsaMath.Enable.d = true;
                rsaMath.Num.d = bigInteger;
            }
            else
            {
                ExpD_label.ForeColor = defaultLabelColor; 
                rsaMath.Enable.d = false;
                rsaMath.Num.d = BigInteger.Zero;
            }
        }

        private void ExpDp_label_Click(object sender, EventArgs e)
        {
            ExpDp_label.ForeColor = ExpDp_label.ForeColor == defaultLabelColor ? clickLabelColor : defaultLabelColor;
        }

        private void ExpDp_textBox_TextChanged(object sender, EventArgs e)
        {
            if (BigIntegerTools.IsDigit(ExpDp_textBox.Text))
            {
                ExpDp_label.ForeColor = textBoxtoLabelColor;
                BigInteger bigInteger = BigIntegerTools.ToInteger(ExpDp_textBox.Text);
                rsaMath.Enable.dp = true;
                rsaMath.Num.dp = bigInteger;
            }
            else
            {
                ExpDp_label.ForeColor = defaultLabelColor;
                rsaMath.Enable.dp = false;
                rsaMath.Num.dp = BigInteger.Zero;
            }
        }

        private void ExpDq_label_Click(object sender, EventArgs e)
        {
            ExpDq_label.ForeColor = ExpDq_label.ForeColor == defaultLabelColor ? clickLabelColor : defaultLabelColor;
        }

        private void ExpDq_textBox_TextChanged(object sender, EventArgs e)
        {
            if (BigIntegerTools.IsDigit(ExpDq_textBox.Text))
            {
                ExpDq_label.ForeColor = textBoxtoLabelColor;
                BigInteger bigInteger = BigIntegerTools.ToInteger(ExpDq_textBox.Text);
                rsaMath.Enable.dq = true;
                rsaMath.Num.dq = bigInteger;
            }
            else
            {
                ExpDq_label.ForeColor = defaultLabelColor;
                rsaMath.Enable.dq = false;
                rsaMath.Num.dq = BigInteger.Zero;
            }
        }

        private void TextM_label_Click(object sender, EventArgs e)
        {
            TextM_label.ForeColor = TextM_label.ForeColor == defaultLabelColor ? clickLabelColor : defaultLabelColor;
        }

        private void TextM_textBox_TextChanged(object sender, EventArgs e)
        {
            if (TextM_textBox.Text != "" && BigIntegerTools.IsArrayDigit(TextM_textBox.Text))
            {
                TextM_label.ForeColor = textBoxtoLabelColor;
                var arrayDigit = TextM_textBox.Text.Split("\r\n".ToCharArray());
                int index = arrayDigit.Where(x => x != "").Count();
                var BigIntegerArray = new BigInteger[index];
                index = 0;
                foreach (string x in arrayDigit)
                {
                    if (x != "")
                    {
                        BigIntegerArray[index] = BigIntegerTools.ToInteger(x);
                        index++;
                    }
                }
                rsaMath.Enable.m = true;
                rsaMath.Num.m = BigIntegerArray;
            }
            else
            {
                TextM_label.ForeColor = defaultLabelColor;
                rsaMath.Enable.m = false;
                rsaMath.Num.m = null;
            }
        }

        private void CryptC_label_Click(object sender, EventArgs e)
        {
            CryptC_label.ForeColor = CryptC_label.ForeColor == defaultLabelColor ? clickLabelColor : defaultLabelColor;
        }

        private void CryptC_textBox_TextChanged(object sender, EventArgs e)
        {
            if (CryptC_textBox.Text != "" && BigIntegerTools.IsArrayDigit(CryptC_textBox.Text))
            {
                CryptC_label.ForeColor = textBoxtoLabelColor;
                var arrayDigit = CryptC_textBox.Text.Split("\r\n".ToCharArray());
                int index = arrayDigit.Where(x => x != "").Count();
                var BigIntegerArray = new BigInteger[index];
                index = 0;
                foreach (string x in arrayDigit)
                {
                    if (x != "")
                    {
                        BigIntegerArray[index] = BigIntegerTools.ToInteger(x);
                        index++;
                    }
                }
                rsaMath.Enable.c = true;
                rsaMath.Num.c = BigIntegerArray;
            }
            else
            {
                CryptC_label.ForeColor = defaultLabelColor;
                rsaMath.Enable.c = false;
                rsaMath.Num.c = null;
            }
        }

        private void Run_button_Click(object sender, EventArgs e)
        {
            Log_textBox.Text += rsaMath.Run();
            if (rsaMath.Enable.n && ModN_label.ForeColor == defaultLabelColor)
            {
                ModN_textBox.Text = rsaMath.Num.n.ToString();
                ModN_label.ForeColor = getValueColor;
            }
            if (rsaMath.Enable.p && PrimeP_label.ForeColor == defaultLabelColor)
            {
                PrimeP_textBox.Text = rsaMath.Num.p.ToString();
                PrimeP_label.ForeColor = getValueColor;
            }
            if (rsaMath.Enable.q && PrimeQ_label.ForeColor == defaultLabelColor)
            {
                PrimeQ_textBox.Text = rsaMath.Num.q.ToString();
                PrimeQ_label.ForeColor = getValueColor;
            }
            if (rsaMath.Enable.phi_n && PhiN_label.ForeColor == defaultLabelColor)
            {
                PhiN_textBox.Text = rsaMath.Num.phi_n.ToString();
                PhiN_label.ForeColor = getValueColor;
            }
            if (rsaMath.Enable.m && TextM_label.ForeColor == defaultLabelColor)
            {
                TextM_textBox.Text = BigIntegerTools.ToString(rsaMath.Num.m);
                TextM_label.ForeColor = getValueColor;
            }
            if (rsaMath.Enable.e && ExpE_label.ForeColor == defaultLabelColor)
            {
                ExpE_textBox.Text = rsaMath.Num.e.ToString();
                ExpE_label.ForeColor = getValueColor;
            }
            if (rsaMath.Enable.d && ExpD_label.ForeColor == defaultLabelColor)
            {
                ExpD_textBox.Text = rsaMath.Num.d.ToString();
                ExpD_label.ForeColor = getValueColor;
            }
            if (rsaMath.Enable.dp && ExpDp_label.ForeColor == defaultLabelColor)
            {
                ExpDp_textBox.Text = rsaMath.Num.dp.ToString();
                ExpDp_label.ForeColor = getValueColor;
            }
            if (rsaMath.Enable.dq && ExpDq_label.ForeColor == defaultLabelColor)
            {
                ExpDq_textBox.Text = rsaMath.Num.dq.ToString();
                ExpDq_label.ForeColor = getValueColor;
            }
            if (rsaMath.Enable.c && CryptC_label.ForeColor == defaultLabelColor)
            {
                CryptC_textBox.Text = BigIntegerTools.ToString(rsaMath.Num.c);
                CryptC_label.ForeColor = getValueColor;
            }
        }

        private void Log_textBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
