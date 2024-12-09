using Tyuiu.PiskulinIY.Sprint6.Task0.V4.Lib;

namespace Tyuiu.PiskulinIY.Sprint6.Task0.V4
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void buttonOtvet_Click(object sender, EventArgs e)
        {
            DataService ds = new DataService();
            try
            {
                textBoxOtvetX.Text = Convert.ToString(ds.Calculate(Convert.ToInt32(textBoxVvodX.Text)));

            }
            catch
            {
                MessageBox.Show("Ошибка");
            }



        }

        private void textBoxVvodX_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxOtvetX_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxTask_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxOtvet_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxVvodX_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 3)
            {
                e.Handled = true;
            }
        }
    }
}
