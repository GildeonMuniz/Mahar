using Mahar.Dominio.Propriedades;
using System;
using System.Collections.Generic;
using System.Text;

namespace Mahar.Dominio.Produtos
{
    public class Produto
    {
        protected Produto() { }


        public Produto(string nome, TipoQuantidade tipoQuantidade, PropriedadeProduto tipo = PropriedadeProduto.Comprado)
        {
            _nome = nome;
            _tipo = tipo;
            TipoQuantidade = TipoQuantidade;

        }

        private long _id;
        private string _nome;
        private PropriedadeProduto _tipo;
        private TipoQuantidade _tipoQuantidade;
        private decimal _quantidadeEstoque;
        private decimal _quantidadeDisponivel;

        public virtual string Nome { get => _nome; set => _nome = value; }
        public virtual PropriedadeProduto Tipo { get => _tipo; set => _tipo = value; }
        public virtual TipoQuantidade TipoQuantidade { get => _tipoQuantidade; set => _tipoQuantidade = value; }
        public virtual Int64 Id { get => _id; protected set => _id = value; }
        public decimal QuantidadeDisponivel { get => _quantidadeDisponivel; protected set => _quantidadeDisponivel = value; }
        public decimal QuantidadeEstoque { get => _quantidadeEstoque; protected set => _quantidadeEstoque = value; }
    }
}
