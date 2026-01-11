namespace _2048WinFormsGame
{
    partial class GameSizeSelectionForm
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
            size6Button = new Button();
            size4Button = new Button();
            size3Button = new Button();
            size5Button = new Button();
            chooseSizeLabel = new Label();
            SuspendLayout();
            // 
            // size6Button
            // 
            size6Button.BackColor = Color.Wheat;
            size6Button.Font = new Font("Segoe UI Black", 36F, FontStyle.Bold, GraphicsUnit.Point, 204);
            size6Button.ForeColor = Color.DarkSlateGray;
            size6Button.Location = new Point(527, 491);
            size6Button.Name = "size6Button";
            size6Button.Size = new Size(293, 176);
            size6Button.TabIndex = 3;
            size6Button.Text = "6";
            size6Button.UseVisualStyleBackColor = false;
            size6Button.Click += size6Button_Click;
            // 
            // size4Button
            // 
            size4Button.BackColor = Color.Wheat;
            size4Button.Font = new Font("Segoe UI Black", 36F, FontStyle.Bold, GraphicsUnit.Point, 204);
            size4Button.ForeColor = Color.DarkSlateGray;
            size4Button.Location = new Point(527, 261);
            size4Button.Name = "size4Button";
            size4Button.Size = new Size(293, 176);
            size4Button.TabIndex = 4;
            size4Button.Text = "4";
            size4Button.UseVisualStyleBackColor = false;
            size4Button.Click += size4Button_Click;
            // 
            // size3Button
            // 
            size3Button.BackColor = Color.Wheat;
            size3Button.Font = new Font("Segoe UI Black", 36F, FontStyle.Bold, GraphicsUnit.Point, 204);
            size3Button.ForeColor = Color.DarkSlateGray;
            size3Button.Location = new Point(159, 261);
            size3Button.Name = "size3Button";
            size3Button.Size = new Size(293, 176);
            size3Button.TabIndex = 5;
            size3Button.Text = "3";
            size3Button.UseVisualStyleBackColor = false;
            size3Button.Click += size3Button_Click;
            // 
            // size5Button
            // 
            size5Button.BackColor = Color.Wheat;
            size5Button.Font = new Font("Segoe UI Black", 36F, FontStyle.Bold, GraphicsUnit.Point, 204);
            size5Button.ForeColor = Color.DarkSlateGray;
            size5Button.Location = new Point(159, 491);
            size5Button.Name = "size5Button";
            size5Button.Size = new Size(293, 176);
            size5Button.TabIndex = 6;
            size5Button.Text = "5";
            size5Button.UseVisualStyleBackColor = false;
            size5Button.Click += size5Button_Click;
            // 
            // chooseSizeLabel
            // 
            chooseSizeLabel.AutoSize = true;
            chooseSizeLabel.Font = new Font("Segoe UI Black", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            chooseSizeLabel.ForeColor = Color.DarkSlateGray;
            chooseSizeLabel.Location = new Point(12, 71);
            chooseSizeLabel.Name = "chooseSizeLabel";
            chooseSizeLabel.Size = new Size(308, 50);
            chooseSizeLabel.TabIndex = 7;
            chooseSizeLabel.Text = "ChooseSizeText";
            // 
            // GameSizeSelectionForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.BurlyWood;
            ClientSize = new Size(984, 961);
            Controls.Add(chooseSizeLabel);
            Controls.Add(size5Button);
            Controls.Add(size3Button);
            Controls.Add(size4Button);
            Controls.Add(size6Button);
            Name = "GameSizeSelectionForm";
            Text = "GameSizeSelectionForm";
            Load += GameSizeSelectionForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button3;
        private Button size6Button;
        private Button size4Button;
        private Button size3Button;
        private Button size5Button;
        private Label chooseSizeLabel;
        private Button button5;
    }
}