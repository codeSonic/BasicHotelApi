using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Hotel.Core
{
    class EanConnector : IConnector
    {
        public Task<List<Hotel>> SearchHotels(SearchRequest searchRequest)
        {
            return Task.FromResult(new List<Hotel>
            {
                new Hotel{ Name = "MGM", Address = "East Street", CityName = "Las Vegas", CountryCode = "US", Currency = "USD", AvgPrice = 500, AvailableRooms = 20, StarRating = 5 },
                new Hotel{ Name = "Venetian", Address = "West Street", CityName = "Las Vegas", CountryCode = "US", Currency = "USD", AvgPrice = 400, AvailableRooms = 16, StarRating = 4.5f }
            });
        }
    }
}
