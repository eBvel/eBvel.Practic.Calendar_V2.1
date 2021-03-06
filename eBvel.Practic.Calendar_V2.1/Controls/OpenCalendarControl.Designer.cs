﻿namespace eBvel.Practic.Calendar_V2._1.Controls
{
    partial class OpenCalendarControl
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

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cDayDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cMonthDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numYearDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fullDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rDDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.countDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.calendarBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.AddEventButton = new System.Windows.Forms.Button();
            this.Left_Label = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Right_Label = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Search_Button = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.calendarBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1128, 73);
            this.label1.TabIndex = 0;
            this.label1.Text = "Производственный календарь";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoGenerateColumns = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.cDayDataGridViewTextBoxColumn,
            this.cMonthDataGridViewTextBoxColumn,
            this.numYearDataGridViewTextBoxColumn,
            this.fullDateDataGridViewTextBoxColumn,
            this.rDDataGridViewCheckBoxColumn,
            this.countDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.calendarBindingSource;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.Location = new System.Drawing.Point(0, 73);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(883, 355);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.GridView_CellMouseClick);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Код";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.Width = 80;
            // 
            // cDayDataGridViewTextBoxColumn
            // 
            this.cDayDataGridViewTextBoxColumn.DataPropertyName = "cDay";
            this.cDayDataGridViewTextBoxColumn.HeaderText = "День";
            this.cDayDataGridViewTextBoxColumn.Name = "cDayDataGridViewTextBoxColumn";
            this.cDayDataGridViewTextBoxColumn.ReadOnly = true;
            this.cDayDataGridViewTextBoxColumn.Width = 120;
            // 
            // cMonthDataGridViewTextBoxColumn
            // 
            this.cMonthDataGridViewTextBoxColumn.DataPropertyName = "cMonth";
            this.cMonthDataGridViewTextBoxColumn.HeaderText = "Месяц";
            this.cMonthDataGridViewTextBoxColumn.Name = "cMonthDataGridViewTextBoxColumn";
            this.cMonthDataGridViewTextBoxColumn.ReadOnly = true;
            this.cMonthDataGridViewTextBoxColumn.Width = 120;
            // 
            // numYearDataGridViewTextBoxColumn
            // 
            this.numYearDataGridViewTextBoxColumn.DataPropertyName = "NumYear";
            this.numYearDataGridViewTextBoxColumn.HeaderText = "Год";
            this.numYearDataGridViewTextBoxColumn.Name = "numYearDataGridViewTextBoxColumn";
            // 
            // fullDateDataGridViewTextBoxColumn
            // 
            this.fullDateDataGridViewTextBoxColumn.DataPropertyName = "FullDate";
            this.fullDateDataGridViewTextBoxColumn.HeaderText = "Полная дата";
            this.fullDateDataGridViewTextBoxColumn.Name = "fullDateDataGridViewTextBoxColumn";
            this.fullDateDataGridViewTextBoxColumn.ReadOnly = true;
            this.fullDateDataGridViewTextBoxColumn.Width = 120;
            // 
            // rDDataGridViewCheckBoxColumn
            // 
            this.rDDataGridViewCheckBoxColumn.DataPropertyName = "RD";
            this.rDDataGridViewCheckBoxColumn.HeaderText = "Выходной";
            this.rDDataGridViewCheckBoxColumn.Name = "rDDataGridViewCheckBoxColumn";
            this.rDDataGridViewCheckBoxColumn.ReadOnly = true;
            // 
            // countDataGridViewTextBoxColumn
            // 
            this.countDataGridViewTextBoxColumn.DataPropertyName = "Count";
            this.countDataGridViewTextBoxColumn.HeaderText = "Count";
            this.countDataGridViewTextBoxColumn.Name = "countDataGridViewTextBoxColumn";
            this.countDataGridViewTextBoxColumn.ReadOnly = true;
            this.countDataGridViewTextBoxColumn.Visible = false;
            // 
            // calendarBindingSource
            // 
            this.calendarBindingSource.DataSource = typeof(CLibrary.Calendar);
            // 
            // AddEventButton
            // 
            this.AddEventButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.AddEventButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddEventButton.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddEventButton.ForeColor = System.Drawing.Color.White;
            this.AddEventButton.Location = new System.Drawing.Point(6, 434);
            this.AddEventButton.Name = "AddEventButton";
            this.AddEventButton.Size = new System.Drawing.Size(208, 50);
            this.AddEventButton.TabIndex = 2;
            this.AddEventButton.Text = "Добавить событие";
            this.AddEventButton.UseVisualStyleBackColor = false;
            this.AddEventButton.Click += new System.EventHandler(this.AddEventButton_Click);
            // 
            // Left_Label
            // 
            this.Left_Label.AutoSize = true;
            this.Left_Label.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Left_Label.Location = new System.Drawing.Point(422, 432);
            this.Left_Label.Name = "Left_Label";
            this.Left_Label.Size = new System.Drawing.Size(34, 22);
            this.Left_Label.TabIndex = 3;
            this.Left_Label.Text = "<<";
            this.Left_Label.Click += new System.EventHandler(this.Left_Click);
            this.Left_Label.MouseEnter += new System.EventHandler(this.LeftLabel_Enter);
            this.Left_Label.MouseLeave += new System.EventHandler(this.LeftLabel_Leave);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(467, 432);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 22);
            this.label3.TabIndex = 4;
            this.label3.Text = "label";
            // 
            // Right_Label
            // 
            this.Right_Label.AutoSize = true;
            this.Right_Label.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Right_Label.Location = new System.Drawing.Point(509, 432);
            this.Right_Label.Name = "Right_Label";
            this.Right_Label.Size = new System.Drawing.Size(34, 22);
            this.Right_Label.TabIndex = 4;
            this.Right_Label.Text = ">>";
            this.Right_Label.Click += new System.EventHandler(this.Right_Click);
            this.Right_Label.MouseEnter += new System.EventHandler(this.RightLabel_Enter);
            this.Right_Label.MouseLeave += new System.EventHandler(this.RightLabel_Leave);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gray;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.Search_Button);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(882, 73);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(246, 529);
            this.panel1.TabIndex = 5;
            // 
            // Search_Button
            // 
            this.Search_Button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Search_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Search_Button.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Search_Button.ForeColor = System.Drawing.Color.White;
            this.Search_Button.Location = new System.Drawing.Point(126, 55);
            this.Search_Button.Name = "Search_Button";
            this.Search_Button.Size = new System.Drawing.Size(104, 44);
            this.Search_Button.TabIndex = 5;
            this.Search_Button.Text = "Найти";
            this.Search_Button.UseVisualStyleBackColor = false;
            this.Search_Button.Click += new System.EventHandler(this.Search_Button_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::eBvel.Practic.Calendar_V2._1.Properties.Resources.iconfinder_search_322497;
            this.pictureBox1.Location = new System.Drawing.Point(6, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(27, 25);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.textBox1.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox1.Location = new System.Drawing.Point(47, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(196, 28);
            this.textBox1.TabIndex = 3;
            this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SearchButton_KeyPress);
            // 
            // OpenCalendarControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Right_Label);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Left_Label);
            this.Controls.Add(this.AddEventButton);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Name = "OpenCalendarControl";
            this.Size = new System.Drawing.Size(1128, 602);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.calendarBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button AddEventButton;
        private System.Windows.Forms.Label Left_Label;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label Right_Label;
        private System.Windows.Forms.BindingSource calendarBindingSource;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cDayDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cMonthDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numYearDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fullDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn rDDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn countDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button Search_Button;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox textBox1;
    }
}
