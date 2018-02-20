using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TopGoers.Model;
using TopGoers.ServiceModel.Interface;

namespace TopGoers.ServiceModel.Mockup
{
    public class PlaceMockup : IPlaceService
    {
        public async Task<IEnumerable<Place>> GetAsync(int? stateId, int? cityId, string search)
        {
            int id = 0;
            var result = new[]
            {
                new Place
                {
                    PlaceId = id++,
                    CityId = 1,
                    StateId = 1,
                    Name = "Temacom"
                },
                new Place
                {
                    PlaceId = id++,
                    CityId = 1,
                    StateId = 1,
                    Name = "Figueiras"
                },
                new Place
                {
                    PlaceId = id++,
                    CityId = 1,
                    StateId = 1,
                    Name = "Arabe"
                },
                new Place
                {
                    PlaceId = id++,
                    CityId = 1,
                    StateId = 1,
                    Name = "Churras"
                },

                new Place
                {
                    PlaceId = id++,
                    CityId = 2,
                    StateId = 1,
                    Name = "Mexicano"
                },
                new Place
                {
                    PlaceId = id++,
                    CityId = 2,
                    StateId = 1,
                    Name = "Chooperia"
                },
                new Place
                {
                    PlaceId = id++,
                    CityId = 2,
                    StateId = 1,
                    Name = "Hamburgueria"
                },

                new Place
                {
                    PlaceId = id++,
                    CityId = 1,
                    StateId = 1,
                    Name = "Figueiras"
                },
                new Place
                {
                    PlaceId = id++,
                    CityId = 1,
                    StateId = 1,
                    Name = "Perimetral"
                },

                new Place
                {
                    PlaceId = id++,
                    CityId = 4,
                    StateId = 2,
                    Name = "Creppe"
                },
                new Place
                {
                    PlaceId = id++,
                    CityId = 4,
                    StateId = 2,
                    Name = "Picanha Grill"
                },

                new Place
                {
                    PlaceId = id++,
                    CityId = 5,
                    StateId = 2,
                    Name = "Argentino"
                },
                new Place
                {
                    PlaceId = id++,
                    CityId = 5,
                    StateId = 2,
                    Name = "Camarão"
                },
                new Place
                {
                    PlaceId = id++,
                    CityId = 5,
                    StateId = 2,
                    Name = "Foundie"
                },

                new Place
                {
                    PlaceId = id++,
                    CityId = 6,
                    StateId = 3,
                    Name = "Lorenzo"
                },
                new Place
                {
                    PlaceId = id++,
                    CityId = 6,
                    StateId = 3,
                    Name = "Mantiqueira"
                },

                new Place
                {
                    PlaceId = id++,
                    CityId = 6,
                    StateId = 3,
                    Name = "Mosca frita"
                },
                new Place
                {
                    PlaceId = id++,
                    CityId = 6,
                    StateId = 3,
                    Name = "Pé sujo"
                }
            }.Where(x => stateId == null || (x.StateId == stateId && (cityId  == null || x.CityId == cityId)));
            
            return result.Where(x => search == null || x.Name.ToLower().Contains(search.ToLower()));
        }

    }
}
