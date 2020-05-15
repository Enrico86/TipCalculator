using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace TipCalculator
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        private TipModel modeloTip;
        //Creamos un objeto de la clase TipModel para poder acceder a todas las propiedades que hemos
        //creado
        public MainPage()
        {
            InitializeComponent();
            modeloTip = new TipModel
            //Instanciamos nuestro objeto modeloTip en el constructor de nuestra MainPage para asegurarnos que cada vez
            //que se abra la MainPage no nos olvidemos de hacerlo. Además de esta manera puedo digamos sugerirle los valores
            //a introducir en las propiedades
            {
                PorcentajePropina = 10,
                NumeroPersonas=2
            };
            //Con esto estamos instanciando nuestro modeloTip con unos valores de sus propiedades
            this.BindingContext = modeloTip;
            //Y por último para poder enlazar las propiedades de la interfaz grafica de nuestra MainPage con las 
            //propiedades de la clase TipModel, tenemos que decirle que el BindingContext de esta clase (this) será
            //el objeto modeloTip (perteneciente a la clase TipModel).
        }
    }
}
