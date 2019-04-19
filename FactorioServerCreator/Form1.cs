using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FactorioServerCreator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void deleteServerBtn_Click(object sender, EventArgs e)
        {

        }

        private void newServerBtn_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(servernameTextBox.Text))
            {
                serverListView.Items.Add(servernameTextBox.Text);
            }
            
        }

        private void browseExeBtn_Click(object sender, EventArgs e)
        {
            navigateToExe.ShowDialog();
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            String factorioPath = navigateToExe.InitialDirectory + navigateToExe.FileName;
            factorioExePath.Text = factorioPath;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            browseExeBtn.Height = factorioExePath.Height;
            
        }

        private void factorioExePath_Enter(object sender, EventArgs e)
        {
            if (factorioExePath.Text == "Browse to Factorio.exe...")
            {
                factorioExePath.Text = "";
            }
        }

        private void factorioExePath_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(factorioExePath.Text))
            {
                factorioExePath.Text = "Browse to Factorio.exe...";
            }
        }

        private void usernameTextBox_Enter(object sender, EventArgs e)
        {
            if (usernameTextBox.Text == "Enter Username...")
            {
                usernameTextBox.Text = "";
            }
        }

        private void usernameTextBox_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(usernameTextBox.Text))
            {
                usernameTextBox.Text = "Enter Username...";
            }
        }
    }
}
