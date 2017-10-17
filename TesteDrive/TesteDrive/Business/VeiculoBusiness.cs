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
    public class VeiculoBusiness : BaseBusiness<Veiculo>
    {
        public VeiculoBusiness(string URL) : base(URL)
        {
        }

        public override void Excluir(string id)
        {
            throw new NotImplementedException();
        }

        public override Task<ObservableCollection<Veiculo>> Obter()
        {
            return httpcliente.GetStringAsync(URL).ContinueWith((valor) =>
            {
                return JsonConvert.DeserializeObject<ObservableCollection<Veiculo>>(valor.Result);
            });
        }

        public override void Obter(string id)
        {
            throw new NotImplementedException();
        }

        public override Task<HttpResponseMessage> Salvar(Veiculo t)
        {
            throw new NotImplementedException();
        }
    }
}
