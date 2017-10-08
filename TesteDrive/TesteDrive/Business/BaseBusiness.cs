using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;

namespace TesteDrive.Business
{
    public abstract class BaseBusiness<T>
    {
        public string URL { get; set; }
        protected HttpClient httpcliente = new HttpClient();
        public BaseBusiness(string URL)
        {
            this.URL = URL;
        }

        public abstract void Salvar(T t);
        public abstract void Obter();
        public abstract void Obter(string id);
        public abstract void Excluir(string id);


    }
}
