namespace LabExer501
{
    public partial class FrmLab1 : Form
    {
        FrmFileName fn;
        string getInput;
        public FrmLab1()
        {
            InitializeComponent();
            fn = new FrmFileName();
            fn.ShowDialog();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            getInput = txtInput.Text;
            string docPath =
            Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            using (StreamWriter outputFile = new StreamWriter(Path.Combine(docPath,
            FrmFileName.SetFileName)))
            {
                outputFile.WriteLine(getInput);
                Console.WriteLine(getInput);
            }

            MessageBox.Show("File has been saved!", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            FrmRegisration fr = new FrmRegisration();
            fr.ShowDialog();
            this.Close();
        }

        private void FrmLab1_Load(object sender, EventArgs e)
        {

        }
    }
}