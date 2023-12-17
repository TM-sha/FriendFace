using System.Runtime.CompilerServices;

namespace FriendFace
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                System.Console.OutputEncoding = System.Text.Encoding.Unicode;
                Register();
            }
        }

        public static void Register()
        {
            Console.WriteLine("-------Welcome to FriendFace!-------\n");
            Console.Write("Register user (Firstname/Lastname): ");
            var Username = Console.ReadLine();
            Console.Clear();
            Console.WriteLine($"Welcome, you are now logged in as: {Username}\n");
            Menu();
        }

        public static void Menu()
        {
            Console.WriteLine("Find other users (1)\n" +
                              "Show friends(2)\n" +
                              "Delete friend (3)\n" +
                              "Exit program (4)\n");
            var input = Console.ReadLine();
            Console.Clear();

            switch (input)
            {
                case "1":
                    BrowseNewUsers();
                    break;
                case "2":
                    ShowFriends();
                    break;
                case "3":
                    RemoveFriend();
                    break;
                case "4":
                    Environment.Exit(1);
                    break;
            }
        }

        public static List<User> users = new List<User>()
        {
            new User("Jonny Uten H", 33, "Oslo", "Studerer IT og spiller pc-spill på fritida."),
            new User("Carl Sverige", 35, "Oslo", "Studerer IT og spiller pc-spill på fritida."),
            new User("Ine Gamlebø", 19, "Molde", "Studerer IT og spiller pc-spill på fritida."),
            new User("Aleksander Bjarnesen", 23, "Fredrikstad", "Studerer IT og spiller pc-spill på fritida."),
            new User("Eskil Glupben", 55, "Larvik", "Studerer IT og spiller pc-spill på fritida."),
            new User("Terje Svenderup", 52, "Larvik", "Studerer IT og spiller pc-spill på fritida."),
            new User("Nils Benjaminsen", 34, "Bergen", "Studerer IT og spiller pc-spill på fritida."),
            new User("Stian Lærvik", 26, "Oslo", "Studerer IT og spiller pc-spill på fritida."),
            new User("Ellen Degernes", 50, "Tønsberg", "Studerer IT og spiller pc-spill på fritida."),
            new User("John Doe", 28, "Kristiansand", "Studerer IT og spiller pc-spill på fritida."),
            new User("Simen Simonsen", 20, "Oslo", "Studerer IT og spiller pc-spill på fritida."),
        };
        static void BrowseNewUsers()
        {
            foreach (var user in users)
            {
                user.BrowseUsers();
            }

            GetUserInfo();
        }

        static void GetUserInfo()
        {
            Console.Write("Which user do you want to see? Firstname: ");
            switch (Console.ReadLine().ToUpper())
            {
                case "JONNY":
                    Console.Clear();
                    users[0].BrowseUserInfo();
                    AddFriend(users[0]);
                    break;
                case "CARL":
                    Console.Clear();
                    users[1].BrowseUserInfo();
                    AddFriend(users[1]);
                    break;
                case "INE":
                    Console.Clear();
                    users[2].BrowseUserInfo();
                    AddFriend(users[2]);
                    break;
                case "ALEKSANDER":
                    Console.Clear();
                    users[3].BrowseUserInfo();
                    AddFriend(users[3]);
                    break;
                case "ESKIL":
                    Console.Clear();
                    users[4].BrowseUserInfo();
                    AddFriend(users[4]);
                    break;
                case "TERJE":
                    Console.Clear();
                    users[5].BrowseUserInfo();
                    AddFriend(users[5]);
                    break;
                case "NILS":
                    Console.Clear();
                    users[6].BrowseUserInfo();
                    AddFriend(users[6]);
                    break;
                case "STIAN":
                    Console.Clear();
                    users[7].BrowseUserInfo();
                    AddFriend(users[7]);
                    break;
                case "ELLEN":
                    Console.Clear();
                    users[8].BrowseUserInfo();
                    AddFriend(users[8]);
                    break;
                case "JOHN":
                    Console.Clear();
                    users[9].BrowseUserInfo();
                    AddFriend(users[9]);
                    break;
                case "SIMEN":
                    Console.Clear();
                    users[10].BrowseUserInfo();
                    AddFriend(users[10]);
                    break;
                default:
                    Console.Clear();
                    Menu();
                    break;
            }
        }

        static void AddFriend(User users)
        {
            Console.Write("Do you want to add this user? y/n: \n");
            if (Console.ReadLine() == "y")
            {
                FriendList.Add(users);
            }
            Console.Clear();
            Menu();
        }

        public static List<User> FriendList = new List<User>();

        static void RemoveFriend()
        {
            foreach (var user in FriendList)
            {
                if (FriendList.Count <= 0)
                {
                    NoFriends();
                }
                else
                {
                    Console.WriteLine(user.Name);
                    Console.Write("Do you want to remove user 1... : ");

                    FriendList.RemoveAt(Convert.ToInt32(Console.ReadLine()) - 1);
                    Console.Clear();
                    Menu();
                }
            }
        }

        static void ShowFriends()
        {
            if (FriendList.Count <= 0)
            {
                NoFriends();
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Dine venner:\n");
                foreach (var user in FriendList)
                {
                    Console.WriteLine(user.Name);
                }

                Console.ReadLine();
                Console.Clear();
                Menu();
            }
        }

        private static void NoFriends()
        {
            Console.WriteLine("You have no friends :-(");
            Thread.Sleep(1500);
            Console.Clear();
            Menu();
        }
    }
}