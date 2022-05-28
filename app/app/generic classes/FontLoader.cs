using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace app
{
    internal class FontLoader
    {
        public static string RobotoSlabRegular = "Roboto Slab";
        public static string RobotoSlabBold = "Roboto Slab Bold";
        public static string RobotoSlabLight = "Roboto Slab Light";
        public static string RobotoSlabExtraLight = "Roboto Slab ExtraLight";

        private PrivateFontCollection _pfc;

        public FontLoader()
        {
            _pfc = new PrivateFontCollection();

            // Adiciona as fonts que são utilizadas no projeto
            _pfc.AddFontFile($"{Application.StartupPath}\\assets\\fonts\\RobotoSlab-Bold.ttf");
            _pfc.AddFontFile($"{Application.StartupPath}\\assets\\fonts\\RobotoSlab-ExtraLight.ttf");
            _pfc.AddFontFile($"{Application.StartupPath}\\assets\\fonts\\RobotoSlab-Light.ttf");
            _pfc.AddFontFile($"{Application.StartupPath}\\assets\\fonts\\RobotoSlab-Regular.ttf");
        }

        /// <summary>
        /// Carrega as fontes nos controlos.
        /// </summary>
        /// <param name="controlsWithFonts"></param>
        public void LoadFontToControls(Dictionary<Control, string> controlsWithFonts)
        {
            foreach(KeyValuePair<Control, string> kvp in controlsWithFonts)
            {
                
                FontFamily font = Array.Find(_pfc.Families, familie => String.Equals(familie.Name, kvp.Value));

                kvp.Key.Font = new Font(font, kvp.Key.Font.Size);
            }
        }

        /// <summary>
        /// Carrega as fontes nos toolStripMenuItems.
        /// </summary>
        /// <param name="toolStripItemsWithFonts"></param>
        public void LoadFontToToolStrips(Dictionary<ToolStripMenuItem, string> toolStripItemsWithFonts)
        {

            foreach (KeyValuePair<ToolStripMenuItem, string> kvp in toolStripItemsWithFonts)
            {

                FontFamily font = Array.Find(_pfc.Families, familie => String.Equals(familie.Name, kvp.Value));

                kvp.Key.Font = new Font(font, kvp.Key.Font.Size);

            }
        }

        /// <summary>
        /// Pesquisa o nome da fonte na coleção de fontes predefinida
        /// </summary>
        /// <param name="font"></param>
        /// <returns>Devolve a familia da fonte</returns>
        public FontFamily GetFont(string font)
        {
            return Array.Find(_pfc.Families, familie => String.Equals(familie.Name, font));
        }

    }
}
