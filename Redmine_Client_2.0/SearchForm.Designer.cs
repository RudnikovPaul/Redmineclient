namespace Redmine_Client_2._0
{
    partial class SearchForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SearchForm));
            this.SearchTaskTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.AcceptButton = new System.Windows.Forms.Button();
            this.ErrorLabel = new System.Windows.Forms.Label();
            this.ResultForSearchLabel = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // SearchTaskTextBox
            // 
            this.SearchTaskTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SearchTaskTextBox.Location = new System.Drawing.Point(105, 33);
            this.SearchTaskTextBox.MaxLength = 11;
            this.SearchTaskTextBox.Name = "SearchTaskTextBox";
            this.SearchTaskTextBox.Size = new System.Drawing.Size(90, 22);
            this.SearchTaskTextBox.TabIndex = 10;
            this.SearchTaskTextBox.TextChanged += new System.EventHandler(this.TextChangedNow);
            this.SearchTaskTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SearchTaskTextBox_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(105, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Enter task number";
            // 
            // AcceptButton
            // 
            this.AcceptButton.Enabled = false;
            this.AcceptButton.Location = new System.Drawing.Point(108, 158);
            this.AcceptButton.Name = "AcceptButton";
            this.AcceptButton.Size = new System.Drawing.Size(75, 23);
            this.AcceptButton.TabIndex = 7;
            this.AcceptButton.Text = "Accept";
            this.AcceptButton.UseVisualStyleBackColor = true;
            this.AcceptButton.Click += new System.EventHandler(this.AcceptButton_Click);
            // 
            // ErrorLabel
            // 
            this.ErrorLabel.AutoSize = true;
            this.ErrorLabel.ForeColor = System.Drawing.Color.Red;
            this.ErrorLabel.Location = new System.Drawing.Point(112, 58);
            this.ErrorLabel.Name = "ErrorLabel";
            this.ErrorLabel.Size = new System.Drawing.Size(71, 13);
            this.ErrorLabel.TabIndex = 12;
            this.ErrorLabel.Text = "Only numbers";
            this.ErrorLabel.Visible = false;
            // 
            // ResultForSearchLabel
            // 
            this.ResultForSearchLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.ResultForSearchLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ResultForSearchLabel.Location = new System.Drawing.Point(20, 75);
            this.ResultForSearchLabel.Name = "ResultForSearchLabel";
            this.ResultForSearchLabel.Size = new System.Drawing.Size(244, 79);
            this.ResultForSearchLabel.TabIndex = 14;
            this.ResultForSearchLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(74, 75);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(142, 79);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Visible = false;
            // 
            // SearchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(288, 193);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.ResultForSearchLabel);
            this.Controls.Add(this.ErrorLabel);
            this.Controls.Add(this.SearchTaskTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AcceptButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SearchForm";
            this.Text = "Search for tasks";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.SearchForm_Closed);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox SearchTaskTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button AcceptButton;
        private System.Windows.Forms.Label ErrorLabel;
        private System.Windows.Forms.Label ResultForSearchLabel;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}