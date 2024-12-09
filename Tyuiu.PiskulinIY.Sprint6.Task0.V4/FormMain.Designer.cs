namespace Tyuiu.PiskulinIY.Sprint6.Task0.V4
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            textBoxTask = new TextBox();
            textBoxVvod = new TextBox();
            textBoxVvodX = new TextBox();
            textBoxOtvet = new TextBox();
            textBoxOtvetX = new TextBox();
            pictureBox1 = new PictureBox();
            buttonOtvet = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // textBoxTask
            // 
            textBoxTask.Location = new Point(12, 12);
            textBoxTask.Multiline = true;
            textBoxTask.Name = "textBoxTask";
            textBoxTask.ReadOnly = true;
            textBoxTask.Size = new Size(394, 73);
            textBoxTask.TabIndex = 0;
            textBoxTask.Text = "Вычислить значеине выражения при Х = 3";
            textBoxTask.TextChanged += textBoxTask_TextChanged;
            // 
            // textBoxVvod
            // 
            textBoxVvod.Location = new Point(84, 232);
            textBoxVvod.Name = "textBoxVvod";
            textBoxVvod.ReadOnly = true;
            textBoxVvod.Size = new Size(99, 23);
            textBoxVvod.TabIndex = 1;
            textBoxVvod.Text = "Ввод Данных";
            // 
            // textBoxVvodX
            // 
            textBoxVvodX.Location = new Point(84, 283);
            textBoxVvodX.Name = "textBoxVvodX";
            textBoxVvodX.Size = new Size(100, 23);
            textBoxVvodX.TabIndex = 2;
            textBoxVvodX.TextChanged += textBoxVvodX_TextChanged;
            textBoxVvodX.KeyPress += textBoxVvodX_KeyPress;
            // 
            // textBoxOtvet
            // 
            textBoxOtvet.Location = new Point(606, 232);
            textBoxOtvet.Name = "textBoxOtvet";
            textBoxOtvet.ReadOnly = true;
            textBoxOtvet.Size = new Size(108, 23);
            textBoxOtvet.TabIndex = 3;
            textBoxOtvet.Text = "Ответ выражения";
            textBoxOtvet.TextChanged += textBoxOtvet_TextChanged;
            // 
            // textBoxOtvetX
            // 
            textBoxOtvetX.Location = new Point(563, 283);
            textBoxOtvetX.Name = "textBoxOtvetX";
            textBoxOtvetX.ReadOnly = true;
            textBoxOtvetX.Size = new Size(188, 23);
            textBoxOtvetX.TabIndex = 4;
            textBoxOtvetX.TextChanged += textBoxOtvetX_TextChanged;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(454, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(334, 31);
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // buttonOtvet
            // 
            buttonOtvet.Location = new Point(563, 363);
            buttonOtvet.Name = "buttonOtvet";
            buttonOtvet.Size = new Size(188, 75);
            buttonOtvet.TabIndex = 6;
            buttonOtvet.Text = "Выполнить";
            buttonOtvet.UseVisualStyleBackColor = true;
            buttonOtvet.Click += buttonOtvet_Click;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonOtvet);
            Controls.Add(pictureBox1);
            Controls.Add(textBoxOtvetX);
            Controls.Add(textBoxOtvet);
            Controls.Add(textBoxVvodX);
            Controls.Add(textBoxVvod);
            Controls.Add(textBoxTask);
            MaximizeBox = false;
            Name = "FormMain";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxTask;
        private TextBox textBoxVvod;
        private TextBox textBoxVvodX;
        private TextBox textBoxOtvet;
        private TextBox textBoxOtvetX;
        private PictureBox pictureBox1;
        private Button buttonOtvet;
    }
}
