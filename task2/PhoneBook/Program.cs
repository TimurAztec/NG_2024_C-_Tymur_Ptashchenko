using System;
using PhoneBook.Data;
using PhoneBook.Models;

public class Program
{
    public static void Main(string[] args)
    {
        while (true)
        {
            try
            {
                Console.WriteLine("Enter command (Q - exit, A - add, GP - Get by phone, GN - Get by name, GA - Get all, D - delete by phone):");
                string command = Console.ReadLine()?.Trim().ToUpper();

                switch (command)
                {
                    case "Q":
                        return;
                    case "A":
                        AddPerson();
                        break;
                    case "GP":
                        GetPersonByPhone();
                        break;
                    case "GN":
                        GetPersonByName();
                        break;
                    case "GA":
                        GetAllPersons();
                        break;
                    case "D":
                        DeletePersonByPhone();
                        break;
                    default:
                        Console.WriteLine("Unknown command. Please try again.");
                        break;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }
    }

    protected static void AddPerson()
    {
        Console.WriteLine("Enter Full Name:");
        string fullName = Console.ReadLine()?.Trim();
        Console.WriteLine("Enter Phone Number:");
        string phoneNumber = Console.ReadLine()?.Trim();

        if (Data.People.Any(p => p.PhoneNumber == phoneNumber))
        {
            throw new InvalidOperationException("A person with this phone number already exists.");
        }

        Data.People.Add(new Contact { FullName = fullName, PhoneNumber = phoneNumber });
        Console.WriteLine("Person added successfully.");
    }

    protected static void GetPersonByPhone()
    {
        Console.WriteLine("Enter Phone Number:");
        string phoneNumber = Console.ReadLine()?.Trim();

        var person = Data.People.FirstOrDefault(p => p.PhoneNumber == phoneNumber);
        if (person == null)
        {
            throw new InvalidOperationException("No person found with this phone number.");
        }

        Console.WriteLine($"Full Name: {person.FullName}, Phone Number: {person.PhoneNumber}");
    }

    protected static void GetPersonByName()
    {
        Console.WriteLine("Enter Full Name:");
        string fullName = Console.ReadLine()?.Trim();

        var persons = Data.People.Where(p => p.FullName.Contains(fullName, StringComparison.OrdinalIgnoreCase)).ToList();
        if (!persons.Any())
        {
            throw new InvalidOperationException("No persons found with this full name.");
        }

        Console.WriteLine("Persons found:");
        foreach (var person in persons)
        {
            Console.WriteLine(person.FullName);
        }
    }


    protected static void GetAllPersons()
    {
        var orderedPeople = Data.People.OrderBy(p => p.FullName).ToList();
        Console.WriteLine("All persons ordered by name:");
        foreach (var person in orderedPeople)
        {
            Console.WriteLine($"Full Name: {person.FullName}, Phone Number: {person.PhoneNumber}");
        }
    }

    protected static void DeletePersonByPhone()
    {
        Console.WriteLine("Enter Phone Number:");
        string phoneNumber = Console.ReadLine()?.Trim();

        var person = Data.People.FirstOrDefault(p => p.PhoneNumber == phoneNumber);
        if (person == null)
        {
            throw new InvalidOperationException("No person found with this phone number.");
        }

        Data.People.Remove(person);
        Console.WriteLine("Person deleted successfully.");
    }
}