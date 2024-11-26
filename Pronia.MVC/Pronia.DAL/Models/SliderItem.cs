namespace Pronia.DAL.Models;

public class SliderItem : BaseEntity
{
    public int Offer { get; set; }
    public string Title { get; set; }
    public string ShortDescription { get; set; }
    public string ImgPath { get; set; }
}
