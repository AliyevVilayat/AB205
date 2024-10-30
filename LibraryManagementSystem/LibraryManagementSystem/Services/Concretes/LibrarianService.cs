using LibraryManagementSystem.Models;
using LibraryManagementSystem.Services.Interfaces;

namespace LibraryManagementSystem.Services.Concretes;

public class LibrarianService : ILibrarianService
{
    public static List<Librarian> Librarians;

    public LibrarianService()
    {
        Librarians = new List<Librarian>();
    }
    public void CreateLibrarian(Librarian librarian)
    {
        Librarians.Add(librarian);
    }

    public void DeleteLibrarian(int id, bool IsSoftDelete)
    {
        int index = -1;
        for (int i = 0; i < Librarians.Count; i++)
        {
            if (id == Librarians[i].Id)
            {
                index = i;
                break;
            }
        }

        if (index != -1)
        {
            if (IsSoftDelete)
            {
                Librarians[index].LibrarianStatus = Enums.LibrarianStatusEnum.Removed;
            }
            else
            {

                Librarians.Remove(Librarians[index]);
            }
        }
        else
        {
            throw new Exception($"Librarians list daxilinde gonderilen id-e({id}) uygun deyer tapilmadi, bu sebebden Delete prosesi yekunlasmadi");
        }
    }

    public List<Librarian> GetAllLibrarians()
    {
        return Librarians;
    }

    public Librarian GetLibrarianById(int id)
    {
        int index = -1;
        for (int i = 0; i < Librarians.Count; i++)
        {
            if (id == Librarians[i].Id)
            {
                index = i;
                break;
            }
        }

        if (index != -1)
        {
            return Librarians[index];
        }
        else
        {
            throw new Exception($"Librarians list daxilinde gonderilen id-e({id}) uygun deyer tapilmadi, bu sebebden geriye deyer qaytarila bilmedi.");
        }
    }
}
