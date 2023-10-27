using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aula03
{
    public class Forma
    {
        public string RetornaNome()
        {
            return "Forma de circular";
        }
        private int RetoraTamanho()
        {
            return 10;
        }

        public string Tipo()
        {
            return "Forma de pizza";
        }
        public string Tipo(string nome)
        {
            return "Forma de pizza";
        }
    }
}
