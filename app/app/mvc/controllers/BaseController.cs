using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace app
{
    internal class BaseController
    {

        protected void RenderView(Form viewToRender)
        {
            viewToRender.TopLevel = true;
            viewToRender.TopMost = true;

            CloseForm(viewToRender.Name);

            viewToRender.Show();
        }

        protected object RenderViewAsDialog(Form viewToRender)
        {
            viewToRender.TopLevel = true;
            viewToRender.TopMost = true;

            CloseForm(viewToRender.Name);

            if (viewToRender.ShowDialog() == DialogResult.OK)
                return null;

            return null;
        }


        private void CloseForm(string formToClose)
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
