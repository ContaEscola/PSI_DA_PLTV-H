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
        /// Carrega as fontes nos controlos, sequencialmente.
        /// </summary>
        /// <param name="controls"></param>
        /// <param name="fontWeights"></param>
        public void LoadFontToControls(Control[] controls, string[] fonts)
        {
            int counter = 0;

            foreach(Control control in controls)
            {
                
                FontFamily font = Array.Find(_pfc.Families, familie => String.Equals(familie.Name, fonts[counter]));

                //Convert from px to points
                //float sizeInPoints = control.Font.Size * (float)0.75;

                control.Font = new Font(font, control.Font.Size);

                counter++;
            }
        }

        /// <summary>
        /// Carrega as fontes nos toolStripMenuItems, sequencialmente.
        /// </summary>
        /// <param name="controls"></param>
        /// <param name="fontWeights"></param>
        public void LoadFontToToolStrips(ToolStripMenuItem[] toolStripItems, string[] fonts)
        {
            int counter = 0;

            foreach (ToolStripMenuItem toolStripItem in toolStripItems)
            {

                FontFamily font = Array.Find(_pfc.Families, familie => String.Equals(familie.Name, fonts[counter]));

                toolStripItem.Font = new Font(font, toolStripItem.Font.Size);

                counter++;
            }
        }

    }
}
