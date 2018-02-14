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
                    Name = "SP"
                },
                new State
                {
                    Name = "RJ"
                },
            };
        }
    }
}
