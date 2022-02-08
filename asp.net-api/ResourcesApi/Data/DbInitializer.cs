using Newtonsoft.Json;
using ResourcesApi.Models;

namespace ResourcesApi.Data
{
    public static class DbInitializer
    {
        public static void Initialize(ResourceDbContext resourceDbContext)
        {
            if (resourceDbContext.Resources.Any())
            {
                return;
            }

            string resourcesFromFile = File.ReadAllText("Data/sample-resources.json");
            dynamic? resources = JsonConvert.DeserializeObject(resourcesFromFile);
            if (resources == null) 
            {
                return;
            }

            foreach(dynamic resource in resources)
            {
                var newResource = new Resource
                {
                    Id = resource.id,
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
                    newResource.ApplicationPeriods.Add(new ResourceApplicationPeriod { Month = applicationPeriod });
                }

                newResource.Locations = new List<ResourceLocation>();
                foreach(dynamic location in resource.location)
                {
                    newResource.Locations.Add(new ResourceLocation { Name = location });
                }

                resourceDbContext.Add(newResource);
                resourceDbContext.SaveChanges();
            }
        }
    }
}