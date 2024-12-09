namespace Tyuiu.PiskulinIY.Sprint6.Task3.V27
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
            textBoxInfo = new TextBox();
            dataGridViewMatrix = new DataGridView();
            buttonResult = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewMatrix).BeginInit();
            SuspendLayout();
            // 
            // textBoxInfo
            // 
            textBoxInfo.Location = new Point(13, 13);
            textBoxInfo.Multiline = true;
            textBoxInfo.Name = "textBoxInfo";
            textBoxInfo.Size = new Size(300, 436);
            textBoxInfo.TabIndex = 0;
            textBoxInfo.Text = "Дана матрица 5х5\r\n  9    13  -14   23    1\r\n15  -17    21   25    23\r\n-4    29  -20  -10    14\r\n27   33    12    33   -12\r\n18   -9    -5     6     3\r\nСортировать 4-ый столбик в порядке возрастания";
            // 
            // dataGridViewMatrix
            // 
            dataGridViewMatrix.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewMatrix.Location = new Point(319, 13);
            dataGridViewMatrix.Name = "dataGridViewMatrix";
            dataGridViewMatrix.Size = new Size(469, 326);
            dataGridViewMatrix.TabIndex = 1;
            // 
            // buttonResult
            // 
            buttonResult.Location = new Point(561, 403);
            buttonResult.Name = "buttonResult";
            buttonResult.Size = new Size(227, 35);
            buttonResult.TabIndex = 2;
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
            Controls.Add(dataGridViewMatrix);
            Controls.Add(textBoxInfo);
            Name = "FormMain";
            Text = "Form1";
            Load += FormMain_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewMatrix).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxInfo;
        private DataGridView dataGridViewMatrix;
        private Button buttonResult;
    }
}
