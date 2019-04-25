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
            serverListView.SelectedItems[0].Remove();
        }

        private void newServerBtn_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(servernameTextBox.Text)&&!servernameTextBox.Text.Equals("Enter Servername..."))
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
            advancedSettingsToggleBtn.Appearance = Appearance.Button;
            advancedSettingsToggleBtn.TextAlign = ContentAlignment.MiddleCenter;
            advancedSettingsToggleBtn.MinimumSize = new Size(75, 23);
            if (string.IsNullOrWhiteSpace(factorioExePath.Text)&&string.IsNullOrWhiteSpace(usernameTextBox.Text) && string.IsNullOrWhiteSpace(servernameTextBox.Text))
            {
                factorioExePath.Text = "Browse to Factorio.exe...";
                usernameTextBox.Text = "Enter Username...";
                servernameTextBox.Text = "Enter Servername...";
            }

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

        private void advancedSettingsToggleBtn_CheckedChanged(object sender, EventArgs e)
        {
            if (advancedSettingsToggleBtn.Checked == true)
            {
                advSettingsGroupBox.Enabled = true;
            }
            if (advancedSettingsToggleBtn.Checked == false)
            {
                advSettingsGroupBox.Enabled = false;
            }
        }

        private void servernameTextBox_Enter(object sender, EventArgs e)
        {
            if (servernameTextBox.Text == "Enter Servername...")
            {
                servernameTextBox.Text = "";
            }
        }

        private void servernameTextBox_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(servernameTextBox.Text))
            {
                servernameTextBox.Text = "Enter Servername...";
            }
        }
    }
}
