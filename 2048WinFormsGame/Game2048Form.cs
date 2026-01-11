using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace _2048WinFormsGame
{
    public partial class Game2048Form : Form
    {
        private int mapSize;
        private User user;
        private Label[,] mapLabel;
        private int[,] mapNumbers;
        private int[,] lastMapNumbers;
        private Random rnd;
        private int score;
        private UserRepository userRepository;
        private bool firstTimeLose;

        public Game2048Form(int mapSize, string name)
        {
            InitializeComponent();
            this.mapSize = mapSize;
            user = new User(name);
        }

        private void Game2048Form_Load(object sender, EventArgs e)
        {
            lastMapNumbers = new int[mapSize, mapSize];
            mapNumbers = new int[mapSize, mapSize];
            mapLabel = new Label[mapSize, mapSize];
            rnd = new Random();
            userRepository = new UserRepository();
            userRepository.Load();
            score = 0;
            firstTimeLose = true;
            bestResultNumberLabel.Text = findBestResult();

            GenerateNumber();
            InitMap();
        }

        private string findBestResult()
        {
            int bestResult = 0;

            foreach (var user in userRepository.Users)
            {
                if (user.Score > bestResult)
                {
                    bestResult = user.Score;
                }
            }

            return bestResult.ToString();
        }

        private void InitMap()
        {
            for (int i = 0; i < mapSize; i++)
            {
                for (int j = 0; j < mapSize; j++)
                {
                    var newLabel = CreateLabel(i, j);
                    Controls.Add(newLabel);
                    mapLabel[i, j] = newLabel;
                }
            }

            MapUpdate();
        }

        private Label CreateLabel(int indexRow, int indexColumn)
        {
            var label = new Label();

            int x = 0;
            int y = 0;

            label.BackColor = Color.FromArgb(192, 192, 255);
            label.Font = new Font("Bahnschrift SemiCondensed", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label.ForeColor = Color.FromArgb(119, 110, 101);
            label.Name = "label128";
            switch (mapSize)
            {
                case 3:
                    label.Size = new Size(200, 200);
                    x = 180 + indexColumn * 210;
                    y = 280 + indexRow * 210;
                    break;
                case 4:
                    label.Size = new Size(150, 150);
                    x = 180 + indexColumn * 160;
                    y = 280 + indexRow * 160;
                    break;
                case 5:
                    label.Size = new Size(120, 120);
                    x = 180 + indexColumn * 130;
                    y = 280 + indexRow * 130;
                    break;
                case 6:
                    label.Size = new Size(100, 100);
                    x = 180 + indexColumn * 110;
                    y = 280 + indexRow * 110;
                    break;
            }
            label.TextAlign = ContentAlignment.MiddleCenter;
            label.Location = new Point(x, y);

            return label;
        }

        private void GenerateNumber()
        {
            while (true)
            {
                int numberForRandomNumber = rnd.Next(0, 100);
                int randomNumber = rnd.Next(mapSize * mapSize);
                int indexRow = randomNumber / mapSize;
                int indexColumn = randomNumber % mapSize;

                if (mapNumbers[indexRow, indexColumn] == 0)
                {
                    if (numberForRandomNumber < 75) mapNumbers[indexRow, indexColumn] = 2;
                    else mapNumbers[indexRow, indexColumn] = 4;
                    break;
                }
            }
        }

        private void Game2048Form_KeyDown(object sender, KeyEventArgs e)
        {
            updateLastMapNumbers();

            if (e.KeyCode == Keys.Up)
            {
                UpShift();

                for (int i = 0; i < mapSize; i++)
                {
                    for (int j = 0; j < mapSize - 1; j++)
                    {
                        if (mapNumbers[j, i] == mapNumbers[j + 1, i])
                        {
                            mapNumbers[j, i] *= 2;
                            ScoreAdd(j, i);
                            mapNumbers[j + 1, i] = 0;
                        }
                    }
                }

                UpShift();
            }
            if (e.KeyCode == Keys.Down)
            {
                DownShift();

                for (int i = 0; i < mapSize; i++)
                {
                    for (int j = mapSize - 1; j > 0; j--)
                    {
                        if (mapNumbers[j, i] == mapNumbers[j - 1, i])
                        {
                            mapNumbers[j, i] *= 2;
                            ScoreAdd(j, i);
                            mapNumbers[j - 1, i] = 0;
                        }
                    }
                }

                DownShift();
            }
            if (e.KeyCode == Keys.Left)
            {
                LeftShift();

                for (int i = 0; i < mapSize; i++)
                {
                    for (int j = 0; j < mapSize - 1; j++)
                    {
                        if (mapNumbers[i, j] == mapNumbers[i, j + 1])
                        {
                            mapNumbers[i, j] *= 2;
                            ScoreAdd(i, j);
                            mapNumbers[i, j + 1] = 0;
                        }
                    }
                }

                LeftShift();
            }
            if (e.KeyCode == Keys.Right)
            {
                RightShift();

                for (int i = 0; i < mapSize; i++)
                {
                    for (int j = mapSize - 1; j > 0; j--)
                    {
                        if (mapNumbers[i, j] == mapNumbers[i, j - 1])
                        {
                            mapNumbers[i, j] *= 2;
                            ScoreAdd(i, j);
                            mapNumbers[i, j - 1] = 0;
                        }
                    }
                }

                RightShift();
            }

            if (CompareMapNumbers()) GenerateNumber();
            MapUpdate();
        }

        private void ScoreAdd(int i, int j)
        {
            score += mapNumbers[i, j];
            scoreNumberLabel.Text = score.ToString();
        }

        private void MapUpdate()
        {
            for (int i = 0; i < mapSize; i++)
            {
                for (int j = 0; j < mapSize; j++)
                {
                    if (mapNumbers[j, i] == 0) mapLabel[j, i].Text = "";
                    else mapLabel[j, i].Text = Convert.ToString(mapNumbers[j, i]);
                    updateColor(j, i);
                }
            }
        }

        private void updateColor(int j, int i)
        {
            int num = mapNumbers[j, i];


           switch (num)
           {
                case 0: mapLabel[j, i].BackColor = Color.FromArgb(205, 193, 180); break;
                case 2: mapLabel[j, i].BackColor = Color.FromArgb(238, 228, 218); break;
                case 4: mapLabel[j, i].BackColor = Color.FromArgb(237, 224, 200); break;
                case 8: mapLabel[j, i].BackColor = Color.FromArgb(242, 177, 121); break;
                case 16: mapLabel[j, i].BackColor = Color.FromArgb(245, 149, 99); break;
                case 32: mapLabel[j, i].BackColor = Color.FromArgb(246, 124, 95); break;
                case 64: mapLabel[j, i].BackColor = Color.FromArgb(246, 94, 59); break;
                case 128: mapLabel[j, i].BackColor = Color.FromArgb(237, 207, 114); break;
                case 256: mapLabel[j, i].BackColor = Color.FromArgb(237, 204, 97); break;
                case 512: mapLabel[j, i].BackColor = Color.FromArgb(237, 200, 80); break;
                case 1024: mapLabel[j, i].BackColor = Color.FromArgb(237, 197, 63); break;
                case 2048: mapLabel[j, i].BackColor = Color.FromArgb(237, 194, 46); break;
                default: mapLabel[j, i].BackColor = Color.FromArgb(60, 58, 50); break;
            }

            if (num < 8) mapLabel[j, i].ForeColor = Color.FromArgb(119, 110, 101);
            else mapLabel[j, i].ForeColor = Color.FromArgb(249, 246, 242);
        }

        private void updateLastMapNumbers()
        {
            for (int i = 0; i < mapSize; i++)
            {
                for (int j = 0; j < mapSize; j++)
                {
                    lastMapNumbers[i, j] = mapNumbers[i, j];
                }
            }
        }

        private bool CompareMapNumbers()
        {
            for (int i = 0; i < mapSize; i++)
            {
                for (int j = 0; j < mapSize; j++)
                {
                    if (lastMapNumbers[i, j] != mapNumbers[i, j])
                    {
                        return true;
                    }
                }
            }

            if (IsGameOver())
            {
                MessageBox.Show("Вы проиграли");
                if (firstTimeLose)
                {
                    user.Score = score;
                    userRepository.Save(user);
                    firstTimeLose = false;
                }
            }
            return false;
        }

        private bool IsGameOver()
        {
            for (int i = 0; i < mapSize; i++)
            {
                for (int j = 0; j < mapSize; j++)
                {
                    if (mapNumbers[i, j] == 0)
                    {
                        return false;
                    }
                }
            }

            for (int i = 0; i < mapSize; i++)
            {
                for (int j = 0; j < mapSize - 1; j++)
                {
                    if (mapNumbers[i, j] == mapNumbers[i, j + 1] || mapNumbers[j, i] == mapNumbers[j + 1, i])
                    {
                        return false;
                    }
                }
            }

            return true;
        }

        private bool UpDownShiftTryMove(int k, int j, int i)
        {
            if (mapNumbers[k, i] != 0)
            {
                mapNumbers[j, i] = mapNumbers[k, i];
                mapNumbers[k, i] = 0;

                return true;
            }
            return false;
        }

        private bool LeftRightShiftTryMove(int k, int j, int i)
        {
            if (mapNumbers[i, k] != 0)
            {
                mapNumbers[i, j] = mapNumbers[i, k];
                mapNumbers[i, k] = 0;

                return true;
            }
            return false;
        }

        private void UpShift()
        {
            for (int i = 0; i < mapSize; i++)
            {
                for (int j = 0; j < mapSize; j++)
                {
                    if (mapNumbers[j, i] == 0)
                    {
                        for (int k = j + 1; k < mapSize; k++)
                        {
                            if (UpDownShiftTryMove(k, j, i)) break;
                        }
                    }
                }
            }
        }

        private void DownShift()
        {
            for (int i = 0; i < mapSize; i++)
            {
                for (int j = mapSize - 1; j >= 0; j--)
                {
                    if (mapNumbers[j, i] == 0)
                    {
                        for (int k = j - 1; k >= 0; k--)
                        {
                            if (UpDownShiftTryMove(k, j, i)) break;
                        }
                    }
                }
            }
        }

        private void LeftShift()
        {
            for (int i = 0; i < mapSize; i++)
            {
                for (int j = 0; j < mapSize; j++)
                {
                    if (mapNumbers[i, j] == 0)
                    {
                        for (int k = j + 1; k < mapSize; k++)
                        {
                            if (LeftRightShiftTryMove(k, j, i)) break;
                        }
                    }
                }
            }
        }

        private void RightShift()
        {
            for (int i = 0; i < mapSize; i++)
            {
                for (int j = mapSize - 1; j >= 0; j--)
                {
                    if (mapNumbers[i, j] == 0)
                    {
                        for (int k = j - 1; k >= 0; k--)
                        {
                            if (LeftRightShiftTryMove(k, j, i)) break;
                        }
                    }
                }
            }
        }

        private void перезагрузкаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void результатыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var userList = new UserListForm();

            userList.Show();
        }
    }
}
