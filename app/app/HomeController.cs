using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace app
{
    internal class HomeController : BaseController
    {
        private Form _homeView;

        public HomeController(Form homeView)
        {
            _homeView = homeView;
        }

    }
}
