using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using RestfulService.Models;
using RestfulService.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestfulService.Controllers
{
    [Produces("application/json")]
    [Route("api/Categories")]
    public class CategoriesController : Controller
    {
        private abstract class result_base
        {
            protected result_base()
            {
            }
            protected result_base(Exception ex)
            {
                exceptionMessage = ex.ToString();
            }

            [JsonProperty(PropertyName = "err")]
            public string exceptionMessage
            {
                get;
                private set;
            }
        }
        [HttpPost]
        public async Task<Response> PostTodoItem([FromBody] Request request)
        {
            if (!ModelState.IsValid)
            {
                return new Response();
            }
            //var words = ConcurrentFactoryHelper.GetConcurrentFactory().Run(request.Text, true);

            /*

            _context.TodoItems.Add(todoItem);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetTodoItem", new { id = todoItem.Id }, todoItem);*/
             var result = new Response
            {
                Categories = new int[0],
                Names = new string[0],
                Text = ""
            };
            return result;
        }

        private static void SendJsonResponse(string text, result_base result)
        {
            var json = JsonConvert.SerializeObject(result);
            //context.Response.Write(json);
        }
    }
}
