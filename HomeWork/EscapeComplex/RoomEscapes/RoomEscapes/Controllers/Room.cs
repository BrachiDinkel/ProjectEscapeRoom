using Microsoft.AspNetCore.Mvc;
using RoomEscapes.Entities;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace RoomEscapes.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Room : ControllerBase
    {
        public static List<RoomsClass> MyRooms = new List<RoomsClass>()
        {
          new RoomsClass(10,"KingShlomo",true),new RoomsClass(20,"PragRoom",false),
            new RoomsClass(30,"Zofen",true),new RoomsClass(40,"Hayara",true)
         };


        // GET: api/<Rooms>
        [HttpGet]
        public List<RoomsClass> Get()
        {
            return MyRooms;
        }

        // GET api/<Rooms>/5
        [HttpGet("{id}")]
        public ActionResult Get(int id)
        {
            RoomsClass room = MyRooms.Find(x => x.Id == id);
            if (room == null)
            {
                return NotFound();
            }
            return Ok(room);
        }

        // POST api/<Rooms>
        [HttpPost]
        public void Post([FromBody] RoomsClass value)
        {
            MyRooms.Add(value);
        }

        // PUT api/<Rooms>/5
        [HttpPut("{id}")]
        public ActionResult Put(int id, [FromBody] RoomsClass value)
        {
            RoomsClass update = MyRooms.Find(x => x.Id == id);
            if (update == null)
            {
                return NotFound();
            }
            update.Id = value.Id;
            update.IsOpen = value.IsOpen;
            update.RoomName = value.RoomName;
            return Ok(update);
        }

        //Status
        [HttpPut("{id},{status}")]
        public ActionResult Status(bool status, [FromBody] int id)
        {
            RoomsClass st = MyRooms.Find(x => x.Id == id);
            if (st == null)
            {
                return NotFound();
            }
            st.IsOpen = status;
            return Ok(st);

        }

    }
}
