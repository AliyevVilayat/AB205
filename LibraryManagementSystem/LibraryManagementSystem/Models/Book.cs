using LibraryManagementSystem.Enums;

namespace LibraryManagementSystem.Models;

public class Book : LibraryItem
{
    private static int _counter;
    public int Id { get; set; }
    public BookGenreEnum Genre { get; set; }
    public LibraryLocation LibraryLocation { get; set; }

    public Book(string title, int? publicationYear) : base(title, publicationYear)
    {
        _counter++;
        Id = _counter;

    }

    public override void DisplayInfo()
    {
        Console.WriteLine("Hello from Book");
    }
}



