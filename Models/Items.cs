namespace Text_Adventure_2.Models
{
    public class Items
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public int DamageMod { get; set; } = 5;
        public int CharacterId { get; set; }


    }
}
