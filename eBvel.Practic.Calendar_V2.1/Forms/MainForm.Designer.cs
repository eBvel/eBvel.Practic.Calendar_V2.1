namespace eBvel.Practic.Calendar_V2._1
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.Calendar_Menu = new System.Windows.Forms.ToolStripMenuItem();
            this.CreateCalendar_Menu = new System.Windows.Forms.ToolStripMenuItem();
            this.OpenCalendar_Menu = new System.Windows.Forms.ToolStripMenuItem();
            this.Exit_Menu = new System.Windows.Forms.ToolStripMenuItem();
            this.Events_Menu = new System.Windows.Forms.ToolStripMenuItem();
            this.OpenEvents_Menu = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Calendar_Menu,
            this.Events_Menu});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 29);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // Calendar_Menu
            // 
            this.Calendar_Menu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CreateCalendar_Menu,
            this.OpenCalendar_Menu,
            this.Exit_Menu});
            this.Calendar_Menu.Name = "Calendar_Menu";
            this.Calendar_Menu.Size = new System.Drawing.Size(116, 25);
            this.Calendar_Menu.Text = "Календарь";
            // 
            // CreateCalendar_Menu
            // 
            this.CreateCalendar_Menu.Name = "CreateCalendar_Menu";
            this.CreateCalendar_Menu.Size = new System.Drawing.Size(155, 26);
            this.CreateCalendar_Menu.Text = "Создать";
            this.CreateCalendar_Menu.Click += new System.EventHandler(this.CreateCalendar_Menu_Click);
            // 
            // OpenCalendar_Menu
            // 
            this.OpenCalendar_Menu.Name = "OpenCalendar_Menu";
            this.OpenCalendar_Menu.Size = new System.Drawing.Size(155, 26);
            this.OpenCalendar_Menu.Text = "Открыть";
            this.OpenCalendar_Menu.Click += new System.EventHandler(this.OpenCalendar_Menu_Click);
            // 
            // Exit_Menu
            // 
            this.Exit_Menu.Name = "Exit_Menu";
            this.Exit_Menu.Size = new System.Drawing.Size(155, 26);
            this.Exit_Menu.Text = "Выход";
            this.Exit_Menu.Click += new System.EventHandler(this.Exit_Menu_Click);
            // 
            // Events_Menu
            // 
            this.Events_Menu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.OpenEvents_Menu});
            this.Events_Menu.Name = "Events_Menu";
            this.Events_Menu.Size = new System.Drawing.Size(138, 25);
            this.Events_Menu.Text = "Мероприятия";
            // 
            // OpenEvents_Menu
            // 
            this.OpenEvents_Menu.Name = "OpenEvents_Menu";
            this.OpenEvents_Menu.Size = new System.Drawing.Size(155, 26);
            this.OpenEvents_Menu.Text = "Открыть";
            this.OpenEvents_Menu.Click += new System.EventHandler(this.OpenEvents_Menu_Click);
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 29);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 421);
            this.panel1.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.Text = "Производственный календарь";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem Calendar_Menu;
        private System.Windows.Forms.ToolStripMenuItem CreateCalendar_Menu;
        private System.Windows.Forms.ToolStripMenuItem OpenCalendar_Menu;
        private System.Windows.Forms.ToolStripMenuItem Exit_Menu;
        private System.Windows.Forms.ToolStripMenuItem Events_Menu;
        private System.Windows.Forms.ToolStripMenuItem OpenEvents_Menu;
        private System.Windows.Forms.Panel panel1;
    }
}

