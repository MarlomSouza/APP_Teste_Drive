using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TesteDrive.Model;
using TesteDrive.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TesteDrive.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Agendamento : ContentPage
    {
        public Veiculo Veiculo { get; private set; }
        public AgendamentoViewModel AgendamentoViewModel { get; set; }

        public Agendamento(Veiculo veiculo)
        {
            InitializeComponent();
            this.Veiculo = veiculo;
            AgendamentoViewModel = new AgendamentoViewModel(veiculo);
            this.BindingContext = AgendamentoViewModel;
        }

        private void Agendar_Clicked(object sender, EventArgs e)
        {
            DisplayAlert("AGENDAR", string.Format("AGENDAR O AGENDAMENTO {0}{1}{2}", AgendamentoViewModel.Agendamento.Nome, AgendamentoViewModel.Agendamento.Veiculo.Nome, AgendamentoViewModel.Agendamento.Email), "CANCELAR");
        }
    }
}
