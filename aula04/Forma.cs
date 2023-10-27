using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aula04
{
    public class Forma
    {
        public (string nome, string id) RetornaNomeTuplaForma()
        {
            return ("Forma de bolo", Guid.NewGuid().ToString());
        }

        public string xpto(string nome, int validade)
        {
            return ("Bolo de "+ nome + "\nValidade de " + validade + " dias");
        }
    }
}
