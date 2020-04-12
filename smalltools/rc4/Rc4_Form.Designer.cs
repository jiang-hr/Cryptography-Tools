namespace Cryptography_Tools.smalltools.rc4
{
    partial class Rc4_Form
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
            this.Encrypt_button = new System.Windows.Forms.Button();
            this.Decrypt_button = new System.Windows.Forms.Button();
            this.Key_textBox = new System.Windows.Forms.TextBox();
            this.Encrypt_textBox = new System.Windows.Forms.TextBox();
            this.Decrypt_textBox = new System.Windows.Forms.TextBox();
            this.Base64_checkBox = new System.Windows.Forms.CheckBox();
            this.Hex_checkBox = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // Encrypt_button
            // 
            this.Encrypt_button.Font = new System.Drawing.Font("宋体", 16F);
            this.Encrypt_button.Location = new System.Drawing.Point(649, 74);
            this.Encrypt_button.Name = "Encrypt_button";
            this.Encrypt_button.Size = new System.Drawing.Size(75, 37);
            this.Encrypt_button.TabIndex = 0;
            this.Encrypt_button.Text = "加密";
            this.Encrypt_button.UseVisualStyleBackColor = true;
            this.Encrypt_button.Click += new System.EventHandler(this.Encrypt_button_Click);
            // 
            // Decrypt_button
            // 
            this.Decrypt_button.Font = new System.Drawing.Font("宋体", 16F);
            this.Decrypt_button.Location = new System.Drawing.Point(649, 305);
            this.Decrypt_button.Name = "Decrypt_button";
            this.Decrypt_button.Size = new System.Drawing.Size(75, 37);
            this.Decrypt_button.TabIndex = 1;
            this.Decrypt_button.Text = "解密";
            this.Decrypt_button.UseVisualStyleBackColor = true;
            this.Decrypt_button.Click += new System.EventHandler(this.Decrypt_button_Click);
            // 
            // Key_textBox
            // 
            this.Key_textBox.Location = new System.Drawing.Point(34, 196);
            this.Key_textBox.Name = "Key_textBox";
            this.Key_textBox.Size = new System.Drawing.Size(480, 21);
            this.Key_textBox.TabIndex = 2;
            this.Key_textBox.Text = "key";
            this.Key_textBox.TextChanged += new System.EventHandler(this.Key_textBox_TextChanged);
            // 
            // Encrypt_textBox
            // 
            this.Encrypt_textBox.Location = new System.Drawing.Point(34, 13);
            this.Encrypt_textBox.Multiline = true;
            this.Encrypt_textBox.Name = "Encrypt_textBox";
            this.Encrypt_textBox.Size = new System.Drawing.Size(480, 151);
            this.Encrypt_textBox.TabIndex = 3;
            this.Encrypt_textBox.Text = "Please put the content you want to encrypt. Now you can use utf-8.";
            this.Encrypt_textBox.TextChanged += new System.EventHandler(this.Encrypt_textBox_TextChanged);
            // 
            // Decrypt_textBox
            // 
            this.Decrypt_textBox.Location = new System.Drawing.Point(34, 251);
            this.Decrypt_textBox.Multiline = true;
            this.Decrypt_textBox.Name = "Decrypt_textBox";
            this.Decrypt_textBox.Size = new System.Drawing.Size(480, 164);
            this.Decrypt_textBox.TabIndex = 4;
            this.Decrypt_textBox.Text = "Please put the content you want to decrypt. Now you can use utf-8.";
            this.Decrypt_textBox.TextChanged += new System.EventHandler(this.Decrypt_textBox_TextChanged);
            // 
            // Base64_checkBox
            // 
            this.Base64_checkBox.AutoSize = true;
            this.Base64_checkBox.Checked = true;
            this.Base64_checkBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.Base64_checkBox.Location = new System.Drawing.Point(616, 171);
            this.Base64_checkBox.Name = "Base64_checkBox";
            this.Base64_checkBox.Size = new System.Drawing.Size(108, 16);
            this.Base64_checkBox.TabIndex = 5;
            this.Base64_checkBox.Text = "是否Base64加密";
            this.Base64_checkBox.UseVisualStyleBackColor = true;
            this.Base64_checkBox.CheckedChanged += new System.EventHandler(this.Base64_checkBox_CheckedChanged);
            // 
            // Hex_checkBox
            // 
            this.Hex_checkBox.AutoSize = true;
            this.Hex_checkBox.Location = new System.Drawing.Point(616, 225);
            this.Hex_checkBox.Name = "Hex_checkBox";
            this.Hex_checkBox.Size = new System.Drawing.Size(108, 16);
            this.Hex_checkBox.TabIndex = 6;
            this.Hex_checkBox.Text = "是否16进制显示";
            this.Hex_checkBox.UseVisualStyleBackColor = true;
            this.Hex_checkBox.CheckedChanged += new System.EventHandler(this.Hex_checkBox_CheckedChanged);
            // 
            // Rc4_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Hex_checkBox);
            this.Controls.Add(this.Base64_checkBox);
            this.Controls.Add(this.Decrypt_textBox);
            this.Controls.Add(this.Encrypt_textBox);
            this.Controls.Add(this.Key_textBox);
            this.Controls.Add(this.Decrypt_button);
            this.Controls.Add(this.Encrypt_button);
            this.Name = "Rc4_Form";
            this.Text = "Rc4加密与解密";
            this.Load += new System.EventHandler(this.Rc4_Form_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Encrypt_button;
        private System.Windows.Forms.Button Decrypt_button;
        private System.Windows.Forms.TextBox Key_textBox;
        private System.Windows.Forms.TextBox Encrypt_textBox;
        private System.Windows.Forms.TextBox Decrypt_textBox;
        private System.Windows.Forms.CheckBox Base64_checkBox;
        private System.Windows.Forms.CheckBox Hex_checkBox;
    }
}