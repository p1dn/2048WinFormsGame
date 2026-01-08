using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace _2048WinFormsGame
{
    public partial class GameSizeSelectionForm : Form
    {
        private string name;

        public GameSizeSelectionForm(string name)
        {
            InitializeComponent();
            this.name = name;
        }

        private void GameSizeSelectionForm_Load(object sender, EventArgs e)
        {
            chooseSizeLabel.Text = $"{name}, выберите размер поля";
        }

        private void size3Button_Click(object sender, EventArgs e) => startGame(3);

        private void size4Button_Click(object sender, EventArgs e) => startGame(4);

        private void size5Button_Click(object sender, EventArgs e) => startGame(5);

        private void size6Button_Click(object sender, EventArgs e) => startGame(6);

        private void startGame(int size)
        {
            var game2048 = new Game2048Form(size, name);

            game2048.FormClosed += (s, args) => this.Close();

            this.Hide();
            game2048.Show();
        }
    }
}
