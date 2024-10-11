using System.Text.Json.Serialization;

namespace ScreenSouns_API.Modelos
{
    internal class Musica
    {
        [JsonPropertyName("song")]
        public string Nome { get; set; }
        [JsonPropertyName("artist")]
        public string Artista { get; set; }
        [JsonPropertyName("duration_ms")]
        public int Duracao { get; set; }
        [JsonPropertyName("genre")]
        public string Genero { get; set; }

        public void DescricaoCompleta()
        {
            Console.WriteLine($"Nome da música: {Nome}");
            Console.WriteLine($"Artista: {Artista}");
            Console.WriteLine($"Duração da música: {Duracao / 1000}");
            Console.WriteLine($"Gênero: {Genero}");
        }
    }
}
