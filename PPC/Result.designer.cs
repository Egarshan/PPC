namespace WindowsFormsApp1
{
    partial class Result
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
            this.VC_text = new System.Windows.Forms.Label();
            this.Proc_text = new System.Windows.Forms.Label();
            this.SSD_text = new System.Windows.Forms.Label();
            this.RAM_text = new System.Windows.Forms.Label();
            this.Price_text = new System.Windows.Forms.Label();
            this.Type_text = new System.Windows.Forms.Label();
            this.Exit_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1382, 68);
            this.label1.TabIndex = 2;
            this.label1.Text = "Ваша конфигурация готова!";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // VC_text
            // 
            this.VC_text.AutoSize = true;
            this.VC_text.BackColor = System.Drawing.Color.Transparent;
            this.VC_text.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.VC_text.Location = new System.Drawing.Point(33, 136);
            this.VC_text.Name = "VC_text";
            this.VC_text.Size = new System.Drawing.Size(162, 29);
            this.VC_text.TabIndex = 5;
            this.VC_text.Text = "Видеокарта: ";
            // 
            // Proc_text
            // 
            this.Proc_text.AutoSize = true;
            this.Proc_text.BackColor = System.Drawing.Color.Transparent;
            this.Proc_text.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Proc_text.Location = new System.Drawing.Point(33, 176);
            this.Proc_text.Name = "Proc_text";
            this.Proc_text.Size = new System.Drawing.Size(151, 29);
            this.Proc_text.TabIndex = 6;
            this.Proc_text.Text = "Процессор: ";
            // 
            // SSD_text
            // 
            this.SSD_text.AutoSize = true;
            this.SSD_text.BackColor = System.Drawing.Color.Transparent;
            this.SSD_text.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SSD_text.Location = new System.Drawing.Point(33, 215);
            this.SSD_text.Name = "SSD_text";
            this.SSD_text.Size = new System.Drawing.Size(74, 29);
            this.SSD_text.TabIndex = 7;
            this.SSD_text.Text = "ТТН: ";
            // 
            // RAM_text
            // 
            this.RAM_text.AutoSize = true;
            this.RAM_text.BackColor = System.Drawing.Color.Transparent;
            this.RAM_text.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RAM_text.Location = new System.Drawing.Point(33, 253);
            this.RAM_text.Name = "RAM_text";
            this.RAM_text.Size = new System.Drawing.Size(76, 29);
            this.RAM_text.TabIndex = 8;
            this.RAM_text.Text = "ОЗУ: ";
            // 
            // Price_text
            // 
            this.Price_text.AutoSize = true;
            this.Price_text.BackColor = System.Drawing.Color.Transparent;
            this.Price_text.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Price_text.ForeColor = System.Drawing.Color.ForestGreen;
            this.Price_text.Location = new System.Drawing.Point(33, 328);
            this.Price_text.Name = "Price_text";
            this.Price_text.Size = new System.Drawing.Size(326, 29);
            this.Price_text.TabIndex = 9;
            this.Price_text.Text = "Стоимость конфигурации: ";
            // 
            // Type_text
            // 
            this.Type_text.AutoSize = true;
            this.Type_text.BackColor = System.Drawing.Color.Transparent;
            this.Type_text.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Type_text.Location = new System.Drawing.Point(33, 97);
            this.Type_text.Name = "Type_text";
            this.Type_text.Size = new System.Drawing.Size(110, 29);
            this.Type_text.TabIndex = 10;
            this.Type_text.Text = "Тип ПК: ";
            // 
            // Exit_btn
            // 
            this.Exit_btn.BackColor = System.Drawing.Color.Red;
            this.Exit_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Exit_btn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Exit_btn.Location = new System.Drawing.Point(1320, 1);
            this.Exit_btn.Name = "Exit_btn";
            this.Exit_btn.Size = new System.Drawing.Size(60, 56);
            this.Exit_btn.TabIndex = 11;
            this.Exit_btn.Text = "X";
            this.Exit_btn.UseVisualStyleBackColor = false;
            this.Exit_btn.Click += new System.EventHandler(this.Exit_btn_Click);
            // 
            // Result
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::PPC.Properties.Resources.prisma_background_vector;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1382, 653);
            this.Controls.Add(this.Exit_btn);
            this.Controls.Add(this.Type_text);
            this.Controls.Add(this.Price_text);
            this.Controls.Add(this.RAM_text);
            this.Controls.Add(this.SSD_text);
            this.Controls.Add(this.Proc_text);
            this.Controls.Add(this.VC_text);
            this.Controls.Add(this.label1);
            this.Name = "Result";
            this.Text = "PPC - Result";
            this.Load += new System.EventHandler(this.Result_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label VC_text;
        private System.Windows.Forms.Label Proc_text;
        private System.Windows.Forms.Label SSD_text;
        private System.Windows.Forms.Label RAM_text;
        private System.Windows.Forms.Label Price_text;
        private System.Windows.Forms.Label Type_text;
        private System.Windows.Forms.Button Exit_btn;
    }
}