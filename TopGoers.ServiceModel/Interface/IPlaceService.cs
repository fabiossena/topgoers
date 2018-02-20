using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace TopGoers.ServiceModel.Interface
{
    public interface IPlaceService
    {
        Task<IEnumerable<Model.Place>> GetAsync(int? stateId, int? cityId, string search);
    }
}
