using ScreenSouns_API.Modelos;
using System.Linq;

namespace ScreenSouns_API.Filtros;

internal class LinqFilter
{
    public static void FiltrarTodosOsGenerosMusicais(List<Musica> musicas)
    {
        var todosOsGenerosMusicais = musicas.Select(genero => genero.Genero).Distinct().ToList();
        Console.WriteLine("Todos os gêneros musicais");
        foreach (var genero in todosOsGenerosMusicais)
        {

            Console.WriteLine($"- {genero}");
        }
    }

    public static void FiltrarArtistaPorGenerosMusicais(List<Musica> musicas, string genero)
    {
        //se usar o select não ser possivel retornar as propriedades no foreach
        var todosArtistasGenerosMusicas = musicas.Where(musica => musica.Genero.Contains(genero)).Select(artista => artista.Artista).Distinct().ToList();
        Console.WriteLine("\nArtistas por generos musicas");

        foreach(var artista in todosArtistasGenerosMusicas)
        {
            Console.WriteLine($"-{artista}");
        }

    }

    public static void FiltrarMusicasArtista(List<Musica> musicas, string artistas)
    {
        var mostrarMusicasArtistas = musicas.Where(artista => artista.Artista.Contains(artistas));
        Console.WriteLine("Mostrar musicas dos artistas");
        Console.WriteLine($"Artista: {artistas}");

        foreach (var musica in mostrarMusicasArtistas)
        {
            Console.WriteLine($"\n= {musica.Nome}");
        }

    }

    public static void FiltrarNumeros(List<int> numeros)
    {
        var numerosDistintos = numeros.Distinct();
        int cont = 0;
        foreach (var num in numerosDistintos) 
        {
            Console.WriteLine($"{cont}: {num}");
            cont++;
        }
    }

    

    
}
