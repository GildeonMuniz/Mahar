using Mahar.Dominio.Propriedades;
using System;
using System.Collections.Generic;
using System.Text;

namespace Mahar.Dominio.Produtos
{
    public class Produto
    {
        public Produto(string nome, TipoQuantidade tipoQuantidade, PropriedadeProduto tipo = PropriedadeProduto.Comprado)
        {
            _nome = nome;
            _tipo = tipo;
            TipoQuantidade = TipoQuantidade;
        }

        private string _nome;
        private PropriedadeProduto _tipo;
        private TipoQuantidade _tipoQuantidade;

        public string Nome { get => _nome; set => _nome = value; }
        public PropriedadeProduto Tipo { get => _tipo; set => _tipo = value; }
        public TipoQuantidade TipoQuantidade { get => _tipoQuantidade; set => _tipoQuantidade = value; }
    }
}
