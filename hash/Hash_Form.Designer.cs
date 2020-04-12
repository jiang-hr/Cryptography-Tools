namespace Cryptography_Tools.hash
{
    partial class Hash_Form
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
            this.Log_textBox = new System.Windows.Forms.TextBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.Md5_button = new System.Windows.Forms.Button();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Log_textBox
            // 
            this.Log_textBox.Font = new System.Drawing.Font("宋体", 12F);
            this.Log_textBox.Location = new System.Drawing.Point(12, 322);
            this.Log_textBox.Multiline = true;
            this.Log_textBox.Name = "Log_textBox";
            this.Log_textBox.Size = new System.Drawing.Size(776, 116);
            this.Log_textBox.TabIndex = 4;
            this.Log_textBox.Text = "此部分记录了大部分的hash的算法，hash是不可逆的，所以不提供解密的算法。\r\n\r\n倒是有可能出现生日碰撞，不过本程序不会给出实现生日碰撞的功能。";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.Md5_button);
            this.flowLayoutPanel1.Cursor = System.Windows.Forms.Cursors.Default;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(12, 12);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(776, 304);
            this.flowLayoutPanel1.TabIndex = 5;
            // 
            // Md5_button
            // 
            this.Md5_button.Font = new System.Drawing.Font("宋体", 16F);
            this.Md5_button.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Md5_button.Location = new System.Drawing.Point(3, 3);
            this.Md5_button.Name = "Md5_button";
            this.Md5_button.Size = new System.Drawing.Size(125, 40);
            this.Md5_button.TabIndex = 0;
            this.Md5_button.Text = "md5";
            this.Md5_button.UseVisualStyleBackColor = true;
            this.Md5_button.Click += new System.EventHandler(this.Md5_button_Click);
            // 
            // Hash_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.Log_textBox);
            this.Name = "Hash_Form";
            this.Text = "Hash_Form";
            this.Load += new System.EventHandler(this.Hash_Form_Load);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Log_textBox;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button Md5_button;
    }
}