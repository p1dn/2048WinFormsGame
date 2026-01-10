using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;

namespace _2048WinFormsGame
{
    public class UserRepository
    {
        public List<User> Users { get; set; } = new List<User>();

        private string path = Path.Combine(
            Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData),
            "2048WinFormsGame",
            "users.json"
        );

        public void Save(User user)
        {
            Users.Add(user);

            Directory.CreateDirectory(Path.GetDirectoryName(path));
            string json = JsonSerializer.Serialize(Users, new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText(path, json);
        }

        public void Load()
        {
            if (!File.Exists(path)) return;

            string json = File.ReadAllText(path);
            Users = JsonSerializer.Deserialize<List<User>>(json) ?? new List<User>();
        }
    }
}
