using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Faceteam.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class RoomsController : ControllerBase
    {
        // GET: api/<RoomsController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            Console.WriteLine("GET request!");
            return new string[] { "hello", "world" };
        }

        // GET api/<RoomsController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<RoomsController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
            // should contain user id, and room id
            // if user id is empty, 404
            // if room id is empty, create new room, return it.
            Console.WriteLine("POST Reqeust: ");
            Console.WriteLine(value);
        }

        // PUT api/<RoomsController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
            Console.WriteLine("PUT Reqeust: ");
            Console.WriteLine(value);
        }

        // DELETE api/<RoomsController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
