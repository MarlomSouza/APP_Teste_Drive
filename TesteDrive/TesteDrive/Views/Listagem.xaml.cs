using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TesteDrive.Model;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TesteDrive.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Listagem : ContentPage
    {
        public List<Veiculo> Veiculos { get; set; }
        public Listagem()
        {
            InitializeComponent();
            Veiculos = new List<Veiculo>();

            this.Veiculos.Add(new Veiculo() { Nome = "Carro 1", Preco = "20" });
            this.Veiculos.Add(new Veiculo() { Nome = "Carro 2", Preco = "50" });

            this.BindingContext = this;

        }

        private void ListaNomes_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            var veiculo = e.Item as Veiculo;
            //var mensagem = string.Format("Voce selecionou o {0} no valor de {1}", veiculo.Nome, veiculo.Preco);
            //DisplayAlert("Teste Drive", mensagem, "OK", "Cancelar");

            Navigation.PushAsync(new Detalhe(veiculo), true);

        }
    }
}
