using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aula04
{
    public class Carro
    {
        public string Nome { get; set; }
        public bool Ligado { get; set; }

        DateTime anoFabricacao;
        public Carro() {
            Console.WriteLine("Carro ligado!");
        }
        public Carro(string nome) {
            this.Nome = nome;
            this.anoFabricacao = DateTime.Now;
            Console.WriteLine($"Modelo do carro: {nome}");
        }
        public bool LigarCarro()
        {
            this.Ligado = true;
            return this.Ligado;
        }
        public bool DesligarCarro()
        {
            this.Ligado = false;
            return this.Ligado;

        }

    }
}
