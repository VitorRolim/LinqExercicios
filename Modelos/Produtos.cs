using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScreenSouns_API.Modelos
{
    internal class Produtos
    {
        public Produtos(string nome, double prec)
        {
            Nome = nome;
            Preco = prec;
        }
        public string Nome { get; set; }
        public double Preco { get; set; }
    }
}
