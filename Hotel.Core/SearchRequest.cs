using System;

namespace Hotel.Core
{
    public class SearchRequest
    {
        public string TenantId { get; set; }
        public DateTime CheckInDate { get; set; }
        public DateTime CheckOutDate { get; set; }
        public string CityName { get; set; }
    }
}
