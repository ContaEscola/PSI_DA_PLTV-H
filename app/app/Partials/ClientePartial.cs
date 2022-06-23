using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace app
{
    public partial class Cliente : Pessoa
    {
        public string PaisExtracted { get { return Morada.Pais; } }
    }
}
