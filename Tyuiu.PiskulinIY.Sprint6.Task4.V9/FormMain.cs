using Microsoft.VisualBasic.ApplicationServices;
using System.Diagnostics;
using Tyuiu.PiskulinIY.Sprint6.Task4.V9.Lib;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
namespace Tyuiu.PiskulinIY.Sprint6.Task4.V9
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        DataService ds = new DataService();
        private void chartResult_Click(object sender, EventArgs e)
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

                

                this.chartFunction.ChartAreas[0].AxisX.Title = "Ось Х";
                this.chartFunction.ChartAreas[0].AxisY.Title = "Ось Y";

                textBoxResult.Text = "";

                chartFunction.Series[0].Points.Clear();

                for (int i = 0; i < len; i++)
                {
                    this.chartFunction.Series[0].Points.AddXY(startstep, valueArray[i]);
                    textBoxResult.AppendText(valueArray[i] + Environment.NewLine);
                    startstep++;

                }

            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            try
            {
                string[] paths = { Path.GetTempPath(), Path.GetTempFileName() };
                string path = Path.Combine(paths);
                File.WriteAllText(path, textBoxResult.Text);

                DialogResult dialogResult = MessageBox.Show("Файл " + path + "сохранен успешно \n Открыть его в блокноте?)", "Сообщение", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                if (dialogResult == DialogResult.Yes)
                {
                    System.Diagnostics.Process txt = new System.Diagnostics.Process();
                    txt.StartInfo.FileName = "notepad.exe";
                    txt.StartInfo.Arguments = path;
                    txt.Start();

                }
            }
            catch
            {
                MessageBox.Show("Сбой при сохранении файла", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error); 



            }
        }
    }
}
