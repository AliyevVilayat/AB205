using LibraryManagementSystem.Enums;

namespace LibraryManagementSystem.Models;

public class Librarian : Person
{
    public DateTime HireDate { get; set; }
    public LibrarianStatusEnum LibrarianStatus { get; set; }
    public Librarian(string name) : base(name)
    {
        LibrarianStatus = LibrarianStatusEnum.Active;
    }

}

