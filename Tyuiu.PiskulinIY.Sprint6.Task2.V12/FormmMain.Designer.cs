namespace Tyuiu.PiskulinIY.Sprint6.Task2.V12
{
    partial class FormmMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            textBox1 = new TextBox();
            buttonResult = new Button();
            textBoxYslovie = new TextBox();
            textBoxEndShag = new TextBox();
            textBoxStart = new TextBox();
            textBoxStop = new TextBox();
            textBoxStartShag = new TextBox();
            textBox7 = new TextBox();
            dataGridViewRows = new DataGridView();
            X = new DataGridViewTextBoxColumn();
            Y = new DataGridViewTextBoxColumn();
            chartFunction = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)dataGridViewRows).BeginInit();
            ((System.ComponentModel.ISupportInitialize)chartFunction).BeginInit();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(12, 41);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(282, 127);
            textBox1.TabIndex = 0;
            textBox1.Text = "Произвести тамбулирование выражения";
            // 
            // buttonResult
            // 
            buttonResult.Location = new Point(116, 366);
            buttonResult.Name = "buttonResult";
            buttonResult.Size = new Size(178, 72);
            buttonResult.TabIndex = 1;
            buttonResult.Text = "Выполнить";
            buttonResult.UseVisualStyleBackColor = true;
            buttonResult.Click += buttonResult_Click;
            // 
            // textBoxYslovie
            // 
            textBoxYslovie.Location = new Point(12, 12);
            textBoxYslovie.Name = "textBoxYslovie";
            textBoxYslovie.ReadOnly = true;
            textBoxYslovie.Size = new Size(100, 23);
            textBoxYslovie.TabIndex = 2;
            textBoxYslovie.Text = "Условие";
            // 
            // textBoxEndShag
            // 
            textBoxEndShag.Location = new Point(194, 203);
            textBoxEndShag.Name = "textBoxEndShag";
            textBoxEndShag.ReadOnly = true;
            textBoxEndShag.Size = new Size(100, 23);
            textBoxEndShag.TabIndex = 3;
            textBoxEndShag.Text = "Конец Шага";
            // 
            // textBoxStart
            // 
            textBoxStart.Location = new Point(12, 232);
            textBoxStart.Name = "textBoxStart";
            textBoxStart.Size = new Size(100, 23);
            textBoxStart.TabIndex = 4;
            textBoxStart.Text = "-5";
            // 
            // textBoxStop
            // 
            textBoxStop.Location = new Point(194, 232);
            textBoxStop.Name = "textBoxStop";
            textBoxStop.Size = new Size(100, 23);
            textBoxStop.TabIndex = 5;
            textBoxStop.Text = "5";
            // 
            // textBoxStartShag
            // 
            textBoxStartShag.Location = new Point(12, 203);
            textBoxStartShag.Name = "textBoxStartShag";
            textBoxStartShag.ReadOnly = true;
            textBoxStartShag.Size = new Size(100, 23);
            textBoxStartShag.TabIndex = 6;
            textBoxStartShag.Text = "Начало шага";
            textBoxStartShag.TextChanged += textBox6_TextChanged;
            // 
            // textBox7
            // 
            textBox7.Location = new Point(12, 174);
            textBox7.Name = "textBox7";
            textBox7.ReadOnly = true;
            textBox7.Size = new Size(100, 23);
            textBox7.TabIndex = 7;
            textBox7.Text = "Ввод Данных";
            textBox7.TextChanged += textBox7_TextChanged;
            // 
            // dataGridViewRows
            // 
            dataGridViewRows.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewRows.Columns.AddRange(new DataGridViewColumn[] { X, Y });
            dataGridViewRows.Location = new Point(300, 41);
            dataGridViewRows.Name = "dataGridViewRows";
            dataGridViewRows.ReadOnly = true;
            dataGridViewRows.RowHeadersVisible = false;
            dataGridViewRows.Size = new Size(206, 397);
            dataGridViewRows.TabIndex = 9;
            // 
            // X
            // 
            X.HeaderText = "X";
            X.Name = "X";
            X.ReadOnly = true;
            // 
            // Y
            // 
            Y.HeaderText = "F(X)";
            Y.Name = "Y";
            Y.ReadOnly = true;
            // 
            // chartFunction
            // 
            chartArea2.Name = "ChartArea1";
            chartFunction.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            chartFunction.Legends.Add(legend2);
            chartFunction.Location = new Point(512, 41);
            chartFunction.Name = "chartFunction";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series2.IsVisibleInLegend = false;
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            chartFunction.Series.Add(series2);
            chartFunction.Size = new Size(620, 397);
            chartFunction.TabIndex = 10;
            chartFunction.Text = "chartX";
            // 
            // FormmMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(968, 450);
            Controls.Add(chartFunction);
            Controls.Add(dataGridViewRows);
            Controls.Add(textBox7);
            Controls.Add(textBoxStartShag);
            Controls.Add(textBoxStop);
            Controls.Add(textBoxStart);
            Controls.Add(textBoxEndShag);
            Controls.Add(textBoxYslovie);
            Controls.Add(buttonResult);
            Controls.Add(textBox1);
            Name = "FormmMain";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridViewRows).EndInit();
            ((System.ComponentModel.ISupportInitialize)chartFunction).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private Button buttonResult;
        private TextBox textBoxYslovie;
        private TextBox textBoxEndShag;
        private TextBox textBoxStart;
        private TextBox textBoxStop;
        private TextBox textBoxStartShag;
        private TextBox textBox7;
        private DataGridView dataGridViewRows;
        private DataGridViewTextBoxColumn X;
        private DataGridViewTextBoxColumn Y;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartFunction;
    }
}
