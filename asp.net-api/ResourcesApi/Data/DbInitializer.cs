using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using ResourcesApi.Models;

namespace ResourcesApi.Data
{
    public static class DbInitializer
    {
        public static void SeedData(ModelBuilder modelBuilder)
        {
            string resourcesFromFile = File.ReadAllText("Data/sample-resources.json");
            dynamic? resources = JsonConvert.DeserializeObject(resourcesFromFile);
            if (resources == null) 
            {
                return;
            }

            int resourceKey = 1;
            int applicationPeriodKey = 1;
            int locationKey = 1;

            foreach(dynamic resource in resources)
            {
                var newResource = new Resource
                {
                    Id = resourceKey,
                    Name = resource.name,
                    Body = resource.body,
                    Url = resource.url,
                    EligibilityCriteria = resource.eligibility_criteria,
                    InternshipPeriod = resource.internship_period,
                    Stipend = resource.stipend,
                    Description = resource.description
                };
                
                newResource.ApplicationPeriods = new List<ResourceApplicationPeriod>();
                foreach(dynamic applicationPeriod in resource.application_period)
                {
                    modelBuilder.Entity<ResourceApplicationPeriod>()
                        .HasData(new ResourceApplicationPeriod
                                { 
                                    Id = applicationPeriodKey,
                                    Month = applicationPeriod, 
                                    ResourceId = newResource.Id
                                });
                    applicationPeriodKey++;
                }

                newResource.Locations = new List<ResourceLocation>();
                foreach(dynamic location in resource.location)
                {
                    modelBuilder.Entity<ResourceLocation>()
                        .HasData(new ResourceLocation 
                                {
                                    Id = locationKey,
                                    Name = location,
                                    ResourceId = newResource.Id
                                });
                    locationKey++;
                }

                modelBuilder.Entity<Resource>().HasData(newResource);

                resourceKey++;
            }
        }
    }
}