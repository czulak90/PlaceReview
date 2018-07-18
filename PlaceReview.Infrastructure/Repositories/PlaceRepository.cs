using PlaceReview.Core.Domain;
using PlaceReview.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace PlaceReview.Infrastructure.Repositories
{
    class PlaceRepository : IPlaceRepository
    {
        public Task AddAsync(Place place)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Place>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Place> GetAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Place>> GetByCreatorAsync(Guid userId)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Place>> GetByCityAsync(string city)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Place>> GetByCountryAsync(string country)
        {
            throw new NotImplementedException();
        }

        public Task RemoveAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(Place place)
        {
            throw new NotImplementedException();
        }
    }
}
