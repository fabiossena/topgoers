using System;
using System.Collections.Generic;
using System.Text;
using TopGoers.Model;
using TopGoers.ServiceModel.Interface;

namespace TopGoers.ServiceModel
{
    public class CityService : BaseService, ICityService
    {
        public IEnumerable<City> GetAsync(int? stateId)
        {
            return null;
        }
    }
}
