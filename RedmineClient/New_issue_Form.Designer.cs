namespace RedmineClient
{
    partial class New_issue_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(New_issue_Form));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.CancelButton = new System.Windows.Forms.Button();
            this.CreateButton = new System.Windows.Forms.Button();
            this.ProjectSelectComboBox = new System.Windows.Forms.ComboBox();
            this.SubjectNameTextBox = new System.Windows.Forms.TextBox();
            this.StartDateCheckBox = new System.Windows.Forms.CheckBox();
            this.DueDateCheckBox = new System.Windows.Forms.CheckBox();
            this.StartDateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.DueDateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.EstimTimeTextBox = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.PrioritycomboBox = new System.Windows.Forms.ComboBox();
            this.PercentDonecomboBox = new System.Windows.Forms.ComboBox();
            this.StatusComboBox = new System.Windows.Forms.ComboBox();
            this.AssignedToComboBox = new System.Windows.Forms.ComboBox();
            this.TrackerComboBox = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.DescriptionRichTextBox = new System.Windows.Forms.RichTextBox();
            this.NotesRichTextBox = new System.Windows.Forms.RichTextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Project:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Subject:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(15, 160);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(85, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "Estimated hours:";
            // 
            // CancelButton
            // 
            this.CancelButton.Location = new System.Drawing.Point(454, 389);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(75, 23);
            this.CancelButton.TabIndex = 15;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // CreateButton
            // 
            this.CreateButton.Location = new System.Drawing.Point(368, 389);
            this.CreateButton.Name = "CreateButton";
            this.CreateButton.Size = new System.Drawing.Size(75, 23);
            this.CreateButton.TabIndex = 16;
            this.CreateButton.Text = "Create";
            this.CreateButton.UseVisualStyleBackColor = true;
            this.CreateButton.Click += new System.EventHandler(this.CreateButton_Click);
            // 
            // ProjectSelectComboBox
            // 
            this.ProjectSelectComboBox.FormattingEnabled = true;
            this.ProjectSelectComboBox.Location = new System.Drawing.Point(66, 13);
            this.ProjectSelectComboBox.Name = "ProjectSelectComboBox";
            this.ProjectSelectComboBox.Size = new System.Drawing.Size(463, 21);
            this.ProjectSelectComboBox.TabIndex = 17;
            // 
            // SubjectNameTextBox
            // 
            this.SubjectNameTextBox.Location = new System.Drawing.Point(68, 46);
            this.SubjectNameTextBox.Name = "SubjectNameTextBox";
            this.SubjectNameTextBox.Size = new System.Drawing.Size(461, 20);
            this.SubjectNameTextBox.TabIndex = 18;
            // 
            // StartDateCheckBox
            // 
            this.StartDateCheckBox.AutoSize = true;
            this.StartDateCheckBox.Location = new System.Drawing.Point(238, 156);
            this.StartDateCheckBox.Name = "StartDateCheckBox";
            this.StartDateCheckBox.Size = new System.Drawing.Size(75, 17);
            this.StartDateCheckBox.TabIndex = 25;
            this.StartDateCheckBox.Text = "Start date:";
            this.StartDateCheckBox.UseVisualStyleBackColor = true;
            this.StartDateCheckBox.CheckedChanged += new System.EventHandler(this.StartDateCheckBox_CheckedChanged);
            // 
            // DueDateCheckBox
            // 
            this.DueDateCheckBox.AutoSize = true;
            this.DueDateCheckBox.Location = new System.Drawing.Point(405, 156);
            this.DueDateCheckBox.Name = "DueDateCheckBox";
            this.DueDateCheckBox.Size = new System.Drawing.Size(73, 17);
            this.DueDateCheckBox.TabIndex = 26;
            this.DueDateCheckBox.Text = "Due date:";
            this.DueDateCheckBox.UseVisualStyleBackColor = true;
            this.DueDateCheckBox.CheckedChanged += new System.EventHandler(this.DueDateCheckBox_CheckedChanged);
            // 
            // StartDateDateTimePicker
            // 
            this.StartDateDateTimePicker.Enabled = false;
            this.StartDateDateTimePicker.Location = new System.Drawing.Point(238, 179);
            this.StartDateDateTimePicker.Name = "StartDateDateTimePicker";
            this.StartDateDateTimePicker.Size = new System.Drawing.Size(134, 20);
            this.StartDateDateTimePicker.TabIndex = 27;
            // 
            // DueDateDateTimePicker
            // 
            this.DueDateDateTimePicker.Enabled = false;
            this.DueDateDateTimePicker.Location = new System.Drawing.Point(405, 179);
            this.DueDateDateTimePicker.Name = "DueDateDateTimePicker";
            this.DueDateDateTimePicker.Size = new System.Drawing.Size(124, 20);
            this.DueDateDateTimePicker.TabIndex = 28;
            // 
            // EstimTimeTextBox
            // 
            this.EstimTimeTextBox.Location = new System.Drawing.Point(106, 160);
            this.EstimTimeTextBox.Name = "EstimTimeTextBox";
            this.EstimTimeTextBox.Size = new System.Drawing.Size(81, 20);
            this.EstimTimeTextBox.TabIndex = 29;
            this.EstimTimeTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.EstimTimeTextBox_KeyPress);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.ForeColor = System.Drawing.Color.Red;
            this.label10.Location = new System.Drawing.Point(58, 47);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(9, 12);
            this.label10.TabIndex = 31;
            this.label10.Text = "*";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label13.ForeColor = System.Drawing.Color.Red;
            this.label13.Location = new System.Drawing.Point(55, 14);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(9, 12);
            this.label13.TabIndex = 32;
            this.label13.Text = "*";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.Transparent;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label15.ForeColor = System.Drawing.Color.Red;
            this.label15.Location = new System.Drawing.Point(342, 121);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(9, 12);
            this.label15.TabIndex = 80;
            this.label15.Text = "*";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label14.ForeColor = System.Drawing.Color.Red;
            this.label14.Location = new System.Drawing.Point(169, 83);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(9, 12);
            this.label14.TabIndex = 79;
            this.label14.Text = "*";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.BackColor = System.Drawing.Color.Transparent;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label17.ForeColor = System.Drawing.Color.Red;
            this.label17.Location = new System.Drawing.Point(57, 123);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(9, 12);
            this.label17.TabIndex = 78;
            this.label17.Text = "*";
            // 
            // PrioritycomboBox
            // 
            this.PrioritycomboBox.FormattingEnabled = true;
            this.PrioritycomboBox.Items.AddRange(new object[] {
            "Low",
            "Normal",
            "High",
            "Urgent",
            "Immediate"});
            this.PrioritycomboBox.Location = new System.Drawing.Point(180, 80);
            this.PrioritycomboBox.Name = "PrioritycomboBox";
            this.PrioritycomboBox.Size = new System.Drawing.Size(121, 21);
            this.PrioritycomboBox.TabIndex = 77;
            // 
            // PercentDonecomboBox
            // 
            this.PercentDonecomboBox.FormattingEnabled = true;
            this.PercentDonecomboBox.Items.AddRange(new object[] {
            "0",
            "10",
            "20",
            "30",
            "40",
            "50",
            "60",
            "70",
            "80",
            "90",
            "100"});
            this.PercentDonecomboBox.Location = new System.Drawing.Point(59, 80);
            this.PercentDonecomboBox.Name = "PercentDonecomboBox";
            this.PercentDonecomboBox.Size = new System.Drawing.Size(55, 21);
            this.PercentDonecomboBox.TabIndex = 76;
            // 
            // StatusComboBox
            // 
            this.StatusComboBox.FormattingEnabled = true;
            this.StatusComboBox.Items.AddRange(new object[] {
            "New",
            "In progress",
            "Resolved",
            "Feadback",
            "Closed",
            "Rejected"});
            this.StatusComboBox.Location = new System.Drawing.Point(353, 120);
            this.StatusComboBox.Name = "StatusComboBox";
            this.StatusComboBox.Size = new System.Drawing.Size(176, 21);
            this.StatusComboBox.TabIndex = 75;
            // 
            // AssignedToComboBox
            // 
            this.AssignedToComboBox.FormattingEnabled = true;
            this.AssignedToComboBox.Location = new System.Drawing.Point(387, 80);
            this.AssignedToComboBox.Name = "AssignedToComboBox";
            this.AssignedToComboBox.Size = new System.Drawing.Size(142, 21);
            this.AssignedToComboBox.TabIndex = 74;
            this.AssignedToComboBox.Text = "Rudnikov Paul";
            // 
            // TrackerComboBox
            // 
            this.TrackerComboBox.FormattingEnabled = true;
            this.TrackerComboBox.Items.AddRange(new object[] {
            "Bug",
            "Feature",
            "Support"});
            this.TrackerComboBox.Location = new System.Drawing.Point(69, 120);
            this.TrackerComboBox.Name = "TrackerComboBox";
            this.TrackerComboBox.Size = new System.Drawing.Size(198, 21);
            this.TrackerComboBox.TabIndex = 73;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(131, 83);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 13);
            this.label7.TabIndex = 72;
            this.label7.Text = "Priority:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 83);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 13);
            this.label6.TabIndex = 71;
            this.label6.Text = "% done:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(305, 123);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 70;
            this.label5.Text = "Status:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(322, 83);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 13);
            this.label4.TabIndex = 69;
            this.label4.Text = "Assigned to:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 68;
            this.label3.Text = "Tracker:";
            // 
            // DescriptionRichTextBox
            // 
            this.DescriptionRichTextBox.Location = new System.Drawing.Point(16, 264);
            this.DescriptionRichTextBox.Name = "DescriptionRichTextBox";
            this.DescriptionRichTextBox.Size = new System.Drawing.Size(513, 119);
            this.DescriptionRichTextBox.TabIndex = 84;
            this.DescriptionRichTextBox.Text = "";
            // 
            // NotesRichTextBox
            // 
            this.NotesRichTextBox.Location = new System.Drawing.Point(236, 216);
            this.NotesRichTextBox.Name = "NotesRichTextBox";
            this.NotesRichTextBox.Size = new System.Drawing.Size(293, 36);
            this.NotesRichTextBox.TabIndex = 83;
            this.NotesRichTextBox.Text = "";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(167, 223);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(65, 13);
            this.label12.TabIndex = 82;
            this.label12.Text = "Local notes:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(15, 242);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(63, 13);
            this.label11.TabIndex = 81;
            this.label11.Text = "Description:";
            // 
            // New_issue_Form
            // 
            this.AcceptButton = this.CreateButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(539, 424);
            this.Controls.Add(this.DescriptionRichTextBox);
            this.Controls.Add(this.NotesRichTextBox);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.PrioritycomboBox);
            this.Controls.Add(this.PercentDonecomboBox);
            this.Controls.Add(this.StatusComboBox);
            this.Controls.Add(this.AssignedToComboBox);
            this.Controls.Add(this.TrackerComboBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.EstimTimeTextBox);
            this.Controls.Add(this.DueDateDateTimePicker);
            this.Controls.Add(this.StartDateDateTimePicker);
            this.Controls.Add(this.DueDateCheckBox);
            this.Controls.Add(this.StartDateCheckBox);
            this.Controls.Add(this.SubjectNameTextBox);
            this.Controls.Add(this.ProjectSelectComboBox);
            this.Controls.Add(this.CreateButton);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(555, 462);
            this.MinimumSize = new System.Drawing.Size(555, 462);
            this.Name = "New_issue_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Create a new issue";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label8;
        private new System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Button CreateButton;
        private System.Windows.Forms.ComboBox ProjectSelectComboBox;
        private System.Windows.Forms.TextBox SubjectNameTextBox;
        private System.Windows.Forms.CheckBox StartDateCheckBox;
        private System.Windows.Forms.CheckBox DueDateCheckBox;
        private System.Windows.Forms.DateTimePicker StartDateDateTimePicker;
        private System.Windows.Forms.DateTimePicker DueDateDateTimePicker;
        private System.Windows.Forms.TextBox EstimTimeTextBox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.ComboBox PrioritycomboBox;
        private System.Windows.Forms.ComboBox PercentDonecomboBox;
        private System.Windows.Forms.ComboBox StatusComboBox;
        private System.Windows.Forms.ComboBox AssignedToComboBox;
        private System.Windows.Forms.ComboBox TrackerComboBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox DescriptionRichTextBox;
        private System.Windows.Forms.RichTextBox NotesRichTextBox;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
    }
}