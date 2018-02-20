using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using TopGoers.Model;
using TopGoers.ServiceModel.Interface;

namespace TopGoers.ServiceModel
{
    public class StateService : BaseService, IStateService
    {
        public async Task<IEnumerable<State>> GetAsync()
        {
            return null;
        }
    }
}
