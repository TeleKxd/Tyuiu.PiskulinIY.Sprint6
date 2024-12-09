using Tyuiu.PiskulinIY.Sprint6.Task2.V12.Lib;

namespace Tyuiu.PiskulinIY.Sprint6.Task2.V12
{
    public partial class FormmMain : Form
    {
        public FormmMain()
        {
            InitializeComponent();
        }
        DataService ds = new DataService();

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonResult_Click(object sender, EventArgs e)
        {
            try
            {
                int startstep = Convert.ToInt32(textBoxStart.Text);
                int stopstep = Convert.ToInt32(textBoxStop.Text);

                int len = ds.GetMassFunction(startstep, stopstep).Length;

                double[] valueArray;
                valueArray = new double[len];
                valueArray = ds.GetMassFunction(startstep, stopstep);

                this.chartFunction.Titles.Add("График функции sin(x)");

                this.chartFunction.ChartAreas[0].AxisX.Title = "Ось Х";
                this.chartFunction.ChartAreas[0].AxisY.Title = "Ось Y";

                for (int i = 0; i < len; i++)
                {
                    this.dataGridViewRows.Rows.Add(Convert.ToString(startstep), Convert.ToString(valueArray[i]));

                    this.chartFunction.Series[0].Points.AddXY(startstep,valueArray[i]);

                    startstep++;

                }



            }
            catch 
            {
                MessageBox.Show("Ошибка");
            }
        }
    }
}
