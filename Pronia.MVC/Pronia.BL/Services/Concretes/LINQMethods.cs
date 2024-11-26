using Pronia.DAL.Contexts;

namespace Pronia.BL.Services.Concretes;

class LINQMethods
{
    private readonly ProniaDBContext _context;

    public LINQMethods(ProniaDBContext context)
    {
        _context = context;
    }

    public void Test()
    {

        _context.SliderItems.Find();
        _context.SliderItems.First(); //Sert odenmezse throw Exception
        _context.SliderItems.FirstOrDefault(); //Sert odenmezse Null qaytarir

        _context.SliderItems.Single(); //Sert odenmezse throw Exception,birden cox data bu serti odeyirse throw Exception
        _context.SliderItems.SingleOrDefault(); // Sert odenmezse Null qaytarir,birden cox data bu serti odeyirse throw Exception



        //_context.SliderItems.Where();

    }
}
