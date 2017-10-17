using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace TesteDrive.Model
{
    public class Veiculo
    {
        public Veiculo()
        {
            Acessorios = new HashSet<Acessorio>();
        }

        public string Nome { get; set; }

        private ICollection<Acessorio> acessorios;

        public ICollection<Acessorio> Acessorios
        {
            get { return acessorios; }
            set
            {
                acessorios = value.Where(a => a.Ativo).ToList();
                this.preco = this.acessorios.Sum(a => a.Valor);
            }
        }


        private decimal preco;
        public string Preco
        {
            get { return this.preco.ToString(); }
            set { preco = Convert.ToDecimal(value); }
        }

        public string PrecoFormatado
        {
            get { return "R$" + string.Format(this.preco.ToString("F2")); }
        }

        public decimal ValorTotal()
        {
            return acessorios.Sum(a => a.Valor);
        }

    }
}
