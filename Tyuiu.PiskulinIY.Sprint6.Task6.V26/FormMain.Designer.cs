namespace Tyuiu.PiskulinIY.Sprint6.Task6.V26
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
            components = new System.ComponentModel.Container();
            openFileDialogTask = new OpenFileDialog();
            toolTip1 = new ToolTip(components);
            buttonOpenFile = new Button();
            buttonResult = new Button();
            textBoxInPutData = new TextBox();
            textBoxStart = new TextBox();
            groupBoxPutData = new GroupBox();
            groupBoxOutPutData = new GroupBox();
            textBoxResult = new TextBox();
            groupBoxPutData.SuspendLayout();
            groupBoxOutPutData.SuspendLayout();
            SuspendLayout();
            // 
            // buttonOpenFile
            // 
            buttonOpenFile.Location = new Point(12, 12);
            buttonOpenFile.Name = "buttonOpenFile";
            buttonOpenFile.Size = new Size(170, 56);
            buttonOpenFile.TabIndex = 0;
            buttonOpenFile.Text = "открыть файл";
            buttonOpenFile.UseVisualStyleBackColor = true;
            buttonOpenFile.Click += buttonOpenFile_Click;
            // 
            // buttonResult
            // 
            buttonResult.Location = new Point(188, 12);
            buttonResult.Name = "buttonResult";
            buttonResult.Size = new Size(170, 56);
            buttonResult.TabIndex = 1;
            buttonResult.Text = "Выполнить";
            buttonResult.UseVisualStyleBackColor = true;
            buttonResult.Click += buttonResult_Click;
            // 
            // textBoxInPutData
            // 
            textBoxInPutData.Location = new Point(12, 74);
            textBoxInPutData.Multiline = true;
            textBoxInPutData.Name = "textBoxInPutData";
            textBoxInPutData.ReadOnly = true;
            textBoxInPutData.Size = new Size(776, 71);
            textBoxInPutData.TabIndex = 3;
            textBoxInPutData.Text = "Дан файл";
            // 
            // textBoxStart
            // 
            textBoxStart.Location = new Point(6, 22);
            textBoxStart.Multiline = true;
            textBoxStart.Name = "textBoxStart";
            textBoxStart.ReadOnly = true;
            textBoxStart.ScrollBars = ScrollBars.Vertical;
            textBoxStart.Size = new Size(311, 265);
            textBoxStart.TabIndex = 4;
            // 
            // groupBoxPutData
            // 
            groupBoxPutData.Controls.Add(textBoxStart);
            groupBoxPutData.Location = new Point(12, 151);
            groupBoxPutData.Name = "groupBoxPutData";
            groupBoxPutData.Size = new Size(323, 287);
            groupBoxPutData.TabIndex = 7;
            groupBoxPutData.TabStop = false;
            groupBoxPutData.Text = "Ввод";
            groupBoxPutData.Enter += groupBoxOutPutData_Enter;
            // 
            // groupBoxOutPutData
            // 
            groupBoxOutPutData.Controls.Add(textBoxResult);
            groupBoxOutPutData.Location = new Point(341, 151);
            groupBoxOutPutData.Name = "groupBoxOutPutData";
            groupBoxOutPutData.Size = new Size(447, 287);
            groupBoxOutPutData.TabIndex = 8;
            groupBoxOutPutData.TabStop = false;
            groupBoxOutPutData.Text = "Вывод";
            groupBoxOutPutData.Enter += groupBoxOUPutData_Enter;
            // 
            // textBoxResult
            // 
            textBoxResult.Location = new Point(6, 22);
            textBoxResult.Multiline = true;
            textBoxResult.Name = "textBoxResult";
            textBoxResult.ReadOnly = true;
            textBoxResult.Size = new Size(435, 265);
            textBoxResult.TabIndex = 5;
            textBoxResult.TextChanged += textBox4_TextChanged;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBoxOutPutData);
            Controls.Add(groupBoxPutData);
            Controls.Add(textBoxInPutData);
            Controls.Add(buttonResult);
            Controls.Add(buttonOpenFile);
            Name = "FormMain";
            Text = "Form1";
            Load += FormMain_Load;
            groupBoxPutData.ResumeLayout(false);
            groupBoxPutData.PerformLayout();
            groupBoxOutPutData.ResumeLayout(false);
            groupBoxOutPutData.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private OpenFileDialog openFileDialogTask;
        private ToolTip toolTip1;
        private Button buttonOpenFile;
        private Button buttonResult;
        private TextBox textBoxInPutData;
        private TextBox textBoxStart;
        private GroupBox groupBoxPutData;
        private GroupBox groupBoxOutPutData;
        private TextBox textBoxResult;
    }
}
