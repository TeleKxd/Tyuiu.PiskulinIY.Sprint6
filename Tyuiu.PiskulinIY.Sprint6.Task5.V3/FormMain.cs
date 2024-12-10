using Tyuiu.PiskulinIY.Sprint6.Task5.V3.Lib;

namespace Tyuiu.PiskulinIY.Sprint6.Task5.V3
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        DataService ds = new DataService();

        string path = @"C:\Users\AeroC\source\repos\Tyuiu.PiskulinIY.Sprint6\Tyuiu.PiskulinIY.Sprint6.Task5.V3\bin\Debug\net8.0-windows\InPutFileTask5v3.txt";

        private void buttonResult_Click(object sender, EventArgs e)
        {
            dataGridViewResult.ColumnCount = 2;
            dataGridViewResult.Columns[0].Width = 20;
            dataGridViewResult.Columns[1].Width = 50;

            this.chartFunction.ChartAreas[0].AxisX.Title = "Îñü Õ";
            this.chartFunction.ChartAreas[0].AxisY.Title = "Îñü Y";

            chartFunction.Series[0].Points.Clear();

            double[] numsMass = new double[ds.len];

            numsMass = ds.LoadFromDataFile(path);

            for (int i = 0; i < numsMass.Length; i++)
            {
                dataGridViewResult.Rows.Add(Convert.ToString(i), Convert.ToString(numsMass[i]));
                chartFunction.Series[0].Points.AddXY(i, numsMass[i]);
            }

        }

        private void buttonOpenFile_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process txt = new System.Diagnostics.Process();
            txt.StartInfo.FileName = "notepad.exe";
            txt.StartInfo.Arguments = path;
            txt.Start();
        }
    }
}
