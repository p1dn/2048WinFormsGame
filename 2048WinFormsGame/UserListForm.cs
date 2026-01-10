using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace _2048WinFormsGame
{
    public partial class UserListForm : Form
    {
        private UserRepository UserRepository;

        public UserListForm()
        {
            InitializeComponent();
        }

        private void UserListForm_Load(object sender, EventArgs e)
        {
            UserRepository = new UserRepository();
            UserRepository.Load();

            foreach (var user in UserRepository.Users)
            {
                userListDataGridView.Rows.Add(user.Name, user.Score);
            }
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
