using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace TesteDrive.Business
{
    public abstract class BaseBusiness<T>
    {
        public string URL { get; set; }
        protected HttpClient httpcliente;
        public BaseBusiness(string URL)
        {
            this.URL = URL;
            this.httpcliente = new HttpClient();
        }

        public abstract Task<HttpResponseMessage> Salvar(T t);
        public abstract Task<ObservableCollection<T>> Obter();
        public abstract void Obter(string id);
        public abstract void Excluir(string id);


    }
}
