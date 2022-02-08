using ResourcesApi.Models;
using Newtonsoft.Json;

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

            var sampleResourcesFromFile = File.ReadAllText("Data/sample-resources.json");
            var sampleResources = JsonConvert.DeserializeObject<Resource[]>(sampleResourcesFromFile) ?? new Resource[0];

            sampleResources[0].ApplicationPeriods = new List<ResourceApplicationPeriod> 
            {
                new ResourceApplicationPeriod { Month = "March" },
                new ResourceApplicationPeriod { Month = "April" }
            };

            sampleResources[0].Locations = new List<ResourceLocation> 
            {
                new ResourceLocation { Name = "Remote" }
            };

            resourceDbContext.AddRange(sampleResources);
            resourceDbContext.SaveChanges();
        }
    }
}