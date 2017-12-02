namespace Scheduler
{
    partial class AddJob
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.jobTxtBox = new System.Windows.Forms.TextBox();
            this.workersTxtBox = new System.Windows.Forms.TextBox();
            this.hoursTxtBox = new System.Windows.Forms.TextBox();
            this.timeBox = new System.Windows.Forms.ComboBox();
            this.monChkBox = new System.Windows.Forms.CheckBox();
            this.tuesChkBox = new System.Windows.Forms.CheckBox();
            this.wedChkBox = new System.Windows.Forms.CheckBox();
            this.thursChkBox = new System.Windows.Forms.CheckBox();
            this.fridayChkBox = new System.Windows.Forms.CheckBox();
            this.satChkBox = new System.Windows.Forms.CheckBox();
            this.sunChkBox = new System.Windows.Forms.CheckBox();
            this.addBtn = new System.Windows.Forms.Button();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(65, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name of job:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(65, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Number of workers:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(65, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Number of hours:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(65, 126);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Time";
            // 
            // jobTxtBox
            // 
            this.jobTxtBox.Location = new System.Drawing.Point(186, 22);
            this.jobTxtBox.Name = "jobTxtBox";
            this.jobTxtBox.Size = new System.Drawing.Size(121, 20);
            this.jobTxtBox.TabIndex = 4;
            // 
            // workersTxtBox
            // 
            this.workersTxtBox.Location = new System.Drawing.Point(186, 60);
            this.workersTxtBox.Name = "workersTxtBox";
            this.workersTxtBox.Size = new System.Drawing.Size(121, 20);
            this.workersTxtBox.TabIndex = 5;
            // 
            // hoursTxtBox
            // 
            this.hoursTxtBox.Location = new System.Drawing.Point(186, 91);
            this.hoursTxtBox.Name = "hoursTxtBox";
            this.hoursTxtBox.Size = new System.Drawing.Size(121, 20);
            this.hoursTxtBox.TabIndex = 6;
            // 
            // timeBox
            // 
            this.timeBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.timeBox.FormattingEnabled = true;
            this.timeBox.Items.AddRange(new object[] {
            "12AM",
            "1AM",
            "2AM",
            "3AM",
            "4AM",
            "5AM",
            "6AM",
            "7AM",
            "8AM",
            "9AM",
            "10AM",
            "11AM",
            "12PM",
            "1PM",
            "2PM",
            "3PM",
            "4PM",
            "5PM",
            "6PM",
            "7PM",
            "8PM",
            "9PM",
            "10PM",
            "11PM"});
            this.timeBox.Location = new System.Drawing.Point(186, 122);
            this.timeBox.Name = "timeBox";
            this.timeBox.Size = new System.Drawing.Size(121, 21);
            this.timeBox.TabIndex = 7;
            // 
            // monChkBox
            // 
            this.monChkBox.AutoSize = true;
            this.monChkBox.Location = new System.Drawing.Point(99, 27);
            this.monChkBox.Name = "monChkBox";
            this.monChkBox.Size = new System.Drawing.Size(64, 17);
            this.monChkBox.TabIndex = 8;
            this.monChkBox.Text = "Monday";
            this.monChkBox.UseVisualStyleBackColor = true;
            // 
            // tuesChkBox
            // 
            this.tuesChkBox.AutoSize = true;
            this.tuesChkBox.Location = new System.Drawing.Point(169, 27);
            this.tuesChkBox.Name = "tuesChkBox";
            this.tuesChkBox.Size = new System.Drawing.Size(67, 17);
            this.tuesChkBox.TabIndex = 9;
            this.tuesChkBox.Text = "Tuesday";
            this.tuesChkBox.UseVisualStyleBackColor = true;
            // 
            // wedChkBox
            // 
            this.wedChkBox.AutoSize = true;
            this.wedChkBox.Location = new System.Drawing.Point(242, 27);
            this.wedChkBox.Name = "wedChkBox";
            this.wedChkBox.Size = new System.Drawing.Size(83, 17);
            this.wedChkBox.TabIndex = 10;
            this.wedChkBox.Text = "Wednesday";
            this.wedChkBox.UseVisualStyleBackColor = true;
            // 
            // thursChkBox
            // 
            this.thursChkBox.AutoSize = true;
            this.thursChkBox.Location = new System.Drawing.Point(46, 61);
            this.thursChkBox.Name = "thursChkBox";
            this.thursChkBox.Size = new System.Drawing.Size(70, 17);
            this.thursChkBox.TabIndex = 11;
            this.thursChkBox.Text = "Thursday";
            this.thursChkBox.UseVisualStyleBackColor = true;
            // 
            // fridayChkBox
            // 
            this.fridayChkBox.AutoSize = true;
            this.fridayChkBox.Location = new System.Drawing.Point(152, 61);
            this.fridayChkBox.Name = "fridayChkBox";
            this.fridayChkBox.Size = new System.Drawing.Size(54, 17);
            this.fridayChkBox.TabIndex = 12;
            this.fridayChkBox.Text = "Friday";
            this.fridayChkBox.UseVisualStyleBackColor = true;
            // 
            // satChkBox
            // 
            this.satChkBox.AutoSize = true;
            this.satChkBox.Location = new System.Drawing.Point(242, 61);
            this.satChkBox.Name = "satChkBox";
            this.satChkBox.Size = new System.Drawing.Size(68, 17);
            this.satChkBox.TabIndex = 13;
            this.satChkBox.Text = "Saturday";
            this.satChkBox.UseVisualStyleBackColor = true;
            // 
            // sunChkBox
            // 
            this.sunChkBox.AutoSize = true;
            this.sunChkBox.Location = new System.Drawing.Point(31, 27);
            this.sunChkBox.Name = "sunChkBox";
            this.sunChkBox.Size = new System.Drawing.Size(62, 17);
            this.sunChkBox.TabIndex = 14;
            this.sunChkBox.Text = "Sunday";
            this.sunChkBox.UseVisualStyleBackColor = true;
            // 
            // addBtn
            // 
            this.addBtn.Location = new System.Drawing.Point(81, 264);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(75, 23);
            this.addBtn.TabIndex = 15;
            this.addBtn.Text = "Add Job";
            this.addBtn.UseVisualStyleBackColor = true;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // cancelBtn
            // 
            this.cancelBtn.Location = new System.Drawing.Point(214, 264);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(75, 23);
            this.cancelBtn.TabIndex = 16;
            this.cancelBtn.Text = "Cancel";
            this.cancelBtn.UseVisualStyleBackColor = true;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.monChkBox);
            this.groupBox1.Controls.Add(this.tuesChkBox);
            this.groupBox1.Controls.Add(this.wedChkBox);
            this.groupBox1.Controls.Add(this.sunChkBox);
            this.groupBox1.Controls.Add(this.thursChkBox);
            this.groupBox1.Controls.Add(this.satChkBox);
            this.groupBox1.Controls.Add(this.fridayChkBox);
            this.groupBox1.Location = new System.Drawing.Point(12, 164);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(348, 84);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Day of week";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // AddJob
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(371, 307);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.addBtn);
            this.Controls.Add(this.timeBox);
            this.Controls.Add(this.hoursTxtBox);
            this.Controls.Add(this.workersTxtBox);
            this.Controls.Add(this.jobTxtBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AddJob";
            this.Text = "Add A Job";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox jobTxtBox;
        private System.Windows.Forms.TextBox workersTxtBox;
        private System.Windows.Forms.TextBox hoursTxtBox;
        private System.Windows.Forms.ComboBox timeBox;
        private System.Windows.Forms.CheckBox monChkBox;
        private System.Windows.Forms.CheckBox tuesChkBox;
        private System.Windows.Forms.CheckBox wedChkBox;
        private System.Windows.Forms.CheckBox thursChkBox;
        private System.Windows.Forms.CheckBox fridayChkBox;
        private System.Windows.Forms.CheckBox satChkBox;
        private System.Windows.Forms.CheckBox sunChkBox;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}