using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook_Program
{
    public class CreateContact
    {
        //This Program is used to Create Contacts in the Address Book of the Peoples.

        public List<Person> People = new List<Person>();

        //This method is Add the Person Contact
        public void AddPerson()
        {
            Person person = new Person();
            
            Console.Write("Enter First Name: ");
            person.FirstName = Console.ReadLine();

            Console.Write("Enter Last Name: ");
            person.LastName = Console.ReadLine();

            Console.Write("Enter Phone Number: ");
            person.PhoneNumber = Console.ReadLine();

            Console.Write("Enter Email: ");
            person.Email = Console.ReadLine();

            string[] addresses = new string[4];
            Console.Write("Enter Area: ");
            addresses[0] = Console.ReadLine();
            Console.Write("Enter City: ");
            addresses[1] = Console.ReadLine();
            Console.Write("Enter State: ");
            addresses[2] = Console.ReadLine();
            Console.Write("Enter Zip: ");
            addresses[3] = Console.ReadLine();
            person.Addresses = addresses;
            People.Add(person);

        }
        //This method is Print the Person Details.
        public void PrintPerson(Person person)
        {
            Console.WriteLine("First Name: " + person.FirstName);
            Console.WriteLine("Last Name: " + person.LastName);
            Console.WriteLine("Phone Number: " + person.PhoneNumber);
            Console.WriteLine("Email: " + person.Email);
            Console.WriteLine("Address: Area " + person.Addresses[0]);
            Console.WriteLine("City: " + person.Addresses[1]);
            Console.WriteLine("State: " + person.Addresses[2]);
            Console.WriteLine("Zip: " + person.Addresses[3]);
            Console.WriteLine("--------------------------------");

        }
        //This method is Check the the Address Book is empty or not.
        public void ListPeople()
        {
            if (People.Count == 0)
            {
                Console.WriteLine("Your address book is empty. Press any key to continue.");
                Console.ReadKey();
                return;
            }
            Console.WriteLine("Here are the current people in your address book:\n");
            foreach(var person in People)
            {
                PrintPerson(person);
            }
            Console.WriteLine("\nPress any key to continue.");
            Console.ReadKey();

        }
    }

    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public string[] Addresses { get; set; }
    }
}