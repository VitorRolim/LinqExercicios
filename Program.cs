using ScreenSouns_API.Filtros;
using ScreenSouns_API.Modelos;
using System.Text.Json;
using (HttpClient client = new HttpClient())
{
    try
    {
        string resposta = await client.GetStringAsync("https://guilhermeonrails.github.io/api-csharp-songs/songs.json");
        var musicas = JsonSerializer.Deserialize<List<Musica>>(resposta);
        LinqFilter.FiltrarTodosOsGenerosMusicais(musicas);
        LinqOrder.OrdenarArtistasMusicais(musicas);
        LinqFilter.FiltrarArtistaPorGenerosMusicais(musicas, "pop, rock");
        LinqFilter.FiltrarMusicasArtista(musicas, "Taylor Swift");

        Console.WriteLine("/********************Exercicio 1*********************************/");
        List<int> nums = new List<int>() { 1,1,1,1,1,1,1,5,4,6,7,8,49,98,446,86,45};
        LinqFilter.FiltrarNumeros(nums);
        Console.WriteLine("/********************Exercicio 2*********************************/ ");
        Livro gameOfThrones = new Livro("Canção de Gelo e Fogo","George R.R. Martin",2001);
        Livro neuroMancer = new Livro("Neuromancer", "William Gibson", 2022);
        Livro reZero = new Livro("Re:Zero - Começando uma vida em outro mundo", "Tappei Nagatsuki", 2016);

        List<Livro> livros = new List<Livro>();
        livros.Add(gameOfThrones);
        livros.Add(neuroMancer);
        livros.Add(reZero);

        LinqOrder.LivrosOrdenados(livros);
        Console.WriteLine("/********************Exercicio 3*********************************/");
        Produtos produto1 = new Produtos("Processador ryzen 3", 447.99);
        Produtos produto2 = new Produtos("Processador i5-12400f", 588.99);
        Produtos produto3 = new Produtos("Processador ryzen 5 ", 688.99);

        List<Produtos> lista = new List<Produtos>() {produto1, produto2, produto3 };

        var mediaProdutos = lista.Average(x => x.Preco);

            Console.WriteLine($"Média dos produtos: {mediaProdutos}");




        Console.WriteLine("/********************Exercicio 4*********************************/");
        var numerosPares = nums.Where(x => x % 2 == 0);
        foreach(var numero in numerosPares){
            Console.WriteLine($"Números pares: {numero}");
        }
    }
    catch (Exception ex)
    {
        Console.WriteLine($"Deu ruim aqui: {ex.Message}");
    }
}