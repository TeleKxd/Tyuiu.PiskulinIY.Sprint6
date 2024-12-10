namespace Tyuiu.PiskulinIY.Sprint6.Task7.V13
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
            dataGridViewOutPut = new DataGridView();
            dataGridViewInPut = new DataGridView();
            textBoxInfo = new TextBox();
            buttonOpenFile = new Button();
            buttonSaveFile = new Button();
            buttonResult = new Button();
            openFileDialogTask = new OpenFileDialog();
            toolTipButton = new ToolTip(components);
            saveFileDialogMatrix = new SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)dataGridViewOutPut).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewInPut).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewOutPut
            // 
            dataGridViewOutPut.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewOutPut.Location = new Point(0, 85);
            dataGridViewOutPut.Name = "dataGridViewOutPut";
            dataGridViewOutPut.ReadOnly = true;
            dataGridViewOutPut.Size = new Size(661, 747);
            dataGridViewOutPut.TabIndex = 10;
            dataGridViewOutPut.CellContentClick += dataGridViewOutPut_CellContentClick;
            // 
            // dataGridViewInPut
            // 
            dataGridViewInPut.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewInPut.Location = new Point(667, 85);
            dataGridViewInPut.Name = "dataGridViewInPut";
            dataGridViewInPut.ReadOnly = true;
            dataGridViewInPut.Size = new Size(496, 754);
            dataGridViewInPut.TabIndex = 1;
            dataGridViewInPut.CellContentClick += dataGridViewInPut_CellContentClick;
            // 
            // textBoxInfo
            // 
            textBoxInfo.Dock = DockStyle.Top;
            textBoxInfo.Location = new Point(0, 0);
            textBoxInfo.Multiline = true;
            textBoxInfo.Name = "textBoxInfo";
            textBoxInfo.ReadOnly = true;
            textBoxInfo.Size = new Size(1163, 79);
            textBoxInfo.TabIndex = 2;
            textBoxInfo.Text = "Дан файл: ";
            // 
            // buttonOpenFile
            // 
            buttonOpenFile.Location = new Point(307, 0);
            buttonOpenFile.Name = "buttonOpenFile";
            buttonOpenFile.Size = new Size(104, 65);
            buttonOpenFile.TabIndex = 3;
            buttonOpenFile.Text = "Открыть";
            buttonOpenFile.UseVisualStyleBackColor = true;
            buttonOpenFile.Click += buttonOpenFile_Click;
            // 
            // buttonSaveFile
            // 
            buttonSaveFile.Location = new Point(514, 0);
            buttonSaveFile.Name = "buttonSaveFile";
            buttonSaveFile.Size = new Size(90, 65);
            buttonSaveFile.TabIndex = 4;
            buttonSaveFile.Text = "Сохранить";
            buttonSaveFile.UseVisualStyleBackColor = true;
            buttonSaveFile.Click += buttonSaveFile_Click;
            // 
            // buttonResult
            // 
            buttonResult.Location = new Point(417, 0);
            buttonResult.Name = "buttonResult";
            buttonResult.Size = new Size(91, 65);
            buttonResult.TabIndex = 5;
            buttonResult.Text = "Выполнить";
            buttonResult.UseVisualStyleBackColor = true;
            buttonResult.Click += buttonResult_Click;
            // 
            // openFileDialogTask
            // 
            openFileDialogTask.FileName = "openFileDialog1";
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(1163, 929);
            Controls.Add(buttonResult);
            Controls.Add(buttonSaveFile);
            Controls.Add(buttonOpenFile);
            Controls.Add(textBoxInfo);
            Controls.Add(dataGridViewInPut);
            Controls.Add(dataGridViewOutPut);
            MinimumSize = new Size(816, 489);
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += FormMain_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewOutPut).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewInPut).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridViewOutPut;
        private DataGridView dataGridViewInPut;
        private TextBox textBoxInfo;
        private Button buttonOpenFile;
        private Button buttonSaveFile;
        private Button buttonResult;
        private OpenFileDialog openFileDialogTask;
        private ToolTip toolTipButton;
        private SaveFileDialog saveFileDialogMatrix;
    }
}
