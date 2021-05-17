namespace lab13
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.paramLabel = new System.Windows.Forms.Label();
            this.paramNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.numberOfExperimentsLabel = new System.Windows.Forms.Label();
            this.numberOfExperimentsNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.startButton = new System.Windows.Forms.Button();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.averageLabel = new System.Windows.Forms.Label();
            this.varianceLabel = new System.Windows.Forms.Label();
            this.chiLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.paramNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numberOfExperimentsNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // paramLabel
            // 
            this.paramLabel.AutoSize = true;
            this.paramLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.paramLabel.Location = new System.Drawing.Point(25, 41);
            this.paramLabel.Name = "paramLabel";
            this.paramLabel.Size = new System.Drawing.Size(64, 24);
            this.paramLabel.TabIndex = 0;
            this.paramLabel.Text = "Param";
            // 
            // paramNumericUpDown
            // 
            this.paramNumericUpDown.DecimalPlaces = 3;
            this.paramNumericUpDown.Location = new System.Drawing.Point(134, 47);
            this.paramNumericUpDown.Name = "paramNumericUpDown";
            this.paramNumericUpDown.Size = new System.Drawing.Size(120, 20);
            this.paramNumericUpDown.TabIndex = 2;
            this.paramNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // numberOfExperimentsLabel
            // 
            this.numberOfExperimentsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numberOfExperimentsLabel.Location = new System.Drawing.Point(12, 86);
            this.numberOfExperimentsLabel.Name = "numberOfExperimentsLabel";
            this.numberOfExperimentsLabel.Size = new System.Drawing.Size(116, 57);
            this.numberOfExperimentsLabel.TabIndex = 3;
            this.numberOfExperimentsLabel.Text = "Number of experiments";
            // 
            // numberOfExperimentsNumericUpDown
            // 
            this.numberOfExperimentsNumericUpDown.Location = new System.Drawing.Point(134, 111);
            this.numberOfExperimentsNumericUpDown.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numberOfExperimentsNumericUpDown.Name = "numberOfExperimentsNumericUpDown";
            this.numberOfExperimentsNumericUpDown.Size = new System.Drawing.Size(120, 20);
            this.numberOfExperimentsNumericUpDown.TabIndex = 4;
            this.numberOfExperimentsNumericUpDown.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // startButton
            // 
            this.startButton.Location = new System.Drawing.Point(29, 167);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(75, 23);
            this.startButton.TabIndex = 5;
            this.startButton.Text = "Start";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // chart1
            // 
            chartArea2.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chart1.Legends.Add(legend2);
            this.chart1.Location = new System.Drawing.Point(284, 41);
            this.chart1.Name = "chart1";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chart1.Series.Add(series2);
            this.chart1.Size = new System.Drawing.Size(647, 300);
            this.chart1.TabIndex = 6;
            this.chart1.Text = "chart1";
            // 
            // averageLabel
            // 
            this.averageLabel.AutoSize = true;
            this.averageLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.averageLabel.Location = new System.Drawing.Point(290, 359);
            this.averageLabel.Name = "averageLabel";
            this.averageLabel.Size = new System.Drawing.Size(72, 20);
            this.averageLabel.TabIndex = 7;
            this.averageLabel.Text = "Average:";
            // 
            // varianceLabel
            // 
            this.varianceLabel.AutoSize = true;
            this.varianceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.varianceLabel.Location = new System.Drawing.Point(290, 388);
            this.varianceLabel.Name = "varianceLabel";
            this.varianceLabel.Size = new System.Drawing.Size(76, 20);
            this.varianceLabel.TabIndex = 8;
            this.varianceLabel.Text = "Variance:";
            // 
            // chiLabel
            // 
            this.chiLabel.AutoSize = true;
            this.chiLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.chiLabel.Location = new System.Drawing.Point(290, 417);
            this.chiLabel.Name = "chiLabel";
            this.chiLabel.Size = new System.Drawing.Size(99, 20);
            this.chiLabel.TabIndex = 9;
            this.chiLabel.Text = "Chi-squared:";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 359);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(266, 95);
            this.label1.TabIndex = 10;
            this.label1.Text = "Вывод: при увеличении числа экспериментов эмпирическое распредленеие стремится к " +
    "теоретическому";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(943, 471);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.chiLabel);
            this.Controls.Add(this.varianceLabel);
            this.Controls.Add(this.averageLabel);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.numberOfExperimentsNumericUpDown);
            this.Controls.Add(this.numberOfExperimentsLabel);
            this.Controls.Add(this.paramNumericUpDown);
            this.Controls.Add(this.paramLabel);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.paramNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numberOfExperimentsNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label paramLabel;
        private System.Windows.Forms.NumericUpDown paramNumericUpDown;
        private System.Windows.Forms.Label numberOfExperimentsLabel;
        private System.Windows.Forms.NumericUpDown numberOfExperimentsNumericUpDown;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Label averageLabel;
        private System.Windows.Forms.Label varianceLabel;
        private System.Windows.Forms.Label chiLabel;
        private System.Windows.Forms.Label label1;
    }
}

