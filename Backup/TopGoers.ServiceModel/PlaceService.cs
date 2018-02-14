using System;
using System.Collections.Generic;
using System.Text;
using TopGoers.Model;
using TopGoers.ServiceModel.Interface;

namespace TopGoers.ServiceModel
{
    public class PlaceService : BaseService, IPlaceService
    {
        public IEnumerable<Place> GetAsync()
        {
            return null;
        }
    }
}
