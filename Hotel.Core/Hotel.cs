using System;
using System.Collections.Generic;
using System.Text;

namespace Hotel.Core
{
    public class Hotel
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public string CityName { get; set; }
        public string CountryCode { get; set; }
        public decimal AvgPrice { get; set; }
        public string Currency { get; set; }
        public int AvailableRooms { get; set; }
        public float StarRating { get; set; }
    }
}
