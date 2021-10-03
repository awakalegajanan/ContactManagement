using Newtonsoft.Json;
using OnionContactManagementSolution.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace OnionContactManagementSolution.UI.Services
{
    public class ServiceRepository
    {
        public HttpClient Client { get; set; }
        public ServiceRepository(string serviceUrl)
        {
            Client = new HttpClient();
            Client.BaseAddress = new Uri(serviceUrl);
        }
        public IEnumerable<Contact> GetResponse(string url)
        {
            IEnumerable<Contact> contacts = null;

            //  client.BaseAddress = new Uri("http://localhost:49562/api/");
            //HTTP GET
            var responseTask = Client.GetAsync(url);
            responseTask.Wait();

            var result = responseTask.Result;
            if (result.IsSuccessStatusCode)
            {
                var readTask = result.Content.ReadAsAsync<IEnumerable<Contact>>();
                readTask.Wait();

                contacts = readTask.Result;
            }
            else //web api sent error response 
            {                
                contacts = Enumerable.Empty<Contact>();
            }

            return contacts;
        }

        public Contact GetResponseById(string url, int id)
        {
            Contact contact = null;

            //  client.BaseAddress = new Uri("http://localhost:49562/api/");
            //HTTP GET
            var responseTask = Client.GetAsync($"{url}/{id}");
            responseTask.Wait();

            var result = responseTask.Result;
            if (result.IsSuccessStatusCode)
            {
                var readTask = result.Content.ReadAsAsync<Contact>();
                readTask.Wait();

                contact = readTask.Result;
            }
            else //web api sent error response 
            {
                contact = new Contact();
            }

            return contact;
        }

        public HttpResponseMessage PutResponse(string url, Contact model)
        {
            var jsonString = JsonConvert.SerializeObject(model);
            var content = new StringContent(jsonString, Encoding.UTF8, "application/json");
            return Client.PutAsync(url, content).Result;
        }
        public HttpResponseMessage PostResponse(string url, Contact model)
        {
            var jsonString = JsonConvert.SerializeObject(model);
            var content = new StringContent(jsonString, Encoding.UTF8, "application/json");
            return Client.PostAsync(url, content).Result;
        }
        public HttpResponseMessage DeleteResponse(string url, Contact model)
        {
            var jsonString = JsonConvert.SerializeObject(model);
            var content = new StringContent(jsonString, Encoding.UTF8, "application/json");
            return Client.PutAsync(url, content).Result;
        }
    }
}