
namespace security_and_fire_system
{
    partial class InitialParametersForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InitialParametersForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.button_start = new System.Windows.Forms.Button();
            this.checkBox_input = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_fireChance = new System.Windows.Forms.TextBox();
            this.textBox_rooms = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel1.Controls.Add(this.button_start);
            this.panel1.Controls.Add(this.checkBox_input);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.textBox_fireChance);
            this.panel1.Controls.Add(this.textBox_rooms);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(335, 379);
            this.panel1.TabIndex = 0;
            // 
            // button_start
            // 
            this.button_start.AutoSize = true;
            this.button_start.Enabled = false;
            this.button_start.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_start.Location = new System.Drawing.Point(107, 221);
            this.button_start.Name = "button_start";
            this.button_start.Size = new System.Drawing.Size(101, 43);
            this.button_start.TabIndex = 6;
            this.button_start.Text = "Запустить";
            this.button_start.UseVisualStyleBackColor = true;
            this.button_start.Click += new System.EventHandler(this.button_start_Click);
            // 
            // checkBox_input
            // 
            this.checkBox_input.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBox_input.Location = new System.Drawing.Point(23, 326);
            this.checkBox_input.Name = "checkBox_input";
            this.checkBox_input.Size = new System.Drawing.Size(298, 50);
            this.checkBox_input.TabIndex = 5;
            this.checkBox_input.Text = "Подтверждаю правильность введённых данных";
            this.checkBox_input.UseVisualStyleBackColor = true;
            this.checkBox_input.CheckedChanged += new System.EventHandler(this.checkBox_input_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(260, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(25, 19);
            this.label3.TabIndex = 4;
            this.label3.Text = "%";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(43, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 19);
            this.label2.TabIndex = 3;
            this.label2.Text = "Шанс возгорания:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(63, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 19);
            this.label1.TabIndex = 2;
            this.label1.Text = "Кол-во комнат:";
            // 
            // textBox_fireChance
            // 
            this.textBox_fireChance.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBox_fireChance.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_fireChance.Location = new System.Drawing.Point(199, 119);
            this.textBox_fireChance.Multiline = true;
            this.textBox_fireChance.Name = "textBox_fireChance";
            this.textBox_fireChance.Size = new System.Drawing.Size(55, 28);
            this.textBox_fireChance.TabIndex = 1;
            // 
            // textBox_rooms
            // 
            this.textBox_rooms.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBox_rooms.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_rooms.Location = new System.Drawing.Point(190, 46);
            this.textBox_rooms.Multiline = true;
            this.textBox_rooms.Name = "textBox_rooms";
            this.textBox_rooms.Size = new System.Drawing.Size(43, 28);
            this.textBox_rooms.TabIndex = 0;
            // 
            // InitialParametersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(333, 378);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(349, 417);
            this.MinimumSize = new System.Drawing.Size(349, 417);
            this.Name = "InitialParametersForm";
            this.Text = "Охранно-пожарная система";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBox_fireChance;
        private System.Windows.Forms.TextBox textBox_rooms;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox checkBox_input;
        private System.Windows.Forms.Button button_start;
    }
}

