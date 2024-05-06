using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace OOP
{
    internal class Program
    {
        struct PersonStruct
        {
            public string name;
            public int age;
            public string address;

            public PersonStruct(string name, int age, string address)
            {
                this.name = name;
                this.age = age;
                this.address = address;
            }
        }
        static void Main(string[] args)
        {
            /*LearnAboutStructures();
            UsingRef();
            UsingRefStructureCall();*/
            CallClassFunctions();
            Console.ReadLine();
        }

        private static void CallClassFunctions()
        {
            Vehicle vehicle = new Vehicle("Ford", "Fiesta", 153655);
            Console.WriteLine("Oh nice vehicle: ");
            Console.WriteLine(Vehicle.ReturnDetails(vehicle));
            Console.WriteLine("Use the Vehicle Object to call the method: ");
            Console.WriteLine(vehicle.ReturnDetails());
            Console.WriteLine("Its time to upgrade my vehicle");
            vehicle.Make = "Toyota";
            vehicle.Model = "Hilux Legend";
            vehicle.Mileage = 1500;
            Console.WriteLine(vehicle.ReturnDetails());
            Console.WriteLine(vehicle.ToString());
            Console.WriteLine(vehicle.Equals(vehicle));
        }

        static void LearnAboutStructures()
        {
            PersonStruct person;
            person.name = "John";
            person.age = 30;
            person.address = "123 Main St.";
            Console.WriteLine($"The person is {person.name} of age {person.age} who lives at {person.address}.");
        }

        static void UsingRef()
        {
            string newName = "";
            int newAge = 0;
            string newAddress = "";
            GetPerson(ref newName, ref newAge, ref newAddress);
            Console.WriteLine($"The person is {newName} of age {newAge} who lives at {newAddress}.");
        }

        static void GetPerson(ref string name, ref int age, ref string address)
        {
            Console.Write("Enter a name: ");
            name = Console.ReadLine();
            Console.Write("Enter an age: ");
            age = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter an address: ");
            address = Console.ReadLine();
        }

        static void UsingRefStructureCall()
        {
            Person person = new Person();
            GetPerson(ref person);
            Console.WriteLine($"The person is {person.name} of age {person.age} who lives at {person.address}.");
        }

        static Person GetPerson(ref Person person)
        {
            Console.Write("Enter a name: ");
            person.name = Console.ReadLine();
            Console.Write("Enter an age: ");
            person.age = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter an address: ");
            person.address = Console.ReadLine();
            return new Person(person.name, person.age, person.address);
        }
    }

    class Person
    {
        public string name;
        public int age;
        public string address;
        public Person()
        {
            
        }
        public Person(string name, int age, string address)
        {
            this.name = name;
            this.age = age;
            this.address = address;
        }
    }
}
