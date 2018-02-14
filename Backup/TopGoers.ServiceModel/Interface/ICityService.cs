using System;
using System.Collections.Generic;
using System.Text;

namespace TopGoers.ServiceModel.Interface
{
    public interface ICityService
    {
        IEnumerable<Model.City> GetAsync();
    }
}
