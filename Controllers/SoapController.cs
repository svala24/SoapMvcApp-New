using Microsoft.AspNetCore.Mvc;
using SoapMvcApp.Models;
using System.Collections.Generic;

public class SoapController : Controller
{
    public IActionResult Index()
    {
        var soaps = new List<Soap>
        {
            new Soap { Id = 1, Name = "Lavender Bliss", Scent = "Lavender", Price = 5.99m, Description = "A calming lavender-scented soap." },
            new Soap { Id = 2, Name = "Citrus Splash", Scent = "Citrus", Price = 4.99m, Description = "A refreshing citrus-scented soap." },
            new Soap { Id = 3, Name = "Minty Fresh", Scent = "Mint", Price = 6.99m, Description = "An invigorating mint-scented soap." },
            new Soap { Id = 4, Name = "Aloe Vera Fresh", Scent = "Mild Aloe", Price = 2.99m, Description = "Refreshing soap with soothing aloe vera." },
            new Soap { Id = 5, Name = "Rose Petal Luxury", Scent = "Rose", Price = 3.99m, Description = "Luxurious soap with rose petal extract." },
            new Soap { Id = 6, Name = "Oatmeal Delight", Scent = "Unscented", Price = 6.99m, Description = " Gentle exfoliating soap with oatmeal." },
            new Soap { Id = 7, Name = "Coconut Cream", Scent = "Coconut", Price = 5.99m, Description = "Moisturizing soap with coconut oil." },
            new Soap { Id = 8, Name = "Citrus Burst", Scent = "Citrus", Price = 4.99m, Description = " Energizing soap with citrus extracts." },
            new Soap { Id = 9, Name = "Charcoal Detox", Scent = "Mild", Price = 6.99m, Description = "Detoxifying soap with activated charcoal." },
            new Soap { Id = 10, Name = "Honey & Almond", Scent = "Honey Almond", Price = 5.99m, Description = "Nourishing soap with honey and almond." },
           
        };
        return View(soaps);
    }
}
