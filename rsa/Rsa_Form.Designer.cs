namespace Cryptography_Tools.rsa
{
    partial class Rsa_Form
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.PrimeP_label = new System.Windows.Forms.Label();
            this.PrimeQ_label = new System.Windows.Forms.Label();
            this.ModN_label = new System.Windows.Forms.Label();
            this.PhiN_label = new System.Windows.Forms.Label();
            this.ModN_textBox = new System.Windows.Forms.TextBox();
            this.PrimeP_textBox = new System.Windows.Forms.TextBox();
            this.PrimeQ_textBox = new System.Windows.Forms.TextBox();
            this.PhiN_textBox = new System.Windows.Forms.TextBox();
            this.ExpE_label = new System.Windows.Forms.Label();
            this.TextM_label = new System.Windows.Forms.Label();
            this.CryptC_label = new System.Windows.Forms.Label();
            this.ExpE_textBox = new System.Windows.Forms.TextBox();
            this.ExpD_label = new System.Windows.Forms.Label();
            this.ExpD_textBox = new System.Windows.Forms.TextBox();
            this.TextM_textBox = new System.Windows.Forms.TextBox();
            this.CryptC_textBox = new System.Windows.Forms.TextBox();
            this.ExpDp_label = new System.Windows.Forms.Label();
            this.ExpDq_label = new System.Windows.Forms.Label();
            this.ExpDp_textBox = new System.Windows.Forms.TextBox();
            this.ExpDq_textBox = new System.Windows.Forms.TextBox();
            this.Run_button = new System.Windows.Forms.Button();
            this.Log_textBox = new System.Windows.Forms.TextBox();
            this.FurtherAnalysis_checkBox = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // PrimeP_label
            // 
            this.PrimeP_label.AutoSize = true;
            this.PrimeP_label.Font = new System.Drawing.Font("宋体", 12F);
            this.PrimeP_label.ForeColor = System.Drawing.Color.Black;
            this.PrimeP_label.Location = new System.Drawing.Point(41, 113);
            this.PrimeP_label.Name = "PrimeP_label";
            this.PrimeP_label.Size = new System.Drawing.Size(48, 16);
            this.PrimeP_label.TabIndex = 0;
            this.PrimeP_label.Text = "质数p";
            this.PrimeP_label.Click += new System.EventHandler(this.PrimeP_label_Click);
            // 
            // PrimeQ_label
            // 
            this.PrimeQ_label.AutoSize = true;
            this.PrimeQ_label.Font = new System.Drawing.Font("宋体", 12F);
            this.PrimeQ_label.ForeColor = System.Drawing.Color.Black;
            this.PrimeQ_label.Location = new System.Drawing.Point(41, 170);
            this.PrimeQ_label.Name = "PrimeQ_label";
            this.PrimeQ_label.Size = new System.Drawing.Size(48, 16);
            this.PrimeQ_label.TabIndex = 1;
            this.PrimeQ_label.Text = "质数q";
            this.PrimeQ_label.Click += new System.EventHandler(this.PrimeQ_label_Click);
            // 
            // ModN_label
            // 
            this.ModN_label.AutoSize = true;
            this.ModN_label.Font = new System.Drawing.Font("宋体", 12F);
            this.ModN_label.ForeColor = System.Drawing.Color.Black;
            this.ModN_label.Location = new System.Drawing.Point(13, 50);
            this.ModN_label.Name = "ModN_label";
            this.ModN_label.Size = new System.Drawing.Size(88, 16);
            this.ModN_label.TabIndex = 2;
            this.ModN_label.Text = "公钥/模数n";
            this.ModN_label.Click += new System.EventHandler(this.ModN_label_Click);
            // 
            // PhiN_label
            // 
            this.PhiN_label.AutoSize = true;
            this.PhiN_label.Font = new System.Drawing.Font("宋体", 12F);
            this.PhiN_label.ForeColor = System.Drawing.Color.Black;
            this.PhiN_label.Location = new System.Drawing.Point(12, 231);
            this.PhiN_label.Name = "PhiN_label";
            this.PhiN_label.Size = new System.Drawing.Size(88, 16);
            this.PhiN_label.TabIndex = 3;
            this.PhiN_label.Text = "私钥/φ(n)";
            this.PhiN_label.Click += new System.EventHandler(this.PhiN_label_Click);
            // 
            // ModN_textBox
            // 
            this.ModN_textBox.Location = new System.Drawing.Point(107, 32);
            this.ModN_textBox.Multiline = true;
            this.ModN_textBox.Name = "ModN_textBox";
            this.ModN_textBox.Size = new System.Drawing.Size(995, 50);
            this.ModN_textBox.TabIndex = 4;
            this.ModN_textBox.TextChanged += new System.EventHandler(this.ModN_textBox_TextChanged);
            // 
            // PrimeP_textBox
            // 
            this.PrimeP_textBox.Location = new System.Drawing.Point(107, 102);
            this.PrimeP_textBox.Multiline = true;
            this.PrimeP_textBox.Name = "PrimeP_textBox";
            this.PrimeP_textBox.Size = new System.Drawing.Size(995, 36);
            this.PrimeP_textBox.TabIndex = 5;
            this.PrimeP_textBox.TextChanged += new System.EventHandler(this.PrimeP_textBox_TextChanged);
            // 
            // PrimeQ_textBox
            // 
            this.PrimeQ_textBox.Location = new System.Drawing.Point(107, 161);
            this.PrimeQ_textBox.Multiline = true;
            this.PrimeQ_textBox.Name = "PrimeQ_textBox";
            this.PrimeQ_textBox.Size = new System.Drawing.Size(995, 36);
            this.PrimeQ_textBox.TabIndex = 6;
            this.PrimeQ_textBox.TextChanged += new System.EventHandler(this.PrimeQ_textBox_TextChanged);
            // 
            // PhiN_textBox
            // 
            this.PhiN_textBox.Location = new System.Drawing.Point(107, 217);
            this.PhiN_textBox.Multiline = true;
            this.PhiN_textBox.Name = "PhiN_textBox";
            this.PhiN_textBox.Size = new System.Drawing.Size(995, 48);
            this.PhiN_textBox.TabIndex = 7;
            this.PhiN_textBox.TextChanged += new System.EventHandler(this.PhiN_textBox_TextChanged);
            // 
            // ExpE_label
            // 
            this.ExpE_label.AutoSize = true;
            this.ExpE_label.Font = new System.Drawing.Font("宋体", 12F);
            this.ExpE_label.ForeColor = System.Drawing.Color.Black;
            this.ExpE_label.Location = new System.Drawing.Point(12, 293);
            this.ExpE_label.Name = "ExpE_label";
            this.ExpE_label.Size = new System.Drawing.Size(120, 16);
            this.ExpE_label.TabIndex = 8;
            this.ExpE_label.Text = "公钥/加密指数e";
            this.ExpE_label.Click += new System.EventHandler(this.ExpE_label_Click);
            // 
            // TextM_label
            // 
            this.TextM_label.AutoSize = true;
            this.TextM_label.Font = new System.Drawing.Font("宋体", 12F);
            this.TextM_label.ForeColor = System.Drawing.Color.Black;
            this.TextM_label.Location = new System.Drawing.Point(41, 460);
            this.TextM_label.Name = "TextM_label";
            this.TextM_label.Size = new System.Drawing.Size(48, 16);
            this.TextM_label.TabIndex = 9;
            this.TextM_label.Text = "明文m";
            this.TextM_label.Click += new System.EventHandler(this.TextM_label_Click);
            // 
            // CryptC_label
            // 
            this.CryptC_label.AutoSize = true;
            this.CryptC_label.Font = new System.Drawing.Font("宋体", 12F);
            this.CryptC_label.ForeColor = System.Drawing.Color.Black;
            this.CryptC_label.Location = new System.Drawing.Point(41, 585);
            this.CryptC_label.Name = "CryptC_label";
            this.CryptC_label.Size = new System.Drawing.Size(48, 16);
            this.CryptC_label.TabIndex = 10;
            this.CryptC_label.Text = "密文c";
            this.CryptC_label.Click += new System.EventHandler(this.CryptC_label_Click);
            // 
            // ExpE_textBox
            // 
            this.ExpE_textBox.Location = new System.Drawing.Point(146, 284);
            this.ExpE_textBox.Multiline = true;
            this.ExpE_textBox.Name = "ExpE_textBox";
            this.ExpE_textBox.Size = new System.Drawing.Size(207, 43);
            this.ExpE_textBox.TabIndex = 11;
            this.ExpE_textBox.TextChanged += new System.EventHandler(this.ExpE_textBox_TextChanged);
            // 
            // ExpD_label
            // 
            this.ExpD_label.AutoSize = true;
            this.ExpD_label.Font = new System.Drawing.Font("宋体", 12F);
            this.ExpD_label.ForeColor = System.Drawing.Color.Black;
            this.ExpD_label.Location = new System.Drawing.Point(383, 293);
            this.ExpD_label.Name = "ExpD_label";
            this.ExpD_label.Size = new System.Drawing.Size(120, 16);
            this.ExpD_label.TabIndex = 12;
            this.ExpD_label.Text = "私钥/解密指数d";
            this.ExpD_label.Click += new System.EventHandler(this.ExpD_label_Click);
            // 
            // ExpD_textBox
            // 
            this.ExpD_textBox.Location = new System.Drawing.Point(509, 284);
            this.ExpD_textBox.Multiline = true;
            this.ExpD_textBox.Name = "ExpD_textBox";
            this.ExpD_textBox.Size = new System.Drawing.Size(593, 43);
            this.ExpD_textBox.TabIndex = 13;
            this.ExpD_textBox.TextChanged += new System.EventHandler(this.ExpD_textBox_TextChanged);
            // 
            // TextM_textBox
            // 
            this.TextM_textBox.Location = new System.Drawing.Point(107, 407);
            this.TextM_textBox.Multiline = true;
            this.TextM_textBox.Name = "TextM_textBox";
            this.TextM_textBox.Size = new System.Drawing.Size(995, 121);
            this.TextM_textBox.TabIndex = 14;
            this.TextM_textBox.TextChanged += new System.EventHandler(this.TextM_textBox_TextChanged);
            // 
            // CryptC_textBox
            // 
            this.CryptC_textBox.Location = new System.Drawing.Point(107, 547);
            this.CryptC_textBox.Multiline = true;
            this.CryptC_textBox.Name = "CryptC_textBox";
            this.CryptC_textBox.Size = new System.Drawing.Size(995, 122);
            this.CryptC_textBox.TabIndex = 15;
            this.CryptC_textBox.TextChanged += new System.EventHandler(this.CryptC_textBox_TextChanged);
            // 
            // ExpDp_label
            // 
            this.ExpDp_label.AutoSize = true;
            this.ExpDp_label.Font = new System.Drawing.Font("宋体", 12F);
            this.ExpDp_label.ForeColor = System.Drawing.Color.Black;
            this.ExpDp_label.Location = new System.Drawing.Point(21, 367);
            this.ExpDp_label.Name = "ExpDp_label";
            this.ExpDp_label.Size = new System.Drawing.Size(112, 16);
            this.ExpDp_label.TabIndex = 16;
            this.ExpDp_label.Text = "dp = d %(p-1)";
            this.ExpDp_label.Click += new System.EventHandler(this.ExpDp_label_Click);
            // 
            // ExpDq_label
            // 
            this.ExpDq_label.AutoSize = true;
            this.ExpDq_label.Font = new System.Drawing.Font("宋体", 12F);
            this.ExpDq_label.ForeColor = System.Drawing.Color.Black;
            this.ExpDq_label.Location = new System.Drawing.Point(569, 367);
            this.ExpDq_label.Name = "ExpDq_label";
            this.ExpDq_label.Size = new System.Drawing.Size(112, 16);
            this.ExpDq_label.TabIndex = 17;
            this.ExpDq_label.Text = "dq = d %(q-1)";
            this.ExpDq_label.Click += new System.EventHandler(this.ExpDq_label_Click);
            // 
            // ExpDp_textBox
            // 
            this.ExpDp_textBox.Location = new System.Drawing.Point(139, 351);
            this.ExpDp_textBox.Multiline = true;
            this.ExpDp_textBox.Name = "ExpDp_textBox";
            this.ExpDp_textBox.Size = new System.Drawing.Size(413, 50);
            this.ExpDp_textBox.TabIndex = 18;
            this.ExpDp_textBox.TextChanged += new System.EventHandler(this.ExpDp_textBox_TextChanged);
            // 
            // ExpDq_textBox
            // 
            this.ExpDq_textBox.Location = new System.Drawing.Point(689, 351);
            this.ExpDq_textBox.Multiline = true;
            this.ExpDq_textBox.Name = "ExpDq_textBox";
            this.ExpDq_textBox.Size = new System.Drawing.Size(413, 50);
            this.ExpDq_textBox.TabIndex = 19;
            this.ExpDq_textBox.TextChanged += new System.EventHandler(this.ExpDq_textBox_TextChanged);
            // 
            // Run_button
            // 
            this.Run_button.Font = new System.Drawing.Font("宋体", 16F);
            this.Run_button.Location = new System.Drawing.Point(1145, 521);
            this.Run_button.Name = "Run_button";
            this.Run_button.Size = new System.Drawing.Size(83, 33);
            this.Run_button.TabIndex = 20;
            this.Run_button.Text = "run";
            this.Run_button.UseVisualStyleBackColor = true;
            this.Run_button.Click += new System.EventHandler(this.Run_button_Click);
            // 
            // Log_textBox
            // 
            this.Log_textBox.Location = new System.Drawing.Point(1124, 32);
            this.Log_textBox.Multiline = true;
            this.Log_textBox.Name = "Log_textBox";
            this.Log_textBox.Size = new System.Drawing.Size(128, 432);
            this.Log_textBox.TabIndex = 21;
            this.Log_textBox.Text = "消息框（log）\r\n记录内部运转内容\r\n";
            this.Log_textBox.TextChanged += new System.EventHandler(this.Log_textBox_TextChanged);
            // 
            // FurtherAnalysis_checkBox
            // 
            this.FurtherAnalysis_checkBox.AutoSize = true;
            this.FurtherAnalysis_checkBox.Font = new System.Drawing.Font("宋体", 12F);
            this.FurtherAnalysis_checkBox.ForeColor = System.Drawing.Color.Black;
            this.FurtherAnalysis_checkBox.Location = new System.Drawing.Point(1129, 597);
            this.FurtherAnalysis_checkBox.Name = "FurtherAnalysis_checkBox";
            this.FurtherAnalysis_checkBox.Size = new System.Drawing.Size(123, 20);
            this.FurtherAnalysis_checkBox.TabIndex = 22;
            this.FurtherAnalysis_checkBox.Text = "开启进阶分析";
            this.FurtherAnalysis_checkBox.UseVisualStyleBackColor = true;
            this.FurtherAnalysis_checkBox.CheckedChanged += new System.EventHandler(this.FurtherAnalysis_checkBox_CheckedChanged);
            // 
            // Rsa_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.FurtherAnalysis_checkBox);
            this.Controls.Add(this.Log_textBox);
            this.Controls.Add(this.Run_button);
            this.Controls.Add(this.ExpDq_textBox);
            this.Controls.Add(this.ExpDp_textBox);
            this.Controls.Add(this.ExpDq_label);
            this.Controls.Add(this.ExpDp_label);
            this.Controls.Add(this.CryptC_textBox);
            this.Controls.Add(this.TextM_textBox);
            this.Controls.Add(this.ExpD_textBox);
            this.Controls.Add(this.ExpD_label);
            this.Controls.Add(this.ExpE_textBox);
            this.Controls.Add(this.CryptC_label);
            this.Controls.Add(this.TextM_label);
            this.Controls.Add(this.ExpE_label);
            this.Controls.Add(this.PhiN_textBox);
            this.Controls.Add(this.PrimeQ_textBox);
            this.Controls.Add(this.PrimeP_textBox);
            this.Controls.Add(this.ModN_textBox);
            this.Controls.Add(this.PhiN_label);
            this.Controls.Add(this.ModN_label);
            this.Controls.Add(this.PrimeQ_label);
            this.Controls.Add(this.PrimeP_label);
            this.Name = "Rsa_Form";
            this.Text = "rsa工具集";
            this.Load += new System.EventHandler(this.Rsa_Form_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label PrimeP_label;
        private System.Windows.Forms.Label PrimeQ_label;
        private System.Windows.Forms.Label ModN_label;
        private System.Windows.Forms.Label PhiN_label;
        private System.Windows.Forms.TextBox ModN_textBox;
        private System.Windows.Forms.TextBox PrimeP_textBox;
        private System.Windows.Forms.TextBox PrimeQ_textBox;
        private System.Windows.Forms.TextBox PhiN_textBox;
        private System.Windows.Forms.Label ExpE_label;
        private System.Windows.Forms.Label TextM_label;
        private System.Windows.Forms.Label CryptC_label;
        private System.Windows.Forms.TextBox ExpE_textBox;
        private System.Windows.Forms.Label ExpD_label;
        private System.Windows.Forms.TextBox ExpD_textBox;
        private System.Windows.Forms.TextBox TextM_textBox;
        private System.Windows.Forms.TextBox CryptC_textBox;
        private System.Windows.Forms.Label ExpDp_label;
        private System.Windows.Forms.Label ExpDq_label;
        private System.Windows.Forms.TextBox ExpDp_textBox;
        private System.Windows.Forms.TextBox ExpDq_textBox;
        private System.Windows.Forms.Button Run_button;
        private System.Windows.Forms.TextBox Log_textBox;
        private System.Windows.Forms.CheckBox FurtherAnalysis_checkBox;
    }
}