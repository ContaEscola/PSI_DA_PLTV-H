using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace app
{
    public partial class Trabalhador : Pessoa
    {
        // http://www.tutorialspanel.com/string-format-in-csharp-for-decimal/index.htm
        public string SalarioFormated { get { return $"{String.Format("{0:0,0.00}",Salario)}€"; } }

        public string PaisExtracted { get { return Morada.Pais; } }
    }
}
