namespace Text_Adventure_2.Models
{
    public class Rooms
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public int RoomNumber { get; set; } = 0;
        public string Option1Text { get; set; } = string.Empty;
        public string Option2Text { get; set; } = string.Empty;
        public string Option3Text { get; set; } = string.Empty;
        public int Option1Num { get; set; }
        public int Option2Num { get; set; }
        public int Option3Num { get; set; }

    }
}
