using AutoMapper;
using PlaceReview.Core.Domain;
using PlaceReview.Infrastructure.DTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace PlaceReview.Infrastructure.Mappers
{
    public static class AutoMapperConfig
    {
        public static IMapper Initialize()
            => new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<Place, PlaceDto>();
            })
            .CreateMapper();
    }
}
