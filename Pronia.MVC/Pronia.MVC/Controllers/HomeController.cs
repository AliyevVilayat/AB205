using Microsoft.AspNetCore.Mvc;
using Pronia.BL.Services.Abstractions;
using Pronia.DAL.Models;

namespace Pronia.MVC.Controllers;

public class HomeController : Controller
{
    private readonly ISliderItemService _sliderItemService;

    public HomeController(ISliderItemService sliderItemService)
    {
        _sliderItemService = sliderItemService;
    }

    public async Task<IActionResult> Index()
    {
        List<SliderItem> sliderItems = await _sliderItemService.GetAllSliderItemsAsync();
        return View(sliderItems);
    }
}
