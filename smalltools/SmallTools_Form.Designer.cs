namespace Cryptography_Tools.smalltools
{
    partial class SmallTools_Form
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
            this.Base64_button = new System.Windows.Forms.Button();
            this.flowLayoutPanel_Right = new System.Windows.Forms.FlowLayoutPanel();
            this.Md5_button = new System.Windows.Forms.Button();
            this.Log_textBox = new System.Windows.Forms.TextBox();
            this.Rc4_button = new System.Windows.Forms.Button();
            this.flowLayoutPanel_Right.SuspendLayout();
            this.SuspendLayout();
            // 
            // Base64_button
            // 
            this.Base64_button.Location = new System.Drawing.Point(3, 3);
            this.Base64_button.Name = "Base64_button";
            this.Base64_button.Size = new System.Drawing.Size(71, 26);
            this.Base64_button.TabIndex = 0;
            this.Base64_button.Text = "Base64";
            this.Base64_button.UseVisualStyleBackColor = true;
            this.Base64_button.Click += new System.EventHandler(this.Base64_button_Click);
            // 
            // flowLayoutPanel_Right
            // 
            this.flowLayoutPanel_Right.Controls.Add(this.Base64_button);
            this.flowLayoutPanel_Right.Controls.Add(this.Md5_button);
            this.flowLayoutPanel_Right.Controls.Add(this.Rc4_button);
            this.flowLayoutPanel_Right.Location = new System.Drawing.Point(12, 12);
            this.flowLayoutPanel_Right.Name = "flowLayoutPanel_Right";
            this.flowLayoutPanel_Right.Size = new System.Drawing.Size(776, 304);
            this.flowLayoutPanel_Right.TabIndex = 2;
            // 
            // Md5_button
            // 
            this.Md5_button.Location = new System.Drawing.Point(80, 3);
            this.Md5_button.Name = "Md5_button";
            this.Md5_button.Size = new System.Drawing.Size(75, 26);
            this.Md5_button.TabIndex = 1;
            this.Md5_button.Text = "md5";
            this.Md5_button.UseVisualStyleBackColor = true;
            this.Md5_button.Click += new System.EventHandler(this.Md5_button_Click);
            // 
            // Log_textBox
            // 
            this.Log_textBox.Location = new System.Drawing.Point(12, 322);
            this.Log_textBox.Multiline = true;
            this.Log_textBox.Name = "Log_textBox";
            this.Log_textBox.Size = new System.Drawing.Size(776, 116);
            this.Log_textBox.TabIndex = 3;
            this.Log_textBox.Text = "目前这个日志log毫无卵用，纯粹占个地方";
            // 
            // Rc4_button
            // 
            this.Rc4_button.Location = new System.Drawing.Point(161, 3);
            this.Rc4_button.Name = "Rc4_button";
            this.Rc4_button.Size = new System.Drawing.Size(75, 26);
            this.Rc4_button.TabIndex = 2;
            this.Rc4_button.Text = "rc4";
            this.Rc4_button.UseVisualStyleBackColor = true;
            this.Rc4_button.Click += new System.EventHandler(this.Rc4_button_Click);
            // 
            // SmallTools_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Log_textBox);
            this.Controls.Add(this.flowLayoutPanel_Right);
            this.Name = "SmallTools_Form";
            this.Text = "小工具集";
            this.Load += new System.EventHandler(this.SmallTools_Form_Load);
            this.flowLayoutPanel_Right.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Base64_button;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel_Right;
        private System.Windows.Forms.TextBox Log_textBox;
        private System.Windows.Forms.Button Md5_button;
        private System.Windows.Forms.Button Rc4_button;
    }
}