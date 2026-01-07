namespace _2048WinFormsGame
{
    partial class WelcomeForm
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
            helloLabel = new Label();
            enterNameLabel = new Label();
            userNameTextBox = new TextBox();
            enterButton = new Button();
            SuspendLayout();
            // 
            // helloLabel
            // 
            helloLabel.AutoSize = true;
            helloLabel.Font = new Font("Segoe UI Black", 36F, FontStyle.Bold, GraphicsUnit.Point, 204);
            helloLabel.ForeColor = Color.DarkSlateGray;
            helloLabel.Location = new Point(233, 49);
            helloLabel.Name = "helloLabel";
            helloLabel.Size = new Size(517, 65);
            helloLabel.TabIndex = 0;
            helloLabel.Text = "Добро пожаловать!";
            // 
            // enterNameLabel
            // 
            enterNameLabel.AutoSize = true;
            enterNameLabel.Font = new Font("Segoe UI Black", 24F, FontStyle.Bold, GraphicsUnit.Point, 204);
            enterNameLabel.ForeColor = Color.DarkSlateGray;
            enterNameLabel.Location = new Point(325, 331);
            enterNameLabel.Name = "enterNameLabel";
            enterNameLabel.Size = new Size(324, 45);
            enterNameLabel.TabIndex = 1;
            enterNameLabel.Text = "Введите ваше имя";
            // 
            // userNameTextBox
            // 
            userNameTextBox.BackColor = SystemColors.ControlDarkDark;
            userNameTextBox.Font = new Font("Segoe UI Black", 24F, FontStyle.Bold, GraphicsUnit.Point, 204);
            userNameTextBox.ForeColor = SystemColors.InactiveBorder;
            userNameTextBox.Location = new Point(325, 398);
            userNameTextBox.Name = "userNameTextBox";
            userNameTextBox.Size = new Size(324, 50);
            userNameTextBox.TabIndex = 2;
            userNameTextBox.TextChanged += userNameTextBox_TextChanged;
            // 
            // enterButton
            // 
            enterButton.Location = new Point(325, 549);
            enterButton.Name = "enterButton";
            enterButton.Size = new Size(324, 81);
            enterButton.TabIndex = 3;
            enterButton.Text = "Далее";
            enterButton.UseVisualStyleBackColor = true;
            enterButton.Click += enterButton_Click;
            // 
            // WelcomeForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.BurlyWood;
            ClientSize = new Size(984, 961);
            Controls.Add(enterButton);
            Controls.Add(userNameTextBox);
            Controls.Add(enterNameLabel);
            Controls.Add(helloLabel);
            Name = "WelcomeForm";
            Text = "WelcomeForm";
            Load += WelcomeForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label helloLabel;
        private Label enterNameLabel;
        private TextBox userNameTextBox;
        private Button enterButton;
    }
}