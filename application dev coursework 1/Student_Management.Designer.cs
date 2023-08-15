namespace application_dev_coursework_1
{
    partial class ManagingGroupCoursework
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Exit = new System.Windows.Forms.Button();
            this.Import = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.studentsDataGridView1 = new System.Windows.Forms.DataGridView();
            this.GroupTwo = new System.Windows.Forms.Button();
            this.SaveGroup1 = new System.Windows.Forms.Button();
            this.RetrieveGroup1 = new System.Windows.Forms.Button();
            this.RetrieveGroup3 = new System.Windows.Forms.Button();
            this.SaveGroup3 = new System.Windows.Forms.Button();
            this.DisplayMarkforGroup3 = new System.Windows.Forms.Button();
            this.DisplayMarkforGroup1 = new System.Windows.Forms.Button();
            this.DisplayGroup1 = new System.Windows.Forms.Button();
            this.DisplayGroup3 = new System.Windows.Forms.Button();
            this.DisplayGroup4 = new System.Windows.Forms.Button();
            this.DisplayMarkforGroup4 = new System.Windows.Forms.Button();
            this.SaveGroup4 = new System.Windows.Forms.Button();
            this.RetrieveGroup4 = new System.Windows.Forms.Button();
            this.BulkAssignToGroups = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.studentsDataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // Exit
            // 
            this.Exit.Location = new System.Drawing.Point(147, 38);
            this.Exit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(86, 31);
            this.Exit.TabIndex = 12;
            this.Exit.Text = "Exit";
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // Import
            // 
            this.Import.Location = new System.Drawing.Point(12, 31);
            this.Import.Name = "Import";
            this.Import.Size = new System.Drawing.Size(103, 41);
            this.Import.TabIndex = 13;
            this.Import.Text = "Import";
            this.Import.UseVisualStyleBackColor = true;
            this.Import.Click += new System.EventHandler(this.Import_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "All files (*.*)|*.*";
            // 
            // studentsDataGridView1
            // 
            this.studentsDataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.studentsDataGridView1.Location = new System.Drawing.Point(463, 12);
            this.studentsDataGridView1.Name = "studentsDataGridView1";
            this.studentsDataGridView1.RowHeadersWidth = 51;
            this.studentsDataGridView1.RowTemplate.Height = 29;
            this.studentsDataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.studentsDataGridView1.Size = new System.Drawing.Size(719, 476);
            this.studentsDataGridView1.TabIndex = 35;
            this.studentsDataGridView1.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.studentsDataGridView1_CellMouseDoubleClick);
            // 
            // GroupTwo
            // 
            this.GroupTwo.Location = new System.Drawing.Point(284, 31);
            this.GroupTwo.Name = "GroupTwo";
            this.GroupTwo.Size = new System.Drawing.Size(100, 38);
            this.GroupTwo.TabIndex = 42;
            this.GroupTwo.Text = "Group2";
            this.GroupTwo.UseVisualStyleBackColor = true;
            this.GroupTwo.Click += new System.EventHandler(this.GroupTwo_Click_1);
            // 
            // SaveGroup1
            // 
            this.SaveGroup1.Location = new System.Drawing.Point(20, 230);
            this.SaveGroup1.Name = "SaveGroup1";
            this.SaveGroup1.Size = new System.Drawing.Size(121, 37);
            this.SaveGroup1.TabIndex = 46;
            this.SaveGroup1.Text = "Save Group1";
            this.SaveGroup1.UseVisualStyleBackColor = true;
            this.SaveGroup1.Click += new System.EventHandler(this.SaveGroup1_Click);
            // 
            // RetrieveGroup1
            // 
            this.RetrieveGroup1.Location = new System.Drawing.Point(190, 230);
            this.RetrieveGroup1.Name = "RetrieveGroup1";
            this.RetrieveGroup1.Size = new System.Drawing.Size(124, 38);
            this.RetrieveGroup1.TabIndex = 47;
            this.RetrieveGroup1.Text = "Retrieve Group1";
            this.RetrieveGroup1.UseVisualStyleBackColor = true;
            this.RetrieveGroup1.Click += new System.EventHandler(this.RetrieveGroup1_Click);
            // 
            // RetrieveGroup3
            // 
            this.RetrieveGroup3.Location = new System.Drawing.Point(300, 458);
            this.RetrieveGroup3.Name = "RetrieveGroup3";
            this.RetrieveGroup3.Size = new System.Drawing.Size(129, 36);
            this.RetrieveGroup3.TabIndex = 48;
            this.RetrieveGroup3.Text = "Retrieve Group3";
            this.RetrieveGroup3.UseVisualStyleBackColor = true;
            this.RetrieveGroup3.Click += new System.EventHandler(this.RetrieveGroup3_Click);
            // 
            // SaveGroup3
            // 
            this.SaveGroup3.Location = new System.Drawing.Point(147, 458);
            this.SaveGroup3.Name = "SaveGroup3";
            this.SaveGroup3.Size = new System.Drawing.Size(114, 36);
            this.SaveGroup3.TabIndex = 49;
            this.SaveGroup3.Text = "Save Group3";
            this.SaveGroup3.UseVisualStyleBackColor = true;
            this.SaveGroup3.Click += new System.EventHandler(this.SaveGroup3_Click);
            // 
            // DisplayMarkforGroup3
            // 
            this.DisplayMarkforGroup3.Location = new System.Drawing.Point(171, 339);
            this.DisplayMarkforGroup3.Name = "DisplayMarkforGroup3";
            this.DisplayMarkforGroup3.Size = new System.Drawing.Size(117, 52);
            this.DisplayMarkforGroup3.TabIndex = 50;
            this.DisplayMarkforGroup3.Text = "Display Mark for Group3";
            this.DisplayMarkforGroup3.UseVisualStyleBackColor = true;
            this.DisplayMarkforGroup3.Click += new System.EventHandler(this.DisplayMarkforGroup3_Click);
            // 
            // DisplayMarkforGroup1
            // 
            this.DisplayMarkforGroup1.Location = new System.Drawing.Point(171, 127);
            this.DisplayMarkforGroup1.Name = "DisplayMarkforGroup1";
            this.DisplayMarkforGroup1.Size = new System.Drawing.Size(112, 57);
            this.DisplayMarkforGroup1.TabIndex = 51;
            this.DisplayMarkforGroup1.Text = "Display Mark for Group1";
            this.DisplayMarkforGroup1.UseVisualStyleBackColor = true;
            this.DisplayMarkforGroup1.Click += new System.EventHandler(this.DisplayMarkforGroup1_Click);
            // 
            // DisplayGroup1
            // 
            this.DisplayGroup1.Location = new System.Drawing.Point(21, 134);
            this.DisplayGroup1.Name = "DisplayGroup1";
            this.DisplayGroup1.Size = new System.Drawing.Size(120, 42);
            this.DisplayGroup1.TabIndex = 52;
            this.DisplayGroup1.Text = "Display Group1";
            this.DisplayGroup1.UseVisualStyleBackColor = true;
            this.DisplayGroup1.Click += new System.EventHandler(this.DisplayGroup1_Click);
            // 
            // DisplayGroup3
            // 
            this.DisplayGroup3.Location = new System.Drawing.Point(21, 458);
            this.DisplayGroup3.Name = "DisplayGroup3";
            this.DisplayGroup3.Size = new System.Drawing.Size(94, 54);
            this.DisplayGroup3.TabIndex = 53;
            this.DisplayGroup3.Text = "Display Group3";
            this.DisplayGroup3.UseVisualStyleBackColor = true;
            this.DisplayGroup3.Click += new System.EventHandler(this.DisplayGroup3_Click);
            // 
            // DisplayGroup4
            // 
            this.DisplayGroup4.Location = new System.Drawing.Point(12, 553);
            this.DisplayGroup4.Name = "DisplayGroup4";
            this.DisplayGroup4.Size = new System.Drawing.Size(129, 45);
            this.DisplayGroup4.TabIndex = 54;
            this.DisplayGroup4.Text = "Display Group4";
            this.DisplayGroup4.UseVisualStyleBackColor = true;
            this.DisplayGroup4.Click += new System.EventHandler(this.DisplayGroup4_Click);
            // 
            // DisplayMarkforGroup4
            // 
            this.DisplayMarkforGroup4.Location = new System.Drawing.Point(171, 551);
            this.DisplayMarkforGroup4.Name = "DisplayMarkforGroup4";
            this.DisplayMarkforGroup4.Size = new System.Drawing.Size(118, 49);
            this.DisplayMarkforGroup4.TabIndex = 55;
            this.DisplayMarkforGroup4.Text = "Display Mark for Group4";
            this.DisplayMarkforGroup4.UseVisualStyleBackColor = true;
            this.DisplayMarkforGroup4.Click += new System.EventHandler(this.DisplayMarkforGroup4_Click);
            // 
            // SaveGroup4
            // 
            this.SaveGroup4.Location = new System.Drawing.Point(322, 551);
            this.SaveGroup4.Name = "SaveGroup4";
            this.SaveGroup4.Size = new System.Drawing.Size(94, 54);
            this.SaveGroup4.TabIndex = 56;
            this.SaveGroup4.Text = "Save Group4";
            this.SaveGroup4.UseVisualStyleBackColor = true;
            this.SaveGroup4.Click += new System.EventHandler(this.SaveGroup4_Click);
            // 
            // RetrieveGroup4
            // 
            this.RetrieveGroup4.Location = new System.Drawing.Point(21, 633);
            this.RetrieveGroup4.Name = "RetrieveGroup4";
            this.RetrieveGroup4.Size = new System.Drawing.Size(129, 36);
            this.RetrieveGroup4.TabIndex = 57;
            this.RetrieveGroup4.Text = "Retrieve Group4";
            this.RetrieveGroup4.UseVisualStyleBackColor = true;
            this.RetrieveGroup4.Click += new System.EventHandler(this.RetrieveGroup4_Click);
            // 
            // BulkAssignToGroups
            // 
            this.BulkAssignToGroups.Location = new System.Drawing.Point(12, 341);
            this.BulkAssignToGroups.Name = "BulkAssignToGroups";
            this.BulkAssignToGroups.Size = new System.Drawing.Size(129, 50);
            this.BulkAssignToGroups.TabIndex = 58;
            this.BulkAssignToGroups.Text = "Bulk-Assign To Groups";
            this.BulkAssignToGroups.UseVisualStyleBackColor = true;
            this.BulkAssignToGroups.Click += new System.EventHandler(this.BulkAssignToGroups_Click);
            // 
            // ManagingGroupCoursework
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1194, 692);
            this.Controls.Add(this.BulkAssignToGroups);
            this.Controls.Add(this.RetrieveGroup4);
            this.Controls.Add(this.SaveGroup4);
            this.Controls.Add(this.DisplayMarkforGroup4);
            this.Controls.Add(this.DisplayGroup4);
            this.Controls.Add(this.DisplayGroup3);
            this.Controls.Add(this.DisplayGroup1);
            this.Controls.Add(this.DisplayMarkforGroup1);
            this.Controls.Add(this.DisplayMarkforGroup3);
            this.Controls.Add(this.SaveGroup3);
            this.Controls.Add(this.RetrieveGroup3);
            this.Controls.Add(this.RetrieveGroup1);
            this.Controls.Add(this.SaveGroup1);
            this.Controls.Add(this.GroupTwo);
            this.Controls.Add(this.studentsDataGridView1);
            this.Controls.Add(this.Import);
            this.Controls.Add(this.Exit);
            this.Name = "ManagingGroupCoursework";
            this.Text = "Managing group coursework";
            ((System.ComponentModel.ISupportInitialize)(this.studentsDataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private TextBox studentIDtextBox;
        private Button Exit;
        private Button Import;
        private OpenFileDialog openFileDialog1;
        private DataGridView studentsDataGridView1;
        private Button GroupTwo;
        private Button SaveGroup1;
        private Button RetrieveGroup1;
        private Button RetrieveGroup3;
        private Button SaveGroup3;
        private Button DisplayMarkforGroup3;
        private Button DisplayMarkforGroup1;
        private Button DisplayGroup1;
        private Button DisplayGroup3;
        private Button DisplayGroup4;
        private Button DisplayMarkforGroup4;
        private Button SaveGroup4;
        private Button RetrieveGroup4;
        private Button BulkAssignToGroups;
    }
}