using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TopGoers.ServiceModel.Interface;
using TopGoers.ServiceModel.Mockup;

namespace TopGoers.UnitTest
{
    [TestFixture]
    public class PlacesTest
    {
        [Test]
        public async Task TestGetPlaces()
        {
            IPlaceService placeService = new PlaceMockup();

            IStateService stateService = new StateMockup();
            ICityService cityService = new CityMockup();

            var state = await stateService.GetAsync();
            Assert.IsNotNull(state);

            var city = await cityService.GetAsync(state.FirstOrDefault().StateId);
            Assert.IsNotNull(city);

            var places = await placeService.GetAsync(null, city.FirstOrDefault().CityId, "");
            Assert.IsNotNull(places);
        }
    }
}
