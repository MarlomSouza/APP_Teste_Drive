using System;
using System.Collections.Generic;
using System.Text;
using TesteDrive.Model;

namespace TesteDrive.ViewModels
{
    public class DetalheViewModel : BaseViewModel
    {
        public DetalheViewModel(Veiculo veiculo)
        {
            this.Veiculo = veiculo;
            CriarObjetos();
            this.valorTotal = 0;
        }

        public Veiculo Veiculo { get; set; }

        public Acessorio ABS { get; set; }
        public Acessorio SOM { get; set; }

        public Acessorio Kilometragem { get; set; }

        private bool temKilometragem;

        public bool TemKilometragem
        {
            get { return temKilometragem; }
            set
            {
                temKilometragem = value;
                CalcularValorTotal(Kilometragem, value);
            }
        }

        private bool temABS;

        public bool TemABS
        {
            get { return temABS; }
            set
            {
                temABS = value;
                CalcularValorTotal(ABS, value);
            }
        }
        private bool temSOM;

        public bool TemSom
        {
            get { return temSOM; }
            set
            {
                temSOM = value;
                CalcularValorTotal(SOM, value);
            }
        }

        private decimal valorTotal;

        public string ValorTotal
        {
            get
            {
                return valorTotal.ToString("F2");
            }
            set
            {
                try
                {
                    valorTotal = Convert.ToDecimal(value);
                }
                catch (Exception e)
                {

                    throw;
                }
            }
        }


        private void CriarObjetos()
        {
            this.ABS = new Acessorio("ABS", 220, true);
            this.SOM = new Acessorio("SOM", 110, true);
            this.Kilometragem = new Acessorio("Ilimitada", 100, true);
        }


        private void CalcularValorTotal(Acessorio acessorio, bool ativo)
        {
            if (ativo)
                this.valorTotal += acessorio.Valor;
            else
                this.valorTotal -= acessorio.Valor;

            if (valorTotal < 0)
                this.valorTotal = 0;

            OnPropertyChanged(nameof(ValorTotal));
        }
    }
}
