namespace Lesson10.Exceptions;

public class EmptyStringException : Exception
{
    public EmptyStringException()
    {
    }

    public EmptyStringException(string message) : base(message)
    {
    }
}

