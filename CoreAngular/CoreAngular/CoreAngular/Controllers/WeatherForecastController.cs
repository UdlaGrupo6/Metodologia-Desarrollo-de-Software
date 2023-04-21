using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace CoreAngular.Controllers
{
    [ApiController]


    [Route("[controller]")]

    public class WeatherForecastController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {




        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"


    };

        private readonly ILogger<WeatherForecastController> _logger;

        public WeatherForecastController(ILogger<WeatherForecastController> logger)
        {
            _logger = logger;
        }

        [HttpGet(Name = "GetWeather/{user}/{password}")]
        public ActionResult<String> Get(String user, String password)
        {
            var url = "http://apiservicios.ecuasolmovsa.com:3009/api/Usuarios?usuario=" + user + "&password=" + password;



            var request = (HttpWebRequest)WebRequest.Create(url);

            request.Method = "GET";


            request.Accept = "application/json";
            try
            {
                using (WebResponse response = request.GetResponse())

                {
                    using (Stream strReader = response.GetResponseStream())



                    {
                        if (strReader == null) return null;
                        using (StreamReader objReader = new StreamReader(strReader))

                        {
                            string responseBody = objReader.ReadToEnd();



                            return responseBody;

                            Console.WriteLine(responseBody);
                        }
                    }
                }
            }
            catch (WebException ex)
            {
                // Manejar el error 
            }

            return null;

        }
    }
}