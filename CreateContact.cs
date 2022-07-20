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

            Console.Write("Enter Area: ");
            person.Area = Console.ReadLine();
            Console.Write("Enter City: ");
            person.City = Console.ReadLine();
            Console.Write("Enter State: ");
            person.State = Console.ReadLine();
            Console.Write("Enter Zip: ");
            person.Zip = Console.ReadLine();
           
            People.Add(person);

        }
        //This method is Print the Person Details.
        public void PrintPerson(Person person)
        {
            Console.WriteLine("First Name: " + person.FirstName);
            Console.WriteLine("Last Name: " + person.LastName);
            Console.WriteLine("Phone Number: " + person.PhoneNumber);
            Console.WriteLine("Email: " + person.Email);
            Console.WriteLine("Address: Area " + person.Area);
            Console.WriteLine("City: " + person.City);
            Console.WriteLine("State: " + person.State);
            Console.WriteLine("Zip: " + person.Zip);
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
            for(int i = 0; i < People.Count; i++ )
            {
                PrintPerson(People[i]);
            }
            Console.WriteLine("\nPress any key to continue.");
            Console.ReadKey();
        }
        public void Edit()
        {
            if (People.Count != 0)
            {
                string edit = Console.ReadLine();
                foreach (var person in People)
                {
                    PrintPerson(person);
                    if (person.FirstName.ToLower() == edit.ToLower())
                    {
                        while (true)
                        {
                            Console.WriteLine("Changes");
                            Console.WriteLine("Enter the number:");
                            int number = Convert.ToInt32(Console.ReadLine());
                            switch (number)
                            {
                                case 1:
                                    Console.WriteLine("Enter New First name: ");
                                    person.FirstName = Console.ReadLine();
                                    break;
                                case 2:
                                    Console.WriteLine("Enter New Last name: ");
                                    person.LastName = Console.ReadLine();
                                    break;
                                case 3:
                                    Console.WriteLine("Enter New Phone Number: ");
                                    person.PhoneNumber = Console.ReadLine();
                                    break;
                                case 4:
                                    Console.WriteLine("Enter New Area: ");
                                    person.Area = Console.ReadLine();
                                    Console.WriteLine("Enter New City: ");
                                    person.City = Console.ReadLine();
                                    Console.WriteLine("Enter New State: ");
                                    person.State = Console.ReadLine();
                                    Console.WriteLine("Enter New Zip: ");
                                    person.Zip = Console.ReadLine();
                                    break;
                                case 5:
                                    AddPerson();
                                    break;
                                default:
                                    Console.WriteLine("InValid Number");
                                    break;
                            }
                            return;
                        }
                    }
                    else
                    {
                        Console.Write("Enter valid name:");
                    }

                }
            }
            else
            {
                Console.WriteLine("Address book is Empty");
            }

        }
    }

    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public string Area { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zip { get; set; }
    }
}