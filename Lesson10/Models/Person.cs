using System.Text.RegularExpressions;
using Lesson10.Exceptions;

namespace Lesson10.Models;

internal class Person
{
    private string _name;

    private string _surname;

    public string Name
    {
        get
        {
            return _name;
        }
        set
        {
            InputCheck(value);
            _name = value;
        }
    }

    public string Surname
    {
        get
        {
            return _surname;
        }
        set
        {
            InputCheck(value);
            _surname = value;
        }
    }

    public string InputCheck(string inputText)
    {
        if (String.IsNullOrEmpty(inputText))
        {
            throw new EmptyStringException("Nothing entered");
        }
        Regex regex = new Regex(@"^[a-zA-Z-]+$");
        Match match = regex.Match(inputText);
        if (!match.Success)
        {
            throw new EmptyStringException("Invalid character used");
        }
        return inputText;
    }
}

