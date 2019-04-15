using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CityInfo.API.Entities;

namespace CityInfo.API
{
    public static class CityInfoContextExtensions
    {
        public static void EnsureSeedDataForContext(this CityInfoContext context)
        {
            if (context.Cities.Any())
            {
                return;
            }

            var cities = new List<City>()
            {
                new City()
                {
                    Name = "New York",
                    Description = "Comment 1",
                    PointOfInterest = new List<PointOfInterest>()
                    {
                        new PointOfInterest()
                        {
                            Name = "Central Park 1",
                            Description = "Central Park Description 1"

                        },

                        new PointOfInterest()
                        {
                            Name = "Empire State Building 2",
                            Description = "Empire State Building Description 2"

                        },
                    }
                },
                new City()
                {
                    Name = "New York",
                    Description = "Comment 2",
                    PointOfInterest = new List<PointOfInterest>()
                    {
                        new PointOfInterest()
                        {
                            Name = "Central Park 1",
                            Description = "Central Park Description 1"
                        },

                        new PointOfInterest()
                        {
                            Name = "Empire State Building 2",
                            Description = "Empire State Building Description 2"
                        }
                    }
                }

            };

            context.Cities.AddRange(cities);
            context.SaveChanges();
        }
    }
}
