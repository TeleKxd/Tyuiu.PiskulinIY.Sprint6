using System.IO;
using Tyuiu.PiskulinIY.Sprint6.Task7.V13.Lib;
namespace Tyuiu.PiskulinIY.Sprint6.Task7.V13
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();

            openFileDialogTask.Filter = "Значения, разделенные запятыми (*.csv)|*.csv|Все файлы (*.*)|*.*";
            saveFileDialogMatrix.Filter = "Значения, разделенные запятыми (*.csv)|*.csv|Все файлы (*.*)|*.*";

        }

        static int rows;
        static int columns;
        static string openFilePath;

        DataService ds = new DataService();

        public static int[,] LoadFromFileData(string filePath)
        {
            string file = File.ReadAllText(filePath);
            file = file.Replace('\n', '\r');
            string[] lines = file.Split(new char[] { '\r' }, StringSplitOptions.RemoveEmptyEntries);

            rows = lines.Length;
            columns = lines[0].Split(';').Length;

            int[,] array = new int[rows, columns];

            for (int i = 0; i < rows; i++)
            {
                string[] line_mas = lines[i].Split(';');
                for (int j = 0; j < columns; j++)
                {
                    array[i, j] = Convert.ToInt32(line_mas[j]);
                }
            }
            return array;
        }

        private void buttonOpenFile_Click(object sender, EventArgs e)
        {
            openFileDialogTask.ShowDialog();
            openFilePath = openFileDialogTask.FileName;

            int[,] array = new int[rows, columns];

            array = LoadFromFileData(openFilePath);

            dataGridViewInPut.ColumnCount = columns;
            dataGridViewInPut.RowCount = rows;
            dataGridViewOutPut.ColumnCount = columns;
            dataGridViewOutPut.RowCount = columns;

            for (int i = 0; i <= columns; i++)
            {
                dataGridViewInPut.Columns[i].Width = 25;
                dataGridViewOutPut.Columns[i].Width = 25;
            }

            for (int i = 0; i <= rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    dataGridViewInPut.Rows[i].Cells[j].Value = array[i, j];
                }
            }

            array = ds.GetMatrix(openFilePath);
            buttonResult.Enabled = true;
        }

        private void buttonResult_Click(object sender, EventArgs e)
        {
            int[,] arrayValues = new int[rows, columns];
            arrayValues = ds.GetMatrix(openFilePath);

            for (int i = 0; i <= rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    dataGridViewOutPut.Rows[i].Cells[j].Value = arrayValues[i, j];

                }
            }

            buttonSaveFile.Enabled = true;
        }

        private void dataGridViewOutPut_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void buttonSaveFile_Click(object sender, EventArgs e)
        {
            saveFileDialogMatrix.FileName = "OutPutFileTask7.csv";
            saveFileDialogMatrix.InitialDirectory = Directory.GetCurrentDirectory();
            saveFileDialogMatrix.ShowDialog();

            string path = saveFileDialogMatrix.FileName;

            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;

            if (fileExists)
            {
                File.Delete(path);

            }

            int rows = dataGridViewOutPut.RowCount;
            int columns = dataGridViewOutPut.ColumnCount;

            string str = "";
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    if (j != columns - 1)
                    {
                        str = str + dataGridViewOutPut.Rows[i].Cells[j].Value + ";";

                    }
                    else
                    {
                        str = str + dataGridViewOutPut.Rows[i].Cells[j].Value;
                    }

                }

                File.AppendAllText(path, str + Environment.NewLine);
                str = "";
            }

        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            dataGridViewInPut.RowCount = 50;
            dataGridViewOutPut.RowCount = 50;

            dataGridViewInPut.ColumnCount = 50;
            dataGridViewOutPut.ColumnCount = 50;



            for (int i = 0; i < 50; i++)
            {
                dataGridViewInPut.Columns[i].Width = 25;
                dataGridViewOutPut.Columns[i].Width = 25;
            }
        }

        private void dataGridViewInPut_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void splitter1_SplitterMoved(object sender, SplitterEventArgs e)
        {

        }
    }
}
