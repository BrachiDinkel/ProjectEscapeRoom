namespace RoomEscapes.Entities
{
    public class CardsClass
    {
        public int IdCard { get; set; }
        public int CountOfCards { get; set; }
        public int IdRoom { get; set; }

        public CardsClass(int idCard, int countOfCards, int idRoom)
        {
            IdCard = idCard;
            CountOfCards = countOfCards;
            IdRoom = idRoom;
        }
    }
}
