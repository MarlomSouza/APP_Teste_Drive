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
    public partial class Detalhe : ContentPage
    {

        public Veiculo Veiculo { get; set; }

        public DetalheViewModel DetalheViewModel { get; set; }
        public Detalhe(Veiculo carro)
        {
                InitializeComponent();
                DetalheViewModel = new DetalheViewModel(carro);
                this.Title = carro.Nome;

                this.BindingContext = DetalheViewModel;
            
        }



        private void botaoProximo_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Agendamento(Veiculo));
        }
    }
}
