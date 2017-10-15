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
            this.calcBtn = new System.Windows.Forms.Button();
            this.jobEditBtn = new System.Windows.Forms.Button();
            this.aboutBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // calcBtn
            // 
            this.calcBtn.Location = new System.Drawing.Point(61, 22);
            this.calcBtn.Name = "calcBtn";
            this.calcBtn.Size = new System.Drawing.Size(123, 23);
            this.calcBtn.TabIndex = 0;
            this.calcBtn.Text = "Calculate Schedule";
            this.calcBtn.UseVisualStyleBackColor = true;
            // 
            // jobEditBtn
            // 
            this.jobEditBtn.Location = new System.Drawing.Point(61, 71);
            this.jobEditBtn.Name = "jobEditBtn";
            this.jobEditBtn.Size = new System.Drawing.Size(123, 23);
            this.jobEditBtn.TabIndex = 1;
            this.jobEditBtn.Text = "Job List Editor";
            this.jobEditBtn.UseVisualStyleBackColor = true;
            // 
            // aboutBtn
            // 
            this.aboutBtn.Location = new System.Drawing.Point(82, 120);
            this.aboutBtn.Name = "aboutBtn";
            this.aboutBtn.Size = new System.Drawing.Size(75, 23);
            this.aboutBtn.TabIndex = 2;
            this.aboutBtn.Text = "About";
            this.aboutBtn.UseVisualStyleBackColor = true;
            // 
            // ScheduleCalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(246, 159);
            this.Controls.Add(this.aboutBtn);
            this.Controls.Add(this.jobEditBtn);
            this.Controls.Add(this.calcBtn);
            this.Name = "ScheduleCalculator";
            this.Text = "Schedule_Calculator";
            this.Load += new System.EventHandler(this.Schedule_Calculator_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button calcBtn;
        private System.Windows.Forms.Button jobEditBtn;
        private System.Windows.Forms.Button aboutBtn;
    }
}