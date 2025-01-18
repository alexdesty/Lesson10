using Lesson10.Exceptions;
using Lesson10.Models;

namespace Lesson10;

internal class Program
{
    static void Main(string[] args)
    {
        try
        {
            Person person = new Person();
            Console.WriteLine("Enter Name:");
            person.Name = Console.ReadLine();
            Console.WriteLine("Enter Surname:");
            person.Surname = Console.ReadLine();
        }
        catch (EmptyStringException emptyStringEx)
        {
            Console.WriteLine($"Error: {emptyStringEx.Message}");
        }
        catch (WrongUserInputException wrongUserInputEx)
        {
            Console.WriteLine($"Error: {wrongUserInputEx.Message}");
        }
    }
}

