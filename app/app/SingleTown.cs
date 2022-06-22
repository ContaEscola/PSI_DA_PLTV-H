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

        public static BaseDadosContainer AppDB { get { return appDB; } }

        public SingleTown()
        {
            appDB = new BaseDadosContainer();
        }
    }
}
