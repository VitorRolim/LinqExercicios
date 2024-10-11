using ScreenSouns_API.Modelos;
using System.Linq;

namespace ScreenSouns_API.Filtros;

internal class LinqOrder
{
    public static void OrdenarArtistasMusicais(List<Musica> musicas)
    {
        var artistasOrdenados = musicas.OrderBy(artista => artista.Artista).Select(artistas => artistas.Artista).Distinct().ToList();
        Console.WriteLine("\nArtistas Ordenados");

        foreach(var artista in artistasOrdenados)
        {
            Console.WriteLine($"Nome: {artista}");
        }
    }

    public static void LivrosOrdenados(List<Livro> livros)
    {
        var livrosOrdenados = livros.Where(livro => livro.AnoPublicacao > 2000).OrderBy(livro => livro.Titulo);
        int cont = 0;
        foreach(var liv in livrosOrdenados)
        {
            Console.WriteLine($"Livro {cont}:");
            Console.WriteLine($"Título: {liv.Titulo}");
            Console.WriteLine($"Título: {liv.Autor}");
            Console.WriteLine($"Título: {liv.AnoPublicacao}\n");
            cont++;
        }
    }
  

}
