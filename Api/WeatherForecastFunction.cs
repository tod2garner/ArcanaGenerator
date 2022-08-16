using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.Extensions.Logging;
using System;
using System.Linq;

namespace BlazorApp.Api
{
    /// <summary>
    /// Example class showing how to use Azure Function calls
    /// </summary>
    public static class WeatherForecastFunction
    {
        [FunctionName("WeatherForecast")]
        public static IActionResult Run(
            [HttpTrigger(AuthorizationLevel.Anonymous, "get", Route = null)] HttpRequest req,
            ILogger log)
        {
            var randomNumber = new Random();
            var temp = 0;

            var result = Enumerable.Range(1, 5).Select(index => new GeneratorEngine.Templates.SpellTemplate
            {
                Description = temp.ToString()
            }).ToArray();

            return new OkObjectResult(result);
        }
    }
}
