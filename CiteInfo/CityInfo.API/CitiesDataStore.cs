using CityInfo.API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.Internal;

namespace CityInfo.API
{
    public class CitiesDataStore
    {
        public static CitiesDataStore Current { get; } = new CitiesDataStore();
        public List<CityDto> Cities { get; set; }

        public CitiesDataStore()
        {
            // init dummy data

            Cities = new List<CityDto>()
            {
                new CityDto()
                {
                    Id = 1,
                    Name = "New York",
                    Description = "Comment 1",
                    PointOfInterest = new List<PointOfInterestDto>()
                    {
                        new PointOfInterestDto()
                        {
                            Id = 1,
                            Name = "Central Park 1",
                            Description = "Central Park Description 1"

                        },

                        new PointOfInterestDto()
                        {
                            Id = 2,
                            Name = "Empire State Building 2",
                            Description = "Empire State Building Description 2"

                        },
                    }
                },
                new CityDto()
                {
                    Id = 2,
                    Name = "New York",
                    Description = "Comment 2",
                    PointOfInterest = new List<PointOfInterestDto>()
                    {
                        new PointOfInterestDto()
                        {
                            Id = 1,
                            Name = "Central Park 1",
                            Description = "Central Park Description 1"
                        },

                        new PointOfInterestDto()
                        {
                            Id = 2,
                            Name = "Empire State Building 2",
                            Description = "Empire State Building Description 2"
                        }
                    }
                }

            };
        }
    }
}
