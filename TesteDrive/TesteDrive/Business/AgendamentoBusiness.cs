using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
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

        public override Task<ObservableCollection<Agendamento>> Obter()
        {
            throw new NotImplementedException();
        }

        public override void Obter(string id)
        {
            throw new NotImplementedException();
        }

        public override Task<HttpResponseMessage> Salvar(Agendamento agendamento)
        {
            var content = new StringContent(SerializarAgendamento(agendamento), Encoding.UTF8, "application/json");
            return httpcliente.PostAsync(URL, content);
        }

        private string SerializarAgendamento(Agendamento agendamento)
        {
            var data = agendamento.DataAgendamento;
            var hora = agendamento.HoraAgendamento;
            var dataAgendamento = new DateTime(data.Year, data.Month, data.Day, hora.Hours, hora.Minutes, hora.Seconds);

  
            var json = JsonConvert.SerializeObject(new
            {
                nome = agendamento.Nome,
                fone = agendamento.Telefone,
                email = agendamento.Email,
                carro = agendamento.Veiculo.Nome,
                preco = agendamento.Veiculo.Preco,
                dataAgendamento = dataAgendamento
            });

            return json;
        }
    }
}
