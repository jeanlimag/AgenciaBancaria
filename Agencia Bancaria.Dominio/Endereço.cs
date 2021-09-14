﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agencia_Bancaria.Dominio
{
    public class Endereço
    {
        public Endereço(string logradouro, string cep, string cidade, string estado)
        {
            Logradouro = logradouro.ValidaStringVazia();
            CEP = cep.ValidaStringVazia();
            Cidade = cidade.ValidaStringVazia();
            Estado = estado.ValidaStringVazia();
        }
    
    
        public string Logradouro { get; private set; }
        public string CEP { get; private set; }
        public string Cidade { get; private set; }
        public string Estado { get; private set; }

    }
}
