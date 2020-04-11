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
            this.encrypt_button = new System.Windows.Forms.Button();
            this.decrypt_button = new System.Windows.Forms.Button();
            this.key_textBox = new System.Windows.Forms.TextBox();
            this.encrypt_textBox = new System.Windows.Forms.TextBox();
            this.decrypt_textBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // encrypt_button
            // 
            this.encrypt_button.Font = new System.Drawing.Font("宋体", 16F);
            this.encrypt_button.Location = new System.Drawing.Point(649, 74);
            this.encrypt_button.Name = "encrypt_button";
            this.encrypt_button.Size = new System.Drawing.Size(75, 37);
            this.encrypt_button.TabIndex = 0;
            this.encrypt_button.Text = "加密";
            this.encrypt_button.UseVisualStyleBackColor = true;
            this.encrypt_button.Click += new System.EventHandler(this.encrypt_button_Click);
            // 
            // decrypt_button
            // 
            this.decrypt_button.Font = new System.Drawing.Font("宋体", 16F);
            this.decrypt_button.Location = new System.Drawing.Point(649, 305);
            this.decrypt_button.Name = "decrypt_button";
            this.decrypt_button.Size = new System.Drawing.Size(75, 37);
            this.decrypt_button.TabIndex = 1;
            this.decrypt_button.Text = "解密";
            this.decrypt_button.UseVisualStyleBackColor = true;
            this.decrypt_button.Click += new System.EventHandler(this.decrypt_button_Click);
            // 
            // key_textBox
            // 
            this.key_textBox.Location = new System.Drawing.Point(34, 196);
            this.key_textBox.Name = "key_textBox";
            this.key_textBox.Size = new System.Drawing.Size(480, 21);
            this.key_textBox.TabIndex = 2;
            this.key_textBox.Text = "key";
            this.key_textBox.TextChanged += new System.EventHandler(this.key_textBox_TextChanged);
            // 
            // encrypt_textBox
            // 
            this.encrypt_textBox.Location = new System.Drawing.Point(34, 13);
            this.encrypt_textBox.Multiline = true;
            this.encrypt_textBox.Name = "encrypt_textBox";
            this.encrypt_textBox.Size = new System.Drawing.Size(480, 151);
            this.encrypt_textBox.TabIndex = 3;
            this.encrypt_textBox.Text = "Please put the content you want to encrypt. Do not use utf-8.";
            this.encrypt_textBox.TextChanged += new System.EventHandler(this.encrypt_textBox_TextChanged);
            // 
            // decrypt_textBox
            // 
            this.decrypt_textBox.Location = new System.Drawing.Point(34, 251);
            this.decrypt_textBox.Multiline = true;
            this.decrypt_textBox.Name = "decrypt_textBox";
            this.decrypt_textBox.Size = new System.Drawing.Size(480, 164);
            this.decrypt_textBox.TabIndex = 4;
            this.decrypt_textBox.Text = "Please put the content you want to decrypt. Do not use utf-8.";
            this.decrypt_textBox.TextChanged += new System.EventHandler(this.decrypt_textBox_TextChanged);
            // 
            // Rc4_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.decrypt_textBox);
            this.Controls.Add(this.encrypt_textBox);
            this.Controls.Add(this.key_textBox);
            this.Controls.Add(this.decrypt_button);
            this.Controls.Add(this.encrypt_button);
            this.Name = "Rc4_Form";
            this.Text = "Rc4_Form";
            this.Load += new System.EventHandler(this.Rc4_Form_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button encrypt_button;
        private System.Windows.Forms.Button decrypt_button;
        private System.Windows.Forms.TextBox key_textBox;
        private System.Windows.Forms.TextBox encrypt_textBox;
        private System.Windows.Forms.TextBox decrypt_textBox;
    }
}