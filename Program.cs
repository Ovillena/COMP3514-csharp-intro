using System;

namespace College
{
    class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("What is your name?");
            // var name = Console.ReadLine();
            // Console.WriteLine("Hello " + name);

            var p = new Person {
                Id = 123,
                FirstName= "James",
                LastName= "Bond"
            };

            var s = new Student {
                Id = 321,
                FirstName = "Amy",
                LastName = "Fox",
                School = "BCIT",
                Specialization = "Foreign Affairs"
            };

            var t = new Team{
                TeamName = "Canucks",
                TeamCity = "Vancouver",
                State = "BC",
                Country = "Canada"
            };

            Console.WriteLine(p);
            Console.WriteLine(s);
            Console.WriteLine(t.TeamName + " " + t.Country);
        }
    }
}
