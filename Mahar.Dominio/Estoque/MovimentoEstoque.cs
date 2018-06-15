using Mahar.Dominio.Constantes;
using Mahar.Dominio.Excessao;
using Mahar.Dominio.Fornecedores;
using Mahar.Dominio.Produtos;
using System;
using System.Collections.Generic;
using System.Text;

namespace Mahar.Dominio.Estoque
{
    public class MovimentoEstoque
    {
        public MovimentoEstoque(TipoMovimento tipoMovimento, Fornecedor fornecedor)
        {
            TipoMovimento = tipoMovimento;
            Fornecedor = fornecedor;
            _produtos = new List<ProdutoMovimento>();
            _dataMovimento = DateTime.Now;
        }

        private TipoMovimento _tipoMovimento;
        private Fornecedor _fornecedor;
        private IList<ProdutoMovimento> _produtos;
        private DateTime _dataMovimento;


        public TipoMovimento TipoMovimento { get => _tipoMovimento; protected set => _tipoMovimento = value; }
        public Fornecedor Fornecedor { get => _fornecedor; protected set => _fornecedor = value; }
        public IList<ProdutoMovimento> Produtos { get => _produtos; protected set => _produtos = value; }
        public DateTime DataMovimento { get => _dataMovimento;protected set => _dataMovimento = value; }

        public void IncluirProduto(Produto produto, Decimal quantidade, decimal valor)
        {
            if (produto == null)
            {
                throw new ExcecaoGeral("Produto não pode ser nullo");
            }
            if (quantidade <= 0)
            {
                throw new ExcecaoGeral("Informe Quantidade");
            }

            var produtoMovimento = new ProdutoMovimento(produto: produto, quantidade: quantidade, valor: valor);

            _produtos.Add(produtoMovimento);

        }
    }
}
