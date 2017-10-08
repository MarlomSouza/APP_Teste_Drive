using System;
using System.Collections.Generic;
using System.Text;
using TesteDrive.Model;
using Xamarin.Forms;

namespace TesteDrive.ViewModels
{
    public class ListagemViewModel : BaseViewModel
    {


        private List<Veiculo> veiculo;

        public List<Veiculo> Veiculos
        {
            get { return veiculo; }
            set { veiculo = value; }
        }

        private Veiculo veiculoSelecionado;

        public Veiculo VeiculoSelecionado
        {
            get { return veiculoSelecionado; }
            set
            {
                veiculoSelecionado = value;
                if (veiculoSelecionado != null)
                    MessagingCenter.Send<Veiculo>(veiculoSelecionado, "VeiculoSelecionado");
            }
        }

        public ListagemViewModel()
        {
            this.veiculo = new List<Veiculo>
            {
                new Veiculo() { Nome = "Carro 1", Preco = "20" },
                new Veiculo() { Nome = "Carro 2", Preco = "50.21" },
                new Veiculo() { Nome = "Carro 3", Preco = "30" },
            };
        }




    }
}
