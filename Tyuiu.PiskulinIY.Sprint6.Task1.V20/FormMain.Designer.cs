namespace Tyuiu.PiskulinIY.Sprint6.Task1.V20
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
            textBoxYslovie = new TextBox();
            textBoxStart = new TextBox();
            textBoxEnd = new TextBox();
            textBoxResult = new TextBox();
            textBoxStartShaga = new TextBox();
            textBoxKonecShaga = new TextBox();
            textBoxTask1 = new TextBox();
            textBoxVvod = new TextBox();
            buttonResult = new Button();
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
            // textBoxStart
            // 
            textBoxStart.Location = new Point(12, 309);
            textBoxStart.Name = "textBoxStart";
            textBoxStart.Size = new Size(100, 23);
            textBoxStart.TabIndex = 1;
            textBoxStart.Text = "-5";
            // 
            // textBoxEnd
            // 
            textBoxEnd.Location = new Point(287, 309);
            textBoxEnd.Name = "textBoxEnd";
            textBoxEnd.Size = new Size(100, 23);
            textBoxEnd.TabIndex = 2;
            textBoxEnd.Text = "5";
            // 
            // textBoxResult
            // 
            textBoxResult.Location = new Point(491, 41);
            textBoxResult.Multiline = true;
            textBoxResult.Name = "textBoxResult";
            textBoxResult.ReadOnly = true;
            textBoxResult.ScrollBars = ScrollBars.Vertical;
            textBoxResult.Size = new Size(297, 397);
            textBoxResult.TabIndex = 3;
            // 
            // textBoxStartShaga
            // 
            textBoxStartShaga.Location = new Point(12, 280);
            textBoxStartShaga.Name = "textBoxStartShaga";
            textBoxStartShaga.ReadOnly = true;
            textBoxStartShaga.Size = new Size(100, 23);
            textBoxStartShaga.TabIndex = 4;
            textBoxStartShaga.Text = "Старт шага";
            // 
            // textBoxKonecShaga
            // 
            textBoxKonecShaga.Location = new Point(287, 280);
            textBoxKonecShaga.Name = "textBoxKonecShaga";
            textBoxKonecShaga.ReadOnly = true;
            textBoxKonecShaga.Size = new Size(100, 23);
            textBoxKonecShaga.TabIndex = 5;
            textBoxKonecShaga.Text = "Конец шага";
            textBoxKonecShaga.TextChanged += textBox6_TextChanged;
            // 
            // textBoxTask1
            // 
            textBoxTask1.Location = new Point(12, 41);
            textBoxTask1.Multiline = true;
            textBoxTask1.Name = "textBoxTask1";
            textBoxTask1.ReadOnly = true;
            textBoxTask1.Size = new Size(473, 168);
            textBoxTask1.TabIndex = 6;
            textBoxTask1.Text = "Произвести табулирование на заданном диапозоне с шагом 1. Результат вывести в виде таблицы";
            // 
            // textBoxVvod
            // 
            textBoxVvod.Location = new Point(12, 251);
            textBoxVvod.Name = "textBoxVvod";
            textBoxVvod.ReadOnly = true;
            textBoxVvod.Size = new Size(100, 23);
            textBoxVvod.TabIndex = 7;
            textBoxVvod.Text = "Ввод данных:";
            // 
            // buttonResult
            // 
            buttonResult.Location = new Point(327, 367);
            buttonResult.Name = "buttonResult";
            buttonResult.Size = new Size(158, 71);
            buttonResult.TabIndex = 8;
            buttonResult.Text = "Выполнить";
            buttonResult.UseVisualStyleBackColor = true;
            buttonResult.Click += buttonResult_Click;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonResult);
            Controls.Add(textBoxVvod);
            Controls.Add(textBoxTask1);
            Controls.Add(textBoxKonecShaga);
            Controls.Add(textBoxStartShaga);
            Controls.Add(textBoxResult);
            Controls.Add(textBoxEnd);
            Controls.Add(textBoxStart);
            Controls.Add(textBoxYslovie);
            Name = "FormMain";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxYslovie;
        private TextBox textBoxStart;
        private TextBox textBoxEnd;
        private TextBox textBoxResult;
        private TextBox textBoxStartShaga;
        private TextBox textBoxKonecShaga;
        private TextBox textBoxTask1;
        private TextBox textBoxVvod;
        private Button buttonResult;
    }
}
