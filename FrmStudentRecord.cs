using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace LabExer501
{
    public partial class FrmStudentRecord : Form
    {
        private string fileName;

        public FrmStudentRecord()
        {
            InitializeComponent();
        }
        public FrmStudentRecord(string fileName)
        {
            InitializeComponent();
            this.fileName = fileName;
        }

        private void FrmStudentRecord_Load(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(fileName))
                lvShowText.Items.Add("This is where the record details will appear.");
            else
                lvShowText.Clear();
                lvShowText.Items.Add(fileName);
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            FrmRegisration fr = new FrmRegisration();
            fr.ShowDialog();
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            try
            {
                lvShowText.Clear();
                openFileDialog1.InitialDirectory = @"C:\Users\Takashima\Documents";
                openFileDialog1.Title = "Browse Text Files";
                openFileDialog1.DefaultExt = "txt";
                openFileDialog1.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
                openFileDialog1.ShowDialog();
                string path = openFileDialog1.FileName;
                fileName = path;
                using (StreamReader streamReader = File.OpenText(path))
                {
                    string _getText = "";
                    while ((_getText = streamReader.ReadLine()) != null)
                    {
                        Console.WriteLine(_getText);
                        lvShowText.Items.Add(_getText);
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("There is no file opened!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnUpload_Click(object sender, EventArgs e)
        {
            if (lvShowText.Items.Count == 0 || String.IsNullOrWhiteSpace(fileName))
            {
                MessageBox.Show("There is no file opened!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else 
            MessageBox.Show("Successfully uploaded!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            lvShowText.Clear();
            lvShowText.Items.Add("This is where the record details will appear.");

        }
    }
}
