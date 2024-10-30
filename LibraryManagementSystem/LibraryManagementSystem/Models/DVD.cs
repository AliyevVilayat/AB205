namespace LibraryManagementSystem.Models;

public class DVD : LibraryItem
{
    public DVD(string title, int? publicationYear) : base(title, publicationYear)
    {
    }

    public override void DisplayInfo()
    {
        Console.WriteLine("Hello from DVD");
    }
}


/*



*/