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

        protected override void OnAppearing()
        {
            base.OnAppearing();
            MessagingCenter.Subscribe<Model.Agendamento>(this, "Agendar", (agendamento) =>
            {
                DisplayAlert("AGENDAR", string.Format("AGENDAR O AGENDAMENTO {0}{1}{2}", agendamento.Nome, agendamento.Veiculo.Nome, agendamento.Email), "CANCELAR");
            });
        }

        protected override void OnDisappearing()
        {
            base.OnDisappearing();
            MessagingCenter.Unsubscribe<Model.Agendamento>(this, "Agendar");
        }
    }
}
