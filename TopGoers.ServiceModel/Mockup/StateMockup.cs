using System;
using System.Collections.Generic;
using System.Text;
using TopGoers.Model;
using TopGoers.ServiceModel.Interface;

namespace TopGoers.ServiceModel.Mockup
{
    public class StateMockup : IStateService
    {
        public IEnumerable<State> GetAsync()
        {
            return new[]
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
        }
    }
}
