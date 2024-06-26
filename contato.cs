﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace listadecontatos
{
    internal class Contato
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
                if (value.Length == 11)
                {
                    telefone = value;
                }
                else
                {
                    telefone = "(00) 00000-0000";
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
        public Contato(string nome, string sobrenome, string telefone)
        {
            Nome = nome;
            Sobrenome = sobrenome;
            Telefone = telefone;
        }

        //ToString() pertence a classse object
        // todas as classes são filhas de object(herança)
        // "override" sobreescreve o método da classe pai
        public override string ToString()
        {
            //inicializa a variável como vazia.
            string saida = string.Empty;
            saida += string.Format("{0} {1}", Nome, Sobrenome);
            saida += string.Format("({0}) {1}-{2}",
                Telefone.Substring(0, 2),
                Telefone.Substring(2, 5),
                Telefone.Substring(7, 4));
            return saida;
        }

    }
    }



