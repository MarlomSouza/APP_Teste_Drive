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
        }

        public Veiculo Veiculo { get; set; }

        public Acessorio ABS { get; set; }
        public Acessorio SOM { get; set; }

        private Acessorio kilometragem;
        public Acessorio Kilometragem
        {
            get
            {
                return this.kilometragem;
            }
            set
            {
                OnPropertyChanged(nameof(Kilometragem.Nome));
                this.kilometragem = value;
            }
        }

        private int valorTotal;

        public int ValorTotal
        {
            get { return valorTotal; }
            set { valorTotal = value; }
        }


        private void CriarObjetos()
        {
            this.ABS = new Acessorio("ABS", 100, true);
            this.SOM = new Acessorio("SOM", 100, true);
            this.Kilometragem = new Acessorio("Ilimitada", 100, false);
        }
    }
}
