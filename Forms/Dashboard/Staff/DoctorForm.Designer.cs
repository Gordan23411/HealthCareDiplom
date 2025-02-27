﻿namespace HealthCare_Plus.Forms.Dashboard.Staff
{
    partial class DoctorForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.TopPanel = new System.Windows.Forms.Panel();
            this.Reset_btn = new System.Windows.Forms.Button();
            this.Search_btn = new System.Windows.Forms.Button();
            this.Location_input = new System.Windows.Forms.ComboBox();
            this.location_label = new System.Windows.Forms.Label();
            this.Specialization_Input = new System.Windows.Forms.ComboBox();
            this.specialization_label = new System.Windows.Forms.Label();
            this.Email_label = new System.Windows.Forms.Label();
            this.Email_input = new System.Windows.Forms.TextBox();
            this.first_label = new System.Windows.Forms.Label();
            this.Name_input = new System.Windows.Forms.TextBox();
            this.search_by_label = new System.Windows.Forms.Label();
            this.HeadlingLabel = new System.Windows.Forms.Label();
            this.BodyPanel = new System.Windows.Forms.Panel();
            this.doctorsDataGridView = new System.Windows.Forms.DataGridView();
            this.TopPanel.SuspendLayout();
            this.BodyPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.doctorsDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // TopPanel
            // 
            this.TopPanel.Controls.Add(this.Reset_btn);
            this.TopPanel.Controls.Add(this.Search_btn);
            this.TopPanel.Controls.Add(this.Location_input);
            this.TopPanel.Controls.Add(this.location_label);
            this.TopPanel.Controls.Add(this.Specialization_Input);
            this.TopPanel.Controls.Add(this.specialization_label);
            this.TopPanel.Controls.Add(this.Email_label);
            this.TopPanel.Controls.Add(this.Email_input);
            this.TopPanel.Controls.Add(this.first_label);
            this.TopPanel.Controls.Add(this.Name_input);
            this.TopPanel.Controls.Add(this.search_by_label);
            this.TopPanel.Controls.Add(this.HeadlingLabel);
            this.TopPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TopPanel.Location = new System.Drawing.Point(0, 0);
            this.TopPanel.Name = "TopPanel";
            this.TopPanel.Size = new System.Drawing.Size(832, 200);
            this.TopPanel.TabIndex = 0;
            // 
            // Reset_btn
            // 
            this.Reset_btn.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Reset_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Reset_btn.FlatAppearance.BorderSize = 0;
            this.Reset_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Reset_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Reset_btn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Reset_btn.Location = new System.Drawing.Point(141, 128);
            this.Reset_btn.Name = "Reset_btn";
            this.Reset_btn.Size = new System.Drawing.Size(100, 30);
            this.Reset_btn.TabIndex = 29;
            this.Reset_btn.Text = "Сброс";
            this.Reset_btn.UseVisualStyleBackColor = false;
            this.Reset_btn.Click += new System.EventHandler(this.Reset_btn_Click);
            // 
            // Search_btn
            // 
            this.Search_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(208)))), ((int)(((byte)(104)))));
            this.Search_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Search_btn.FlatAppearance.BorderSize = 0;
            this.Search_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Search_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Search_btn.Location = new System.Drawing.Point(23, 128);
            this.Search_btn.Name = "Search_btn";
            this.Search_btn.Size = new System.Drawing.Size(100, 30);
            this.Search_btn.TabIndex = 28;
            this.Search_btn.Text = "Поиск";
            this.Search_btn.UseVisualStyleBackColor = false;
            this.Search_btn.Click += new System.EventHandler(this.Search_btn_Click);
            // 
            // Location_input
            // 
            this.Location_input.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Location_input.FormattingEnabled = true;
            this.Location_input.Items.AddRange(new object[] {
            "Kandy",
            "Colombo"});
            this.Location_input.Location = new System.Drawing.Point(589, 87);
            this.Location_input.Name = "Location_input";
            this.Location_input.Size = new System.Drawing.Size(152, 21);
            this.Location_input.TabIndex = 13;
            // 
            // location_label
            // 
            this.location_label.AutoSize = true;
            this.location_label.Cursor = System.Windows.Forms.Cursors.Default;
            this.location_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.location_label.Location = new System.Drawing.Point(585, 64);
            this.location_label.Name = "location_label";
            this.location_label.Size = new System.Drawing.Size(130, 17);
            this.location_label.TabIndex = 8;
            this.location_label.Text = "Местонахождению";
            // 
            // Specialization_Input
            // 
            this.Specialization_Input.BackColor = System.Drawing.Color.White;
            this.Specialization_Input.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Specialization_Input.FormattingEnabled = true;
            this.Specialization_Input.Items.AddRange(new object[] {
            "Neurology",
            "Urology",
            "Family Medicine",
            "Psychiatry",
            "Dermatology",
            "Orthopedics",
            "Cardiology",
            "Gastroenterology",
            "Neurosurgery"});
            this.Specialization_Input.Location = new System.Drawing.Point(423, 87);
            this.Specialization_Input.Name = "Specialization_Input";
            this.Specialization_Input.Size = new System.Drawing.Size(143, 21);
            this.Specialization_Input.TabIndex = 12;
            // 
            // specialization_label
            // 
            this.specialization_label.AutoSize = true;
            this.specialization_label.Cursor = System.Windows.Forms.Cursors.Default;
            this.specialization_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.specialization_label.Location = new System.Drawing.Point(419, 64);
            this.specialization_label.Name = "specialization_label";
            this.specialization_label.Size = new System.Drawing.Size(112, 17);
            this.specialization_label.TabIndex = 7;
            this.specialization_label.Text = "Специализации";
            // 
            // Email_label
            // 
            this.Email_label.AutoSize = true;
            this.Email_label.Cursor = System.Windows.Forms.Cursors.Default;
            this.Email_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Email_label.Location = new System.Drawing.Point(213, 64);
            this.Email_label.Name = "Email_label";
            this.Email_label.Size = new System.Drawing.Size(138, 17);
            this.Email_label.TabIndex = 6;
            this.Email_label.Text = "Электронной почте";
            // 
            // Email_input
            // 
            this.Email_input.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Email_input.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Email_input.Location = new System.Drawing.Point(217, 87);
            this.Email_input.MaxLength = 300;
            this.Email_input.MinimumSize = new System.Drawing.Size(2, 21);
            this.Email_input.Name = "Email_input";
            this.Email_input.Size = new System.Drawing.Size(171, 20);
            this.Email_input.TabIndex = 11;
            // 
            // first_label
            // 
            this.first_label.AutoSize = true;
            this.first_label.Cursor = System.Windows.Forms.Cursors.Default;
            this.first_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.first_label.Location = new System.Drawing.Point(19, 64);
            this.first_label.Name = "first_label";
            this.first_label.Size = new System.Drawing.Size(51, 17);
            this.first_label.TabIndex = 5;
            this.first_label.Text = "Имени";
            // 
            // Name_input
            // 
            this.Name_input.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Name_input.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name_input.Location = new System.Drawing.Point(23, 87);
            this.Name_input.MaxLength = 300;
            this.Name_input.MinimumSize = new System.Drawing.Size(2, 21);
            this.Name_input.Name = "Name_input";
            this.Name_input.Size = new System.Drawing.Size(171, 20);
            this.Name_input.TabIndex = 10;
            // 
            // search_by_label
            // 
            this.search_by_label.AutoSize = true;
            this.search_by_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.search_by_label.Location = new System.Drawing.Point(20, 46);
            this.search_by_label.Name = "search_by_label";
            this.search_by_label.Size = new System.Drawing.Size(69, 16);
            this.search_by_label.TabIndex = 4;
            this.search_by_label.Text = "Поиск по:";
            // 
            // HeadlingLabel
            // 
            this.HeadlingLabel.AutoSize = true;
            this.HeadlingLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HeadlingLabel.Location = new System.Drawing.Point(19, 9);
            this.HeadlingLabel.Name = "HeadlingLabel";
            this.HeadlingLabel.Size = new System.Drawing.Size(104, 20);
            this.HeadlingLabel.TabIndex = 3;
            this.HeadlingLabel.Text = "Поиск врача";
            // 
            // BodyPanel
            // 
            this.BodyPanel.Controls.Add(this.doctorsDataGridView);
            this.BodyPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BodyPanel.Location = new System.Drawing.Point(0, 200);
            this.BodyPanel.Name = "BodyPanel";
            this.BodyPanel.Size = new System.Drawing.Size(832, 250);
            this.BodyPanel.TabIndex = 1;
            // 
            // doctorsDataGridView
            // 
            this.doctorsDataGridView.AllowUserToAddRows = false;
            this.doctorsDataGridView.AllowUserToDeleteRows = false;
            this.doctorsDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.doctorsDataGridView.BackgroundColor = System.Drawing.Color.LightGray;
            this.doctorsDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(211)))), ((int)(((byte)(51)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(0, 4, 0, 4);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.doctorsDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.doctorsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.doctorsDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.doctorsDataGridView.EnableHeadersVisualStyles = false;
            this.doctorsDataGridView.Location = new System.Drawing.Point(0, 0);
            this.doctorsDataGridView.MultiSelect = false;
            this.doctorsDataGridView.Name = "doctorsDataGridView";
            this.doctorsDataGridView.ReadOnly = true;
            this.doctorsDataGridView.Size = new System.Drawing.Size(832, 250);
            this.doctorsDataGridView.TabIndex = 1;
            // 
            // DoctorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(832, 450);
            this.Controls.Add(this.BodyPanel);
            this.Controls.Add(this.TopPanel);
            this.Name = "DoctorForm";
            this.Text = "Доктора";
            this.Load += new System.EventHandler(this.DoctorForm_Load);
            this.TopPanel.ResumeLayout(false);
            this.TopPanel.PerformLayout();
            this.BodyPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.doctorsDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel TopPanel;
        private System.Windows.Forms.Panel BodyPanel;
        private System.Windows.Forms.Label search_by_label;
        private System.Windows.Forms.Label HeadlingLabel;
        private System.Windows.Forms.TextBox Name_input;
        private System.Windows.Forms.Label first_label;
        private System.Windows.Forms.Label specialization_label;
        private System.Windows.Forms.Label Email_label;
        private System.Windows.Forms.TextBox Email_input;
        private System.Windows.Forms.ComboBox Specialization_Input;
        private System.Windows.Forms.ComboBox Location_input;
        private System.Windows.Forms.Label location_label;
        private System.Windows.Forms.Button Reset_btn;
        private System.Windows.Forms.Button Search_btn;
        private System.Windows.Forms.DataGridView doctorsDataGridView;
    }
}