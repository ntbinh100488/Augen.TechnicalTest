using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using Augen.TechnicalTest.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;

namespace Augen.TechnicalTest.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookStoreController : ControllerBase
    {
        private readonly ILogger<BookStoreController> _logger;

        public BookStoreController(ILogger<BookStoreController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public async Task<IEnumerable<Book>> Get(string queryString)
        {
            using (var client = new HttpClient())
            {
                //client.BaseAddress = new Uri("https://www.googleapis.com/books/v1/volumes?q={}");
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                //GET Method  
                HttpResponseMessage response = await client.GetAsync("https://www.googleapis.com/books/v1/volumes?q={" + queryString + "}");
                if (response.IsSuccessStatusCode)
                {
                    var bookStr = await response.Content.ReadAsStringAsync();

                    var rootObject = JsonConvert.DeserializeObject<RootObject>(bookStr);

                    var books = rootObject.Items.Select(a => new Book
                    {
                        PublishedDate = a.VolumeInfo.PublishedDate,
                        Authors = a.VolumeInfo.Authors,
                        Title = a.VolumeInfo.Title
                    });

                    return books;
                }
                else
                {
                    Console.WriteLine("Internal server Error");
                }
            }

            return null;
        }
    }
}