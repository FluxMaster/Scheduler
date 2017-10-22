namespace Scheduler
{
    partial class JobEditor
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
            this.saveBtn = new System.Windows.Forms.Button();
            this.loadBtn = new System.Windows.Forms.Button();
            this.addBtn = new System.Windows.Forms.Button();
            this.listTxtBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // saveBtn
            // 
            this.saveBtn.Location = new System.Drawing.Point(75, 21);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(75, 23);
            this.saveBtn.TabIndex = 0;
            this.saveBtn.Text = "Save List";
            this.saveBtn.UseVisualStyleBackColor = true;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // loadBtn
            // 
            this.loadBtn.Location = new System.Drawing.Point(202, 21);
            this.loadBtn.Name = "loadBtn";
            this.loadBtn.Size = new System.Drawing.Size(75, 23);
            this.loadBtn.TabIndex = 1;
            this.loadBtn.Text = "Load List";
            this.loadBtn.UseVisualStyleBackColor = true;
            this.loadBtn.Click += new System.EventHandler(this.loadBtn_Click);
            // 
            // addBtn
            // 
            this.addBtn.Location = new System.Drawing.Point(329, 21);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(75, 23);
            this.addBtn.TabIndex = 2;
            this.addBtn.Text = "Add Job";
            this.addBtn.UseVisualStyleBackColor = true;
            // 
            // listTxtBox
            // 
            this.listTxtBox.Location = new System.Drawing.Point(12, 59);
            this.listTxtBox.Multiline = true;
            this.listTxtBox.Name = "listTxtBox";
            this.listTxtBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.listTxtBox.Size = new System.Drawing.Size(472, 302);
            this.listTxtBox.TabIndex = 4;
            // 
            // JobEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(496, 373);
            this.Controls.Add(this.listTxtBox);
            this.Controls.Add(this.addBtn);
            this.Controls.Add(this.loadBtn);
            this.Controls.Add(this.saveBtn);
            this.Name = "JobEditor";
            this.Text = "JobEditor";
            this.Load += new System.EventHandler(this.JobEditor_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.Button loadBtn;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.TextBox listTxtBox;
    }
}