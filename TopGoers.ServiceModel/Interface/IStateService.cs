using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace TopGoers.ServiceModel.Interface
{
    public interface IStateService
    {
        Task<IEnumerable<Model.State>> GetAsync();
    }
}
