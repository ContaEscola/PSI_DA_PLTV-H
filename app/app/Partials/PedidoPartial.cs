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

        public string ValorPorPagarFormated
        {
            get
            {
                if (Pagamento == null) return "";

                decimal totalValue = ValorTotal;

                foreach (Pagamento pagamento in Pagamento)
                    totalValue -= pagamento.Valor;

                return $"{String.Format(System.Globalization.CultureInfo.GetCultureInfo("pt-PT"), "{0:#,0.00}", ValorTotal)}€";
            }
        }

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
            get {   if (Estado == null) return ""; 
                    return Estado.State; }
        }
    }
}
