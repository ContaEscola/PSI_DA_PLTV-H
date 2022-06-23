using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace app
{
    public partial class Trabalhador : Pessoa
    {
        // https://www.code-sample.net/CSharp/Format-Number
        public string SalarioFormated { get { return $"{String.Format("{0:#,0.00}", Salario)}€"; } }

        public string PaisExtracted { get { return Morada.Pais; } }
    }
}
