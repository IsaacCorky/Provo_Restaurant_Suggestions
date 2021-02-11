using System;
using System.Collections.Generic;

namespace Provo_Restaurant_Suggestions.Models
{
    public static class Repository
    {
        private static List<Restaurant> responses = new List<Restaurant>();
        public static IEnumerable<Restaurant> Responses => responses;
        public static void AddResponse(Restaurant response)
        {
            responses.Add(response);
        }
    }
}