namespace AddressBook_Program
{
    class Program
    {
        static void Main(string[] args)
        {
            CreateContact createContact = new CreateContact();
            createContact.AddPerson();
            createContact.ListPeople();
        }
    }
}