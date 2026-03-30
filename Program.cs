using System;

namespace UserManagementSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Тестовый код для проверки функционала (из ветки feature/user-removal)
            var manager = new UserManager();
            manager.AddUser("test");
            Console.WriteLine("Добавлен пользователь 'test'");

            bool isRemoved = manager.RemoveUser("test");
            Console.WriteLine($"Результат удаления пользователя 'test': {isRemoved}"); // Должно вывести True

            Console.WriteLine("Нажмите любую клавишу для выхода...");
            Console.ReadKey();
        }
    }
}