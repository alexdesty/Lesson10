namespace Lesson10.Exceptions;

public class WrongUserInputException : Exception
{
    public WrongUserInputException()
    {
    }

    public WrongUserInputException(string message) : base(message)
    {
    }
}

