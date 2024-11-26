using Microsoft.EntityFrameworkCore;
using Pronia.BL.Services.Abstractions;
using Pronia.DAL.Contexts;
using Pronia.DAL.Models;

namespace Pronia.BL.Services.Concretes;

public class SliderItemService : ISliderItemService
{
    private readonly ProniaDBContext _context;

    public SliderItemService(ProniaDBContext context)
    {
        _context = context;
    }

    #region Read
    public async Task<SliderItem> GetSliderItemByIdAsync(int id)
    {
        SliderItem? sliderItem = await _context.SliderItems.FindAsync(id);
        if (sliderItem is null)
        {
            throw new Exception($"Slider Item not found with this id({id})");
        }

        return sliderItem;
    }

    public async Task<List<SliderItem>> GetAllSliderItemsAsync()
    {
        List<SliderItem> sliderItems = await _context.SliderItems.ToListAsync();
        return sliderItems;
    }
    #endregion

    #region Create

    public async Task CreateSliderItemAsync(SliderItem sliderItem)
    {
        await _context.SliderItems.AddAsync(sliderItem);
        int rows = await _context.SaveChangesAsync();

        if (rows != 1)
        {
            throw new Exception("Something went wrong. Slider Item cannot be added");
        }
    }
    #endregion

    #region Update

    public async Task UpdateSliderItemAsync(int id, SliderItem sliderItem)
    {
        #region UpdateV1

        /*if (id != sliderItem.Id) { throw new Exception("Ids are not same"); }
        SliderItem? baseSliderItem = await _context.SliderItems.FindAsync(id);
        if (baseSliderItem is null)
        {
            throw new Exception($"Slider Item not found with this id({id})");
        }

        if (baseSliderItem.IsDeleted)
        {
            throw new Exception($"Slider Item not found with this id({id})");
        }

        baseSliderItem.Title = sliderItem.Title;
        baseSliderItem.ShortDescription = sliderItem.ShortDescription;
        baseSliderItem.Offer = sliderItem.Offer;
        baseSliderItem.ImgPath = sliderItem.ImgPath;

        baseSliderItem.LastModifiedDate = DateTime.Now;

        await _context.SaveChangesAsync();*/
        #endregion

        #region UpdateV2

        if (id != sliderItem.Id)
        {
            throw new Exception("Ids are not same");
        }


        SliderItem? baseSliderItem = await _context.SliderItems.AsNoTracking().SingleOrDefaultAsync(s => s.Id == id && !s.IsDeleted);

        if (baseSliderItem is null)
        {
            throw new Exception($"Slider Item not found with this id({id})");
        }

        sliderItem.CreatedDate = baseSliderItem.CreatedDate;
        sliderItem.LastModifiedDate = DateTime.Now;

        _context.SliderItems.Update(sliderItem);
        await _context.SaveChangesAsync();

    }
    #endregion


    #endregion

    #region Delete

    public async Task SoftDeleteSliderItemAsync(int id)
    {
        #region SoftDeleteV1

        /*        SliderItem? baseSliderItem = await _context.SliderItems.AsNoTracking().SingleOrDefaultAsync(s => s.Id == id && !s.IsDeleted);
                if (baseSliderItem is null)
                {
                    throw new Exception($"Slider Item not found with this id({id})");
                }

                baseSliderItem.IsDeleted = true;
                baseSliderItem.LastModifiedDate = DateTime.Now;
                baseSliderItem.DeletedDate = DateTime.Now;

                _context.SliderItems.Update(baseSliderItem);
                await _context.SaveChangesAsync();*/
        #endregion

        #region SoftDeleteV2
        SliderItem? baseSliderItem = await _context.SliderItems.SingleOrDefaultAsync(s => s.Id == id && !s.IsDeleted);
        if (baseSliderItem is null)
        {
            throw new Exception($"Slider Item not found with this id({id})");
        }

        baseSliderItem.IsDeleted = true;
        baseSliderItem.LastModifiedDate = DateTime.Now;
        baseSliderItem.DeletedDate = DateTime.Now;

        await _context.SaveChangesAsync();
        #endregion

    }

    public async Task HardDeleteSliderItemAsync(int id)
    {


        SliderItem? baseSliderItem = await _context.SliderItems.FindAsync(id);
        if (baseSliderItem is null)
        {
            throw new Exception($"Slider Item not found with this id({id})");
        }

        _context.SliderItems.Remove(baseSliderItem);
    }

    #endregion

}
