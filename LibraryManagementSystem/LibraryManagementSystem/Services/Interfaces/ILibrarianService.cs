using LibraryManagementSystem.Models;

namespace LibraryManagementSystem.Services.Interfaces;

public interface ILibrarianService
{
    Librarian GetLibrarianById(int id);
    List<Librarian> GetAllLibrarians();
    void CreateLibrarian(Librarian librarian);
    void DeleteLibrarian(int id, bool IsSoftDelete);
}


