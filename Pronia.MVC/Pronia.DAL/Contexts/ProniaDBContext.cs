using Microsoft.EntityFrameworkCore;
using Pronia.DAL.Models;

namespace Pronia.DAL.Contexts;

public class ProniaDBContext : DbContext
{
    public DbSet<SliderItem> SliderItems { get; set; }

    public ProniaDBContext(DbContextOptions<ProniaDBContext> opt) : base(opt)
    {

    }

}
