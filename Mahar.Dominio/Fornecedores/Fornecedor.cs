using System;
using System.Collections.Generic;
using System.Text;

namespace Mahar.Dominio.Fornecedores
{
   public class Fornecedor
    {
        public Fornecedor(string nome)
        {
            Nome = nome;
        }

        private string _nome;

        public string Nome { get => _nome; set => _nome = value; }
    }
}
