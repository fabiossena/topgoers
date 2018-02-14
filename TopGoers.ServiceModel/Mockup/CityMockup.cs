using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TopGoers.Model;
using TopGoers.ServiceModel.Interface;

namespace TopGoers.ServiceModel.Mockup
{
    public class CityMockup : ICityService
    {
        public IEnumerable<City> GetAsync(int? stateId)
        {
            if (stateId == null)
            {
                return new City[0];
            }

            return new[]
            {
                new City
                {
                    CityId = 1,
                    StateId = 1,
                    Name = "São Paulo - Capital"
                },
                new City
                {
                    CityId = 2,
                    StateId = 1,
                    Name = "Sorocaba"
                },
                new City
                {
                    CityId = 1,
                    StateId = 1,
                    Name = "Santo André"
                },

                new City
                {
                    CityId = 4,
                    StateId = 2,
                    Name = "Rio - Capital"
                },
                new City
                {
                    CityId = 5,
                    StateId = 2,
                    Name = "Rezende"
                },

                new City
                {
                    CityId = 6,
                    StateId = 3,
                    Name = "Belo Horizonte"
                },
                new City
                {
                    CityId = 6,
                    StateId = 3,
                    Name = "Juiz de Fora"
                }
            }.Where(x => x.StateId == stateId);
        }
    }
}
