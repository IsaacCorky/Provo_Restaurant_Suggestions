using System;
using System.ComponentModel.DataAnnotations;

namespace Provo_Restaurant_Suggestions.Models
{
    public class Top5
    {
        //constructor
        public Top5(int rank)
        {
           Rank = rank;
        }

        public int Rank { get; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Address { get; set; }
#nullable enable
        public string? Dish { get; set; } = "It's all tasty!";
        [RegularExpression(@"^\(?([0-9]{3})\)?[-. ]?([0-9]{3})[-. ]?([0-9]{4})$",
        ErrorMessage = "Entered phone format is not valid.")]
        public string? Url { get; set; } = "Coming soon...";
        public string? Phone { get; set; }
#nullable disable
        
        

        public static Top5[] GetTop5()
        {
            Top5 t1 = new Top5(1)
            {
                
                Name = "Communal",
                Dish = "Pork Chop",
                Address = "201 N University Ave",
                Phone = "801 372 8000",
                Url = "www.communalrestaurant.com"
            };

            Top5 t2 = new Top5(2)
            {
                
                Name = "Mozz Pizza",
                Dish = "Pepperoni with Spicy Honey",
                Address = "145 N University Ave",
                Phone = "801 852 0069",
                Url = "www.mozzartisanpizza.com"
            };

            Top5 t3 = new Top5(3)
            {
                
                Name = "Black Sheep Cafe",
                Dish = "Navajo Tacos",
                Address = "19 N University Ave",
                Phone = "801 607 2485",
                Url = "www.blacksheepcafe.com"
            };

            Top5 t4 = new Top5(4)
            {
                
                Name = "Pho Plus",
                Dish = "Pho #1 with Stake",
                Address = "68 W Center St",
                Phone = "801 377 8808",
                Url = "www.phoplusutah.com"
            };

            Top5 t5 = new Top5(5)
            {
                
                Name = "Thai Hut",
                Address = "410 N University Ave",
                Phone = "801 691 1822"
            };

            return new Top5[] { t1, t2, t3, t4, t5 };

        }

    }
}
        

    