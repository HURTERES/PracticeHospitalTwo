namespace PracticeHospitalKov
{
    partial class FormStatistics
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            this.PanelStatistics = new System.Windows.Forms.Panel();
            this.BtnAddRow = new System.Windows.Forms.Button();
            this.Chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.LblIntensObluz = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.LblSrednNahodVSist = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.LblSrednDlinaOcheredi = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.LblNahodVSisteme = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.LblIntensivnost = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.PanelFormulas = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.PanelStatistics.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Chart)).BeginInit();
            this.PanelFormulas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // PanelStatistics
            // 
            this.PanelStatistics.Controls.Add(this.BtnAddRow);
            this.PanelStatistics.Controls.Add(this.Chart);
            this.PanelStatistics.Controls.Add(this.LblIntensObluz);
            this.PanelStatistics.Controls.Add(this.label9);
            this.PanelStatistics.Controls.Add(this.LblSrednNahodVSist);
            this.PanelStatistics.Controls.Add(this.label7);
            this.PanelStatistics.Controls.Add(this.LblSrednDlinaOcheredi);
            this.PanelStatistics.Controls.Add(this.label6);
            this.PanelStatistics.Controls.Add(this.LblNahodVSisteme);
            this.PanelStatistics.Controls.Add(this.label5);
            this.PanelStatistics.Controls.Add(this.LblIntensivnost);
            this.PanelStatistics.Controls.Add(this.label3);
            this.PanelStatistics.Controls.Add(this.label2);
            this.PanelStatistics.Controls.Add(this.label1);
            this.PanelStatistics.Location = new System.Drawing.Point(12, 56);
            this.PanelStatistics.Name = "PanelStatistics";
            this.PanelStatistics.Size = new System.Drawing.Size(1000, 349);
            this.PanelStatistics.TabIndex = 0;
            // 
            // BtnAddRow
            // 
            this.BtnAddRow.BackColor = System.Drawing.Color.SeaGreen;
            this.BtnAddRow.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BtnAddRow.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.BtnAddRow.FlatAppearance.BorderSize = 0;
            this.BtnAddRow.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.BtnAddRow.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnAddRow.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BtnAddRow.ForeColor = System.Drawing.Color.White;
            this.BtnAddRow.Location = new System.Drawing.Point(48, 287);
            this.BtnAddRow.Name = "BtnAddRow";
            this.BtnAddRow.Size = new System.Drawing.Size(452, 47);
            this.BtnAddRow.TabIndex = 74;
            this.BtnAddRow.Text = "✎ Записать данные в документ";
            this.BtnAddRow.UseVisualStyleBackColor = false;
            this.BtnAddRow.Click += new System.EventHandler(this.BtnAddRow_Click);
            // 
            // Chart
            // 
            chartArea1.Name = "ChartArea1";
            this.Chart.ChartAreas.Add(chartArea1);
            this.Chart.Location = new System.Drawing.Point(580, 3);
            this.Chart.Name = "Chart";
            this.Chart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SeaGreen;
            this.Chart.Size = new System.Drawing.Size(417, 331);
            this.Chart.TabIndex = 27;
            this.Chart.Text = "chart1";
            // 
            // LblIntensObluz
            // 
            this.LblIntensObluz.AutoSize = true;
            this.LblIntensObluz.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LblIntensObluz.Location = new System.Drawing.Point(451, 159);
            this.LblIntensObluz.Name = "LblIntensObluz";
            this.LblIntensObluz.Size = new System.Drawing.Size(54, 25);
            this.LblIntensObluz.TabIndex = 26;
            this.LblIntensObluz.Text = "XXX";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(44, 159);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(318, 25);
            this.label9.TabIndex = 25;
            this.label9.Text = "Интенсивность обслуживания:";
            // 
            // LblSrednNahodVSist
            // 
            this.LblSrednNahodVSist.AutoSize = true;
            this.LblSrednNahodVSist.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LblSrednNahodVSist.Location = new System.Drawing.Point(450, 234);
            this.LblSrednNahodVSist.Name = "LblSrednNahodVSist";
            this.LblSrednNahodVSist.Size = new System.Drawing.Size(54, 25);
            this.LblSrednNahodVSist.TabIndex = 24;
            this.LblSrednNahodVSist.Text = "XXX";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(43, 234);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(405, 25);
            this.label7.TabIndex = 23;
            this.label7.Text = "Среднее время нахождения в системе:";
            // 
            // LblSrednDlinaOcheredi
            // 
            this.LblSrednDlinaOcheredi.AutoSize = true;
            this.LblSrednDlinaOcheredi.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LblSrednDlinaOcheredi.Location = new System.Drawing.Point(450, 196);
            this.LblSrednDlinaOcheredi.Name = "LblSrednDlinaOcheredi";
            this.LblSrednDlinaOcheredi.Size = new System.Drawing.Size(54, 25);
            this.LblSrednDlinaOcheredi.TabIndex = 22;
            this.LblSrednDlinaOcheredi.Text = "XXX";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(43, 196);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(356, 25);
            this.label6.TabIndex = 21;
            this.label6.Text = "Среднее кол-во заявок в очереди:";
            // 
            // LblNahodVSisteme
            // 
            this.LblNahodVSisteme.AutoSize = true;
            this.LblNahodVSisteme.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LblNahodVSisteme.Location = new System.Drawing.Point(450, 123);
            this.LblNahodVSisteme.Name = "LblNahodVSisteme";
            this.LblNahodVSisteme.Size = new System.Drawing.Size(54, 25);
            this.LblNahodVSisteme.TabIndex = 20;
            this.LblNahodVSisteme.Text = "XXX";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(43, 123);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(349, 25);
            this.label5.TabIndex = 19;
            this.label5.Text = "Среднее число заявок в системе:";
            // 
            // LblIntensivnost
            // 
            this.LblIntensivnost.AutoSize = true;
            this.LblIntensivnost.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LblIntensivnost.Location = new System.Drawing.Point(451, 86);
            this.LblIntensivnost.Name = "LblIntensivnost";
            this.LblIntensivnost.Size = new System.Drawing.Size(54, 25);
            this.LblIntensivnost.TabIndex = 18;
            this.LblIntensivnost.Text = "XXX";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(44, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(244, 25);
            this.label3.TabIndex = 17;
            this.label3.Text = "Интенсивность потока:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(43, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(488, 25);
            this.label2.TabIndex = 16;
            this.label2.Text = "Время обслуживания заявки:                   15 мин";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(44, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(501, 25);
            this.label1.TabIndex = 15;
            this.label1.Text = "Пропускная способность:                         20 чел/ч";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.Color.SeaGreen;
            this.label4.Location = new System.Drawing.Point(81, 11);
            this.label4.Margin = new System.Windows.Forms.Padding(0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(863, 42);
            this.label4.TabIndex = 28;
            this.label4.Text = "СМО вида М/М/1 для ГБУЗ Новозыбковская ЦРБ";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PanelFormulas
            // 
            this.PanelFormulas.Controls.Add(this.label8);
            this.PanelFormulas.Controls.Add(this.pictureBox1);
            this.PanelFormulas.Location = new System.Drawing.Point(40, 13);
            this.PanelFormulas.Name = "PanelFormulas";
            this.PanelFormulas.Size = new System.Drawing.Size(942, 392);
            this.PanelFormulas.TabIndex = 75;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(844, 249);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(61, 42);
            this.label8.TabIndex = 1;
            this.label8.Text = "🤯";
            this.label8.MouseEnter += new System.EventHandler(this.label8_MouseEnter);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::PracticeHospitalKov.Properties.Resources.FormulasMM1;
            this.pictureBox1.Location = new System.Drawing.Point(12, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(920, 371);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // ToolTip
            // 
            this.ToolTip.AutomaticDelay = 50000;
            // 
            // FormStatistics
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1024, 416);
            this.Controls.Add(this.PanelFormulas);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.PanelStatistics);
            this.Name = "FormStatistics";
            this.ShowIcon = false;
            this.Text = "🧪 ГБУЗ Новозыбковская ЦРБ";
            this.Load += new System.EventHandler(this.FormStatistics_Load);
            this.PanelStatistics.ResumeLayout(false);
            this.PanelStatistics.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Chart)).EndInit();
            this.PanelFormulas.ResumeLayout(false);
            this.PanelFormulas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label LblIntensObluz;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label LblSrednNahodVSist;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label LblSrednDlinaOcheredi;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label LblNahodVSisteme;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label LblIntensivnost;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataVisualization.Charting.Chart Chart;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button BtnAddRow;
        public System.Windows.Forms.Panel PanelStatistics;
        private System.Windows.Forms.PictureBox pictureBox1;
        public System.Windows.Forms.Panel PanelFormulas;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ToolTip ToolTip;
    }
}