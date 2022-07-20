namespace AddressBook_Program
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Address Book Program");

            CreateContact createContact = new CreateContact();

            string command = "";
            while (command != "exit")
            {
                Console.Clear();
                Console.WriteLine("Please enter a command: ");
                command = Console.ReadLine().ToLower();

                switch (command)
                {
                    case "add":
                        createContact.AddPerson();
                        break;
                    case "list":
                        createContact.ListPeople();
                        break;
                    case "edit":
                        Console.WriteLine("Enter the Name of Person");
                        string Name = Console.ReadLine();
                        createContact.edit(Name);
                        break;
                }
            }
            Console.WriteLine("Enter \'exit\' to Program End");
        }
    }
}