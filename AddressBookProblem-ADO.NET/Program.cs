using System;

namespace AddressBookProblem_ADO.NET
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to AddressBook System program using ADO.NET");
            ///Creating Instance object of AddressBookRepository class.
            AddressBookRepository repository = new AddressBookRepository();
            ///UC1 Creating a method for checking for the validity of the connection.
            repository.EnsureDataBaseConnection();
        }
    }
}
