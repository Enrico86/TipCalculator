using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;
using Xamarin.Forms;

namespace TipCalculator
{
    public class TipModel : INotifyPropertyChanged
    {
        public Command CalculosCommand { get; set; }

        public TipModel()
        {
            CalculosCommand = new Command(HacerCalculos);
        }

        private void HacerCalculos()
        {
            TotalPropina = TotalCuenta * PorcentajePropina / 100;
            PropinaPersona = TotalPropina / NumeroPersonas;
            TotalPorPersona = PropinaPersona + (TotalCuenta / NumeroPersonas);
            TotalCuentaYPropina = TotalCuenta + TotalPropina;
        }

        private float _totalCuenta;
        public float TotalCuenta
        {
            get
            {
                if (_totalCuenta < 0)
                { _totalCuenta = Math.Abs(_totalCuenta); }
                return _totalCuenta;
            }
            set { _totalCuenta = value; }
        }
        private float _porcentajePropina;
        public float PorcentajePropina
        {
            get
            {
                if (_porcentajePropina < 0)
                { _porcentajePropina = Math.Abs(_porcentajePropina); }
                return _porcentajePropina;
            }
            set { _porcentajePropina = value; }
        }
        private int _numeroPersonas;
        public int NumeroPersonas
        {
            get { return _numeroPersonas; }
            set { _numeroPersonas = value; }
        }
        private float _totalPropina;
        public float TotalPropina
        {
            get { return _totalPropina; }
            set
            {
                _totalPropina = value;
                OnPropertyChanged();
            }
        }
        private float _propinaPersona;
        public float PropinaPersona
        {
            get { return _propinaPersona; }
            set
            {
                _propinaPersona = value;
                OnPropertyChanged();
            }
        }
        private float _totalPorPersona;
        public float TotalPorPersona
        {
            get { return _totalPorPersona; }
            set
            {
                _totalPorPersona = value;
                OnPropertyChanged();
            }
        }
        private float _totalCuentaYPropina;
        public float TotalCuentaYPropina
        {
            get { return _totalCuentaYPropina; }
            set
            {
                _totalCuentaYPropina = value;
                OnPropertyChanged();
            }
        }



        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)

        {

            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs((propertyName)));

        }
    }
}
