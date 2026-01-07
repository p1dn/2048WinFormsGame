using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace _2048WinFormsGame
{
    public partial class WelcomeForm : Form
    {
        public WelcomeForm()
        {
            InitializeComponent();
        }

        private void WelcomeForm_Load(object sender, EventArgs e)
        {

        }

        private void userNameTextBox_TextChanged(object sender, EventArgs e) { }

        private void enterButton_Click(object sender, EventArgs e)
        {
            var gameSizeSelection = new GameSizeSelectionForm(userNameTextBox.Text);

            this.Hide();
            gameSizeSelection.Show();
        }
    }
}
