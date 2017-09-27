namespace Redmine_Client_2._0
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle22 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle23 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle24 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle21 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.Issue_list_GridView = new System.Windows.Forms.DataGridView();
            this.GridNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GridName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GridStart = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GridDue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GridDone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ListContextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.Settings_button = new System.Windows.Forms.Button();
            this.Start_timer_button = new System.Windows.Forms.Button();
            this.Timer_label = new System.Windows.Forms.Label();
            this.Search_others_button = new System.Windows.Forms.Button();
            this.New_task_button = new System.Windows.Forms.Button();
            this.Commit_button = new System.Windows.Forms.Button();
            this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CurrentIssueTimer = new System.Windows.Forms.Timer(this.components);
            this.AutoSaveTimer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.Issue_list_GridView)).BeginInit();
            this.ListContextMenuStrip.SuspendLayout();
            this.contextMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // Issue_list_GridView
            // 
            this.Issue_list_GridView.AllowUserToAddRows = false;
            this.Issue_list_GridView.AllowUserToDeleteRows = false;
            this.Issue_list_GridView.AllowUserToResizeRows = false;
            this.Issue_list_GridView.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.Issue_list_GridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle19.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle19.BackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle19.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle19.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle19.SelectionBackColor = System.Drawing.SystemColors.GrayText;
            dataGridViewCellStyle19.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle19.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Issue_list_GridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle19;
            this.Issue_list_GridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Issue_list_GridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.GridNumber,
            this.GridName,
            this.GridStart,
            this.GridDue,
            this.GridDone});
            dataGridViewCellStyle22.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle22.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle22.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle22.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle22.SelectionBackColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle22.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle22.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Issue_list_GridView.DefaultCellStyle = dataGridViewCellStyle22;
            this.Issue_list_GridView.GridColor = System.Drawing.Color.WhiteSmoke;
            this.Issue_list_GridView.Location = new System.Drawing.Point(8, 41);
            this.Issue_list_GridView.MultiSelect = false;
            this.Issue_list_GridView.Name = "Issue_list_GridView";
            this.Issue_list_GridView.ReadOnly = true;
            dataGridViewCellStyle23.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle23.BackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle23.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle23.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle23.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle23.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle23.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Issue_list_GridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle23;
            this.Issue_list_GridView.RowHeadersVisible = false;
            dataGridViewCellStyle24.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Issue_list_GridView.RowsDefaultCellStyle = dataGridViewCellStyle24;
            this.Issue_list_GridView.RowTemplate.ReadOnly = true;
            this.Issue_list_GridView.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Issue_list_GridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Issue_list_GridView.Size = new System.Drawing.Size(547, 258);
            this.Issue_list_GridView.TabIndex = 1;
            this.Issue_list_GridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Issue_list_double_click);
            this.Issue_list_GridView.SelectionChanged += new System.EventHandler(this.Issue_list_selection_changed);
            this.Issue_list_GridView.Sorted += new System.EventHandler(this.Sorting_items_GridView_Clicked);
            // 
            // GridNumber
            // 
            dataGridViewCellStyle20.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.GridNumber.DefaultCellStyle = dataGridViewCellStyle20;
            this.GridNumber.Frozen = true;
            this.GridNumber.HeaderText = "#";
            this.GridNumber.MaxInputLength = 10;
            this.GridNumber.MinimumWidth = 45;
            this.GridNumber.Name = "GridNumber";
            this.GridNumber.ReadOnly = true;
            this.GridNumber.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.GridNumber.Width = 45;
            // 
            // GridName
            // 
            this.GridName.Frozen = true;
            this.GridName.HeaderText = "Name";
            this.GridName.MinimumWidth = 305;
            this.GridName.Name = "GridName";
            this.GridName.ReadOnly = true;
            this.GridName.Width = 317;
            // 
            // GridStart
            // 
            this.GridStart.Frozen = true;
            this.GridStart.HeaderText = "Start";
            this.GridStart.MinimumWidth = 60;
            this.GridStart.Name = "GridStart";
            this.GridStart.ReadOnly = true;
            this.GridStart.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.GridStart.Width = 60;
            // 
            // GridDue
            // 
            this.GridDue.Frozen = true;
            this.GridDue.HeaderText = "Due";
            this.GridDue.MinimumWidth = 60;
            this.GridDue.Name = "GridDue";
            this.GridDue.ReadOnly = true;
            this.GridDue.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.GridDue.Width = 60;
            // 
            // GridDone
            // 
            dataGridViewCellStyle21.NullValue = null;
            this.GridDone.DefaultCellStyle = dataGridViewCellStyle21;
            this.GridDone.Frozen = true;
            this.GridDone.HeaderText = "done";
            this.GridDone.MaxInputLength = 10;
            this.GridDone.Name = "GridDone";
            this.GridDone.ReadOnly = true;
            this.GridDone.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.GridDone.ToolTipText = "% of issue done";
            this.GridDone.Width = 45;
            // 
            // ListContextMenuStrip
            // 
            this.ListContextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editToolStripMenuItem,
            this.deleteToolStripMenuItem,
            this.deleteToolStripMenuItem1});
            this.ListContextMenuStrip.Name = "ListContextMenuStrip";
            this.ListContextMenuStrip.Size = new System.Drawing.Size(108, 70);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.deleteToolStripMenuItem.Text = "Hide";
            // 
            // deleteToolStripMenuItem1
            // 
            this.deleteToolStripMenuItem1.Name = "deleteToolStripMenuItem1";
            this.deleteToolStripMenuItem1.Size = new System.Drawing.Size(107, 22);
            this.deleteToolStripMenuItem1.Text = "Delete";
            // 
            // Settings_button
            // 
            this.Settings_button.BackColor = System.Drawing.Color.SkyBlue;
            this.Settings_button.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.Settings_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Settings_button.Location = new System.Drawing.Point(486, 7);
            this.Settings_button.Name = "Settings_button";
            this.Settings_button.Size = new System.Drawing.Size(70, 28);
            this.Settings_button.TabIndex = 4;
            this.Settings_button.Text = "Settings";
            this.Settings_button.UseVisualStyleBackColor = false;
            this.Settings_button.Click += new System.EventHandler(this.Settings_button_Click);
            // 
            // Start_timer_button
            // 
            this.Start_timer_button.BackColor = System.Drawing.Color.SkyBlue;
            this.Start_timer_button.Enabled = false;
            this.Start_timer_button.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.Start_timer_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Start_timer_button.Location = new System.Drawing.Point(194, 7);
            this.Start_timer_button.Name = "Start_timer_button";
            this.Start_timer_button.Size = new System.Drawing.Size(70, 28);
            this.Start_timer_button.TabIndex = 10;
            this.Start_timer_button.Text = "Start";
            this.Start_timer_button.UseVisualStyleBackColor = false;
            this.Start_timer_button.Click += new System.EventHandler(this.Start_timer_button_Click);
            // 
            // Timer_label
            // 
            this.Timer_label.AutoSize = true;
            this.Timer_label.BackColor = System.Drawing.Color.Black;
            this.Timer_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Timer_label.ForeColor = System.Drawing.Color.White;
            this.Timer_label.Location = new System.Drawing.Point(287, 9);
            this.Timer_label.Name = "Timer_label";
            this.Timer_label.Size = new System.Drawing.Size(88, 24);
            this.Timer_label.TabIndex = 11;
            this.Timer_label.Text = "00:00:00";
            // 
            // Search_others_button
            // 
            this.Search_others_button.BackColor = System.Drawing.Color.SkyBlue;
            this.Search_others_button.Enabled = false;
            this.Search_others_button.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.Search_others_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.Search_others_button.Location = new System.Drawing.Point(8, 7);
            this.Search_others_button.Name = "Search_others_button";
            this.Search_others_button.Size = new System.Drawing.Size(70, 28);
            this.Search_others_button.TabIndex = 21;
            this.Search_others_button.Text = "Search";
            this.Search_others_button.UseVisualStyleBackColor = false;
            this.Search_others_button.Click += new System.EventHandler(this.Search_others_button_Click);
            // 
            // New_task_button
            // 
            this.New_task_button.BackColor = System.Drawing.Color.SkyBlue;
            this.New_task_button.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.New_task_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.New_task_button.Location = new System.Drawing.Point(102, 7);
            this.New_task_button.Name = "New_task_button";
            this.New_task_button.Size = new System.Drawing.Size(70, 28);
            this.New_task_button.TabIndex = 19;
            this.New_task_button.Text = "New";
            this.New_task_button.UseVisualStyleBackColor = false;
            this.New_task_button.Click += new System.EventHandler(this.New_issue_button_Click);
            // 
            // Commit_button
            // 
            this.Commit_button.BackColor = System.Drawing.Color.SkyBlue;
            this.Commit_button.Enabled = false;
            this.Commit_button.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.Commit_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Commit_button.Location = new System.Drawing.Point(396, 7);
            this.Commit_button.Name = "Commit_button";
            this.Commit_button.Size = new System.Drawing.Size(70, 28);
            this.Commit_button.TabIndex = 18;
            this.Commit_button.Text = "Commit";
            this.Commit_button.UseVisualStyleBackColor = false;
            this.Commit_button.Click += new System.EventHandler(this.Commit_button_Click);
            // 
            // notifyIcon
            // 
            this.notifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon.Icon")));
            this.notifyIcon.Visible = true;
            this.notifyIcon.MouseUp += new System.Windows.Forms.MouseEventHandler(this.NotifyIcon_MouseClick);
            // 
            // contextMenuStrip
            // 
            this.contextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.settingsToolStripMenuItem,
            this.aboutToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.contextMenuStrip.Name = "contextMenuStrip";
            this.contextMenuStrip.Size = new System.Drawing.Size(117, 70);
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("settingsToolStripMenuItem.Image")));
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.settingsToolStripMenuItem.Text = "Settings";
            this.settingsToolStripMenuItem.Click += new System.EventHandler(this.Settings_button_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("aboutToolStripMenuItem.Image")));
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.AboutForm_click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("exitToolStripMenuItem.Image")));
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.ExitAppClick);
            // 
            // CurrentIssueTimer
            // 
            this.CurrentIssueTimer.Tick += new System.EventHandler(this.Current_stage_timer_tick);
            // 
            // AutoSaveTimer
            // 
            this.AutoSaveTimer.Enabled = true;
            this.AutoSaveTimer.Interval = 2000;
            this.AutoSaveTimer.Tick += new System.EventHandler(this.AutoSaveTimerTick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(562, 307);
            this.Controls.Add(this.Search_others_button);
            this.Controls.Add(this.New_task_button);
            this.Controls.Add(this.Commit_button);
            this.Controls.Add(this.Timer_label);
            this.Controls.Add(this.Start_timer_button);
            this.Controls.Add(this.Settings_button);
            this.Controls.Add(this.Issue_list_GridView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Redmine Client";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_Closed);
            this.Resize += new System.EventHandler(this.MainFormResize);
            ((System.ComponentModel.ISupportInitialize)(this.Issue_list_GridView)).EndInit();
            this.ListContextMenuStrip.ResumeLayout(false);
            this.contextMenuStrip.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView Issue_list_GridView;
        private System.Windows.Forms.Button Settings_button;
        private System.Windows.Forms.Button Start_timer_button;
        private System.Windows.Forms.Label Timer_label;
        private System.Windows.Forms.Button Search_others_button;
        private System.Windows.Forms.Button New_task_button;
        private System.Windows.Forms.Button Commit_button;
        private System.Windows.Forms.NotifyIcon notifyIcon;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip;
        private System.Windows.Forms.Timer CurrentIssueTimer;
        private System.Windows.Forms.Timer AutoSaveTimer;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn GridNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn GridName;
        private System.Windows.Forms.DataGridViewTextBoxColumn GridStart;
        private System.Windows.Forms.DataGridViewTextBoxColumn GridDue;
        private System.Windows.Forms.DataGridViewTextBoxColumn GridDone;
        private System.Windows.Forms.ContextMenuStrip ListContextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem1;
    }
}

