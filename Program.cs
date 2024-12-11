using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mediator_Pattern
{
    public class Program
    {
        public static void Main(string[] args)
        {
            ChatMediator mediator = new ChatMediator();

            User user1 = new User("Oshkin", mediator);
            User user2 = new User("Sanya", mediator);
            mediator.AddUser(user1);
            mediator.AddUser(user2);
            user1.SendMessage("Привет, Саня!", "Sanya");
            user2.SendMessage("Привет, Ошкин!", "Oshkin");

            // Вывод истории сообщений
            Console.WriteLine("История сообщений Ошкина:");
            foreach (var message in user1.MessageHistory)
            {
                Console.WriteLine(message);
            }

            Console.WriteLine("История сообщений Сани:");
            foreach (var message in user2.MessageHistory)
            {
                Console.WriteLine(message);
            }

            // Удаление пользователя
            mediator.RemoveUser(user1);
        }
    }
}
