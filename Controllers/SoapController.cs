using Microsoft.AspNetCore.Mvc;
using SoapMvcApp.Models;
using System.Collections.Generic;

public class SoapController : Controller
{
    public IActionResult Index()
    {
        var soaps = new List<Soap>
        {
            new Soap { Id = 1, Name = "Lavender Bliss", Scent = "Lavender", Price = 5.99m, Weight = 110, Description = "A calming lavender-scented soap." },
            new Soap { Id = 2, Name = "Citrus Splash", Scent = "Citrus", Price = 4.99m, Weight = 121, Description = "A refreshing citrus-scented soap." },
            new Soap { Id = 3, Name = "Minty Fresh", Scent = "Mint", Price = 6.99m, Weight = 124, Description = "An invigorating mint-scented soap." },
            new Soap { Id = 4, Name = "Aloe Vera Fresh", Scent = "Mild Aloe", Price = 2.99m, Weight = 91, Description = "Refreshing soap with soothing aloe vera." },
            new Soap { Id = 5, Name = "Rose Petal Luxury", Scent = "Rose", Price = 3.99m, Weight = 97, Description = "Luxurious soap with rose petal extract." },
            new Soap { Id = 6, Name = "Oatmeal Delight", Scent = "Unscented", Price = 6.99m, Weight = 90, Description = " Gentle exfoliating soap with oatmeal." },
            new Soap { Id = 7, Name = "Coconut Cream", Scent = "Coconut", Price = 5.99m, Weight = 190, Description = "Moisturizing soap with coconut oil." },
            new Soap { Id = 8, Name = "Citrus Burst", Scent = "Citrus", Price = 4.99m, Weight = 130, Description = " Energizing soap with citrus extracts." },
            new Soap { Id = 9, Name = "Charcoal Detox", Scent = "Mild", Price = 6.99m, Weight = 105, Description = "Detoxifying soap with activated charcoal." },
            new Soap { Id = 10, Name = "Honey & Almond", Scent = "Honey Almond", Price = 5.99m, Weight = 120, Description = "Nourishing soap with honey and almond." },
           
        };
        return View(soaps);
    }
}
