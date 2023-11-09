namespace RoomEscapes.Entities
{
    public class CustomersClass
    {
        public int IdC { get; set; }
        public string FName { get; set; }
        public string LName { get; set; }
        public CardsClass Card { get; set; }
        public CustomersClass(int idC, string fName, string lName)
        {
            IdC = idC;
            FName = fName;
            LName = lName;
        }
    }
}
