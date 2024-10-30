namespace LibraryManagementSystem.Models;

public sealed class LibraryMember : Person
{
    public DateTime MembershipDate { get; set; }
    public LibraryMember(string name) : base(name)
    {
    }

}

