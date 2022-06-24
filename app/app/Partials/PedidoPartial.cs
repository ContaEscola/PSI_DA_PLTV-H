using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace app
{
    public partial class Pedido
    {
        public string ValorTotalFormated { get { 
                return $"{String.Format(System.Globalization.CultureInfo.GetCultureInfo("pt-PT"), "{0:#,0.00}", ValorTotal)}€"; 
            } }

        public string ClienteFormated
        {
            get { return Cliente.Nome; }
        }

        public string TrabalhadorFormated
        {
            get { return Trabalhador.Nome; }
        }

        public string EstadoFormated
        {
            get { return Estado.State; }
        }
    }
}
