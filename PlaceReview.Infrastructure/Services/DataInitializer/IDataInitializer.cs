using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace PlaceReview.Infrastructure.Services.DataInitializer
{
    public interface IDataInitializer : IService
    {
        Task SeedAsync();
    }
}
