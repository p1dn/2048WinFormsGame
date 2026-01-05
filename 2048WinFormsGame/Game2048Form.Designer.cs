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
            gameRules = new Label();
            SuspendLayout();
            // 
            // gameRules
            // 
            gameRules.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 204);
            gameRules.Location = new Point(12, 70);
            gameRules.Name = "gameRules";
            gameRules.Size = new Size(960, 75);
            gameRules.TabIndex = 0;
            gameRules.Text = "Как играть: Используйте клавиши со стрелками, чтобы перемещать плитки. Когда две плитки с одинаковым номером соприкасаются, они объединяются в одну!";
            // 
            // Game2048Form
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.BurlyWood;
            ClientSize = new Size(984, 961);
            Controls.Add(gameRules);
            Name = "Game2048Form";
            Text = "2048";
            Load += Game2048Form_Load;
            KeyDown += Game2048Form_KeyDown;
            ResumeLayout(false);
        }

        #endregion

        private Label gameRules;
    }
}