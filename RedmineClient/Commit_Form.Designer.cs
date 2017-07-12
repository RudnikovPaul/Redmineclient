namespace RedmineClient
{
    partial class Commit_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Commit_Form));
            this.CommitButton = new System.Windows.Forms.Button();
            this.CancelButton = new System.Windows.Forms.Button();
            this.CommentRichTextBox = new System.Windows.Forms.RichTextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.ComboBoxActivity = new System.Windows.Forms.ComboBox();
            this.labelCommitActivity = new System.Windows.Forms.Label();
            this.labelTimeContent = new System.Windows.Forms.Label();
            this.labelCommitTime = new System.Windows.Forms.Label();
            this.labelIssueContent = new System.Windows.Forms.Label();
            this.labelCommitIssue = new System.Windows.Forms.Label();
            this.labelProjectContent = new System.Windows.Forms.Label();
            this.labelCommitProject = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // CommitButton
            // 
            this.CommitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CommitButton.Location = new System.Drawing.Point(231, 183);
            this.CommitButton.Name = "CommitButton";
            this.CommitButton.Size = new System.Drawing.Size(75, 27);
            this.CommitButton.TabIndex = 42;
            this.CommitButton.Text = "Commit";
            this.CommitButton.UseVisualStyleBackColor = true;
            this.CommitButton.Click += new System.EventHandler(this.CommitButton_Click);
            // 
            // CancelButton
            // 
            this.CancelButton.Location = new System.Drawing.Point(329, 189);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(58, 21);
            this.CancelButton.TabIndex = 41;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // CommentRichTextBox
            // 
            this.CommentRichTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CommentRichTextBox.Location = new System.Drawing.Point(10, 120);
            this.CommentRichTextBox.MaxLength = 10000;
            this.CommentRichTextBox.Name = "CommentRichTextBox";
            this.CommentRichTextBox.Size = new System.Drawing.Size(392, 54);
            this.CommentRichTextBox.TabIndex = 58;
            this.CommentRichTextBox.Text = "";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label13.Location = new System.Drawing.Point(14, 103);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(54, 13);
            this.label13.TabIndex = 61;
            this.label13.Text = "Comment:";
            // 
            // ComboBoxActivity
            // 
            this.ComboBoxActivity.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBoxActivity.FormattingEnabled = true;
            this.ComboBoxActivity.Location = new System.Drawing.Point(87, 50);
            this.ComboBoxActivity.Margin = new System.Windows.Forms.Padding(2);
            this.ComboBoxActivity.Name = "ComboBoxActivity";
            this.ComboBoxActivity.Size = new System.Drawing.Size(108, 21);
            this.ComboBoxActivity.TabIndex = 68;
            // 
            // labelCommitActivity
            // 
            this.labelCommitActivity.AutoSize = true;
            this.labelCommitActivity.Location = new System.Drawing.Point(13, 53);
            this.labelCommitActivity.Name = "labelCommitActivity";
            this.labelCommitActivity.Size = new System.Drawing.Size(44, 13);
            this.labelCommitActivity.TabIndex = 67;
            this.labelCommitActivity.Text = "Activity:";
            // 
            // labelTimeContent
            // 
            this.labelTimeContent.AutoSize = true;
            this.labelTimeContent.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTimeContent.Location = new System.Drawing.Point(84, 76);
            this.labelTimeContent.Name = "labelTimeContent";
            this.labelTimeContent.Size = new System.Drawing.Size(34, 13);
            this.labelTimeContent.TabIndex = 70;
            this.labelTimeContent.Text = "Time";
            // 
            // labelCommitTime
            // 
            this.labelCommitTime.AutoSize = true;
            this.labelCommitTime.Location = new System.Drawing.Point(13, 76);
            this.labelCommitTime.Name = "labelCommitTime";
            this.labelCommitTime.Size = new System.Drawing.Size(50, 13);
            this.labelCommitTime.TabIndex = 69;
            this.labelCommitTime.Text = "Time (H):";
            // 
            // labelIssueContent
            // 
            this.labelIssueContent.AutoSize = true;
            this.labelIssueContent.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelIssueContent.Location = new System.Drawing.Point(84, 32);
            this.labelIssueContent.Name = "labelIssueContent";
            this.labelIssueContent.Size = new System.Drawing.Size(69, 13);
            this.labelIssueContent.TabIndex = 66;
            this.labelIssueContent.Text = "IssueName";
            // 
            // labelCommitIssue
            // 
            this.labelCommitIssue.AutoSize = true;
            this.labelCommitIssue.Location = new System.Drawing.Point(13, 32);
            this.labelCommitIssue.Name = "labelCommitIssue";
            this.labelCommitIssue.Size = new System.Drawing.Size(35, 13);
            this.labelCommitIssue.TabIndex = 65;
            this.labelCommitIssue.Text = "Issue:";
            // 
            // labelProjectContent
            // 
            this.labelProjectContent.AutoSize = true;
            this.labelProjectContent.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelProjectContent.Location = new System.Drawing.Point(84, 11);
            this.labelProjectContent.Name = "labelProjectContent";
            this.labelProjectContent.Size = new System.Drawing.Size(79, 13);
            this.labelProjectContent.TabIndex = 64;
            this.labelProjectContent.Text = "ProjectName";
            // 
            // labelCommitProject
            // 
            this.labelCommitProject.AutoSize = true;
            this.labelCommitProject.Location = new System.Drawing.Point(13, 11);
            this.labelCommitProject.Name = "labelCommitProject";
            this.labelCommitProject.Size = new System.Drawing.Size(43, 13);
            this.labelCommitProject.TabIndex = 63;
            this.labelCommitProject.Text = "Project:";
            // 
            // Commit_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(414, 220);
            this.Controls.Add(this.ComboBoxActivity);
            this.Controls.Add(this.labelCommitActivity);
            this.Controls.Add(this.labelTimeContent);
            this.Controls.Add(this.labelCommitTime);
            this.Controls.Add(this.labelIssueContent);
            this.Controls.Add(this.labelCommitIssue);
            this.Controls.Add(this.labelProjectContent);
            this.Controls.Add(this.labelCommitProject);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.CommentRichTextBox);
            this.Controls.Add(this.CommitButton);
            this.Controls.Add(this.CancelButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(565, 526);
            this.Name = "Commit_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Commit";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button CommitButton;
        private new System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.RichTextBox CommentRichTextBox;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox ComboBoxActivity;
        private System.Windows.Forms.Label labelCommitActivity;
        private System.Windows.Forms.Label labelTimeContent;
        private System.Windows.Forms.Label labelCommitTime;
        private System.Windows.Forms.Label labelIssueContent;
        private System.Windows.Forms.Label labelCommitIssue;
        private System.Windows.Forms.Label labelProjectContent;
        private System.Windows.Forms.Label labelCommitProject;
    }
}