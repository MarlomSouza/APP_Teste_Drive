using System;
using System.Collections.Generic;
using System.Text;
using TesteDrive.Model;

namespace TesteDrive.Business
{
    public class AgendamentoBusiness : BaseBusiness<Agendamento>
    {
        public AgendamentoBusiness(string URL) : base(URL)
        {
        }

        public override void Excluir(string id)
        {
            throw new NotImplementedException();
        }

        public override async void Obter()
        {
            var resultado = await httpcliente.GetStringAsync(URL);
            

        }

        public override void Obter(string id)
        {
            throw new NotImplementedException();
        }

        public override void Salvar(Agendamento t)
        {
            throw new NotImplementedException();
        }
    }
}
