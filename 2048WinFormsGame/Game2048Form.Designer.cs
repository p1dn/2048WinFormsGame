namespace _2048WinFormsGame
{
    partial class Game2048Form
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            gameRulesLabel = new Label();
            scoreTextLabel = new Label();
            scoreNumberLabel = new Label();
            играToolStripMenuItem = new ToolStripMenuItem();
            результатыToolStripMenuItem = new ToolStripMenuItem();
            перезагрузкаToolStripMenuItem = new ToolStripMenuItem();
            выходToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1 = new MenuStrip();
            bestResultTextLabel = new Label();
            bestResultNumberLabel = new Label();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // gameRulesLabel
            // 
            gameRulesLabel.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 204);
            gameRulesLabel.Location = new Point(12, 70);
            gameRulesLabel.Name = "gameRulesLabel";
            gameRulesLabel.Size = new Size(960, 75);
            gameRulesLabel.TabIndex = 0;
            gameRulesLabel.Text = "How to play: Use your arrow keys to move the tiles. When two tiles with the same number touch, they merge into one!";
            // 
            // scoreTextLabel
            // 
            scoreTextLabel.AutoSize = true;
            scoreTextLabel.Font = new Font("Segoe UI Black", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            scoreTextLabel.Location = new Point(12, 196);
            scoreTextLabel.Name = "scoreTextLabel";
            scoreTextLabel.Size = new Size(98, 37);
            scoreTextLabel.TabIndex = 1;
            scoreTextLabel.Text = "Score:";
            // 
            // scoreNumberLabel
            // 
            scoreNumberLabel.AutoSize = true;
            scoreNumberLabel.Font = new Font("Segoe UI Black", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            scoreNumberLabel.Location = new Point(106, 196);
            scoreNumberLabel.Name = "scoreNumberLabel";
            scoreNumberLabel.Size = new Size(33, 37);
            scoreNumberLabel.TabIndex = 2;
            scoreNumberLabel.Text = "0";
            // 
            // играToolStripMenuItem
            // 
            играToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { результатыToolStripMenuItem, перезагрузкаToolStripMenuItem, выходToolStripMenuItem });
            играToolStripMenuItem.Name = "играToolStripMenuItem";
            играToolStripMenuItem.Size = new Size(50, 20);
            играToolStripMenuItem.Text = "Game";
            // 
            // результатыToolStripMenuItem
            // 
            результатыToolStripMenuItem.Name = "результатыToolStripMenuItem";
            результатыToolStripMenuItem.Size = new Size(180, 22);
            результатыToolStripMenuItem.Text = "Results";
            результатыToolStripMenuItem.Click += результатыToolStripMenuItem_Click;
            // 
            // перезагрузкаToolStripMenuItem
            // 
            перезагрузкаToolStripMenuItem.Name = "перезагрузкаToolStripMenuItem";
            перезагрузкаToolStripMenuItem.Size = new Size(180, 22);
            перезагрузкаToolStripMenuItem.Text = "Restart";
            перезагрузкаToolStripMenuItem.Click += перезагрузкаToolStripMenuItem_Click;
            // 
            // выходToolStripMenuItem
            // 
            выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            выходToolStripMenuItem.Size = new Size(180, 22);
            выходToolStripMenuItem.Text = "Exit";
            выходToolStripMenuItem.Click += выходToolStripMenuItem_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { играToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(984, 24);
            menuStrip1.TabIndex = 3;
            menuStrip1.Text = "menuStrip1";
            // 
            // bestResultTextLabel
            // 
            bestResultTextLabel.AutoSize = true;
            bestResultTextLabel.Font = new Font("Segoe UI Black", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            bestResultTextLabel.Location = new Point(523, 196);
            bestResultTextLabel.Name = "bestResultTextLabel";
            bestResultTextLabel.Size = new Size(174, 37);
            bestResultTextLabel.TabIndex = 4;
            bestResultTextLabel.Text = "Best Result:";
            // 
            // bestResultNumberLabel
            // 
            bestResultNumberLabel.AutoSize = true;
            bestResultNumberLabel.Font = new Font("Segoe UI Black", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            bestResultNumberLabel.Location = new Point(703, 196);
            bestResultNumberLabel.Name = "bestResultNumberLabel";
            bestResultNumberLabel.Size = new Size(33, 37);
            bestResultNumberLabel.TabIndex = 5;
            bestResultNumberLabel.Text = "0";
            // 
            // Game2048Form
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.BurlyWood;
            ClientSize = new Size(984, 961);
            Controls.Add(bestResultNumberLabel);
            Controls.Add(bestResultTextLabel);
            Controls.Add(scoreNumberLabel);
            Controls.Add(scoreTextLabel);
            Controls.Add(gameRulesLabel);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Game2048Form";
            Text = "2048";
            Load += Game2048Form_Load;
            KeyDown += Game2048Form_KeyDown;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label gameRulesLabel;
        private Label scoreTextLabel;
        private Label scoreNumberLabel;
        private ToolStripMenuItem играToolStripMenuItem;
        private ToolStripMenuItem результатыToolStripMenuItem;
        private ToolStripMenuItem перезагрузкаToolStripMenuItem;
        private ToolStripMenuItem выходToolStripMenuItem;
        private MenuStrip menuStrip1;
        private Label bestResultTextLabel;
        private Label bestResultNumberLabel;
    }
}