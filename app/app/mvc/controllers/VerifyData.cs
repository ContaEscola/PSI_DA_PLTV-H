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

        public static void HasMoradaForRestaurant(Morada moradaToCheck)
        {
            List<Morada> allMoradas = SingleTown.AppDB.MoradaSet.ToList<Morada>();

            foreach (Morada morada in allMoradas)
            {
                if (moradaToCheck.Rua == morada.Rua)
                {
                        throw new Exception($"Esta rua já está a ser utilizada!{Environment.NewLine}Experimente completá-la com mais informações!");
                }
            }

        }

        public static void HasMoradaForPerson(Morada moradaToCheck)
        {
            List<Restaurante> allRestaurants = (from morada in SingleTown.AppDB.MoradaSet
                                                join restaurante in SingleTown.AppDB.RestauranteSet on morada.Id equals restaurante.Morada.Id
                                                where morada.Rua == moradaToCheck.Rua
                                                select restaurante).ToList<Restaurante>();

            if (allRestaurants.Count > 0)
                throw new Exception($"Esta rua já está a ser utilizada!{Environment.NewLine}Experimente completá-la com mais informações!");

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

        public static void HasPerson(Pessoa personToCheck)
        {
            List<Pessoa> allPeople = (from people in SingleTown.AppDB.PessoaSet
                                      where people.Nome == personToCheck.Nome
                                      select people).ToList<Pessoa>();

            if (allPeople.Count > 0)
                throw new Exception("Este nome já está a ser utilizado!");

        }
    }
}
