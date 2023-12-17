using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FriendFace
{
    internal class User
    {
        public string Name;
        private int _age;
        private string _location;
        private string _om;

        public User(string name, int age, string location, string om)
        {
            Name = name;
            _age = age;
            _location = location;
            _om = om;
        }

        public void BrowseUsers()
        {
            Console.WriteLine($"{Name} is on FriendFace.\n");
        }

        public void BrowseUserInfo()
        {
            Console.WriteLine($"Navn: {Name}\n" +
                              $"Alder: {_age}\n" +
                              $"Bosted: {_location}\n" +
                              $"Om: {_om}\n");
        }
    }
}
