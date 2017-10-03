using System;
using System.Collections.Generic;
using System.Text;

namespace TesteDrive.Model
{
    public class Acessorio
    {
        public Acessorio(string nome, decimal valor, bool ativo)
        {
            Nome = nome;
            Valor = valor;
            Ativo = ativo;
        }
        public Acessorio()
        {

        }

        public string Nome { get; set; }

        public string NomeFormatado
        {
            get
            {
                return string.Format("{0} - R${1}", this.Nome, this.Valor);
            }
        }

        public decimal Valor { get; set; }

        private bool ativo;
        public bool Ativo
        {
            get { return ativo; }
            set
            {
                if (value)
                    this.Nome = "ABS ATIVo";

                ativo = value;
            }
        }


    }
}
