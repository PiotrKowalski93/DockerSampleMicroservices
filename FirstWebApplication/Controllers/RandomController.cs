using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace FirstWebApplication.Controllers
{
    public class RandomController : Controller
    {
        private string _doSomethingBaseAddress;
        private string _doSomethingAPIUrl;

        public RandomController()
        {
            _doSomethingBaseAddress = "http://samplewebapi";
            _doSomethingAPIUrl = "/random";
        }

        // GET: /<controller>/
        public async Task<IActionResult> Index()
        {
            HttpResponseMessage response = null;

            try
            {
                HttpClient client = new HttpClient();
                HttpRequestMessage request =
                    new HttpRequestMessage(HttpMethod.Get,
                        _doSomethingBaseAddress + _doSomethingAPIUrl);

                response = await client.SendAsync(request);
            }
            catch (Exception ex)
            {
                // let the pain go away
            }

            if (response != null && response.IsSuccessStatusCode)
            {
                List<Dictionary<String, String>> responseElements = new List<Dictionary<String, String>>();
                JsonSerializerSettings settings = new JsonSerializerSettings();
                String responseString = await response.Content.ReadAsStringAsync();
                ViewData["Number"] = responseString;

            }

            return View();
        }
    }
}