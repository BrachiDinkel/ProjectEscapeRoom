namespace RoomEscapes.Entities
{
    public class RoomsClass
    {
        public int Id { get; set; }
        public string RoomName { get; set; }
        public bool IsOpen { get; set; }
        public RoomsClass(int id, string roomName, bool status)
        {
            Id = id;
            RoomName = roomName;
            this.IsOpen = status;
        }
        int count = 0;
        public int IsFull(int num)
        {
            return count += num;
        }
    }
}
