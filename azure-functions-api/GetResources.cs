using System.IO;
using System.Threading.Tasks;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;

namespace Frontendstudygroup.Api
{
    public static class GetResources
    {
        [FunctionName("GetResources")]
        public static async Task<IActionResult> Run(
            [HttpTrigger(AuthorizationLevel.Anonymous, "get", Route = null)] HttpRequest req,
            ILogger log)
        {
            log.LogInformation("Triggered GetResources API.");

            string jsonData = await File.ReadAllTextAsync("data.json");
            var resources = JsonConvert.DeserializeObject<IEnumerable<Resource>>(jsonData);

            return new OkObjectResult(resources);
        }
    }
}
