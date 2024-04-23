using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace listadecontatos
{
    internal class contato
    {
        // variáveis
        private string nome;
        private string sobrenome;
        private string telefone;

        // propriedade são os métodos "get e "set"
        // get leitura
        // definição
        // é possível ser somente leitura ou somente definição

        public string Nome
        {
            get
            {
                return nome;
            }
            set
            {
                nome = value;

            }
        }
        public string Sobrenome
        {
            get
            {
                return sobrenome;
            }
            set
            {
                sobrenome = value;
            }
        }
        public string Telefone
        {
            get
            {
                return telefone;
            }
            set
            {
                if (value.Length == 13)
                {
                    telefone = value;
                }
                else
                {
                    telefone = "00- 0000 00000";
                }
            }
        }

            public Contato()
        {
            Nome = "Claúdio";
            Sobrenome = "Genésio II";
            Telefone = "(11) 1245-35432";
        }
        //sobrecarga do metodo constutor

        }
    }
}

