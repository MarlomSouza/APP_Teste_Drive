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
    public partial class Agendamento : ContentPage
    {
        public Veiculo Veiculo { get; private set; }
        public Agendamento(Veiculo veiculo)
        {
            InitializeComponent();
            this.Veiculo = veiculo;
            this.BindingContext = this;
        }


    }
}
