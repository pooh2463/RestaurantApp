
using System;
using System.Collections.Generic;
using System.Linq;

namespace RestaurantApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello SIT.1/1");
            Console.WriteLine("Week 2");
            Console.WriteLine();

            List<Restaurant> Restaurants = new List<Restaurant>
            {
                new Restaurant(1, "Quanjude Roast Duck", "Beijing Cuisine", 4.5),
                new Restaurant(2, "Donglaishun Hot Pot", "Hot Pot", 4.6),
                new Restaurant(3, "Din Tai Fung", "Taiwanese Cuisine", 4.7),
                 new Restaurant(4, "Huguosi Snacks","Snacks", 4.2),
                  new Restaurant(5, "Haidilao Hot Pot", "Hot Pot", 4.8),
            };

            Console.WriteLine("List of All Restaurants");
            Console.WriteLine("------------------------------------------------------------");
            Console.WriteLine("{0,-5} {1,-25} {2,-22} {3,-6}",
                "ID", "Name", "Type", "Rating");
            Console.WriteLine("------------------------------------------------------------");

            foreach (Restaurant restaurant in Restaurants)
            {
                Console.WriteLine("{0,-5} {1,-25} {2,-22} {3,-6:F1}",
                    restaurant.Id,
                    restaurant.Name,
                    restaurant.Type,
                    restaurant.Rating
                    );
            }
            Console.WriteLine("------------------------------------------------------------");
            Console.WriteLine("Total Restaurants: {0}", Restaurants.Count);
            double averageRating = Restaurants.Average(r => r.Rating);
            Console.WriteLine("Average Rating: {0:F2}", averageRating);
        }

        public class Restaurant
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public string Type { get; set; }
            public double Rating { get; set; }

            public Restaurant(int id, string name, string type, double rating)
            {
                Id = id;
                Name = name;
                Type = type;
                Rating = rating;
            }
        }
    }
}
