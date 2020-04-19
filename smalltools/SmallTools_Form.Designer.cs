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
            this.flowLayoutPanel_Right = new System.Windows.Forms.FlowLayoutPanel();
            this.Rc4_button = new System.Windows.Forms.Button();
            this.Log_textBox = new System.Windows.Forms.TextBox();
            this.flowLayoutPanel_Right.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel_Right
            // 
            this.flowLayoutPanel_Right.Controls.Add(this.Rc4_button);
            this.flowLayoutPanel_Right.Location = new System.Drawing.Point(12, 12);
            this.flowLayoutPanel_Right.Name = "flowLayoutPanel_Right";
            this.flowLayoutPanel_Right.Size = new System.Drawing.Size(776, 304);
            this.flowLayoutPanel_Right.TabIndex = 2;
            // 
            // Rc4_button
            // 
            this.Rc4_button.Font = new System.Drawing.Font("宋体", 16F);
            this.Rc4_button.Location = new System.Drawing.Point(3, 3);
            this.Rc4_button.Name = "Rc4_button";
            this.Rc4_button.Size = new System.Drawing.Size(125, 40);
            this.Rc4_button.TabIndex = 2;
            this.Rc4_button.Text = "rc4加密";
            this.Rc4_button.UseVisualStyleBackColor = true;
            this.Rc4_button.Click += new System.EventHandler(this.Rc4_button_Click);
            // 
            // Log_textBox
            // 
            this.Log_textBox.Font = new System.Drawing.Font("宋体", 12F);
            this.Log_textBox.Location = new System.Drawing.Point(12, 322);
            this.Log_textBox.Multiline = true;
            this.Log_textBox.Name = "Log_textBox";
            this.Log_textBox.Size = new System.Drawing.Size(776, 116);
            this.Log_textBox.TabIndex = 3;
            this.Log_textBox.Text = "小工具集集成了各种各样的小的加密方式或者是通讯方式\r\n比如最原始的rc4流密码之类的工具。\r\n当然也有许多通讯用的内容，比如base编码或者url编码。";
            this.Log_textBox.TextChanged += new System.EventHandler(this.Log_textBox_TextChanged);
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
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel_Right;
        private System.Windows.Forms.TextBox Log_textBox;
        private System.Windows.Forms.Button Rc4_button;
    }
}