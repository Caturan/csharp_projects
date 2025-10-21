using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WeatherApi.Context;
using WeatherApi.Entities;

namespace WeatherApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WeathersController : ControllerBase
    {
        WeatherContext context = new WeatherContext();

        [HttpGet]
        public IActionResult WeatherCityList()
        {
            var values = context.Cities.ToList();
            return Ok(values);
        }
        [HttpPost]
        public IActionResult AddWeatherCity(City city)
        {
            context.Cities.Add(city);
            context.SaveChanges();
            return Ok("Eklendi");
        }
        [HttpDelete]
        public IActionResult DeleteWeatherCity(int id)
        {
            var city = context.Cities.Find(id);
            if (city == null)
            {
                return NotFound();
            }
            context.Cities.Remove(city);
            context.SaveChanges();
            return Ok("Silindi");
        }
        [HttpPut]
        public IActionResult UpdateWeatherCity(City city)
        {
            var updatedCity = context.Cities.Find(city.CityId);
            if (updatedCity == null)
            {
                return NotFound();
            }
            updatedCity.CityName = city.CityName;
            updatedCity.Country = city.Country;
            updatedCity.Temp = city.Temp;
            updatedCity.Detail = city.Detail;
            context.SaveChanges();
            return Ok("Güncellendi");
        }
        [HttpGet("GetByIdWeatherCity")]
        public IActionResult GetByIdWeatherCity(int id)
        {
            var city = context.Cities.Find(id);
            if (city == null)
            {
                return NotFound();
            }
            return Ok(city);
        }
        [HttpGet("TotalCityCount")]
        public IActionResult TotalCityCount()
        {
            var count = context.Cities.Count();
            return Ok(count);
        }
        [HttpGet("MaxTempCity")]
        public IActionResult MaxTempCity()
        {
            var maxTempCity = context.Cities.OrderByDescending(c => c.Temp).FirstOrDefault();
            if (maxTempCity == null)
            {
                return NotFound();
            }
            return Ok(maxTempCity);
        }
    }
}
