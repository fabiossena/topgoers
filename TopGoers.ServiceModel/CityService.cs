using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using TopGoers.Model;
using TopGoers.ServiceModel.Interface;

namespace TopGoers.ServiceModel
{
    public class CityService : BaseService, ICityService
    {
        public async Task<IEnumerable<City>> GetAsync(int? stateId)
        {
            return null;
        }
    }
}
