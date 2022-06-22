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
    }
}
