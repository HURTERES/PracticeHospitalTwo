namespace PracticeHospitalKov
{
    partial class Form1
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
            this.BtnShowRows = new System.Windows.Forms.Button();
            this.BtnAddRow = new System.Windows.Forms.Button();
            this.BtnShowStatistic = new System.Windows.Forms.Button();
            this.BtnUsedFormulas = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.Green;
            this.label1.Location = new System.Drawing.Point(171, 24);
            this.label1.Margin = new System.Windows.Forms.Padding(0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(485, 42);
            this.label1.TabIndex = 1;
            this.label1.Text = "ГБУЗ Новозыбковская ЦРБ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BtnShowRows
            // 
            this.BtnShowRows.BackColor = System.Drawing.Color.Green;
            this.BtnShowRows.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BtnShowRows.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.BtnShowRows.FlatAppearance.BorderSize = 0;
            this.BtnShowRows.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.BtnShowRows.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnShowRows.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BtnShowRows.ForeColor = System.Drawing.Color.White;
            this.BtnShowRows.Location = new System.Drawing.Point(204, 109);
            this.BtnShowRows.Name = "BtnShowRows";
            this.BtnShowRows.Size = new System.Drawing.Size(452, 47);
            this.BtnShowRows.TabIndex = 72;
            this.BtnShowRows.Text = "📝 Просмотр записей пациентов";
            this.BtnShowRows.UseVisualStyleBackColor = false;
            this.BtnShowRows.Click += new System.EventHandler(this.BtnComplete_Click);
            // 
            // BtnAddRow
            // 
            this.BtnAddRow.BackColor = System.Drawing.Color.Green;
            this.BtnAddRow.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BtnAddRow.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.BtnAddRow.FlatAppearance.BorderSize = 0;
            this.BtnAddRow.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.BtnAddRow.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnAddRow.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BtnAddRow.ForeColor = System.Drawing.Color.White;
            this.BtnAddRow.Location = new System.Drawing.Point(204, 181);
            this.BtnAddRow.Name = "BtnAddRow";
            this.BtnAddRow.Size = new System.Drawing.Size(452, 47);
            this.BtnAddRow.TabIndex = 73;
            this.BtnAddRow.Text = "✎ Добавить запись в таблицу";
            this.BtnAddRow.UseVisualStyleBackColor = false;
            this.BtnAddRow.Click += new System.EventHandler(this.button1_Click);
            // 
            // BtnShowStatistic
            // 
            this.BtnShowStatistic.BackColor = System.Drawing.Color.Green;
            this.BtnShowStatistic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BtnShowStatistic.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.BtnShowStatistic.FlatAppearance.BorderSize = 0;
            this.BtnShowStatistic.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.BtnShowStatistic.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnShowStatistic.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BtnShowStatistic.ForeColor = System.Drawing.Color.White;
            this.BtnShowStatistic.Location = new System.Drawing.Point(204, 251);
            this.BtnShowStatistic.Name = "BtnShowStatistic";
            this.BtnShowStatistic.Size = new System.Drawing.Size(452, 47);
            this.BtnShowStatistic.TabIndex = 74;
            this.BtnShowStatistic.Text = "📜 Статистика работы системы";
            this.BtnShowStatistic.UseVisualStyleBackColor = false;
            this.BtnShowStatistic.Click += new System.EventHandler(this.BtnShowStatistic_Click);
            // 
            // BtnUsedFormulas
            // 
            this.BtnUsedFormulas.BackColor = System.Drawing.Color.Green;
            this.BtnUsedFormulas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BtnUsedFormulas.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.BtnUsedFormulas.FlatAppearance.BorderSize = 0;
            this.BtnUsedFormulas.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.BtnUsedFormulas.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnUsedFormulas.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BtnUsedFormulas.ForeColor = System.Drawing.Color.White;
            this.BtnUsedFormulas.Location = new System.Drawing.Point(204, 321);
            this.BtnUsedFormulas.Name = "BtnUsedFormulas";
            this.BtnUsedFormulas.Size = new System.Drawing.Size(452, 47);
            this.BtnUsedFormulas.TabIndex = 75;
            this.BtnUsedFormulas.Text = "📐 Используемые формулы";
            this.BtnUsedFormulas.UseVisualStyleBackColor = false;
            this.BtnUsedFormulas.Click += new System.EventHandler(this.BtnUsedFormulas_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.Green;
            this.label2.Location = new System.Drawing.Point(9, 464);
            this.label2.Margin = new System.Windows.Forms.Padding(0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(429, 42);
            this.label2.TabIndex = 76;
            this.label2.Text = "Панель администратора";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::PracticeHospitalKov.Properties.Resources.HospitalLogo1;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(156, 144);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Green;
            this.panel1.Location = new System.Drawing.Point(17, 459);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(643, 2);
            this.panel1.TabIndex = 77;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Green;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(204, 391);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(452, 47);
            this.button1.TabIndex = 78;
            this.button1.Text = "Руководство пользователя";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(240)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(687, 515);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BtnUsedFormulas);
            this.Controls.Add(this.BtnShowStatistic);
            this.Controls.Add(this.BtnAddRow);
            this.Controls.Add(this.BtnShowRows);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "🧪 ГБУЗ Новозыбковская ЦРБ";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Shown += new System.EventHandler(this.Form1_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnShowRows;
        private System.Windows.Forms.Button BtnAddRow;
        private System.Windows.Forms.Button BtnShowStatistic;
        private System.Windows.Forms.Button BtnUsedFormulas;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
    }
}

