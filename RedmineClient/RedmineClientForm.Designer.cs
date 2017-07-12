namespace RedmineClient
{
    partial class Form1
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.Task_list_GridView = new System.Windows.Forms.DataGridView();
            this.Exit_button = new System.Windows.Forms.Button();
            this.About_button = new System.Windows.Forms.Button();
            this.Settings_button = new System.Windows.Forms.Button();
            this.Update_tasks_button = new System.Windows.Forms.Button();
            this.Commit_button = new System.Windows.Forms.Button();
            this.New_task_button = new System.Windows.Forms.Button();
            this.Timer_label = new System.Windows.Forms.Label();
            this.Start_timer_button = new System.Windows.Forms.Button();
            this.Tasks_label = new System.Windows.Forms.Label();
            this.Reset_timer_button = new System.Windows.Forms.Button();
            this.Name_label = new System.Windows.Forms.Label();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.CurrentIssueNameLabel = new System.Windows.Forms.Label();
            this.Search_others_button = new System.Windows.Forms.Button();
            this.CurrentStageTimer = new System.Windows.Forms.Timer(this.components);
            this.AutoSavingTimeTimer = new System.Windows.Forms.Timer(this.components);
            this.WorkingMode_label = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.kjhgkgToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.GridNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GridName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GridStart = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GridDue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GridDone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CommitStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.Task_list_GridView)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Task_list_GridView
            // 
            this.Task_list_GridView.AllowUserToAddRows = false;
            this.Task_list_GridView.AllowUserToDeleteRows = false;
            this.Task_list_GridView.AllowUserToResizeRows = false;
            this.Task_list_GridView.BackgroundColor = System.Drawing.Color.Gray;
            this.Task_list_GridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.GrayText;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Task_list_GridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.Task_list_GridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Task_list_GridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.GridNumber,
            this.GridName,
            this.GridStart,
            this.GridDue,
            this.GridDone,
            this.CommitStatus});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.DarkGray;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Task_list_GridView.DefaultCellStyle = dataGridViewCellStyle4;
            this.Task_list_GridView.GridColor = System.Drawing.Color.DimGray;
            this.Task_list_GridView.Location = new System.Drawing.Point(43, 189);
            this.Task_list_GridView.MultiSelect = false;
            this.Task_list_GridView.Name = "Task_list_GridView";
            this.Task_list_GridView.ReadOnly = true;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Task_list_GridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.Task_list_GridView.RowHeadersVisible = false;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Task_list_GridView.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.Task_list_GridView.RowTemplate.ReadOnly = true;
            this.Task_list_GridView.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Task_list_GridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Task_list_GridView.Size = new System.Drawing.Size(547, 291);
            this.Task_list_GridView.TabIndex = 0;
            this.Task_list_GridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.OpenEditWindow);
            this.Task_list_GridView.SelectionChanged += new System.EventHandler(this.Task_list_gridView_clicked);
            this.Task_list_GridView.Sorted += new System.EventHandler(this.Sorting_items_GridView_Clicked);
            // 
            // Exit_button
            // 
            this.Exit_button.BackColor = System.Drawing.Color.SkyBlue;
            this.Exit_button.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.Exit_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Exit_button.Location = new System.Drawing.Point(503, 514);
            this.Exit_button.Name = "Exit_button";
            this.Exit_button.Size = new System.Drawing.Size(87, 28);
            this.Exit_button.TabIndex = 1;
            this.Exit_button.Text = "Exit";
            this.Exit_button.UseVisualStyleBackColor = false;
            this.Exit_button.Click += new System.EventHandler(this.Exit_button_Click);
            // 
            // About_button
            // 
            this.About_button.BackColor = System.Drawing.Color.SkyBlue;
            this.About_button.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.About_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.About_button.Location = new System.Drawing.Point(49, 516);
            this.About_button.Name = "About_button";
            this.About_button.Size = new System.Drawing.Size(59, 24);
            this.About_button.TabIndex = 2;
            this.About_button.Text = "About";
            this.About_button.UseVisualStyleBackColor = false;
            this.About_button.Click += new System.EventHandler(this.About_button_Click);
            // 
            // Settings_button
            // 
            this.Settings_button.BackColor = System.Drawing.Color.SkyBlue;
            this.Settings_button.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.Settings_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Settings_button.Location = new System.Drawing.Point(404, 514);
            this.Settings_button.Name = "Settings_button";
            this.Settings_button.Size = new System.Drawing.Size(87, 28);
            this.Settings_button.TabIndex = 3;
            this.Settings_button.Text = "Settings";
            this.Settings_button.UseVisualStyleBackColor = false;
            this.Settings_button.Click += new System.EventHandler(this.Settings_button_Click);
            // 
            // Update_tasks_button
            // 
            this.Update_tasks_button.BackColor = System.Drawing.Color.SkyBlue;
            this.Update_tasks_button.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.Update_tasks_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Update_tasks_button.Location = new System.Drawing.Point(60, 64);
            this.Update_tasks_button.Name = "Update_tasks_button";
            this.Update_tasks_button.Size = new System.Drawing.Size(71, 28);
            this.Update_tasks_button.TabIndex = 4;
            this.Update_tasks_button.Text = "update";
            this.Update_tasks_button.UseVisualStyleBackColor = false;
            this.Update_tasks_button.Visible = false;
            this.Update_tasks_button.Click += new System.EventHandler(this.Update_tasks_button_Click);
            // 
            // Commit_button
            // 
            this.Commit_button.BackColor = System.Drawing.Color.SkyBlue;
            this.Commit_button.Enabled = false;
            this.Commit_button.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.Commit_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Commit_button.Location = new System.Drawing.Point(509, 63);
            this.Commit_button.Name = "Commit_button";
            this.Commit_button.Size = new System.Drawing.Size(71, 28);
            this.Commit_button.TabIndex = 5;
            this.Commit_button.Text = "Commit";
            this.Commit_button.UseVisualStyleBackColor = false;
            this.Commit_button.Click += new System.EventHandler(this.Commit_button_Click);
            // 
            // New_task_button
            // 
            this.New_task_button.BackColor = System.Drawing.Color.SkyBlue;
            this.New_task_button.Enabled = false;
            this.New_task_button.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.New_task_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.New_task_button.Location = new System.Drawing.Point(103, 149);
            this.New_task_button.Name = "New_task_button";
            this.New_task_button.Size = new System.Drawing.Size(65, 30);
            this.New_task_button.TabIndex = 6;
            this.New_task_button.Text = "New";
            this.New_task_button.UseVisualStyleBackColor = false;
            this.New_task_button.Click += new System.EventHandler(this.New_issue_button_Click);
            // 
            // Timer_label
            // 
            this.Timer_label.AutoSize = true;
            this.Timer_label.BackColor = System.Drawing.Color.Black;
            this.Timer_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Timer_label.ForeColor = System.Drawing.Color.White;
            this.Timer_label.Location = new System.Drawing.Point(279, 65);
            this.Timer_label.Name = "Timer_label";
            this.Timer_label.Size = new System.Drawing.Size(88, 24);
            this.Timer_label.TabIndex = 8;
            this.Timer_label.Text = "00:00:00";
            // 
            // Start_timer_button
            // 
            this.Start_timer_button.BackColor = System.Drawing.Color.SkyBlue;
            this.Start_timer_button.Enabled = false;
            this.Start_timer_button.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.Start_timer_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Start_timer_button.Location = new System.Drawing.Point(161, 63);
            this.Start_timer_button.Name = "Start_timer_button";
            this.Start_timer_button.Size = new System.Drawing.Size(96, 28);
            this.Start_timer_button.TabIndex = 9;
            this.Start_timer_button.Text = "Start";
            this.Start_timer_button.UseVisualStyleBackColor = false;
            this.Start_timer_button.Click += new System.EventHandler(this.Start_timer_button_Click);
            // 
            // Tasks_label
            // 
            this.Tasks_label.AutoSize = true;
            this.Tasks_label.BackColor = System.Drawing.Color.Transparent;
            this.Tasks_label.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Tasks_label.Location = new System.Drawing.Point(204, 149);
            this.Tasks_label.Name = "Tasks_label";
            this.Tasks_label.Size = new System.Drawing.Size(220, 27);
            this.Tasks_label.TabIndex = 10;
            this.Tasks_label.Text = "Issues assinged to you";
            // 
            // Reset_timer_button
            // 
            this.Reset_timer_button.BackColor = System.Drawing.Color.SkyBlue;
            this.Reset_timer_button.Enabled = false;
            this.Reset_timer_button.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.Reset_timer_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Reset_timer_button.Location = new System.Drawing.Point(389, 63);
            this.Reset_timer_button.Name = "Reset_timer_button";
            this.Reset_timer_button.Size = new System.Drawing.Size(96, 28);
            this.Reset_timer_button.TabIndex = 11;
            this.Reset_timer_button.Text = "Reset";
            this.Reset_timer_button.UseVisualStyleBackColor = false;
            this.Reset_timer_button.Click += new System.EventHandler(this.Reset_timer_button_Click);
            // 
            // Name_label
            // 
            this.Name_label.AutoSize = true;
            this.Name_label.BackColor = System.Drawing.Color.DarkGray;
            this.Name_label.Font = new System.Drawing.Font("Cooper Black", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name_label.ForeColor = System.Drawing.Color.Black;
            this.Name_label.Location = new System.Drawing.Point(222, 9);
            this.Name_label.Name = "Name_label";
            this.Name_label.Size = new System.Drawing.Size(202, 27);
            this.Name_label.TabIndex = 12;
            this.Name_label.Text = "Redmine Client";
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.NotifyIcon1_MouseClick);
            // 
            // CurrentIssueNameLabel
            // 
            this.CurrentIssueNameLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.CurrentIssueNameLabel.AutoSize = true;
            this.CurrentIssueNameLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.CurrentIssueNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CurrentIssueNameLabel.ForeColor = System.Drawing.Color.Black;
            this.CurrentIssueNameLabel.Location = new System.Drawing.Point(209, 104);
            this.CurrentIssueNameLabel.Name = "CurrentIssueNameLabel";
            this.CurrentIssueNameLabel.Size = new System.Drawing.Size(0, 18);
            this.CurrentIssueNameLabel.TabIndex = 16;
            this.CurrentIssueNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Search_others_button
            // 
            this.Search_others_button.BackColor = System.Drawing.Color.SkyBlue;
            this.Search_others_button.Enabled = false;
            this.Search_others_button.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.Search_others_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Search_others_button.Location = new System.Drawing.Point(452, 156);
            this.Search_others_button.Name = "Search_others_button";
            this.Search_others_button.Size = new System.Drawing.Size(80, 19);
            this.Search_others_button.TabIndex = 17;
            this.Search_others_button.Text = "Search others";
            this.Search_others_button.UseVisualStyleBackColor = false;
            this.Search_others_button.Click += new System.EventHandler(this.Search_others_button_Click);
            // 
            // CurrentStageTimer
            // 
            this.CurrentStageTimer.Tick += new System.EventHandler(this.Current_stage_timer_tick);
            // 
            // AutoSavingTimeTimer
            // 
            this.AutoSavingTimeTimer.Enabled = true;
            this.AutoSavingTimeTimer.Interval = 2000;
            this.AutoSavingTimeTimer.Tick += new System.EventHandler(this.AutoSavingTimeTimerTick);
            // 
            // WorkingMode_label
            // 
            this.WorkingMode_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.WorkingMode_label.ForeColor = System.Drawing.Color.Red;
            this.WorkingMode_label.Location = new System.Drawing.Point(462, 17);
            this.WorkingMode_label.Name = "WorkingMode_label";
            this.WorkingMode_label.Size = new System.Drawing.Size(144, 29);
            this.WorkingMode_label.TabIndex = 18;
            this.WorkingMode_label.Text = "Offline working mode Server is not accessible";
            this.WorkingMode_label.Visible = false;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem2,
            this.kjhgkgToolStripMenuItem,
            this.settingsToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(117, 70);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Image = global::RedmineClient.Properties.Resources.Control_16;
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(116, 22);
            this.toolStripMenuItem2.Text = "Settings";
            this.toolStripMenuItem2.Click += new System.EventHandler(this.Settings_button_Click);
            // 
            // kjhgkgToolStripMenuItem
            // 
            this.kjhgkgToolStripMenuItem.Image = global::RedmineClient.Properties.Resources.Sign_Info_Icon_16;
            this.kjhgkgToolStripMenuItem.Name = "kjhgkgToolStripMenuItem";
            this.kjhgkgToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.kjhgkgToolStripMenuItem.Text = "About";
            this.kjhgkgToolStripMenuItem.Click += new System.EventHandler(this.About_button_Click);
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.Image = global::RedmineClient.Properties.Resources.delete_icon_16x16;
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.settingsToolStripMenuItem.Text = "Exit";
            this.settingsToolStripMenuItem.Click += new System.EventHandler(this.Exit_button_Click);
            // 
            // GridNumber
            // 
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.GridNumber.DefaultCellStyle = dataGridViewCellStyle2;
            this.GridNumber.HeaderText = "#";
            this.GridNumber.MaxInputLength = 10;
            this.GridNumber.MinimumWidth = 57;
            this.GridNumber.Name = "GridNumber";
            this.GridNumber.ReadOnly = true;
            this.GridNumber.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.GridNumber.Width = 57;
            // 
            // GridName
            // 
            this.GridName.HeaderText = "Name";
            this.GridName.MinimumWidth = 230;
            this.GridName.Name = "GridName";
            this.GridName.ReadOnly = true;
            this.GridName.Width = 230;
            // 
            // GridStart
            // 
            this.GridStart.HeaderText = "Start";
            this.GridStart.MinimumWidth = 75;
            this.GridStart.Name = "GridStart";
            this.GridStart.ReadOnly = true;
            this.GridStart.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.GridStart.Width = 75;
            // 
            // GridDue
            // 
            this.GridDue.HeaderText = "Due";
            this.GridDue.MinimumWidth = 75;
            this.GridDue.Name = "GridDue";
            this.GridDue.ReadOnly = true;
            this.GridDue.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.GridDue.Width = 75;
            // 
            // GridDone
            // 
            this.GridDone.HeaderText = "done";
            this.GridDone.Name = "GridDone";
            this.GridDone.ReadOnly = true;
            this.GridDone.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.GridDone.ToolTipText = "% of issue done";
            this.GridDone.Width = 60;
            // 
            // CommitStatus
            // 
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CommitStatus.DefaultCellStyle = dataGridViewCellStyle3;
            this.CommitStatus.HeaderText = "com";
            this.CommitStatus.MinimumWidth = 20;
            this.CommitStatus.Name = "CommitStatus";
            this.CommitStatus.ReadOnly = true;
            this.CommitStatus.ToolTipText = "does the issue need to be committed to server";
            this.CommitStatus.Width = 30;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::RedmineClient.Properties.Resources.silver;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(631, 554);
            this.Controls.Add(this.WorkingMode_label);
            this.Controls.Add(this.Search_others_button);
            this.Controls.Add(this.CurrentIssueNameLabel);
            this.Controls.Add(this.Name_label);
            this.Controls.Add(this.Reset_timer_button);
            this.Controls.Add(this.Tasks_label);
            this.Controls.Add(this.Start_timer_button);
            this.Controls.Add(this.Timer_label);
            this.Controls.Add(this.New_task_button);
            this.Controls.Add(this.Commit_button);
            this.Controls.Add(this.Update_tasks_button);
            this.Controls.Add(this.Settings_button);
            this.Controls.Add(this.About_button);
            this.Controls.Add(this.Exit_button);
            this.Controls.Add(this.Task_list_GridView);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(647, 592);
            this.MinimumSize = new System.Drawing.Size(647, 592);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Redmine Client";
            this.Resize += new System.EventHandler(this.RedmineClientFormResize);
            ((System.ComponentModel.ISupportInitialize)(this.Task_list_GridView)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView Task_list_GridView;
        private System.Windows.Forms.Button Exit_button;
        private System.Windows.Forms.Button About_button;
        private System.Windows.Forms.Button Settings_button;
        private System.Windows.Forms.Button Update_tasks_button;
        private System.Windows.Forms.Button Commit_button;
        private System.Windows.Forms.Button New_task_button;
        private System.Windows.Forms.Label Timer_label;
        private System.Windows.Forms.Button Start_timer_button;
        private System.Windows.Forms.Label Tasks_label;
        private System.Windows.Forms.Button Reset_timer_button;
        private System.Windows.Forms.Label Name_label;
        public System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.Label CurrentIssueNameLabel;
        private System.Windows.Forms.Button Search_others_button;
        private System.Windows.Forms.Timer CurrentStageTimer;
        private System.Windows.Forms.Timer AutoSavingTimeTimer;
        private System.Windows.Forms.Label WorkingMode_label;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem kjhgkgToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn GridNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn GridName;
        private System.Windows.Forms.DataGridViewTextBoxColumn GridStart;
        private System.Windows.Forms.DataGridViewTextBoxColumn GridDue;
        private System.Windows.Forms.DataGridViewTextBoxColumn GridDone;
        private System.Windows.Forms.DataGridViewTextBoxColumn CommitStatus;
    }
}

