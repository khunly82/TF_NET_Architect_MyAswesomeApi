namespace MyAswesomeApi
{
    public class Pokemon
    {
        public int PokemonID { get; set; }
        public int NumeroPokedex { get; set; }
        public string Nom { get; set; } = null!;
        public string TypePrincipal { get; set; } = null!;
        public string? TypeSecondaire { get; set; }
        public int Niveau { get; set; }
        public int PointsDeVie { get; set; }
    }
}
