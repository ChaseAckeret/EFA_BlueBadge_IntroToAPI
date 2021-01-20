using IntroToApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace IntroToApi
{
    class SWAPIService
    {
        private readonly HttpClient _httpClient = new HttpClient();

        public async Task<Person> GetPersonAsync(string url)
        {
            /*
              HttpResponseMessage response = await _httpClient.GetAsync(url);

            if (response.IsSuccessStatusCode)
            {
                Person person = await response.Content.ReadAsAsync<Person>();
                return person;
            }
            return null;
            */

            return await GetAsync<Person>(url);
        }

        public async Task<Vehicle> GetVehicleAsync(string url)
        {
            var response = await _httpClient.GetAsync(url);

            return response.IsSuccessStatusCode
                ? await response.Content.ReadAsAsync<Vehicle>()
                : null;
        }

        public async Task<T> GetAsync<T>(string url) where T : class
        {
            HttpResponseMessage response = await _httpClient.GetAsync(url);

            if (response.IsSuccessStatusCode)
            {
                T content = await response.Content.ReadAsAsync<T>();
                return content;
            }
            //return default;
            return null;
        }
    }
}
