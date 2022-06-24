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

        public static void HasEmployee(Trabalhador employeeToCheck)
        {
            List<Trabalhador> allEmployees = (from employee in SingleTown.AppDB.TrabalhadorSet
                                      where employee.Nome == employeeToCheck.Nome
                                      select employee).ToList<Trabalhador>();

            if (allEmployees.Count > 0)
                throw new Exception("Este nome já está a ser utilizado!");

        }

        public static void HasCliente(Cliente clientToCheck)
        {
            List<Cliente> allClients = (from client in SingleTown.AppDB.ClienteSet
                                              where client.Nome == clientToCheck.Nome
                                              select client).ToList<Cliente>();

            if (allClients.Count > 0)
                throw new Exception("Este nome já está a ser utilizado!");

        }

        public static void HasNIF(string nif)
        {
            List<Cliente> allClients = (from client in SingleTown.AppDB.ClienteSet
                                        where client.NumContribuinte == nif
                                        select client).ToList<Cliente>();

            if (allClients.Count > 0)
                throw new Exception("Este nif já está a ser utilizado!");

        }

        public static void ExistsItemMenu(ItemMenu itemMenu)
        {
            List<ItemMenu> allItemsMenu = (from item in SingleTown.AppDB.ItemMenuSet
                                        where item.Nome == itemMenu.Nome
                                        select item).ToList<ItemMenu>();

            if (allItemsMenu.Count > 0)
                throw new Exception("Este nome já está a ser utilizado num item!");

        }

        public static void HasItemOnMenu(ItemMenu itemMenu, Restaurante restaurantToCheck)
        {
            if (itemMenu == null || restaurantToCheck == null) return;

            bool foundItem = false;

            foreach(ItemMenu itemOnRestaurant in restaurantToCheck.ItemMenu)
            {
                if(itemOnRestaurant.Nome == itemMenu.Nome)
                {
                    foundItem = true;
                    break;
                }
            }

            if (foundItem)
                throw new Exception("Este item já existe no seu menu!");

        }
    }
}
