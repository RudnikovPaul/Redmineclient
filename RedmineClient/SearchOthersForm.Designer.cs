namespace RedmineClient
{
    partial class SearchOthersForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SearchOthersForm));
            this.AcceptButton = new System.Windows.Forms.Button();
            this.CancelButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SearchTaskTextBox = new System.Windows.Forms.TextBox();
            this.ErrorLabel = new System.Windows.Forms.Label();
            this.SearchButton = new System.Windows.Forms.Button();
            this.FindResultLabel = new System.Windows.Forms.Label();
            this.ResultForSearchLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // AcceptButton
            // 
            this.AcceptButton.Location = new System.Drawing.Point(103, 181);
            this.AcceptButton.Name = "AcceptButton";
            this.AcceptButton.Size = new System.Drawing.Size(75, 23);
            this.AcceptButton.TabIndex = 0;
            this.AcceptButton.Text = "Accept";
            this.AcceptButton.UseVisualStyleBackColor = true;
            this.AcceptButton.Click += new System.EventHandler(this.SubmitButton_Click);
            // 
            // CancelButton
            // 
            this.CancelButton.Location = new System.Drawing.Point(207, 201);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(51, 20);
            this.CancelButton.TabIndex = 1;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(94, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Enter task number";
            // 
            // SearchTaskTextBox
            // 
            this.SearchTaskTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SearchTaskTextBox.Location = new System.Drawing.Point(97, 32);
            this.SearchTaskTextBox.MaxLength = 11;
            this.SearchTaskTextBox.Name = "SearchTaskTextBox";
            this.SearchTaskTextBox.Size = new System.Drawing.Size(87, 22);
            this.SearchTaskTextBox.TabIndex = 3;
            this.SearchTaskTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SearchTaskTextBox_KeyPress);
            // 
            // ErrorLabel
            // 
            this.ErrorLabel.AutoSize = true;
            this.ErrorLabel.ForeColor = System.Drawing.Color.Red;
            this.ErrorLabel.Location = new System.Drawing.Point(106, 59);
            this.ErrorLabel.Name = "ErrorLabel";
            this.ErrorLabel.Size = new System.Drawing.Size(71, 13);
            this.ErrorLabel.TabIndex = 5;
            this.ErrorLabel.Text = "Only numbers";
            this.ErrorLabel.Visible = false;
            // 
            // SearchButton
            // 
            this.SearchButton.Location = new System.Drawing.Point(103, 147);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(75, 23);
            this.SearchButton.TabIndex = 6;
            this.SearchButton.Text = "Search";
            this.SearchButton.UseVisualStyleBackColor = true;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // FindResultLabel
            // 
            this.FindResultLabel.AutoSize = true;
            this.FindResultLabel.Location = new System.Drawing.Point(111, 63);
            this.FindResultLabel.Name = "FindResultLabel";
            this.FindResultLabel.Size = new System.Drawing.Size(57, 13);
            this.FindResultLabel.TabIndex = 7;
            this.FindResultLabel.Text = "task found";
            this.FindResultLabel.Visible = false;
            // 
            // ResultForSearchLabel
            // 
            this.ResultForSearchLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.ResultForSearchLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ResultForSearchLabel.Location = new System.Drawing.Point(15, 81);
            this.ResultForSearchLabel.Name = "ResultForSearchLabel";
            this.ResultForSearchLabel.Size = new System.Drawing.Size(244, 59);
            this.ResultForSearchLabel.TabIndex = 8;
            this.ResultForSearchLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SearchOthersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(265, 231);
            this.Controls.Add(this.ResultForSearchLabel);
            this.Controls.Add(this.FindResultLabel);
            this.Controls.Add(this.SearchButton);
            this.Controls.Add(this.ErrorLabel);
            this.Controls.Add(this.SearchTaskTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.AcceptButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(281, 269);
            this.MinimumSize = new System.Drawing.Size(281, 269);
            this.Name = "SearchOthersForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Search for other tasks";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private new System.Windows.Forms.Button AcceptButton;
        private new System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox SearchTaskTextBox;
        private System.Windows.Forms.Label ErrorLabel;
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.Label FindResultLabel;
        private System.Windows.Forms.Label ResultForSearchLabel;
    }
}