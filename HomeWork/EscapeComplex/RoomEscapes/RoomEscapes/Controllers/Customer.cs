using Microsoft.AspNetCore.Mvc;
using RoomEscapes.Entities;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace RoomEscapes.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Customers : ControllerBase
    {

        List<CustomersClass> customers = new List<CustomersClass>() { new CustomersClass(123,"brachi","dinkel"),
            new CustomersClass(456, "miri", "heizler"),new CustomersClass(789,"sara","cohen")
            ,new CustomersClass(258,"lea","levi")};
        // GET: api/<Customers>
        [HttpGet]
        public IEnumerable<CustomersClass> Get()
        {
            return customers;
        }

        // GET api/<Customers>/5
        [HttpGet("{id}")]
        public ActionResult Get(int id)
        {
            CustomersClass customer = customers.Find(x => x.IdC == id);
            if (customer == null)
            {
                return NotFound();
            }
            return Ok(customer);
        }


        // POST api/<Customers>
        [HttpPost]
        public void Post([FromBody] CustomersClass value)
        {
            customers.Add(value);
        }

        // PUT api/<Customers>/5
        [HttpPut("{id}")]
        public ActionResult Put(int id, [FromBody] CustomersClass value)
        {
            var update = customers.Find(x => x.IdC == id);
            if (update == null)
            {
                return NoContent();
            }
            update.IdC = value.IdC;
            update.FName = value.FName;
            update.LName = value.LName;
            return Ok(update);
        }

        // DELETE api/<Customers>/5
        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            var delete = customers.Find(x => x.IdC == id);
            if (delete == null)
            {
                return NotFound();
            }
            return Ok(customers.Remove(delete));
        }
    }
}
