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

        public static bool HasCategory(Categoria categoryToCheck)
        {
            List<Categoria> allCategories = SingleTown.AppDB.CategoriaSet.ToList<Categoria>();

            foreach (Categoria category in allCategories)
            {
                if (categoryToCheck.Nome == category.Nome)
                {
                    return true;

                }
            }

            return false;
        }

        public static void HasMorada(Morada moradaToCheck)
        {
            List<Morada> allMoradas = SingleTown.AppDB.MoradaSet.ToList<Morada>();

            foreach (Morada morada in allMoradas)
            {
                if (moradaToCheck.Rua == morada.Rua)
                {
                    throw new Exception("Já existe um restaurante com esta rua!");
                }
            }

        }

        public static void HasRestaurant(Restaurante restaurantToCheck)
        {
            List<Restaurante> allRestaurants = SingleTown.AppDB.RestauranteSet.ToList<Restaurante>();

            foreach (Restaurante restaurante in allRestaurants)
            {
                if (restaurantToCheck.Nome == restaurante.Nome)
                {
                    throw new Exception("Já existe um restaurante com este nome!");
                }
            }
        }
    }
}
