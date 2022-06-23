using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace app
{
    public partial class AddEditRestaurant : Form
    {
        private FontLoader _fontLoader;

        private bool _toEdit;


        /// <summary>
        /// Inicializa o formulário para adicionar um restaurante
        /// </summary>
        /// <param name="toEdit">Passe true se quiser que o formulário seja para editar um restaurante</param>
        public AddEditRestaurant(bool toEdit = false)
        {
            InitializeComponent();

            _fontLoader = new FontLoader();

            _toEdit = toEdit;

        }


        //Irá dar load das fontes nos controlos, e o title consoante a ação desejada
        private void AddEditRestaurant_Load(object sender, EventArgs e)
        {
            Dictionary<Control, string> fontsForControls = new Dictionary<Control, string>();

            fontsForControls.Add(Lbl_Title, FontLoader.RobotoSlabBold);

            fontsForControls.Add(Lbl_RestaurantName, FontLoader.RobotoSlabRegular);
            fontsForControls.Add(TxtBox_RestaurantName, FontLoader.RobotoSlabRegular);

            fontsForControls.Add(Lbl_RestaurantAddress, FontLoader.RobotoSlabLight);

            fontsForControls.Add(Lbl_RestaurantStreet, FontLoader.RobotoSlabRegular);
            fontsForControls.Add(TxtBox_RestaurantStreet, FontLoader.RobotoSlabRegular);

            fontsForControls.Add(Lbl_RestaurantCity, FontLoader.RobotoSlabRegular);
            fontsForControls.Add(TxtBox_RestaurantCity, FontLoader.RobotoSlabRegular);

            fontsForControls.Add(Lbl_RestaurantPostalCode, FontLoader.RobotoSlabRegular);
            fontsForControls.Add(MaskedTxtBox_RestaurantPostalCode, FontLoader.RobotoSlabRegular);

            fontsForControls.Add(Lbl_RestaurantCountry, FontLoader.RobotoSlabRegular);
            fontsForControls.Add(TxtBox_RestaurantCountry, FontLoader.RobotoSlabRegular);

            fontsForControls.Add(Btn_Conclude, FontLoader.RobotoSlabRegular);

            _fontLoader.LoadFontToControls(fontsForControls);

            Lbl_RestaurantAddress.BringToFront();

           
            //Se o formulário for para editar então faz-se alterações
            if(_toEdit)
            {
                this.Text = "Alterar Restaurante";
                Lbl_Title.Text = "Alterar Restaurante"; 
            }
        }

        private void Btn_Conclude_Click(object sender, EventArgs e)
        {
            if(_toEdit)
            {

            } else
            {
                if (String.IsNullOrEmpty(TxtBox_RestaurantName.Text) || String.IsNullOrEmpty(TxtBox_RestaurantStreet.Text)) return;
                if (String.IsNullOrEmpty(TxtBox_RestaurantCity.Text) || String.IsNullOrEmpty(TxtBox_RestaurantCountry.Text)) return;

                try
                {
                    string codPostal = MaskedTxtBox_RestaurantPostalCode.Text;
                    StringHelper.TrimAllWhiteSpace(ref codPostal);

                    if (codPostal.Length != 8) throw new Exception("Código Postal Inválido!");

                    Morada newMorada = new Morada
                    {
                        Rua = TxtBox_RestaurantStreet.Text,
                        Cidade = TxtBox_RestaurantCity.Text,
                        CodPostal = codPostal,
                        Pais = TxtBox_RestaurantCountry.Text
                    };

                    Restaurante newRestaurant = new Restaurante
                    {
                        Nome = TxtBox_RestaurantName.Text
                    };

                    VerifyData.HasRestaurant(newRestaurant);
                    VerifyData.HasMorada(newMorada);

                    CRUD.AddMorada(newMorada);
                    Morada moradaInDB = CRUD.GetMorada(newMorada.Rua);

                    newRestaurant.Morada = moradaInDB;

                    CRUD.AddRestaurant(newRestaurant);

                    Close();

                } catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }

}
