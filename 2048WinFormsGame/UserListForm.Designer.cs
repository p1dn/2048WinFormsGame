namespace _2048WinFormsGame
{
    partial class UserListForm
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
            userListDataGridView = new DataGridView();
            UserName = new DataGridViewTextBoxColumn();
            Result = new DataGridViewTextBoxColumn();
            closeButton = new Button();
            ((System.ComponentModel.ISupportInitialize)userListDataGridView).BeginInit();
            SuspendLayout();
            // 
            // userListDataGridView
            // 
            userListDataGridView.AllowUserToAddRows = false;
            userListDataGridView.AllowUserToDeleteRows = false;
            userListDataGridView.BackgroundColor = Color.Wheat;
            userListDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            userListDataGridView.Columns.AddRange(new DataGridViewColumn[] { UserName, Result });
            userListDataGridView.Location = new Point(12, 12);
            userListDataGridView.Name = "userListDataGridView";
            userListDataGridView.ReadOnly = true;
            userListDataGridView.Size = new Size(960, 854);
            userListDataGridView.TabIndex = 0;
            // 
            // UserName
            // 
            UserName.FillWeight = 200F;
            UserName.HeaderText = "Имя";
            UserName.Name = "UserName";
            UserName.ReadOnly = true;
            UserName.Width = 418;
            // 
            // Result
            // 
            Result.FillWeight = 200F;
            Result.HeaderText = "Результат";
            Result.Name = "Result";
            Result.ReadOnly = true;
            Result.Width = 500;
            // 
            // closeButton
            // 
            closeButton.BackColor = Color.LemonChiffon;
            closeButton.Font = new Font("Segoe UI Black", 18F, FontStyle.Bold, GraphicsUnit.Point, 204);
            closeButton.ForeColor = Color.DarkSlateGray;
            closeButton.Location = new Point(12, 872);
            closeButton.Name = "closeButton";
            closeButton.Size = new Size(960, 77);
            closeButton.TabIndex = 1;
            closeButton.Text = "Закрыть";
            closeButton.UseVisualStyleBackColor = false;
            closeButton.Click += closeButton_Click;
            // 
            // UserListForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.BurlyWood;
            ClientSize = new Size(984, 961);
            Controls.Add(closeButton);
            Controls.Add(userListDataGridView);
            Name = "UserListForm";
            Text = "UserListForm";
            Load += UserListForm_Load;
            ((System.ComponentModel.ISupportInitialize)userListDataGridView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView userListDataGridView;
        private Button closeButton;
        private DataGridViewTextBoxColumn UserName;
        private DataGridViewTextBoxColumn Result;
    }
}