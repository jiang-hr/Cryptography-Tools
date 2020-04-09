namespace Cryptography_Tools
{
    partial class Main_Form
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.SmallTools_Button = new System.Windows.Forms.Button();
            this.Rsa_Button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // SmallTools_Button
            // 
            this.SmallTools_Button.Font = new System.Drawing.Font("宋体", 16F);
            this.SmallTools_Button.Location = new System.Drawing.Point(74, 116);
            this.SmallTools_Button.Name = "SmallTools_Button";
            this.SmallTools_Button.Size = new System.Drawing.Size(97, 29);
            this.SmallTools_Button.TabIndex = 0;
            this.SmallTools_Button.Text = "小工具集";
            this.SmallTools_Button.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.SmallTools_Button.UseVisualStyleBackColor = true;
            this.SmallTools_Button.Click += new System.EventHandler(this.SmallTools_Button_Click);
            // 
            // Rsa_Button
            // 
            this.Rsa_Button.Font = new System.Drawing.Font("宋体", 16F);
            this.Rsa_Button.Location = new System.Drawing.Point(74, 208);
            this.Rsa_Button.Name = "Rsa_Button";
            this.Rsa_Button.Size = new System.Drawing.Size(125, 29);
            this.Rsa_Button.TabIndex = 1;
            this.Rsa_Button.Text = "rsa工具集";
            this.Rsa_Button.UseVisualStyleBackColor = true;
            this.Rsa_Button.Click += new System.EventHandler(this.Rsa_Button_Click);
            // 
            // Main_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Rsa_Button);
            this.Controls.Add(this.SmallTools_Button);
            this.Name = "Main_Form";
            this.Text = "密码学工具集";
            this.Load += new System.EventHandler(this.Main_Form_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button SmallTools_Button;
        private System.Windows.Forms.Button Rsa_Button;
    }
}

