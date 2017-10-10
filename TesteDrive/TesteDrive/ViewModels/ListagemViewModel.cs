using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;
using TesteDrive.Business;
using TesteDrive.Model;
using Xamarin.Forms;

namespace TesteDrive.ViewModels
{
    public class ListagemViewModel : BaseViewModel
    {
        private string URL_GET_VEICULOS = "http://aluracar.herokuapp.com/";

        private VeiculoBusiness busines;

        private ObservableCollection<Veiculo> veiculo;
        public ObservableCollection<Veiculo> Veiculos
        {
            get { return veiculo; }
            set
            {
                veiculo = value;
                OnPropertyChanged();
            }
        }

        private Veiculo veiculoSelecionado;

        public Veiculo VeiculoSelecionado
        {
            get { return veiculoSelecionado; }
            set
            {
                veiculoSelecionado = value;
                if (veiculoSelecionado != null)
                    MessagingCenter.Send(veiculoSelecionado, "VeiculoSelecionado");
            }
        }

        private bool aguarde;

        public bool Aguarde
        {
            get { return aguarde; }
            set
            {
                aguarde = value;
                OnPropertyChanged();
            }
        }


        public ListagemViewModel()
        {
            Aguarde = true;
            this.busines = new VeiculoBusiness(URL_GET_VEICULOS);

            busines.Obter().ContinueWith(d =>
            {
                Veiculos = d.Result;
                this.Aguarde = false;
            }, TaskContinuationOptions.OnlyOnRanToCompletion);

        }
    }
}
