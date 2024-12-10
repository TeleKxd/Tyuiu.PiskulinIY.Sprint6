using Tyuiu.PiskulinIY.Sprint6.Task6.V26.Lib;
namespace Tyuiu.PiskulinIY.Sprint6.Task6.V26
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        DataService ds = new DataService();
        string openFilePath;
        private void FormMain_Load(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonOpenFile_Click(object sender, EventArgs e)
        {
            openFileDialogTask.ShowDialog();
            openFilePath = openFileDialogTask.FileName;
            textBoxStart.Text = File.ReadAllText(openFilePath);
            textBoxInPutData.Text = groupBoxOutPutData.Text + " " + openFileDialogTask.FileName;
            buttonResult.Enabled = true;


        }

        private void groupBoxOutPutData_Enter(object sender, EventArgs e)
        {

        }

        private void groupBoxOUPutData_Enter(object sender, EventArgs e)
        {

        }

        private void buttonResult_Click(object sender, EventArgs e)
        {
            string str = "";
            textBoxResult.Text = ds.CollectTextFromFile(openFilePath);
        }
    }
}
