namespace PokemonApi
{
    public class Caracteristicas : BaseEntity
    {

        public string? Types { get; set; }
        public string? Abilities { get; set; }
        public string? Weight { get; set; }
        public string? Height { get; set; }
        public Sprites? Sprites { get; set; }
    }
}
