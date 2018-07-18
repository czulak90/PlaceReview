using PlaceReview.Core.Domain;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PlaceReview.Core.Repositories
{
    public interface IPlaceRepository : IRepository
    {
        Task<Place> GetAsync(Guid id);
        Task<IEnumerable<Place>> GetByCreatorAsync(Guid userId);
        Task<IEnumerable<Place>> GetByCountryAsync(string country);
        Task<IEnumerable<Place>> GetByCityAsync(string city);
        Task<IEnumerable<Place>> GetAllAsync();
        Task AddAsync(Place place);
        Task RemoveAsync(Guid id);
        Task UpdateAsync(Place place);
    }
}
