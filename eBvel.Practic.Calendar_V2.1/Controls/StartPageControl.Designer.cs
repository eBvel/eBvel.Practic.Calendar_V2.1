namespace eBvel.Practic.Calendar_V2._1.Controls
{
    partial class StartPageControl
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
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Exit_Label = new System.Windows.Forms.Label();
            this.Reports_Label = new System.Windows.Forms.Label();
            this.References_Label = new System.Windows.Forms.Label();
            this.References_Panel = new System.Windows.Forms.Panel();
            this.Reference_Label2 = new System.Windows.Forms.Label();
            this.Reference_Label1 = new System.Windows.Forms.Label();
            this.Reports_Panel = new System.Windows.Forms.Panel();
            this.Report_Label1 = new System.Windows.Forms.Label();
            this.Report_Label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.References_Panel.SuspendLayout();
            this.Reports_Panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1054, 94);
            this.label1.TabIndex = 0;
            this.label1.Text = "Производственный календарь";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gray;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.Exit_Label);
            this.panel1.Controls.Add(this.Reports_Label);
            this.panel1.Controls.Add(this.References_Label);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 94);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(181, 483);
            this.panel1.TabIndex = 1;
            // 
            // Exit_Label
            // 
            this.Exit_Label.AutoSize = true;
            this.Exit_Label.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Exit_Label.ForeColor = System.Drawing.Color.White;
            this.Exit_Label.Location = new System.Drawing.Point(36, 235);
            this.Exit_Label.Name = "Exit_Label";
            this.Exit_Label.Size = new System.Drawing.Size(86, 30);
            this.Exit_Label.TabIndex = 0;
            this.Exit_Label.Text = "Выход";
            this.Exit_Label.Click += new System.EventHandler(this.ExitLabel_Click);
            this.Exit_Label.MouseEnter += new System.EventHandler(this.ExitLabel_MouseEnter);
            this.Exit_Label.MouseLeave += new System.EventHandler(this.ExitLabel_MouseLeave);
            // 
            // Reports_Label
            // 
            this.Reports_Label.AutoSize = true;
            this.Reports_Label.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Reports_Label.ForeColor = System.Drawing.Color.White;
            this.Reports_Label.Location = new System.Drawing.Point(36, 142);
            this.Reports_Label.Name = "Reports_Label";
            this.Reports_Label.Size = new System.Drawing.Size(95, 30);
            this.Reports_Label.TabIndex = 0;
            this.Reports_Label.Text = "Отчеты";
            this.Reports_Label.Click += new System.EventHandler(this.ReportsLabel_Click);
            this.Reports_Label.MouseEnter += new System.EventHandler(this.ReportsLabel_MouseEnter);
            this.Reports_Label.MouseLeave += new System.EventHandler(this.ReportsLabel_MouseLeave);
            // 
            // References_Label
            // 
            this.References_Label.AutoSize = true;
            this.References_Label.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.References_Label.ForeColor = System.Drawing.Color.White;
            this.References_Label.Location = new System.Drawing.Point(36, 58);
            this.References_Label.Name = "References_Label";
            this.References_Label.Size = new System.Drawing.Size(117, 30);
            this.References_Label.TabIndex = 0;
            this.References_Label.Text = "Справки";
            this.References_Label.Click += new System.EventHandler(this.ReferencesLabel_Click);
            this.References_Label.MouseEnter += new System.EventHandler(this.ReferencesLabel_MouseEnter);
            this.References_Label.MouseLeave += new System.EventHandler(this.ReferencesLabel_MouseLeave);
            // 
            // References_Panel
            // 
            this.References_Panel.Controls.Add(this.Reports_Panel);
            this.References_Panel.Controls.Add(this.Reference_Label2);
            this.References_Panel.Controls.Add(this.Reference_Label1);
            this.References_Panel.Location = new System.Drawing.Point(181, 94);
            this.References_Panel.Name = "References_Panel";
            this.References_Panel.Size = new System.Drawing.Size(873, 483);
            this.References_Panel.TabIndex = 2;
            this.References_Panel.Visible = false;
            // 
            // Reference_Label2
            // 
            this.Reference_Label2.AutoSize = true;
            this.Reference_Label2.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Reference_Label2.Location = new System.Drawing.Point(64, 119);
            this.Reference_Label2.Name = "Reference_Label2";
            this.Reference_Label2.Size = new System.Drawing.Size(611, 22);
            this.Reference_Label2.TabIndex = 1;
            this.Reference_Label2.Text = "> СПРАВКА: о запланированных мероприятиях на текущий год.";
            this.Reference_Label2.Click += new System.EventHandler(this.ReferenceLabel2_Click);
            // 
            // Reference_Label1
            // 
            this.Reference_Label1.AutoSize = true;
            this.Reference_Label1.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Reference_Label1.Location = new System.Drawing.Point(64, 65);
            this.Reference_Label1.Name = "Reference_Label1";
            this.Reference_Label1.Size = new System.Drawing.Size(658, 22);
            this.Reference_Label1.TabIndex = 0;
            this.Reference_Label1.Text = "> СПРАВКА: о запланированных мероприятиях за прошедший день.";
            this.Reference_Label1.Click += new System.EventHandler(this.ReferenceLabel1_Click);
            // 
            // Reports_Panel
            // 
            this.Reports_Panel.Controls.Add(this.Report_Label2);
            this.Reports_Panel.Controls.Add(this.Report_Label1);
            this.Reports_Panel.Location = new System.Drawing.Point(0, 0);
            this.Reports_Panel.Name = "Reports_Panel";
            this.Reports_Panel.Size = new System.Drawing.Size(871, 482);
            this.Reports_Panel.TabIndex = 2;
            this.Reports_Panel.Visible = false;
            // 
            // Report_Label1
            // 
            this.Report_Label1.AutoSize = true;
            this.Report_Label1.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Report_Label1.Location = new System.Drawing.Point(68, 65);
            this.Report_Label1.Name = "Report_Label1";
            this.Report_Label1.Size = new System.Drawing.Size(593, 22);
            this.Report_Label1.TabIndex = 0;
            this.Report_Label1.Text = "> ОТЧЕТ: о запланированных мероприятиях на будущий день.";
            this.Report_Label1.Click += new System.EventHandler(this.ReportLabel1_Click);
            // 
            // Report_Label2
            // 
            this.Report_Label2.AutoSize = true;
            this.Report_Label2.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Report_Label2.Location = new System.Drawing.Point(68, 126);
            this.Report_Label2.Name = "Report_Label2";
            this.Report_Label2.Size = new System.Drawing.Size(586, 22);
            this.Report_Label2.TabIndex = 1;
            this.Report_Label2.Text = "> ОТЧЕТ: о проведенных мероприятиях за указанный период.";
            this.Report_Label2.Click += new System.EventHandler(this.ReportLable2_Click);
            // 
            // StartPageControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.References_Panel);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Name = "StartPageControl";
            this.Size = new System.Drawing.Size(1054, 577);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.References_Panel.ResumeLayout(false);
            this.References_Panel.PerformLayout();
            this.Reports_Panel.ResumeLayout(false);
            this.Reports_Panel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label Exit_Label;
        private System.Windows.Forms.Label Reports_Label;
        private System.Windows.Forms.Label References_Label;
        private System.Windows.Forms.Panel References_Panel;
        private System.Windows.Forms.Label Reference_Label2;
        private System.Windows.Forms.Label Reference_Label1;
        private System.Windows.Forms.Panel Reports_Panel;
        private System.Windows.Forms.Label Report_Label2;
        private System.Windows.Forms.Label Report_Label1;
    }
}
