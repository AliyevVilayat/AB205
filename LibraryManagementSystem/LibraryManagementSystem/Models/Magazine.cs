namespace LibraryManagementSystem.Models;

public class Magazine : LibraryItem
{
    public Magazine(string title, int? publicationYear) : base(title, publicationYear)
    {
    }

    public override void DisplayInfo()
    {
        Console.WriteLine("Hello from Magazine");
    }
}


/*



*/