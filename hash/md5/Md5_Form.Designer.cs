namespace Cryptography_Tools.hash.md5
{
    partial class Md5_Form
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
            this.IsCapital_checkBox = new System.Windows.Forms.CheckBox();
            this.Md5_textBox = new System.Windows.Forms.TextBox();
            this.BeginText_button = new System.Windows.Forms.Button();
            this.Input_textBox = new System.Windows.Forms.TextBox();
            this.Stream_textBox = new System.Windows.Forms.TextBox();
            this.Stream_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // IsCapital_checkBox
            // 
            this.IsCapital_checkBox.AutoSize = true;
            this.IsCapital_checkBox.Font = new System.Drawing.Font("宋体", 12F);
            this.IsCapital_checkBox.Location = new System.Drawing.Point(546, 370);
            this.IsCapital_checkBox.Name = "IsCapital_checkBox";
            this.IsCapital_checkBox.Size = new System.Drawing.Size(123, 20);
            this.IsCapital_checkBox.TabIndex = 0;
            this.IsCapital_checkBox.Text = "是否大写字母";
            this.IsCapital_checkBox.UseVisualStyleBackColor = true;
            this.IsCapital_checkBox.CheckedChanged += new System.EventHandler(this.IsCapital_checkBox_CheckedChanged);
            // 
            // Md5_textBox
            // 
            this.Md5_textBox.Font = new System.Drawing.Font("宋体", 12F);
            this.Md5_textBox.Location = new System.Drawing.Point(40, 370);
            this.Md5_textBox.Name = "Md5_textBox";
            this.Md5_textBox.Size = new System.Drawing.Size(458, 26);
            this.Md5_textBox.TabIndex = 1;
            this.Md5_textBox.TextChanged += new System.EventHandler(this.Md5_textBox_TextChanged);
            // 
            // BeginText_button
            // 
            this.BeginText_button.Font = new System.Drawing.Font("宋体", 16F);
            this.BeginText_button.Location = new System.Drawing.Point(542, 103);
            this.BeginText_button.Name = "BeginText_button";
            this.BeginText_button.Size = new System.Drawing.Size(127, 45);
            this.BeginText_button.TabIndex = 2;
            this.BeginText_button.Text = "Md5文章";
            this.BeginText_button.UseVisualStyleBackColor = true;
            this.BeginText_button.Click += new System.EventHandler(this.BeginText_button_Click);
            // 
            // Input_textBox
            // 
            this.Input_textBox.Location = new System.Drawing.Point(40, 21);
            this.Input_textBox.Multiline = true;
            this.Input_textBox.Name = "Input_textBox";
            this.Input_textBox.Size = new System.Drawing.Size(458, 237);
            this.Input_textBox.TabIndex = 3;
            this.Input_textBox.Text = "把文章内容放入此处";
            this.Input_textBox.TextChanged += new System.EventHandler(this.Input_textBox_TextChanged);
            // 
            // Stream_textBox
            // 
            this.Stream_textBox.Location = new System.Drawing.Point(40, 300);
            this.Stream_textBox.Multiline = true;
            this.Stream_textBox.Name = "Stream_textBox";
            this.Stream_textBox.Size = new System.Drawing.Size(458, 40);
            this.Stream_textBox.TabIndex = 4;
            this.Stream_textBox.Text = "把文件的位置放入此处";
            this.Stream_textBox.TextChanged += new System.EventHandler(this.Stream_textBox_TextChanged);
            // 
            // Stream_button
            // 
            this.Stream_button.Font = new System.Drawing.Font("宋体", 16F);
            this.Stream_button.Location = new System.Drawing.Point(542, 300);
            this.Stream_button.Name = "Stream_button";
            this.Stream_button.Size = new System.Drawing.Size(127, 40);
            this.Stream_button.TabIndex = 5;
            this.Stream_button.Text = "Md5文件";
            this.Stream_button.UseVisualStyleBackColor = true;
            this.Stream_button.Click += new System.EventHandler(this.Stream_button_Click);
            // 
            // Md5_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(708, 450);
            this.Controls.Add(this.Stream_button);
            this.Controls.Add(this.Stream_textBox);
            this.Controls.Add(this.Input_textBox);
            this.Controls.Add(this.BeginText_button);
            this.Controls.Add(this.Md5_textBox);
            this.Controls.Add(this.IsCapital_checkBox);
            this.Name = "Md5_Form";
            this.Text = "Md5";
            this.Load += new System.EventHandler(this.Md5_Form_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox IsCapital_checkBox;
        private System.Windows.Forms.TextBox Md5_textBox;
        private System.Windows.Forms.Button BeginText_button;
        private System.Windows.Forms.TextBox Input_textBox;
        private System.Windows.Forms.TextBox Stream_textBox;
        private System.Windows.Forms.Button Stream_button;
    }
}