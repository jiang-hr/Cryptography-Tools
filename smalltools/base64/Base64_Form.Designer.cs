namespace Cryptography_Tools.smalltools.base64
{
    partial class Base64_Form
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
            this.Encode_textBox = new System.Windows.Forms.TextBox();
            this.Decode_textBox = new System.Windows.Forms.TextBox();
            this.Base64_button = new System.Windows.Forms.Button();
            this.Base32_button = new System.Windows.Forms.Button();
            this.Base16_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Encode_textBox
            // 
            this.Encode_textBox.Location = new System.Drawing.Point(12, 12);
            this.Encode_textBox.Multiline = true;
            this.Encode_textBox.Name = "Encode_textBox";
            this.Encode_textBox.Size = new System.Drawing.Size(588, 190);
            this.Encode_textBox.TabIndex = 0;
            this.Encode_textBox.Text = "Encode_textBox请把你要加密的内容放入";
            this.Encode_textBox.TextChanged += new System.EventHandler(this.Encode_textBox_TextChanged);
            // 
            // Decode_textBox
            // 
            this.Decode_textBox.Location = new System.Drawing.Point(12, 208);
            this.Decode_textBox.Multiline = true;
            this.Decode_textBox.Name = "Decode_textBox";
            this.Decode_textBox.Size = new System.Drawing.Size(588, 230);
            this.Decode_textBox.TabIndex = 1;
            this.Decode_textBox.Text = "Decode_textBox请把你要解密的内容放入";
            this.Decode_textBox.TextChanged += new System.EventHandler(this.Decode_textBox_TextChanged);
            // 
            // Base64_button
            // 
            this.Base64_button.Location = new System.Drawing.Point(655, 58);
            this.Base64_button.Name = "Base64_button";
            this.Base64_button.Size = new System.Drawing.Size(75, 23);
            this.Base64_button.TabIndex = 2;
            this.Base64_button.Text = "Base64版本";
            this.Base64_button.UseVisualStyleBackColor = true;
            this.Base64_button.Click += new System.EventHandler(this.Base64_button_Click);
            // 
            // Base32_button
            // 
            this.Base32_button.Location = new System.Drawing.Point(655, 192);
            this.Base32_button.Name = "Base32_button";
            this.Base32_button.Size = new System.Drawing.Size(75, 23);
            this.Base32_button.TabIndex = 3;
            this.Base32_button.Text = "Base32版本";
            this.Base32_button.UseVisualStyleBackColor = true;
            this.Base32_button.Click += new System.EventHandler(this.Base32_button_Click);
            // 
            // Base16_button
            // 
            this.Base16_button.Location = new System.Drawing.Point(655, 307);
            this.Base16_button.Name = "Base16_button";
            this.Base16_button.Size = new System.Drawing.Size(75, 23);
            this.Base16_button.TabIndex = 4;
            this.Base16_button.Text = "Base16版本";
            this.Base16_button.UseVisualStyleBackColor = true;
            this.Base16_button.Click += new System.EventHandler(this.Base16_button_Click);
            // 
            // Base64_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Base16_button);
            this.Controls.Add(this.Base32_button);
            this.Controls.Add(this.Base64_button);
            this.Controls.Add(this.Decode_textBox);
            this.Controls.Add(this.Encode_textBox);
            this.Name = "Base64_Form";
            this.Text = "Base64";
            this.Load += new System.EventHandler(this.Base64_Form_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Encode_textBox;
        private System.Windows.Forms.TextBox Decode_textBox;
        private System.Windows.Forms.Button Base64_button;
        private System.Windows.Forms.Button Base32_button;
        private System.Windows.Forms.Button Base16_button;
    }
}