using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Hotel.Core
{
    public class HotelEngine
    {
        private ConfigProvider _configProvider = new ConfigProvider();
        private SupplierDb _supplierDb = new SupplierDb();

        public async Task<List<Hotel>> SearchHotelsAsync(SearchRequest searchRequest)
        {
            var posId = await _configProvider.GetPosIdAsync(searchRequest.TenantId);
            var suppliers = await _supplierDb.GetSuppliersAsync(posId);

            var hotels = new List<Hotel>();
            foreach(var supplier in suppliers)
            {
                hotels.AddRange(await supplier.Connector.SearchHotels(searchRequest));
            }
            return hotels;
        }
    }
}
