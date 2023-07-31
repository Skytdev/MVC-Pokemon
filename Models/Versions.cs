namespace Sharpedex.Models
{
    public class Versions
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<Pokemon> Pokemons { get; set; }

        public Versions() { 
            Name = string.Empty;
            Pokemons = new List<Pokemon>();
        }
    }
}
