using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace TopGoers.ServiceModel.Interface
{
    public interface ICityService
    {
        Task<IEnumerable<Model.City>> GetAsync(int? stateId);
    }
}
