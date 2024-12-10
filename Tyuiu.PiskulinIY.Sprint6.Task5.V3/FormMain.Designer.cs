using Tyuiu.PiskulinIY.Sprint6.Task5.V3.Lib;
namespace Tyuiu.PiskulinIY.Sprint6.Task5.V3
{
    partial class FormMain
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            textBoxYslovie = new TextBox();
            textBox2 = new TextBox();
            textBoxVivod = new TextBox();
            buttonResult = new Button();
            buttonOpenFile = new Button();
            chartFunction = new System.Windows.Forms.DataVisualization.Charting.Chart();
            dataGridViewResult = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)chartFunction).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewResult).BeginInit();
            SuspendLayout();
            // 
            // textBoxYslovie
            // 
            textBoxYslovie.Location = new Point(12, 12);
            textBoxYslovie.Name = "textBoxYslovie";
            textBoxYslovie.ReadOnly = true;
            textBoxYslovie.Size = new Size(100, 23);
            textBoxYslovie.TabIndex = 0;
            textBoxYslovie.Text = "Условие";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(12, 41);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.ReadOnly = true;
            textBox2.Size = new Size(289, 62);
            textBox2.TabIndex = 1;
            textBox2.Text = "Прочитать данные из файла вывести по условию";
            // 
            // textBoxVivod
            // 
            textBoxVivod.Location = new Point(12, 109);
            textBoxVivod.Name = "textBoxVivod";
            textBoxVivod.ReadOnly = true;
            textBoxVivod.Size = new Size(100, 23);
            textBoxVivod.TabIndex = 2;
            textBoxVivod.Text = "Ввывод данных";
            // 
            // buttonResult
            // 
            buttonResult.Location = new Point(323, 12);
            buttonResult.Name = "buttonResult";
            buttonResult.Size = new Size(144, 91);
            buttonResult.TabIndex = 4;
            buttonResult.Text = "Выполнить";
            buttonResult.UseVisualStyleBackColor = true;
            buttonResult.Click += buttonResult_Click;
            // 
            // buttonOpenFile
            // 
            buttonOpenFile.Location = new Point(484, 12);
            buttonOpenFile.Name = "buttonOpenFile";
            buttonOpenFile.Size = new Size(150, 91);
            buttonOpenFile.TabIndex = 5;
            buttonOpenFile.Text = "Открыть файл";
            buttonOpenFile.UseVisualStyleBackColor = true;
            buttonOpenFile.Click += buttonOpenFile_Click;
            // 
            // chartFunction
            // 
            chartArea1.Name = "ChartArea1";
            chartFunction.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            chartFunction.Legends.Add(legend1);
            chartFunction.Location = new Point(322, 138);
            chartFunction.Name = "chartFunction";
            series1.ChartArea = "ChartArea1";
            series1.IsVisibleInLegend = false;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            chartFunction.Series.Add(series1);
            chartFunction.Size = new Size(465, 300);
            chartFunction.TabIndex = 6;
            chartFunction.Text = "chart1";
            // 
            // dataGridViewResult
            // 
            dataGridViewResult.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewResult.Location = new Point(12, 138);
            dataGridViewResult.Name = "dataGridViewResult";
            dataGridViewResult.Size = new Size(289, 300);
            dataGridViewResult.TabIndex = 7;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dataGridViewResult);
            Controls.Add(chartFunction);
            Controls.Add(buttonOpenFile);
            Controls.Add(buttonResult);
            Controls.Add(textBoxVivod);
            Controls.Add(textBox2);
            Controls.Add(textBoxYslovie);
            Name = "FormMain";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)chartFunction).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewResult).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxYslovie;
        private TextBox textBox2;
        private TextBox textBoxVivod;
        private Button buttonResult;
        private Button buttonOpenFile;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartFunction;
        private DataGridView dataGridViewResult;
    }
}
