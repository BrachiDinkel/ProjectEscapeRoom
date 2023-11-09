using Microsoft.AspNetCore.Mvc;
using RoomEscapes.Entities;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace RoomEscapes.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Card : ControllerBase
    {
        List<CardsClass> MyCards = new List<CardsClass>();

        // POST api/<Cards>
        [HttpPost]
        public ActionResult Post(int idcustomer, int idroom, int count)
        {
            RoomsClass card = Room.MyRooms.Find(x => x.Id == idroom);
            if (card == null)
                return NotFound();
            if (card.IsOpen == true && card.IsFull(0) >= 20)
            {
                CardsClass rd = new CardsClass(idcustomer, count, idroom);
                MyCards.Add(rd);
                card.IsFull(count);
                return Ok("The card has been successfully added");
            }
            return Ok("sorry!!:( all the cards sold out");

        }

        // PUT api/<Cards>/5
        [HttpPut("{id}")]
        public ActionResult Put(int id, [FromBody] int count)
        {
            CardsClass update = MyCards.Find(x => x.IdCard == id);
            if (update == null)
                return NotFound();
            update.CountOfCards = count;
            return Ok("The count updated successfully");
        }

        // DELETE api/<Cards>/5
        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            CardsClass delete = MyCards.Find(x => x.IdCard == id);
            if (delete == null)
                return NotFound();
            MyCards.Remove(delete);
            return Ok("The card removed successfuly");

        }
    }
}
