
namespace Random_new_version
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
            this.lb_Number = new System.Windows.Forms.Label();
            this.cb_TwoScreen = new System.Windows.Forms.CheckBox();
            this.tb_Number = new System.Windows.Forms.TextBox();
            this.btn_Start = new System.Windows.Forms.Button();
            this.tb_NumberStart = new System.Windows.Forms.TextBox();
            this.tb_NumberEnd = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.настройкиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_Enabled = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_Disabled = new System.Windows.Forms.ToolStripMenuItem();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lb_Number
            // 
            this.lb_Number.AutoSize = true;
            this.lb_Number.Font = new System.Drawing.Font("Microsoft Sans Serif", 42F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lb_Number.Location = new System.Drawing.Point(84, 29);
            this.lb_Number.Name = "lb_Number";
            this.lb_Number.Size = new System.Drawing.Size(59, 64);
            this.lb_Number.TabIndex = 0;
            this.lb_Number.Text = "0";
            this.lb_Number.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cb_TwoScreen
            // 
            this.cb_TwoScreen.AutoSize = true;
            this.cb_TwoScreen.Location = new System.Drawing.Point(12, 359);
            this.cb_TwoScreen.Name = "cb_TwoScreen";
            this.cb_TwoScreen.Size = new System.Drawing.Size(95, 17);
            this.cb_TwoScreen.TabIndex = 1;
            this.cb_TwoScreen.Text = "Второй экран";
            this.cb_TwoScreen.UseVisualStyleBackColor = true;
            this.cb_TwoScreen.CheckedChanged += new System.EventHandler(this.cb_TwoScreen_CheckedChanged);
            // 
            // tb_Number
            // 
            this.tb_Number.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tb_Number.Location = new System.Drawing.Point(12, 125);
            this.tb_Number.Name = "tb_Number";
            this.tb_Number.Size = new System.Drawing.Size(199, 44);
            this.tb_Number.TabIndex = 2;
            this.tb_Number.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btn_Start
            // 
            this.btn_Start.Location = new System.Drawing.Point(73, 207);
            this.btn_Start.Name = "btn_Start";
            this.btn_Start.Size = new System.Drawing.Size(75, 32);
            this.btn_Start.TabIndex = 3;
            this.btn_Start.Text = "Старт";
            this.btn_Start.UseVisualStyleBackColor = true;
            this.btn_Start.Click += new System.EventHandler(this.btn_Start_Click);
            // 
            // tb_NumberStart
            // 
            this.tb_NumberStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tb_NumberStart.Location = new System.Drawing.Point(12, 287);
            this.tb_NumberStart.Name = "tb_NumberStart";
            this.tb_NumberStart.Size = new System.Drawing.Size(95, 29);
            this.tb_NumberStart.TabIndex = 4;
            // 
            // tb_NumberEnd
            // 
            this.tb_NumberEnd.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tb_NumberEnd.Location = new System.Drawing.Point(116, 287);
            this.tb_NumberEnd.Name = "tb_NumberEnd";
            this.tb_NumberEnd.Size = new System.Drawing.Size(95, 29);
            this.tb_NumberEnd.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 271);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(22, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "ОТ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(155, 271);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "ДО";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.настройкиToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(223, 24);
            this.menuStrip1.TabIndex = 8;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // настройкиToolStripMenuItem
            // 
            this.настройкиToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menu_Enabled,
            this.menu_Disabled});
            this.настройкиToolStripMenuItem.Name = "настройкиToolStripMenuItem";
            this.настройкиToolStripMenuItem.Size = new System.Drawing.Size(79, 20);
            this.настройкиToolStripMenuItem.Text = "Настройки";
            // 
            // menu_Enabled
            // 
            this.menu_Enabled.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.menu_Enabled.Name = "menu_Enabled";
            this.menu_Enabled.Size = new System.Drawing.Size(180, 22);
            this.menu_Enabled.Text = "Включить ПЧ";
            this.menu_Enabled.Click += new System.EventHandler(this.menu_Enabled_Click);
            // 
            // menu_Disabled
            // 
            this.menu_Disabled.Name = "menu_Disabled";
            this.menu_Disabled.Size = new System.Drawing.Size(180, 22);
            this.menu_Disabled.Text = "Выключить ПЧ";
            this.menu_Disabled.Click += new System.EventHandler(this.menu_Disabled_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 30;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(223, 388);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_NumberEnd);
            this.Controls.Add(this.tb_NumberStart);
            this.Controls.Add(this.btn_Start);
            this.Controls.Add(this.tb_Number);
            this.Controls.Add(this.cb_TwoScreen);
            this.Controls.Add(this.lb_Number);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Мекю";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_Number;
        private System.Windows.Forms.CheckBox cb_TwoScreen;
        private System.Windows.Forms.TextBox tb_Number;
        private System.Windows.Forms.Button btn_Start;
        private System.Windows.Forms.TextBox tb_NumberStart;
        private System.Windows.Forms.TextBox tb_NumberEnd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem настройкиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menu_Enabled;
        private System.Windows.Forms.ToolStripMenuItem menu_Disabled;
        private System.Windows.Forms.Timer timer1;
    }
}

