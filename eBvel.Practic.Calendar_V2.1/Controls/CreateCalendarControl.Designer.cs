namespace eBvel.Practic.Calendar_V2._1.Controls
{
    partial class CreateCalendarControl
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
            this.FirstDateButton = new System.Windows.Forms.Button();
            this.HollyDaysButton = new System.Windows.Forms.Button();
            this.CreateCalendar_Button = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
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
            this.label1.Size = new System.Drawing.Size(910, 78);
            this.label1.TabIndex = 1;
            this.label1.Text = "Создайте календарь";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FirstDateButton
            // 
            this.FirstDateButton.BackColor = System.Drawing.Color.DarkSlateGray;
            this.FirstDateButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FirstDateButton.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FirstDateButton.ForeColor = System.Drawing.Color.White;
            this.FirstDateButton.Location = new System.Drawing.Point(24, 135);
            this.FirstDateButton.Name = "FirstDateButton";
            this.FirstDateButton.Size = new System.Drawing.Size(274, 68);
            this.FirstDateButton.TabIndex = 2;
            this.FirstDateButton.Text = "Введите начальные данные";
            this.FirstDateButton.UseVisualStyleBackColor = false;
            this.FirstDateButton.Click += new System.EventHandler(this.FirstDateButton_Click);
            // 
            // HollyDaysButton
            // 
            this.HollyDaysButton.BackColor = System.Drawing.Color.DarkSlateGray;
            this.HollyDaysButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.HollyDaysButton.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.HollyDaysButton.ForeColor = System.Drawing.Color.White;
            this.HollyDaysButton.Location = new System.Drawing.Point(24, 265);
            this.HollyDaysButton.Name = "HollyDaysButton";
            this.HollyDaysButton.Size = new System.Drawing.Size(274, 68);
            this.HollyDaysButton.TabIndex = 2;
            this.HollyDaysButton.Text = "Введите выходные дни";
            this.HollyDaysButton.UseVisualStyleBackColor = false;
            this.HollyDaysButton.Click += new System.EventHandler(this.HollyDaysButton_Click);
            // 
            // CreateCalendar_Button
            // 
            this.CreateCalendar_Button.BackColor = System.Drawing.Color.SeaGreen;
            this.CreateCalendar_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CreateCalendar_Button.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CreateCalendar_Button.ForeColor = System.Drawing.Color.White;
            this.CreateCalendar_Button.Location = new System.Drawing.Point(610, 135);
            this.CreateCalendar_Button.Name = "CreateCalendar_Button";
            this.CreateCalendar_Button.Size = new System.Drawing.Size(266, 102);
            this.CreateCalendar_Button.TabIndex = 2;
            this.CreateCalendar_Button.Text = "Создать";
            this.CreateCalendar_Button.UseVisualStyleBackColor = false;
            this.CreateCalendar_Button.Click += new System.EventHandler(this.CreateCalendarButton_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Enabled = false;
            this.checkBox1.Location = new System.Drawing.Point(304, 139);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(18, 17);
            this.checkBox1.TabIndex = 3;
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Enabled = false;
            this.checkBox2.Location = new System.Drawing.Point(304, 269);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(18, 17);
            this.checkBox2.TabIndex = 4;
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // CreateCalendarControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.CreateCalendar_Button);
            this.Controls.Add(this.HollyDaysButton);
            this.Controls.Add(this.FirstDateButton);
            this.Controls.Add(this.label1);
            this.Name = "CreateCalendarControl";
            this.Size = new System.Drawing.Size(910, 496);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button FirstDateButton;
        private System.Windows.Forms.Button HollyDaysButton;
        private System.Windows.Forms.Button CreateCalendar_Button;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox2;
    }
}
