namespace WindowsFormsApp1
{
    partial class Anketa
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Budget_field = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.Is_Gaming_field = new System.Windows.Forms.CheckBox();
            this.Is_Portable_field = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.VC_Producer_field = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.Proc_Producer_field = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.SSD_Memory_field = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.RAM_Memory_field = new System.Windows.Forms.ComboBox();
            this.Start_btn = new System.Windows.Forms.Button();
            this.Waring_label = new System.Windows.Forms.Label();
            this.VC_Memory_field = new System.Windows.Forms.ComboBox();
            this.Is_gaming_HINT = new System.Windows.Forms.Button();
            this.Is_portable_HINT = new System.Windows.Forms.Button();
            this.Budget_HINT = new System.Windows.Forms.Button();
            this.VC_producer_HINT = new System.Windows.Forms.Button();
            this.RAM_HINT = new System.Windows.Forms.Button();
            this.SSD_HINT = new System.Windows.Forms.Button();
            this.Proc_producer_HINT = new System.Windows.Forms.Button();
            this.VC_memory_HINT = new System.Windows.Forms.Button();
            this.Exit_btn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Budget_field)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(717, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 38);
            this.label1.TabIndex = 1;
            this.label1.Text = "Анкета";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(12, 171);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 29);
            this.label2.TabIndex = 2;
            this.label2.Text = "3) Бюджет: ";
            // 
            // Budget_field
            // 
            this.Budget_field.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Budget_field.Increment = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.Budget_field.Location = new System.Drawing.Point(396, 169);
            this.Budget_field.Maximum = new decimal(new int[] {
            200000,
            0,
            0,
            0});
            this.Budget_field.Minimum = new decimal(new int[] {
            8800,
            0,
            0,
            0});
            this.Budget_field.Name = "Budget_field";
            this.Budget_field.Size = new System.Drawing.Size(163, 34);
            this.Budget_field.TabIndex = 3;
            this.Budget_field.Value = new decimal(new int[] {
            8800,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(12, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(151, 29);
            this.label3.TabIndex = 4;
            this.label3.Text = "1) Игровой?";
            // 
            // Is_Gaming_field
            // 
            this.Is_Gaming_field.AutoSize = true;
            this.Is_Gaming_field.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Is_Gaming_field.Location = new System.Drawing.Point(459, 85);
            this.Is_Gaming_field.Name = "Is_Gaming_field";
            this.Is_Gaming_field.Size = new System.Drawing.Size(64, 33);
            this.Is_Gaming_field.TabIndex = 5;
            this.Is_Gaming_field.Text = "Да";
            this.Is_Gaming_field.UseVisualStyleBackColor = true;
            // 
            // Is_Portable_field
            // 
            this.Is_Portable_field.AutoSize = true;
            this.Is_Portable_field.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Is_Portable_field.Location = new System.Drawing.Point(459, 129);
            this.Is_Portable_field.Name = "Is_Portable_field";
            this.Is_Portable_field.Size = new System.Drawing.Size(64, 33);
            this.Is_Portable_field.TabIndex = 7;
            this.Is_Portable_field.Text = "Да";
            this.Is_Portable_field.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(12, 125);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(209, 29);
            this.label4.TabIndex = 6;
            this.label4.Text = "2) Портативный?";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(12, 216);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(379, 29);
            this.label5.TabIndex = 8;
            this.label5.Text = "4) Производитель видеокарты: \r\n";
            // 
            // VC_Producer_field
            // 
            this.VC_Producer_field.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.VC_Producer_field.FormattingEnabled = true;
            this.VC_Producer_field.Items.AddRange(new object[] {
            "Не знаю"});
            this.VC_Producer_field.Location = new System.Drawing.Point(397, 213);
            this.VC_Producer_field.Name = "VC_Producer_field";
            this.VC_Producer_field.Size = new System.Drawing.Size(162, 37);
            this.VC_Producer_field.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(12, 256);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(288, 29);
            this.label6.TabIndex = 10;
            this.label6.Text = "5) Объём видеопамяти:\r\n";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(12, 305);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(372, 29);
            this.label7.TabIndex = 12;
            this.label7.Text = "6) Производитель процессора:";
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // Proc_Producer_field
            // 
            this.Proc_Producer_field.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Proc_Producer_field.FormattingEnabled = true;
            this.Proc_Producer_field.Items.AddRange(new object[] {
            "Не знаю"});
            this.Proc_Producer_field.Location = new System.Drawing.Point(396, 302);
            this.Proc_Producer_field.Name = "Proc_Producer_field";
            this.Proc_Producer_field.Size = new System.Drawing.Size(162, 37);
            this.Proc_Producer_field.TabIndex = 13;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(12, 354);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(180, 29);
            this.label8.TabIndex = 14;
            this.label8.Text = "7) Объём ТТН:";
            // 
            // SSD_Memory_field
            // 
            this.SSD_Memory_field.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SSD_Memory_field.FormattingEnabled = true;
            this.SSD_Memory_field.Location = new System.Drawing.Point(396, 354);
            this.SSD_Memory_field.Name = "SSD_Memory_field";
            this.SSD_Memory_field.Size = new System.Drawing.Size(162, 37);
            this.SSD_Memory_field.TabIndex = 15;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(12, 410);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(182, 29);
            this.label9.TabIndex = 16;
            this.label9.Text = "8) Объём ОЗУ:";
            // 
            // RAM_Memory_field
            // 
            this.RAM_Memory_field.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RAM_Memory_field.FormattingEnabled = true;
            this.RAM_Memory_field.Location = new System.Drawing.Point(397, 402);
            this.RAM_Memory_field.Name = "RAM_Memory_field";
            this.RAM_Memory_field.Size = new System.Drawing.Size(162, 37);
            this.RAM_Memory_field.TabIndex = 17;
            // 
            // Start_btn
            // 
            this.Start_btn.BackColor = System.Drawing.Color.LightGreen;
            this.Start_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Start_btn.Location = new System.Drawing.Point(672, 235);
            this.Start_btn.Name = "Start_btn";
            this.Start_btn.Size = new System.Drawing.Size(350, 77);
            this.Start_btn.TabIndex = 26;
            this.Start_btn.Text = "Сформировать конфигурацию";
            this.Start_btn.UseVisualStyleBackColor = false;
            this.Start_btn.Click += new System.EventHandler(this.Start_btn_Click);
            // 
            // Waring_label
            // 
            this.Waring_label.AutoSize = true;
            this.Waring_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Waring_label.ForeColor = System.Drawing.Color.Red;
            this.Waring_label.Location = new System.Drawing.Point(1028, 248);
            this.Waring_label.Name = "Waring_label";
            this.Waring_label.Size = new System.Drawing.Size(474, 40);
            this.Waring_label.TabIndex = 27;
            this.Waring_label.Text = "Сначала ответье на все вопросы, иначе мы не сможем\r\nподобрать подходяющую конфигу" +
    "рацию!";
            this.Waring_label.Visible = false;
            // 
            // VC_Memory_field
            // 
            this.VC_Memory_field.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.VC_Memory_field.FormattingEnabled = true;
            this.VC_Memory_field.Location = new System.Drawing.Point(396, 256);
            this.VC_Memory_field.Name = "VC_Memory_field";
            this.VC_Memory_field.Size = new System.Drawing.Size(162, 37);
            this.VC_Memory_field.TabIndex = 28;
            // 
            // Is_gaming_HINT
            // 
            this.Is_gaming_HINT.AutoSize = true;
            this.Is_gaming_HINT.BackgroundImage = global::PPC.Properties.Resources.question_mark;
            this.Is_gaming_HINT.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Is_gaming_HINT.Location = new System.Drawing.Point(529, 88);
            this.Is_gaming_HINT.Name = "Is_gaming_HINT";
            this.Is_gaming_HINT.Size = new System.Drawing.Size(30, 30);
            this.Is_gaming_HINT.TabIndex = 29;
            this.Is_gaming_HINT.UseVisualStyleBackColor = false;
            // 
            // Is_portable_HINT
            // 
            this.Is_portable_HINT.AutoSize = true;
            this.Is_portable_HINT.BackgroundImage = global::PPC.Properties.Resources.question_mark;
            this.Is_portable_HINT.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Is_portable_HINT.Location = new System.Drawing.Point(529, 133);
            this.Is_portable_HINT.Name = "Is_portable_HINT";
            this.Is_portable_HINT.Size = new System.Drawing.Size(30, 30);
            this.Is_portable_HINT.TabIndex = 30;
            this.Is_portable_HINT.UseVisualStyleBackColor = false;
            // 
            // Budget_HINT
            // 
            this.Budget_HINT.AutoSize = true;
            this.Budget_HINT.BackgroundImage = global::PPC.Properties.Resources.question_mark;
            this.Budget_HINT.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Budget_HINT.Location = new System.Drawing.Point(579, 171);
            this.Budget_HINT.Name = "Budget_HINT";
            this.Budget_HINT.Size = new System.Drawing.Size(30, 30);
            this.Budget_HINT.TabIndex = 31;
            this.Budget_HINT.UseVisualStyleBackColor = false;
            // 
            // VC_producer_HINT
            // 
            this.VC_producer_HINT.AutoSize = true;
            this.VC_producer_HINT.BackgroundImage = global::PPC.Properties.Resources.question_mark;
            this.VC_producer_HINT.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.VC_producer_HINT.Location = new System.Drawing.Point(579, 215);
            this.VC_producer_HINT.Name = "VC_producer_HINT";
            this.VC_producer_HINT.Size = new System.Drawing.Size(30, 30);
            this.VC_producer_HINT.TabIndex = 32;
            this.VC_producer_HINT.UseVisualStyleBackColor = false;
            // 
            // RAM_HINT
            // 
            this.RAM_HINT.AutoSize = true;
            this.RAM_HINT.BackgroundImage = global::PPC.Properties.Resources.question_mark;
            this.RAM_HINT.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.RAM_HINT.Location = new System.Drawing.Point(579, 405);
            this.RAM_HINT.Name = "RAM_HINT";
            this.RAM_HINT.Size = new System.Drawing.Size(30, 30);
            this.RAM_HINT.TabIndex = 33;
            this.RAM_HINT.UseVisualStyleBackColor = false;
            // 
            // SSD_HINT
            // 
            this.SSD_HINT.AutoSize = true;
            this.SSD_HINT.BackgroundImage = global::PPC.Properties.Resources.question_mark;
            this.SSD_HINT.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.SSD_HINT.Location = new System.Drawing.Point(579, 357);
            this.SSD_HINT.Name = "SSD_HINT";
            this.SSD_HINT.Size = new System.Drawing.Size(30, 30);
            this.SSD_HINT.TabIndex = 34;
            this.SSD_HINT.UseVisualStyleBackColor = false;
            // 
            // Proc_producer_HINT
            // 
            this.Proc_producer_HINT.AutoSize = true;
            this.Proc_producer_HINT.BackgroundImage = global::PPC.Properties.Resources.question_mark;
            this.Proc_producer_HINT.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Proc_producer_HINT.Location = new System.Drawing.Point(579, 305);
            this.Proc_producer_HINT.Name = "Proc_producer_HINT";
            this.Proc_producer_HINT.Size = new System.Drawing.Size(30, 30);
            this.Proc_producer_HINT.TabIndex = 35;
            this.Proc_producer_HINT.UseVisualStyleBackColor = false;
            // 
            // VC_memory_HINT
            // 
            this.VC_memory_HINT.AutoSize = true;
            this.VC_memory_HINT.BackgroundImage = global::PPC.Properties.Resources.question_mark;
            this.VC_memory_HINT.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.VC_memory_HINT.Location = new System.Drawing.Point(579, 259);
            this.VC_memory_HINT.Name = "VC_memory_HINT";
            this.VC_memory_HINT.Size = new System.Drawing.Size(30, 30);
            this.VC_memory_HINT.TabIndex = 36;
            this.VC_memory_HINT.UseVisualStyleBackColor = false;
            // 
            // Exit_btn
            // 
            this.Exit_btn.BackColor = System.Drawing.Color.Red;
            this.Exit_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Exit_btn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Exit_btn.Location = new System.Drawing.Point(1519, 1);
            this.Exit_btn.Name = "Exit_btn";
            this.Exit_btn.Size = new System.Drawing.Size(60, 56);
            this.Exit_btn.TabIndex = 37;
            this.Exit_btn.Text = "X";
            this.Exit_btn.UseVisualStyleBackColor = false;
            this.Exit_btn.Click += new System.EventHandler(this.Exit_btn_Click);
            // 
            // Anketa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1582, 977);
            this.Controls.Add(this.Exit_btn);
            this.Controls.Add(this.VC_memory_HINT);
            this.Controls.Add(this.Proc_producer_HINT);
            this.Controls.Add(this.SSD_HINT);
            this.Controls.Add(this.RAM_HINT);
            this.Controls.Add(this.VC_producer_HINT);
            this.Controls.Add(this.Budget_HINT);
            this.Controls.Add(this.Is_portable_HINT);
            this.Controls.Add(this.Is_gaming_HINT);
            this.Controls.Add(this.VC_Memory_field);
            this.Controls.Add(this.Waring_label);
            this.Controls.Add(this.Start_btn);
            this.Controls.Add(this.RAM_Memory_field);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.SSD_Memory_field);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.Proc_Producer_field);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.VC_Producer_field);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Is_Portable_field);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Is_Gaming_field);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Budget_field);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Anketa";
            this.Text = "Anketa";
            ((System.ComponentModel.ISupportInitialize)(this.Budget_field)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown Budget_field;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox Is_Gaming_field;
        private System.Windows.Forms.CheckBox Is_Portable_field;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox VC_Producer_field;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private System.Windows.Forms.ComboBox Proc_Producer_field;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox SSD_Memory_field;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox RAM_Memory_field;
        private System.Windows.Forms.Label Waring_label;
        private System.Windows.Forms.Button Start_btn;
        private System.Windows.Forms.ComboBox VC_Memory_field;
        private System.Windows.Forms.Button Is_gaming_HINT;
        private System.Windows.Forms.Button Is_portable_HINT;
        private System.Windows.Forms.Button VC_memory_HINT;
        private System.Windows.Forms.Button Proc_producer_HINT;
        private System.Windows.Forms.Button SSD_HINT;
        private System.Windows.Forms.Button RAM_HINT;
        private System.Windows.Forms.Button VC_producer_HINT;
        private System.Windows.Forms.Button Budget_HINT;
        private System.Windows.Forms.Button Exit_btn;
    }
}