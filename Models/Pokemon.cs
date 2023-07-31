namespace Sharpedex.Models
{
    public class Pokemon
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Type { get; set; }

        public bool IsEvolve { get; set; }
        public int EvolveLevel { get; set; }
        public string Version { get; set; }

        public Pokemon() { 
            Name = string.Empty;
            Description = string.Empty;
            Type = string.Empty;
            EvolveLevel = 0;
            Version = string.Empty;
        }
    }
}
