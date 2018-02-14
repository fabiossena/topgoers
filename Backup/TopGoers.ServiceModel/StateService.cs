using System;
using System.Collections.Generic;
using TopGoers.Model;
using TopGoers.ServiceModel.Interface;

namespace TopGoers.ServiceModel
{
    public class StateService : BaseService, IStateService
    {
        public IEnumerable<State> GetAsync()
        {
            return null;
        }
    }
}
