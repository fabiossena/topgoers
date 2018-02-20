using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using TopGoers.Model;
using TopGoers.ServiceModel.Interface;

namespace TopGoers.ServiceModel.Mockup
{
    public class StateMockup : IStateService
    {
        public async Task<IEnumerable<State>> GetAsync()
        {
            var result = new[]
            {
                new State
                {
                    StateId = 1,
                    Name = "SP"
                },
                new State
                {
                    StateId = 2,
                    Name = "RJ"
                },
                new State
                {
                    StateId = 3,
                    Name = "MG"
                },
            };
            return result;
        }
    }
}
