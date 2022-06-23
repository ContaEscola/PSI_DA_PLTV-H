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

        public static void AddPerson(Pessoa personToAdd)
        {
            SingleTown.AppDB.PessoaSet.Add(personToAdd);
            SingleTown.AppDB.SaveChanges();
        }

        public static Pessoa GetPerson(string personName)
        {
            var allPeople = SingleTown.AppDB.PessoaSet;

            Pessoa person = (Pessoa)allPeople.Where(p => p.Nome == personName).FirstOrDefault();

            return person;
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

            List<Restaurante> checkForExistentRua = (from morada in SingleTown.AppDB.MoradaSet
                                               join restaurante in SingleTown.AppDB.RestauranteSet on morada.Id equals restaurante.Morada.Id
                                               where morada.Rua == updatedEmployee.Morada.Rua && restaurante.Id != SingleTown.SelectedEmployee.IdRestaurante
                                               select restaurante).ToList<Restaurante>();

            if (checkForExistentRua.Count > 0)
                throw new Exception($"Esta rua já está a ser utilizada!{Environment.NewLine}Experimente completá-la com mais informações!");

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
    }
}
