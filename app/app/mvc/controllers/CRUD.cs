using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace app
{
    internal class CRUD
    {

        public static void AddPaymentMethod(MetodoPagamento paymentMethodToAdd)
        {
            bool hasPaymentMethod = VerifyData.HasPaymentMethod(paymentMethodToAdd);

            if (hasPaymentMethod)
                throw new Exception("Já existe um método de pagamento com este nome!");

            SingleTown.AppDB.MetodoPagamentoSet.Add(paymentMethodToAdd);
            SingleTown.AppDB.SaveChanges();
        }
    }
}
