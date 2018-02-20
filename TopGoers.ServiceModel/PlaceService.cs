using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using TopGoers.Model;
using TopGoers.ServiceModel.Interface;

namespace TopGoers.ServiceModel
{
    public class PlaceService : BaseService, IPlaceService
    {
        public async Task<IEnumerable<Place>> GetAsync(int? stateId, int? cityId, string search)
        {
            return null;
        }
    }
}
