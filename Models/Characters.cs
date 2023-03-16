using System.Text.Json.Serialization;

namespace Text_Adventure_2.Models
{
    public class Characters
    {
        public int Id { get; set; }
        public string Type { get; set; } = "Knight";
        public string Name { get; set; } = string.Empty;
        public int ArmorClass { get; set; } = 10;
        public int HitPoints { get; set; } = 20;
        public int CurrentRoom { get; set; } = 0;
        public int UserId { get; set; }

        [JsonIgnore]
        public User? User { get; set; }

    }
}
