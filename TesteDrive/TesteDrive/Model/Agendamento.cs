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
    }
}
