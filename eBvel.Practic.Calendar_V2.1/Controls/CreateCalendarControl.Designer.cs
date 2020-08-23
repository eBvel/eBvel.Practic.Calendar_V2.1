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
            this.CreateCalendarButton = new System.Windows.Forms.Button();
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
            this.label1.Size = new System.Drawing.Size(1098, 73);
            this.label1.TabIndex = 1;
            this.label1.Text = "Создайте календарь";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FirstDateButton
            // 
            this.FirstDateButton.Location = new System.Drawing.Point(166, 104);
            this.FirstDateButton.Name = "FirstDateButton";
            this.FirstDateButton.Size = new System.Drawing.Size(113, 68);
            this.FirstDateButton.TabIndex = 2;
            this.FirstDateButton.Text = "Введите начальные данные";
            this.FirstDateButton.UseVisualStyleBackColor = true;
            this.FirstDateButton.Click += new System.EventHandler(this.FirstDateButton_Click);
            // 
            // HollyDaysButton
            // 
            this.HollyDaysButton.Location = new System.Drawing.Point(152, 223);
            this.HollyDaysButton.Name = "HollyDaysButton";
            this.HollyDaysButton.Size = new System.Drawing.Size(157, 72);
            this.HollyDaysButton.TabIndex = 2;
            this.HollyDaysButton.Text = "Введите выходные дни";
            this.HollyDaysButton.UseVisualStyleBackColor = true;
            this.HollyDaysButton.Click += new System.EventHandler(this.HollyDaysButton_Click);
            // 
            // CreateCalendarButton
            // 
            this.CreateCalendarButton.Location = new System.Drawing.Point(706, 187);
            this.CreateCalendarButton.Name = "CreateCalendarButton";
            this.CreateCalendarButton.Size = new System.Drawing.Size(254, 144);
            this.CreateCalendarButton.TabIndex = 2;
            this.CreateCalendarButton.Text = "Создать";
            this.CreateCalendarButton.UseVisualStyleBackColor = true;
            this.CreateCalendarButton.Click += new System.EventHandler(this.CreateCalendarButton_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Enabled = false;
            this.checkBox1.Location = new System.Drawing.Point(368, 129);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(98, 21);
            this.checkBox1.TabIndex = 3;
            this.checkBox1.Text = "checkBox1";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Enabled = false;
            this.checkBox2.Location = new System.Drawing.Point(388, 261);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(98, 21);
            this.checkBox2.TabIndex = 4;
            this.checkBox2.Text = "checkBox2";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // CreateCalendarControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.CreateCalendarButton);
            this.Controls.Add(this.HollyDaysButton);
            this.Controls.Add(this.FirstDateButton);
            this.Controls.Add(this.label1);
            this.Name = "CreateCalendarControl";
            this.Size = new System.Drawing.Size(1098, 579);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button FirstDateButton;
        private System.Windows.Forms.Button HollyDaysButton;
        private System.Windows.Forms.Button CreateCalendarButton;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox2;
    }
}
