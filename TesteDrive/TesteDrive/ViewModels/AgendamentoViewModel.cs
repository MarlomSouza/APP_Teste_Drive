using System;
using System.Collections.Generic;
using System.Text;
using TesteDrive.Model;

namespace TesteDrive.ViewModels
{
    public class AgendamentoViewModel : BaseViewModel
    {
        public Agendamento Agendamento { get; set; }

        public AgendamentoViewModel(Veiculo veiculo)
        {
            Agendamento = new Agendamento();
            Agendamento.Veiculo = veiculo;
        }

    }
}
