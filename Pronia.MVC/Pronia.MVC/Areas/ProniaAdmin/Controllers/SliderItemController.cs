using Microsoft.AspNetCore.Mvc;
using Pronia.BL.Services.Abstractions;
using Pronia.DAL.Models;

namespace Pronia.MVC.Areas.ProniaAdmin.Controllers;

[Area("ProniaAdmin")]
public class SliderItemController : Controller
{
    private readonly ISliderItemService _sliderItemService;

    public SliderItemController(ISliderItemService sliderItemService)
    {
        _sliderItemService = sliderItemService;
    }

    public async Task<IActionResult> Index()
    {
        List<SliderItem> sliderItems = await _sliderItemService.GetAllSliderItemsAsync();
        return View(sliderItems);
    }

    [HttpGet]
    public IActionResult Create()
    {
        return View();
    }

    [HttpPost]
    public IActionResult Create(SliderItem sliderItem)
    {

        _sliderItemService.CreateSliderItemAsync(sliderItem);
        return RedirectToAction(nameof(Index));
    }

    public async Task<IActionResult> Info(int id)
    {
        SliderItem sliderItem = await _sliderItemService.GetSliderItemByIdAsync(id);
        return View(sliderItem);
    }

    [HttpGet]
    public async Task<IActionResult> Update(int id)
    {
        SliderItem sliderItem = await _sliderItemService.GetSliderItemByIdAsync(id);
        return View(sliderItem);
    }

    [HttpPost]
    public async Task<IActionResult> Update(int id, SliderItem sliderItem)
    {
        if (!ModelState.IsValid)
        {
            return View(sliderItem);
        }

        await _sliderItemService.UpdateSliderItemAsync(id, sliderItem);

        return RedirectToAction(nameof(Index));
    }

    [HttpGet]
    public async Task<IActionResult> Delete(int id)
    {
        SliderItem sliderItem = await _sliderItemService.GetSliderItemByIdAsync(id);
        return View(sliderItem);
    }

    [HttpPost]
    [ActionName("Delete")]
    public async Task<IActionResult> DeletePost(int id)
    {
        await _sliderItemService.SoftDeleteSliderItemAsync(id);
        return RedirectToAction(nameof(Index));
    }
}

