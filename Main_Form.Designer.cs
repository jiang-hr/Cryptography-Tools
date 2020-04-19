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
            this.SmallTools_button = new System.Windows.Forms.Button();
            this.Rsa_button = new System.Windows.Forms.Button();
            this.Hash_button = new System.Windows.Forms.Button();
            this.Coding_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // SmallTools_button
            // 
            this.SmallTools_button.Font = new System.Drawing.Font("宋体", 16F);
            this.SmallTools_button.Location = new System.Drawing.Point(191, 12);
            this.SmallTools_button.Name = "SmallTools_button";
            this.SmallTools_button.Size = new System.Drawing.Size(125, 40);
            this.SmallTools_button.TabIndex = 0;
            this.SmallTools_button.Text = "小工具集";
            this.SmallTools_button.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.SmallTools_button.UseVisualStyleBackColor = true;
            this.SmallTools_button.Click += new System.EventHandler(this.SmallTools_button_Click);
            // 
            // Rsa_button
            // 
            this.Rsa_button.Font = new System.Drawing.Font("宋体", 16F);
            this.Rsa_button.Location = new System.Drawing.Point(12, 12);
            this.Rsa_button.Name = "Rsa_button";
            this.Rsa_button.Size = new System.Drawing.Size(125, 40);
            this.Rsa_button.TabIndex = 1;
            this.Rsa_button.Text = "rsa工具集";
            this.Rsa_button.UseVisualStyleBackColor = true;
            this.Rsa_button.Click += new System.EventHandler(this.Rsa_button_Click);
            // 
            // Hash_button
            // 
            this.Hash_button.Font = new System.Drawing.Font("宋体", 16F);
            this.Hash_button.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Hash_button.Location = new System.Drawing.Point(13, 58);
            this.Hash_button.Name = "Hash_button";
            this.Hash_button.Size = new System.Drawing.Size(125, 40);
            this.Hash_button.TabIndex = 2;
            this.Hash_button.Text = "哈希算法";
            this.Hash_button.UseVisualStyleBackColor = true;
            this.Hash_button.Click += new System.EventHandler(this.Hash_button_Click);
            // 
            // Coding_button
            // 
            this.Coding_button.Font = new System.Drawing.Font("宋体", 16F);
            this.Coding_button.Location = new System.Drawing.Point(191, 58);
            this.Coding_button.Name = "Coding_button";
            this.Coding_button.Size = new System.Drawing.Size(125, 40);
            this.Coding_button.TabIndex = 3;
            this.Coding_button.Text = "编码转换";
            this.Coding_button.UseVisualStyleBackColor = true;
            this.Coding_button.Click += new System.EventHandler(this.Coding_button_Click);
            // 
            // Main_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(341, 230);
            this.Controls.Add(this.Coding_button);
            this.Controls.Add(this.Hash_button);
            this.Controls.Add(this.Rsa_button);
            this.Controls.Add(this.SmallTools_button);
            this.Name = "Main_Form";
            this.Text = "密码学工具集";
            this.Load += new System.EventHandler(this.Main_Form_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button SmallTools_button;
        private System.Windows.Forms.Button Rsa_button;
        private System.Windows.Forms.Button Hash_button;
        private System.Windows.Forms.Button Coding_button;
    }
}

