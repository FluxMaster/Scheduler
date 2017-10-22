namespace Scheduler
{
    partial class ScheduleCalculator
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
            this.JobEditBtn = new System.Windows.Forms.Button();
            this.aboutBtn = new System.Windows.Forms.Button();
            this.CalcBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // JobEditBtn
            // 
            this.JobEditBtn.Location = new System.Drawing.Point(61, 71);
            this.JobEditBtn.Name = "JobEditBtn";
            this.JobEditBtn.Size = new System.Drawing.Size(123, 23);
            this.JobEditBtn.TabIndex = 1;
            this.JobEditBtn.Text = "Job List Editor";
            this.JobEditBtn.UseVisualStyleBackColor = true;
            this.JobEditBtn.Click += new System.EventHandler(this.JobEditBtn_Click);
            // 
            // aboutBtn
            // 
            this.aboutBtn.Location = new System.Drawing.Point(82, 120);
            this.aboutBtn.Name = "aboutBtn";
            this.aboutBtn.Size = new System.Drawing.Size(75, 23);
            this.aboutBtn.TabIndex = 2;
            this.aboutBtn.Text = "About";
            this.aboutBtn.UseVisualStyleBackColor = true;
            this.aboutBtn.Click += new System.EventHandler(this.aboutBtn_Click);
            // 
            // CalcBtn
            // 
            this.CalcBtn.Location = new System.Drawing.Point(51, 24);
            this.CalcBtn.Name = "CalcBtn";
            this.CalcBtn.Size = new System.Drawing.Size(144, 23);
            this.CalcBtn.TabIndex = 3;
            this.CalcBtn.Text = "Calculate Schedule";
            this.CalcBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.CalcBtn.UseVisualStyleBackColor = true;
            this.CalcBtn.Click += new System.EventHandler(this.CalcBtn_Click);
            // 
            // ScheduleCalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(246, 159);
            this.Controls.Add(this.CalcBtn);
            this.Controls.Add(this.aboutBtn);
            this.Controls.Add(this.JobEditBtn);
            this.Name = "ScheduleCalculator";
            this.Text = "Schedule_Calculator";
            this.Load += new System.EventHandler(this.Schedule_Calculator_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button JobEditBtn;
        private System.Windows.Forms.Button aboutBtn;
        private System.Windows.Forms.Button CalcBtn;
    }
}