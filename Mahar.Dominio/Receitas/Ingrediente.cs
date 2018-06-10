using Mahar.Dominio.Produtos;
using System;
using System.Collections.Generic;
using System.Text;

namespace Mahar.Dominio.Receitas
{
   public class Ingrediente
    {
        public Ingrediente(Produto ingrediente, double quantidade)
        {
            if (quantidade <= 0)
            {
                throw new Exception("Quantidade de ingrediente precisa ser maior que 0 ");
            }
            Ingredientes = ingrediente;
            Quantidade = quantidade;
        }

        private Produto _ingrediente ;
        private double _quantidade;

        public Produto Ingredientes { get => _ingrediente; set => _ingrediente = value; }
        public double Quantidade { get => _quantidade; set => _quantidade = value; }
    }
}
