using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace TipCalculator.ViewModels
{
    public class MainPageViewModel
    {
        public Command CalculosCommand { get; set; }

        public TipModel tipModel { get; set; }

        public MainPageViewModel ()
        {
            CalculosCommand = new Command(HacerCalculos);
            tipModel = new TipModel

            {
                PorcentajePropina = 10,
                NumeroPersonas = 2
            };
        }
        private void HacerCalculos()
        {
            tipModel.TotalPropina = tipModel.TotalCuenta * tipModel.PorcentajePropina / 100;
            tipModel.PropinaPersona = tipModel.TotalPropina / tipModel.NumeroPersonas;
            tipModel.TotalPorPersona = tipModel.PropinaPersona + (tipModel.TotalCuenta / tipModel.NumeroPersonas);
            tipModel.TotalCuentaYPropina = tipModel.TotalCuenta + tipModel.TotalPropina;
        }
    }
}
