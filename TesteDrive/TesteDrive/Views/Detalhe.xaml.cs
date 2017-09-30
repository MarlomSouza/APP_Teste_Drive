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
    public partial class Detalhe : ContentPage
    {
        public Carro Veiculo { get; set; }
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
        public Detalhe(Carro carro)
        {
            InitializeComponent();
            this.Veiculo = carro;

            CriarObjetos();
            this.Title = carro.Nome;

            this.BindingContext = this;
        }

        private void CriarObjetos()
        {
            this.ABS = new Acessorio("ABS", 100, true);
            this.SOM = new Acessorio("SOM", 100, true);
            this.Kilometragem = new Acessorio("Ilimitada", 100, false);
        }

        private void botaoProximo_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Agendamento(Veiculo));
        }
    }
}
