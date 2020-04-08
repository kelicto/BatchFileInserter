using System;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace KeLi.BatchFileInserter.App
{
    public partial class MainForm : Form
    {
        private string[] _filePaths;

        public MainForm()
        {
            InitializeComponent();
        }

        private void BtnSelect_Click(object sender, EventArgs e)
        {
            if (ofdPat.ShowDialog() == DialogResult.OK)
                _filePaths = ofdPat.FileNames;
        }

        private void BtnStart_Click(object sender, EventArgs e)
        {
            try
            {
                if (_filePaths == null || _filePaths.Length == 0)
                {
                    MessageBox.Show("Please select files!");

                    btnSelect.Focus();

                    return;
                }

                foreach (var filePath in _filePaths)
                {
                    var context = File.ReadAllLines(filePath, Encoding.Default);

                    var list = context.ToList();

                    var lineNumber = Convert.ToInt32(txtLineNumber.Text) - 1;

                    list.Insert(lineNumber, txtContext.Text);

                    File.WriteAllLines(filePath, list.ToArray(), Encoding.Default);
                }

                MessageBox.Show("Inserts successful!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}