
namespace SM._931802.Komarov.Lab16
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.label1 = new System.Windows.Forms.Label();
            this.rubles = new System.Windows.Forms.Label();
            this.dollars = new System.Windows.Forms.Label();
            this.Start = new System.Windows.Forms.Button();
            this.cur = new System.Windows.Forms.NumericUpDown();
            this.days = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.number = new System.Windows.Forms.NumericUpDown();
            this.sell = new System.Windows.Forms.Button();
            this.buy = new System.Windows.Forms.Button();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.cur)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.days)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.number)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Currency";
            // 
            // rubles
            // 
            this.rubles.AutoSize = true;
            this.rubles.Location = new System.Drawing.Point(629, 32);
            this.rubles.Name = "rubles";
            this.rubles.Size = new System.Drawing.Size(77, 17);
            this.rubles.TabIndex = 4;
            this.rubles.Text = "RUB: 1000";
            // 
            // dollars
            // 
            this.dollars.AutoSize = true;
            this.dollars.Location = new System.Drawing.Point(629, 68);
            this.dollars.Name = "dollars";
            this.dollars.Size = new System.Drawing.Size(53, 17);
            this.dollars.TabIndex = 5;
            this.dollars.Text = "USD: 0";
            // 
            // Start
            // 
            this.Start.Location = new System.Drawing.Point(237, 27);
            this.Start.Name = "Start";
            this.Start.Size = new System.Drawing.Size(100, 61);
            this.Start.TabIndex = 6;
            this.Start.Text = "Start";
            this.Start.UseVisualStyleBackColor = true;
            this.Start.Click += new System.EventHandler(this.Start_Click);
            // 
            // cur
            // 
            this.cur.DecimalPlaces = 2;
            this.cur.Location = new System.Drawing.Point(100, 27);
            this.cur.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.cur.Name = "cur";
            this.cur.Size = new System.Drawing.Size(120, 22);
            this.cur.TabIndex = 9;
            this.cur.Value = new decimal(new int[] {
            7433,
            0,
            0,
            131072});
            // 
            // days
            // 
            this.days.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.days.Location = new System.Drawing.Point(100, 63);
            this.days.Name = "days";
            this.days.Size = new System.Drawing.Size(120, 22);
            this.days.TabIndex = 10;
            this.days.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 65);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 17);
            this.label4.TabIndex = 11;
            this.label4.Text = "Days";
            // 
            // number
            // 
            this.number.Location = new System.Drawing.Point(407, 27);
            this.number.Name = "number";
            this.number.Size = new System.Drawing.Size(194, 22);
            this.number.TabIndex = 12;
            // 
            // sell
            // 
            this.sell.Location = new System.Drawing.Point(407, 55);
            this.sell.Name = "sell";
            this.sell.Size = new System.Drawing.Size(94, 33);
            this.sell.TabIndex = 13;
            this.sell.Text = "Sell";
            this.sell.UseVisualStyleBackColor = true;
            this.sell.Click += new System.EventHandler(this.sell_Click);
            // 
            // buy
            // 
            this.buy.Location = new System.Drawing.Point(507, 55);
            this.buy.Name = "buy";
            this.buy.Size = new System.Drawing.Size(94, 33);
            this.buy.TabIndex = 14;
            this.buy.Text = "Buy";
            this.buy.UseVisualStyleBackColor = true;
            this.buy.Click += new System.EventHandler(this.buy_Click);
            // 
            // chart1
            // 
            chartArea3.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.chart1.Legends.Add(legend3);
            this.chart1.Location = new System.Drawing.Point(32, 107);
            this.chart1.Name = "chart1";
            series3.BorderWidth = 2;
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series3.IsValueShownAsLabel = true;
            series3.LabelFormat = "F2";
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            this.chart1.Series.Add(series3);
            this.chart1.Size = new System.Drawing.Size(935, 491);
            this.chart1.TabIndex = 15;
            this.chart1.Text = "chart1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1017, 631);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.buy);
            this.Controls.Add(this.sell);
            this.Controls.Add(this.number);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.days);
            this.Controls.Add(this.cur);
            this.Controls.Add(this.Start);
            this.Controls.Add(this.dollars);
            this.Controls.Add(this.rubles);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.cur)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.days)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.number)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label rubles;
        private System.Windows.Forms.Label dollars;
        private System.Windows.Forms.Button Start;
        private System.Windows.Forms.NumericUpDown cur;
        private System.Windows.Forms.NumericUpDown days;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown number;
        private System.Windows.Forms.Button sell;
        private System.Windows.Forms.Button buy;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
    }
}

