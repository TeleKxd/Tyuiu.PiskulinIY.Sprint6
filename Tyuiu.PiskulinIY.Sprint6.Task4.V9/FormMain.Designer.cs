namespace Tyuiu.PiskulinIY.Sprint6.Task4.V9
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
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            textBoxYslovie = new TextBox();
            textBoxVvod = new TextBox();
            textBoxStartShag = new TextBox();
            textBoxStopShag = new TextBox();
            textBoxStart = new TextBox();
            textBoxStop = new TextBox();
            textBoxVivod = new TextBox();
            textBoxInfo = new TextBox();
            textBoxResult = new TextBox();
            chartFunction = new System.Windows.Forms.DataVisualization.Charting.Chart();
            buttonResult = new Button();
            buttonSave = new Button();
            ((System.ComponentModel.ISupportInitialize)chartFunction).BeginInit();
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
            // textBoxVvod
            // 
            textBoxVvod.Location = new Point(398, 12);
            textBoxVvod.Name = "textBoxVvod";
            textBoxVvod.ReadOnly = true;
            textBoxVvod.Size = new Size(224, 23);
            textBoxVvod.TabIndex = 1;
            textBoxVvod.Text = "Ввод данных";
            // 
            // textBoxStartShag
            // 
            textBoxStartShag.Location = new Point(398, 41);
            textBoxStartShag.Name = "textBoxStartShag";
            textBoxStartShag.ReadOnly = true;
            textBoxStartShag.Size = new Size(100, 23);
            textBoxStartShag.TabIndex = 2;
            textBoxStartShag.Text = "Старт Шага";
            // 
            // textBoxStopShag
            // 
            textBoxStopShag.Location = new Point(522, 41);
            textBoxStopShag.Name = "textBoxStopShag";
            textBoxStopShag.ReadOnly = true;
            textBoxStopShag.Size = new Size(100, 23);
            textBoxStopShag.TabIndex = 3;
            textBoxStopShag.Text = "Конец Шага";
            // 
            // textBoxStart
            // 
            textBoxStart.Location = new Point(398, 70);
            textBoxStart.Name = "textBoxStart";
            textBoxStart.Size = new Size(100, 23);
            textBoxStart.TabIndex = 4;
            textBoxStart.Text = "-5";
            // 
            // textBoxStop
            // 
            textBoxStop.Location = new Point(522, 70);
            textBoxStop.Name = "textBoxStop";
            textBoxStop.Size = new Size(100, 23);
            textBoxStop.TabIndex = 5;
            textBoxStop.Text = "5";
            // 
            // textBoxVivod
            // 
            textBoxVivod.Location = new Point(12, 123);
            textBoxVivod.Name = "textBoxVivod";
            textBoxVivod.ReadOnly = true;
            textBoxVivod.Size = new Size(100, 23);
            textBoxVivod.TabIndex = 6;
            textBoxVivod.Text = "Вывод";
            // 
            // textBoxInfo
            // 
            textBoxInfo.Location = new Point(12, 41);
            textBoxInfo.Multiline = true;
            textBoxInfo.Name = "textBoxInfo";
            textBoxInfo.ReadOnly = true;
            textBoxInfo.Size = new Size(380, 76);
            textBoxInfo.TabIndex = 7;
            textBoxInfo.Text = "Произвести табулирование на заданном диапозоне с шагом 1.";
            // 
            // textBoxResult
            // 
            textBoxResult.Location = new Point(12, 152);
            textBoxResult.Multiline = true;
            textBoxResult.Name = "textBoxResult";
            textBoxResult.ReadOnly = true;
            textBoxResult.ScrollBars = ScrollBars.Vertical;
            textBoxResult.Size = new Size(380, 286);
            textBoxResult.TabIndex = 8;
            // 
            // chartFunction
            // 
            chartArea1.Name = "ChartArea1";
            chartFunction.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            chartFunction.Legends.Add(legend1);
            chartFunction.Location = new Point(412, 123);
            chartFunction.Name = "chartFunction";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.IsVisibleInLegend = false;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            chartFunction.Series.Add(series1);
            chartFunction.Size = new Size(559, 311);
            chartFunction.TabIndex = 9;
            chartFunction.Text = "chart1";
            title1.Name = "Titlefx";
            title1.Text = "График функции f(x)";
            chartFunction.Titles.Add(title1);
            chartFunction.Click += chartResult_Click;
            // 
            // buttonResult
            // 
            buttonResult.Location = new Point(640, 12);
            buttonResult.Name = "buttonResult";
            buttonResult.Size = new Size(162, 81);
            buttonResult.TabIndex = 10;
            buttonResult.Text = "Выполнить";
            buttonResult.UseVisualStyleBackColor = true;
            buttonResult.Click += buttonResult_Click;
            // 
            // buttonSave
            // 
            buttonSave.Location = new Point(808, 12);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(163, 81);
            buttonSave.TabIndex = 11;
            buttonSave.Text = "Сохранить";
            buttonSave.UseVisualStyleBackColor = true;
            buttonSave.Click += buttonSave_Click;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(984, 446);
            Controls.Add(buttonSave);
            Controls.Add(buttonResult);
            Controls.Add(chartFunction);
            Controls.Add(textBoxResult);
            Controls.Add(textBoxInfo);
            Controls.Add(textBoxVivod);
            Controls.Add(textBoxStop);
            Controls.Add(textBoxStart);
            Controls.Add(textBoxStopShag);
            Controls.Add(textBoxStartShag);
            Controls.Add(textBoxVvod);
            Controls.Add(textBoxYslovie);
            Name = "FormMain";
            Text = "Task4 | I.Y.Piskulin";
            ((System.ComponentModel.ISupportInitialize)chartFunction).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxYslovie;
        private TextBox textBoxVvod;
        private TextBox textBoxStartShag;
        private TextBox textBoxStopShag;
        private TextBox textBoxStart;
        private TextBox textBoxStop;
        private TextBox textBoxVivod;
        private TextBox textBoxInfo;
        private TextBox textBoxResult;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartFunction;
        private Button buttonResult;
        private Button buttonSave;
    }
}
