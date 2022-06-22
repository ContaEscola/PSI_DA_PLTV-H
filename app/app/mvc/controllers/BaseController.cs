using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace app
{
    internal class BaseController
    {
        public static void RenderView(Form viewToRender)
        {
            viewToRender.TopLevel = true;
            viewToRender.TopMost = false;

            CloseForm(viewToRender.Name);

            viewToRender.Show();
        }

        public static void RenderViewAsDialog(Form viewToRender)
        {
            viewToRender.TopLevel = true;
            viewToRender.TopMost = true;

            CloseForm(viewToRender.Name);

            viewToRender.ShowDialog();
        }

        public static Hashtable RenderViewAsDialogWithReturn(Dialog viewToRender)
        {
            viewToRender.TopLevel = true;
            viewToRender.TopMost = true;

            CloseForm(viewToRender.Name);

 
            Hashtable dataToReturn = new Hashtable();

            if (viewToRender.ShowDialog() == DialogResult.OK)
            {
                dataToReturn = viewToRender.GetData();
                viewToRender.Close();
            }
    
            return dataToReturn;
        }


        private static void CloseForm(string formToClose)
        {
            FormCollection openedForms = Application.OpenForms;

            foreach (Form form in openedForms)
            {
                if(form.Name == formToClose)
                {
                    form.Close();
                    break;
                }
            }
        }
    }
}
