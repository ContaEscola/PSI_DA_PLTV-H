using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace app
{
    public partial class ItemMenu
    {
        public string PrecoFormated { get { return $"{String.Format(System.Globalization.CultureInfo.GetCultureInfo("pt-PT"), "{0:#,0.00}", Preco)}€"; } }

        public string CategoriaFormated { get { return $"{Categoria.Nome}"; } }

        public string IngredientesFormated { get
            {
                // https://stackoverflow.com/questions/1547476/easiest-way-to-split-a-string-on-newlines-in-net
                string[] allIngredients = Ingredientes.Split(new string[] { "\\n" },StringSplitOptions.None);

                string fullString = "";
                int count = 0;
                foreach (string ingrediente in allIngredients)
                {
                    count++;
                    fullString += $"{ingrediente}";

                    if (count != allIngredients.Count())
                        fullString += $"{Environment.NewLine}";
                }

                return fullString;
            } 
        }
    }
}
