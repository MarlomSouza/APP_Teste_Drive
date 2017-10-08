using System;
using System.Collections.Generic;
using System.Text;

namespace TesteDrive.Model
{
    public class Agendamento
    {
        public string Nome { get; set; }
        public string Email { get; set; }

        public string Telefone { get; set; }

        public Veiculo Veiculo { get; set; }

        private DateTime dataAgendamento = DateTime.Now;

        public DateTime DataAgendamento
        {
            get { return dataAgendamento; }
            set { dataAgendamento = value; }
        }

        private TimeSpan horaAgendamento = DateTime.Now.TimeOfDay;

        public TimeSpan HoraAgendamento
        {
            get { return horaAgendamento; }
            set { horaAgendamento = value; }
        }


    }
}
