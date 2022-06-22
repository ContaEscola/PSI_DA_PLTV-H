using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace app
{
    internal class VerifyData
    {
        public static bool HasPaymentMethod(MetodoPagamento paymentMethodToCheck)
        {
            List<MetodoPagamento> allPaymentMethods = SingleTown.AppDB.MetodoPagamentoSet.ToList<MetodoPagamento>();

            foreach(MetodoPagamento metodoPagamento in allPaymentMethods)
            {
                if(paymentMethodToCheck.Metodo == metodoPagamento.Metodo)
                {
                    return true;
                    
                }
            }

            return false;
        }
    }
}
