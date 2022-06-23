using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace app
{
    internal class SingleTown
    {
        private static BaseDadosContainer appDB;

        private static MetodoPagamento selectedPaymentMethod;
        private static Categoria selectedCategory;
        public static BaseDadosContainer AppDB { get { return appDB; } }
        public static MetodoPagamento SelectedPaymentMethod { get { return selectedPaymentMethod; } set { selectedPaymentMethod = value; } }
        public static Categoria SelectedCategory { get { return selectedCategory; } set { selectedCategory = value; } }
        public SingleTown()
        {
            appDB = new BaseDadosContainer();
        }
    }
}
