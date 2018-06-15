using Mahar.Dominio.Excessao;
using Mahar.Dominio.Produtos;
using System;
using System.Collections.Generic;
using System.Text;

namespace Mahar.Dominio.Estoque
{
    public class ProdutoMovimento
    {
        public ProdutoMovimento(Produto produto, Decimal quantidade, Decimal valor)
        {
            _produto = produto ?? throw new ExcecaoGeral("Produto não pode ser nullo");

            if (quantidade <=0 )
            {
                throw new ExcecaoGeral("Informe quantidade de produto");
            }

            if (valor <0 )
            {
                throw new ExcecaoGeral("Valor não pode ser negativo");
            }

            _quantidade = quantidade;
            Valor = valor;
        }

        private Produto _produto;
        private decimal _quantidade;
        private decimal _valor;

        public decimal Quantidade { get => _quantidade; protected set => _quantidade = value; }
        public Produto Produto { get => _produto; protected set => _produto = value; }
        public decimal Valor { get => _valor; protected set => _valor = value; }
    }
}
