using Tyuiu.PiskulinIY.Sprint6.Task1.V20.Lib;

namespace Tyuiu.PiskulinIY.Sprint6.Task1.V20
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        DataService ds = new DataService();
        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonResult_Click(object sender, EventArgs e)
        {
            try
            {
                int startstep = Convert.ToInt32(textBoxStart.Text);
                int stopstep = Convert.ToInt32(textBoxEnd.Text);

                string strLine;

                int len = ds.GetMassFunction(startstep, stopstep).Length;

                double[] valueArray;
                valueArray = new double[len];

                valueArray = ds.GetMassFunction(startstep, stopstep);

                textBoxResult.Text = "";
                textBoxResult.AppendText("+----------+---------+" + Environment.NewLine);
                textBoxResult.AppendText("+     X    +   f(x)  +" + Environment.NewLine);
                textBoxResult.AppendText("+----------+---------+" + Environment.NewLine);

                for (int i = 0; i <= len - 1; i++)
                {
                    strLine = String.Format("|{0,5:d}    |   {1,  5:f2}    | ", startstep, valueArray[i]);
                    textBoxResult.AppendText(strLine + Environment.NewLine);
                    startstep++;
                }

                textBoxResult.AppendText("+----------+---------+" + Environment.NewLine);

            }
            catch 
            {
                MessageBox.Show("Îøèáêà");
            }
        }
    }
}
