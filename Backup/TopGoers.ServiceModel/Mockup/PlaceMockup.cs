using System;
using System.Collections.Generic;
using System.Text;
using TopGoers.Model;
using TopGoers.ServiceModel.Interface;

namespace TopGoers.ServiceModel.Mockup
{
    public class PlaceMockup : IPlaceService
    {
        public IEnumerable<Place> GetAsync()
        {
            return new[]
            {
                new Place
                {
                    Name = "Temacom"
                },
                new Place
                {
                    Name = "Goiano"
                }
            };
        }
    }
}
