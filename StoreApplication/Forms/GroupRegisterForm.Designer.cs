namespace StoreApplication.Forms
{
    partial class GroupRegisterForm
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.labelGroupName = new System.Windows.Forms.Label();
            this.labelDescriptions = new System.Windows.Forms.Label();
            this.buttonRegisterGroup = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(96, 53);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(241, 110);
            this.textBox1.TabIndex = 1;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(96, 12);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 2;
            // 
            // labelGroupName
            // 
            this.labelGroupName.AutoSize = true;
            this.labelGroupName.Location = new System.Drawing.Point(29, 15);
            this.labelGroupName.Name = "labelGroupName";
            this.labelGroupName.Size = new System.Drawing.Size(47, 13);
            this.labelGroupName.TabIndex = 3;
            this.labelGroupName.Text = "نام گروه";
            // 
            // labelDescriptions
            // 
            this.labelDescriptions.AutoSize = true;
            this.labelDescriptions.Location = new System.Drawing.Point(29, 56);
            this.labelDescriptions.Name = "labelDescriptions";
            this.labelDescriptions.Size = new System.Drawing.Size(49, 13);
            this.labelDescriptions.TabIndex = 4;
            this.labelDescriptions.Text = "توضیحات";
            // 
            // buttonRegisterGroup
            // 
            this.buttonRegisterGroup.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonRegisterGroup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRegisterGroup.Image = global::StoreApplication.Properties.Resources.AddGroup;
            this.buttonRegisterGroup.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonRegisterGroup.Location = new System.Drawing.Point(168, 182);
            this.buttonRegisterGroup.Name = "buttonRegisterGroup";
            this.buttonRegisterGroup.Size = new System.Drawing.Size(91, 35);
            this.buttonRegisterGroup.TabIndex = 0;
            this.buttonRegisterGroup.Text = "ایجاد گروه";
            this.buttonRegisterGroup.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonRegisterGroup.UseVisualStyleBackColor = true;
            // 
            // GroupRegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(364, 234);
            this.Controls.Add(this.labelDescriptions);
            this.Controls.Add(this.labelGroupName);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.buttonRegisterGroup);
            this.Name = "GroupRegisterForm";
            this.Text = "ایجاد گروه کاربران";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonRegisterGroup;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label labelGroupName;
        private System.Windows.Forms.Label labelDescriptions;
    }
}