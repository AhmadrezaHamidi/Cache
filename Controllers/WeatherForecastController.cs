using System;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Caching.Memory;
namespace chash.Controllers;

[ApiController]
[Route("[controller]")]
public class WeatherForecastController : ControllerBase
{
    private static readonly string[] Summaries = new[]
    {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    };

    private readonly ILogger<WeatherForecastController> _logger;
    private readonly IMemoryCache _memoryCache;
    public WeatherForecastController(ILogger<WeatherForecastController> logger,IMemoryCache memoryCashe )
    {
        _logger = logger;
        _memoryCache = memoryCashe;
    }
     
  
    
    
    [HttpGet(Name = "GetWeatherForecast")]
   
    public  IEnumerable<WeatherForecast> Get(string weatherId)
    {
        string permissionCacheKey = $"permissions-{weatherId}";
        var permissionFlags = new List<WeatherForecast>();

        //memoryCache.GetOrCreateAsync<List<string>>(permissionCacheKey);

        if (!_memoryCache.TryGetValue(permissionCacheKey, out permissionFlags))
        {
            // Key not in cache, so get data.
            permissionFlags = Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = DateOnly.FromDateTime(DateTime.Now.AddDays(index)),
                TemperatureC = Random.Shared.Next(-20, 55),
                Summary = Summaries[Random.Shared.Next(Summaries.Length)]
            })
              .ToList();

            // Set cache options.
            var cacheEntryOptions = new MemoryCacheEntryOptions()
                // Keep in cache for this time, reset time if accessed.
                .SetSlidingExpiration(TimeSpan.FromMinutes(1));

            // Save data in cache.
            _memoryCache.Set(permissionCacheKey, permissionFlags, cacheEntryOptions);
        }

        //how to remove from cache with key
        //memoryCache.Remove(permissionCacheKey);

        if (permissionFlags is null)
            permissionFlags.Add(new WeatherForecast
            {
                Date = DateOnly.FromDateTime(DateTime.Now.AddDays(1)),
                TemperatureC = Random.Shared.Next(-20, 55),
                Summary = Summaries[Random.Shared.Next(Summaries.Length)]
            });
        ///how to remove kach key
        
        /// _memoryCache.Remove(key);


        return permissionFlags;
    }




    [HttpGet("GetById")]
    [ResponseCache(Duration = 5)]
    public WeatherForecast GetById(string weatherId)
    {
        var res =  new WeatherForecast
        {
            Date = DateOnly.FromDateTime(DateTime.Now.AddDays(1)),
            TemperatureC = Random.Shared.Next(-20, 55),
            Summary = Summaries[Random.Shared.Next(Summaries.Length)]
        };

        return res;
    }


}
