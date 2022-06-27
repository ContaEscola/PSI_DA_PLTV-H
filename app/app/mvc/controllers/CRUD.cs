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

        public static void EditPaymentMethod(MetodoPagamento updatedPaymentMethod)
        {
            var allPaymentMethods = SingleTown.AppDB.MetodoPagamentoSet;

            MetodoPagamento paymentMethodToUpdate = (MetodoPagamento)allPaymentMethods.Where(p => p.Metodo == SingleTown.SelectedPaymentMethod.Metodo).FirstOrDefault();


            MetodoPagamento checkForExistentNames = (MetodoPagamento)allPaymentMethods.Where(p => p.Metodo == updatedPaymentMethod.Metodo && p.Id != paymentMethodToUpdate.Id).FirstOrDefault();

            if (checkForExistentNames != null)
                throw new Exception("Já existe um método de pagamento com esta descrição!");

            paymentMethodToUpdate.Metodo = updatedPaymentMethod.Metodo;
            paymentMethodToUpdate.Ativo = updatedPaymentMethod.Ativo;

            
            

            SingleTown.AppDB.SaveChanges();

        }


        public static void AddCategory(Categoria categoryToAdd)
        {
            bool hasCategory = VerifyData.HasCategory(categoryToAdd);

            if (hasCategory)
                throw new Exception("Já existe uma categoria com este nome!");

            SingleTown.AppDB.CategoriaSet.Add(categoryToAdd);
            SingleTown.AppDB.SaveChanges();
        }

        public static Categoria GetCategory(string name)
        {
            var allCategories = SingleTown.AppDB.CategoriaSet;

            Categoria category = (Categoria)allCategories.Where(c => c.Nome == name).FirstOrDefault();

            return category;
        }

        public static void EditCategory(Categoria updatedCategory)
        {
            var allCategories = SingleTown.AppDB.CategoriaSet;

            Categoria categoryToUpdate = (Categoria)allCategories.Where(c => c.Nome == SingleTown.SelectedCategory.Nome).FirstOrDefault();


            Categoria checkForExistentNames = (Categoria)allCategories.Where(c => c.Nome == updatedCategory.Nome && c.Id != categoryToUpdate.Id).FirstOrDefault();

            if (checkForExistentNames != null)
                throw new Exception("Já existe uma categoria com esse nome!");

            categoryToUpdate.Nome = updatedCategory.Nome;
            categoryToUpdate.Ativo = updatedCategory.Ativo;

            SingleTown.AppDB.SaveChanges();

        }

        public static void AddMorada(Morada moradaToAdd)
        {
            SingleTown.AppDB.MoradaSet.Add(moradaToAdd);
            SingleTown.AppDB.SaveChanges();
        }

        public static Morada GetMorada(string rua)
        {
            var allMoradas = SingleTown.AppDB.MoradaSet;

            Morada morada = (Morada)allMoradas.Where(m => m.Rua == rua).FirstOrDefault();

            return morada;
        }

       
        public static void AddRestaurant(Restaurante restaurantToAdd)
        {
            SingleTown.AppDB.RestauranteSet.Add(restaurantToAdd);
            SingleTown.AppDB.SaveChanges();
        }

        public static Restaurante GetRestaurant(string restaurantNameToLookUp)
        {
            var allRestaurants = SingleTown.AppDB.RestauranteSet;

            Restaurante restaurante = (Restaurante)allRestaurants.Where(r => r.Nome == restaurantNameToLookUp).FirstOrDefault();

            return restaurante;
        }

        public static void EditRestaurant(Restaurante updatedRestaurant)
        {
            var allRestaurants = SingleTown.AppDB.RestauranteSet;

            Restaurante checkForExistentNames = (Restaurante)allRestaurants.Where(r => r.Nome == updatedRestaurant.Nome && r.Id != SingleTown.SelectedRestaurant.Id).FirstOrDefault();

            if (checkForExistentNames != null)
                throw new Exception("Já existe um restaurante com esse nome!");

            Restaurante checkForExistentRua = (Restaurante)allRestaurants.Where(r => r.Morada.Rua == updatedRestaurant.Morada.Rua && r.Id != SingleTown.SelectedRestaurant.Id).FirstOrDefault();

            if (checkForExistentRua != null)
                throw new Exception("Já existe um restaurante com essa rua!");

            SingleTown.SelectedRestaurant.Nome = updatedRestaurant.Nome;
            SingleTown.SelectedRestaurant.Morada.Rua = updatedRestaurant.Morada.Rua;
            SingleTown.SelectedRestaurant.Morada.Cidade = updatedRestaurant.Morada.Cidade;
            SingleTown.SelectedRestaurant.Morada.CodPostal = updatedRestaurant.Morada.CodPostal;
            SingleTown.SelectedRestaurant.Morada.Pais = updatedRestaurant.Morada.Pais;

            SingleTown.AppDB.SaveChanges();

        }


        public static void AddEmployee(Trabalhador employeeToAdd)
        {
            SingleTown.AppDB.TrabalhadorSet.Add(employeeToAdd);
            SingleTown.AppDB.SaveChanges();
        }

        public static Trabalhador GetEmployee(string employeeName)
        {
            var allEmployees = SingleTown.AppDB.TrabalhadorSet;

            Trabalhador employee = (Trabalhador)allEmployees.Where(e => e.Nome == employeeName).FirstOrDefault();

            return employee;
        }


        public static void EditEmployee(Trabalhador updatedEmployee)
        {
            var allEmployees = SingleTown.AppDB.TrabalhadorSet;

            Trabalhador checkForExistentNames = (Trabalhador)allEmployees.Where(e => e.Nome == updatedEmployee.Nome && e.Id != SingleTown.SelectedEmployee.Id).FirstOrDefault();

            if (checkForExistentNames != null)
                throw new Exception("Já existe um trabalhador com esse nome!");

            VerifyData.HasMoradaForPerson(updatedEmployee.Morada);

            SingleTown.SelectedEmployee.Nome = updatedEmployee.Nome;
            SingleTown.SelectedEmployee.Telemovel = updatedEmployee.Telemovel;
            SingleTown.SelectedEmployee.Salario = updatedEmployee.Salario;
            SingleTown.SelectedEmployee.Posicao = updatedEmployee.Posicao;

            SingleTown.SelectedEmployee.Morada.Rua = updatedEmployee.Morada.Rua;
            SingleTown.SelectedEmployee.Morada.Cidade = updatedEmployee.Morada.Cidade;
            SingleTown.SelectedEmployee.Morada.CodPostal = updatedEmployee.Morada.CodPostal;
            SingleTown.SelectedEmployee.Morada.Pais = updatedEmployee.Morada.Pais;


            SingleTown.AppDB.SaveChanges();

        }

        public static void RemoveEmployee()
        {
            SingleTown.SelectedEmployee.Ativo = "Inativo";
            SingleTown.AppDB.SaveChanges();

        }


        public static void AddClient(Cliente clientToAdd)
        {
            SingleTown.AppDB.ClienteSet.Add(clientToAdd);
            SingleTown.AppDB.SaveChanges();
        }

        public static Cliente GetClient(string clientName)
        {
            var allClients = SingleTown.AppDB.ClienteSet;

            Cliente client = (Cliente)allClients.Where(c => c.Nome == clientName).FirstOrDefault();

            return client;
        }
        public static void EditClient(Cliente updatedClient)
        {
            var allClients = SingleTown.AppDB.ClienteSet;

            Cliente checkForExistentNames = (Cliente)allClients.Where(c => c.Nome == updatedClient.Nome && c.Id != SingleTown.SelectedClient.Id).FirstOrDefault();

            if (checkForExistentNames != null)
                throw new Exception("Já existe um cliente com esse nome!");

            VerifyData.HasMoradaForPerson(updatedClient.Morada);
            
            Cliente checkForNif = (Cliente)allClients.Where(c => c.NumContribuinte == updatedClient.NumContribuinte && c.Id != SingleTown.SelectedClient.Id).FirstOrDefault();

            if (checkForNif != null)
                throw new Exception("Já existe um cliente com esse nif!");

            SingleTown.SelectedClient.Nome = updatedClient.Nome;
            SingleTown.SelectedClient.Telemovel = updatedClient.Telemovel;
            SingleTown.SelectedClient.NumContribuinte = updatedClient.NumContribuinte;


            SingleTown.SelectedClient.Morada.Rua = updatedClient.Morada.Rua;
            SingleTown.SelectedClient.Morada.Cidade = updatedClient.Morada.Cidade;
            SingleTown.SelectedClient.Morada.CodPostal = updatedClient.Morada.CodPostal;
            SingleTown.SelectedClient.Morada.Pais = updatedClient.Morada.Pais;

            SingleTown.AppDB.SaveChanges();

        }

        public static void RemoveClient()
        {
            SingleTown.SelectedClient.Ativo = "Inativo";
            SingleTown.AppDB.SaveChanges();
        }

        public static void AddItemMenuToRestaurant(Restaurante restaurantToAdd,ItemMenu itemToAdd)
        {
            restaurantToAdd.ItemMenu.Add(itemToAdd);

            SingleTown.AppDB.SaveChanges();
        }

        public static ItemMenu GetItem(string itemName)
        {
            var allItems = SingleTown.AppDB.ItemMenuSet;

            ItemMenu item = (ItemMenu)allItems.Where(i => i.Nome == itemName).FirstOrDefault();

            return item;
        }


        public static void EditItemMenu(ItemMenu updatedItemMenu)
        {
            var allItemMenus = SingleTown.AppDB.ItemMenuSet;

            ItemMenu checkForExistentNames = (ItemMenu)allItemMenus.Where(i => i.Nome == updatedItemMenu.Nome && i.Id != SingleTown.SelectedItemMenu.Id).FirstOrDefault();

            if (checkForExistentNames != null)
                throw new Exception("Já existe um item com esse nome!");

            SingleTown.SelectedItemMenu.Nome = updatedItemMenu.Nome;
            SingleTown.SelectedItemMenu.Ingredientes = updatedItemMenu.Ingredientes;
            SingleTown.SelectedItemMenu.Preco = updatedItemMenu.Preco;
            SingleTown.SelectedItemMenu.Categoria = updatedItemMenu.Categoria;
            SingleTown.SelectedItemMenu.Ativo = updatedItemMenu.Ativo;

            SingleTown.AppDB.SaveChanges();

        public static void AdItemMenuToRestaurant(Restaurante restaurantToAdd,ItemMenu itemToAdd)
        {
            restaurantToAdd.ItemMenu.Add(itemToAdd);

            SingleTown.AppDB.SaveChanges();
        }

        public static ItemMenu GetItem(string itemName)
        {
            var allItems = SingleTown.AppDB.ItemMenuSet;

            ItemMenu item = (ItemMenu)allItems.Where(i => i.Nome == itemName).FirstOrDefault();

            return item;
        }
    }
}
