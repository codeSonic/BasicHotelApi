using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Hotel.Core
{
    class TouricoConnector : IConnector
    {
        public Task<List<Hotel>> SearchHotels(SearchRequest searchRequest)
        {
            return Task.FromResult(new List<Hotel>
            {
                new Hotel{ Name = "Bellagio", Address = "North Street", CityName = "Las Vegas", CountryCode = "US", Currency = "USD", AvgPrice = 600, AvailableRooms = 25, StarRating = 5 },
                new Hotel{ Name = "Mirage", Address = "South Street", CityName = "Las Vegas", CountryCode = "US", Currency = "USD", AvgPrice = 300, AvailableRooms = 8, StarRating = 4 }
            });
        }
    }
}
