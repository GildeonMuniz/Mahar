using Mahar.Dominio.Constantes;
using Mahar.Dominio.Excessao;
using System;
using System.Collections.Generic;
using System.Text;

namespace Mahar.Dominio.Estoque
{
    public class TipoMovimento
    {
        public TipoMovimento(string descricao, string naturezaOperacao, string entradaSaida, string atualizaEstoque, bool venda = false)
        {

            if (string.IsNullOrEmpty(descricao))
            {
                throw new ExcecaoGeral(("Informe descricao  do tipo de movimento");
            }

            if (naturezaOperacao != Constante.Efetiva)
            {
                throw new ExcecaoGeral("Informe (E)fetiva ou (R)eservada  para natureza operação.");
            }

            if (!string.IsNullOrEmpty(atualizaEstoque))
            {
                if (atualizaEstoque != "N" & atualizaEstoque != "S")

                    throw new ExcecaoGeral("Informe (S)im ou (N)ao para definir ação da entrada.");

            }
            _descricao = descricao;
            _tipoentradasaida = entradaSaida;
            _atualizaestoque = atualizaEstoque;
            _naturezaoperacao = naturezaOperacao;
            _venda = venda;


        }
        private string _naturezaoperacao;
        private string _descricao;
        private string _tipoentradasaida;
        private string _atualizaestoque;
         
        private bool _venda;
    }
}
