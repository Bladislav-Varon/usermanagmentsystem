using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserManagementSystem
{
    public class UserManager
    {
        // Создаём список для хранения пользователей
        private List<string> _users = new List<string>();

        // Метод для добавления пользователя
        public void AddUser(string username)
        {
            _users.Add(username);
        }
        public bool RemoveUser(string username)
        {
            return _users.Remove(username);
        }

    }
}