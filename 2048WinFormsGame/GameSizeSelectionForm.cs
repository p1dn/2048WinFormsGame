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

        public GameSizeSelectionForm()
        {
            InitializeComponent();
        }

        public GameSizeSelectionForm(string name)
        {
            this.name = name;
        }
    }
}
