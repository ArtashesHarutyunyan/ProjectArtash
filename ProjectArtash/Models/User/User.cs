using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjectArtash.Models.Persons;

namespace ProjectArtash.Models.User
{
    public static class User
    {
        public static Person FirstInformation()
        {
            Console.WriteLine("Hello,What is your name?");
            string name = Console.ReadLine();
            Console.WriteLine("Surname:");
            string surname = Console.ReadLine();
            Console.WriteLine("Age:");
            int age = int.Parse(Console.ReadLine());
            Person person = new Person(name, surname, age);
            return person;
        }

    }
}
