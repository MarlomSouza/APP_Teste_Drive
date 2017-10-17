using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using TesteDrive.Business;
using TesteDrive.Model;
using Xamarin.Forms;

namespace TesteDrive.ViewModels
{
    public class AgendamentoViewModel : BaseViewModel
    {
        private bool valido;

        public bool Valido
        {
            get { return valido; }
            set { valido = CampoObrigatoriosPreenchidos();
            }
        }


        private Agendamento agendameto;
        public Agendamento Agendamento
        {
            get { return agendameto; }
            set
            {
                agendameto = value;
                CampoObrigatoriosPreenchidos();
            }
        }

        private AgendamentoBusiness agendamentoBusiness;

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
            }, () =>
            {
                return !string.IsNullOrEmpty(Agendamento.Nome) && !string.IsNullOrEmpty(Agendamento.Email) && !string.IsNullOrEmpty(Agendamento.Telefone);
            });
        }

        //public async void SalvarAgendamento()
        //{
        //    agendamentoBusiness = new AgendamentoBusiness("http://aluracar.herokuapp.com/salvaragendamento");
        //    agendamentoBusiness.Salvar(Agendamento).ContinueWith((value) =>
        //    {
        //        if (value.Result.IsSuccessStatusCode)
        //            MessagingCenter.Send<Agendamento>(Agendamento, "SucessoAgendamento");
        //        else
        //            MessagingCenter.Send<ArgumentException>(new ArgumentException(), "FalhaAgendamento");
        //    });
        //}

        public bool CampoObrigatoriosPreenchidos()
        {
            var camposPreenchidos = !string.IsNullOrEmpty(Agendamento.Nome) && !string.IsNullOrEmpty(Agendamento.Email) && !string.IsNullOrEmpty(Agendamento.Telefone);
            if (camposPreenchidos)
            {
                OnPropertyChanged(nameof(Agendamento));
                ((Command)Agendar).ChangeCanExecute();

            }
            return camposPreenchidos;
        }

        public async void SalvarAgendamento()
        {
            agendamentoBusiness = new AgendamentoBusiness("https://aluracar.herokuapp.com/salvaragendamento");
            var value = await agendamentoBusiness.Salvar(this.Agendamento);

            if (value.IsSuccessStatusCode)
                MessagingCenter.Send<Agendamento>(this.Agendamento, "SucessoAgendamento");
            else
                MessagingCenter.Send<ArgumentException>(new ArgumentException(), "FalhaAgendamento");

        }
    }
}
