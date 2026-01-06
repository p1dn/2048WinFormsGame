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
        private const int mapSize = 4;
        private Label[,] mapLabel;
        private int[,] mapNumbers;
        private int[,] lastMapNumbers;
        private static Random rnd = new Random();
        private int score;

        public Game2048Form()
        {
            InitializeComponent();
        }

        private void Game2048Form_Load(object sender, EventArgs e)
        {
            lastMapNumbers = new int[mapSize, mapSize];
            mapNumbers = new int[mapSize, mapSize];
            mapLabel = new Label[mapSize, mapSize];
            score = 0;

            GenerateNumber();
            InitMap();
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

            label.BackColor = Color.FromArgb(192, 192, 255);
            label.Font = new Font("Bahnschrift SemiCondensed", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label.ForeColor = Color.SaddleBrown;
            label.Name = "label128";
            label.Size = new Size(150, 150);
            label.TextAlign = ContentAlignment.MiddleCenter;

            int x = 180 + indexColumn * 160;
            int y = 280 + indexRow * 160;
            label.Location = new Point(x, y);

            return label;
        }

        private void GenerateNumber()
        {
            while (true)
            {
                int randomNumber = rnd.Next(mapSize * mapSize);
                int indexRow = randomNumber / mapSize;
                int indexColumn = randomNumber % mapSize;

                if (mapNumbers[indexRow, indexColumn] == 0)
                {
                    mapNumbers[indexRow, indexColumn] = 2;
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
                }
            }
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

            if (IsGameOver()) MessageBox.Show("Вы проиграли");
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
    }
}
