using System;
using System.Collections.Generic;
using System.Linq;

namespace NullObjectPattern
{
    class Program
    {
        private static readonly List<User> _users = new List<User>()
        {
            new User(1, "Boris"),
            new User(2, "Test")
        };

        static void Main(string[] args)
        {
            for (int i = 1; i <= 3; i++)
            {
                var user = GetUserById(i);
                Console.WriteLine($"Welcome {user.Name}!");

                if (user.HasAccess())
                {
                    Console.WriteLine("You are allowed to join!");
                }
                else
                {
                    Console.WriteLine("You are not allowed to join!");
                }
            }
        }

        private static User GetUserById(int id)
        {
            var user = _users.FirstOrDefault(u => u.Id == id);

            if (user == null)
            {
                return new NullUser();
            }

            return user;
        }
    }
}
