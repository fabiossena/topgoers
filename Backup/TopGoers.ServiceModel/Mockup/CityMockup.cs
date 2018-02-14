using System;
using System.Collections.Generic;
using System.Text;
using TopGoers.Model;
using TopGoers.ServiceModel.Interface;

namespace TopGoers.ServiceModel.Mockup
{
    public class CityMockup : ICityService
    {
        public IEnumerable<City> GetAsync()
        {
            return new[]
            {
                new City
                {
                    Name = "São Paulo"
                },
                new City
                {
                    Name = "Sorocaba"
                },
                new City
                {
                    Name = "Santo André"
                }
            };
        }
    }
}
