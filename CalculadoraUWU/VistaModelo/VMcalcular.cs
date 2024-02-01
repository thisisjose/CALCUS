using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace CalculadoraUWU.VistaModelo
{
    public class VMcalcular : BaseViewModel
    {
        #region VARIABLES
        double _Seconds;
        double _FC;
        string _Mensaje;
        double _Peso;
        double _Altura;
        double _Imc;

        #endregion
        #region CONSTRUCTOR
        public VMcalcular(INavigation navigation)
        {
            Navigation = navigation;

        }
        #endregion
        #region OBJETOS
        public string Mensaje
        {
            get { return _Mensaje; }
            set { SetValue(ref _Mensaje, value); }
        }
        public double FC
        {
            get { return _FC; }
            set { SetValue(ref _FC, value); }
        }

        public double seconds
        {
            get { return _Seconds; }
            set { SetValue(ref _Seconds, value); }
        }
        public double Peso
        {
            get { return _Peso; }
            set { SetValue(ref _Peso, value); }
        }
        public double Altura
        {
            get { return _Altura; }
            set { SetValue(ref _Altura, value); }
        }
        public double Imc
        {
            get { return _Imc; }
            set { SetValue(ref _Imc, value); }
        }
        #endregion
        #region PROCESOS
        public async Task ProcesoAsyncrono()
        {

        }
        public void procesoSimple()
        {

        }
        //private void CalcularFC(double x, double y)
        //{
        //    FC = x * x * x * x / 15;
        //}
        private void CalcularIMC(double p, double a)
        {
            Imc = p / Math.Pow(a, 2);
        }
        public async Task CalcularFrecuencia(double latido1)
        {
            var seconds = latido1 * 4;

            if (seconds > 60)
            {
                await DisplayAlert("Frecuencia Cardiaca", "El FC es alto", "Ok");
            }
            else if (seconds == 60)
            {
                await DisplayAlert("Frecuencia Cardiaca", "El FC es alto", "Ok");
            }
            else
            {
                await DisplayAlert("Frecuencia Cardiaca", "El FC es alto", "Ok");
            }

        }

        public async Task BtnCalcularIMC()
        {
            double peso = Peso;
            double altura = Altura;
            double r = peso / altura*altura;


            if (r < 18)
            {
                await DisplayAlert("Rango de peso", "Tienes peso pluma", "Quitar");
            }
            else if (r >= 18 && r <= 24.9)
            {
                await DisplayAlert("Rango de peso", "Tienes peso masomeno", "Quitar");
            }
            else if (r > 24.9 && r <= 29.9)
            {
               
                await DisplayAlert("Rango de peso", "Tienes Sobre Peso", "Quitar");

            }
            else
            {
                await DisplayAlert("Rango de peso", "Tienes Obesidad", "Quitar");
            }
        
        
            
        }

        #endregion
        #region COMANDOS
        public ICommand ProcesoAsyncomand => new Command(async () => await ProcesoAsyncrono());
        //public ICommand BtnCalcularFrecuencia => new Command<double>(CalcularFrecuencia);
        public ICommand BtnCalcularIMCCommand => new Command(async () => await BtnCalcularIMC());
        #endregion
    }
}
