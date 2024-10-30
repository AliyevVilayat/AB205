namespace LibraryManagementSystem.Exceptions;

public class LibraryItemException : Exception
{
    public LibraryItemException() : base("There is a Library item exception")
    {

    }

    public LibraryItemException(string message) : base(message)
    {

    }
}
