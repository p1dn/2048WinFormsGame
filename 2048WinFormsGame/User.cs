using System;
using System.Collections.Generic;
using System.Text;

namespace _2048WinFormsGame
{
    public class User
    {
        public string Name { get; }
        public int Score { get; set; }

        public User(string name)
        {
            Name = name;
            Score = 0;
        }
    }
}
