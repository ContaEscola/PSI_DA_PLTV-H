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
        private static Restaurante selectedRestaurant;
        private static Trabalhador selectedEmployee;
        private static Cliente selectedClient;
        private static ItemMenu selectedItemMenu;
        public static BaseDadosContainer AppDB { get { return appDB; } }
        public static MetodoPagamento SelectedPaymentMethod { get { return selectedPaymentMethod; } set { selectedPaymentMethod = value; } }
        public static Categoria SelectedCategory { get { return selectedCategory; } set { selectedCategory = value; } }
        public static Restaurante SelectedRestaurant { get { return selectedRestaurant; } set { selectedRestaurant = value; } }
        public static Trabalhador SelectedEmployee { get { return selectedEmployee; } set { selectedEmployee = value; } }
        public static Cliente SelectedClient { get { return selectedClient; } set { selectedClient = value; } }
        public static ItemMenu SelectedItemMenu { get { return selectedItemMenu; } set { selectedItemMenu = value; } }
        public SingleTown()
        {
            appDB = new BaseDadosContainer();
        }
    }
}
