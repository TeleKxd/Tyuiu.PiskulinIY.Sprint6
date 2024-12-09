using System.Drawing.Drawing2D;
using Tyuiu.PiskulinIY.Sprint6.Task3.V27.Lib;

namespace Tyuiu.PiskulinIY.Sprint6.Task3.V27
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        DataService ds = new DataService();
        int[,] matrix = new int[5,5] { { 9, 13, -14, 23, -12 },
                                       { 15, -17, 21, 25, 1 },
                                       { -4, 29, -20, -10, 3 },
                                       { 27, 33, 12, 33, 14 },
                                       { 18, -9, -5, 6, 23 } };
        private void buttonResult_Click(object sender, EventArgs e)
        {
            
            int rows = matrix.GetUpperBound(0) + 1;
            int col = matrix.Length / rows;

            dataGridViewMatrix.ColumnCount = col;
            dataGridViewMatrix.RowCount = rows;

            for (int i = 0; i < col; i++)
            {
                dataGridViewMatrix.Columns[i].Width = 25;

            }
            int[,] result = ds.Calculate(matrix);
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    dataGridViewMatrix.Rows[i].Cells[j].Value = Convert.ToString(result[i, j]);
                }
            }
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            int rows = matrix.GetUpperBound(0) + 1;
            int columns = matrix.Length / rows;

            dataGridViewMatrix.ColumnCount = columns;
            dataGridViewMatrix.RowCount = rows;

            for (int i = 0; i < columns; i++)
            {
                dataGridViewMatrix.Columns[i].Width = 25;
            }

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    dataGridViewMatrix.Rows[i].Cells[j].Value = Convert.ToString(matrix[i, j]);
                }
            }
        }
    }
}
