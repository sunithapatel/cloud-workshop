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
            var sampleResources = JsonConvert.DeserializeObject<IEnumerable<Resource>>(sampleResourcesFromFile) ?? new Resource[0];
            
            resourceDbContext.AddRange(sampleResources);
            resourceDbContext.SaveChanges();
        }
    }
}