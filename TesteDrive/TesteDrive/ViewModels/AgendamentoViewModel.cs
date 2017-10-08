using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using TesteDrive.Model;
using Xamarin.Forms;

namespace TesteDrive.ViewModels
{
    public class AgendamentoViewModel : BaseViewModel
    {
        public Agendamento Agendamento { get; set; }

        private ICommand agendar;

        public ICommand Agendar
        {
            get { return agendar; }
            set { agendar = value; }
        }


        public AgendamentoViewModel(Veiculo veiculo)
        {
            Agendamento = new Agendamento();
            Agendamento.Veiculo = veiculo;

            agendar = new Command(() =>
            {
                MessagingCenter.Send<Agendamento>(Agendamento, "Agendar");
            });
        }

    }
}
