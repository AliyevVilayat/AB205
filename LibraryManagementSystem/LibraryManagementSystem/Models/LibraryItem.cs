namespace LibraryManagementSystem.Models;

public abstract class LibraryItem
{

    public string Title { get; set; }
    public int? PublicationYear { get; set; }

    protected LibraryItem(string title, int? publicationYear)
    {
        Title = title;
        PublicationYear = publicationYear;
    }

    public abstract void DisplayInfo();
}


/*



*/