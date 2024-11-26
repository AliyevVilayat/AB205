using Pronia.DAL.Models;

namespace Pronia.BL.Services.Abstractions;

public interface ISliderItemService
{

    Task<List<SliderItem>> GetAllSliderItemsAsync();

    Task<SliderItem> GetSliderItemByIdAsync(int id);

    Task CreateSliderItemAsync(SliderItem sliderItem);
    Task UpdateSliderItemAsync(int id, SliderItem sliderItem);
    Task SoftDeleteSliderItemAsync(int id);
    Task HardDeleteSliderItemAsync(int id);

}
