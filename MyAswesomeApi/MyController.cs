using Dapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;

namespace MyAswesomeApi
{
    [ApiController]
    public class MyController(
        // injection de dépendences
        IConfiguration configuration
    ): ControllerBase
    {

        [HttpGet("api/hello")]
        public string Hello(string nom = "world")
        {
            return $"Bonjour {nom} !!!!!!";
        }

        [HttpGet("api/pokemons")]
        public List<Pokemon> GetPokemons()
        {
            // se connecter à la Db et récupérer tous les pokemons
            // créer une connection SQL
            // System.Sata.Sqlclient // ADO
            using SqlConnection connection = new(configuration.GetConnectionString("Main"));

            // Exécuter une requète SQL
            // Dapper
            
            List<Pokemon> pokemons = connection.Query<Pokemon>("SELECT * FROM Pokemons").ToList();

            // renvoyer tous les pokémons
            return pokemons;
        }
    }
}
