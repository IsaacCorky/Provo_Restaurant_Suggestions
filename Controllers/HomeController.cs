using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Provo_Restaurant_Suggestions.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Provo_Restaurant_Suggestions.Controllers
{
    public class HomeController : Controller
    {
        /*<!--
        <tr>
            <th scope="row">1</th>
            <td>Mark</td>
            <td>Otto</td>
            <td>mdo</td>
        </tr>-->*/
        public IActionResult Index()
        {
            List<string> FavFood = new List<string>();

            foreach (Top5 t in Top5.GetTop5())
            {
                if (t.Url == "Coming soon...") // no a tag for coming soon
                {
                    FavFood.Add(string.Format("<th scope=\"row\">{0}</th><td>{1}</td><td>{2}</td><td>{3}</td><td>{4}</td><td>{5}</td>", t.Rank, t.Name, t.Dish, t.Address, t.Phone, t.Url));
                }
                else
                {
                    FavFood.Add(string.Format("<th scope=\"row\">{0}</th><td>{1}</td><td>{2}</td><td>{3}</td><td>{4}</td><td><a target=\"_blank\" href=\"http://{5}\">{5}</a></td>", t.Rank, t.Name, t.Dish, t.Address, t.Phone, t.Url));
                }
            }

            return View(FavFood);
        }

        [HttpGet]
        public IActionResult Submit()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Submit(Restaurant RestaurantObject)
        {   //validation
            if (ModelState.IsValid)
            {
                Repository.AddResponse(RestaurantObject);
                return View("Confirmed"); //confirmation page only if valid
            }

            return View(); // stay on current page if invalid
        }

        public IActionResult AllEntries()
        {
            return View(Repository.Responses);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
