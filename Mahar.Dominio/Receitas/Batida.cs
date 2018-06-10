using Mahar.Dominio.Produtos;
using System;
using System.Collections.Generic;
using System.Text;

namespace Mahar.Dominio.Receitas
{
    public class Batida
    {


        public Batida(string nome, double pesoPronto)
        {
            if (string.IsNullOrEmpty(nome))
            {
                throw new Exception("Nome receita obrigatorio");

            }

            if (pesoPronto < 0)
            {
                throw new Exception("Peso final não pode ser negativo");

            }

            Ingredientes = new List<Ingrediente>();

            Nome = nome;
            PesoPronto = pesoPronto;
        }

        private string _nome;
        private double _pesoPronto;
        private double _pesoCru;
        private List<Ingrediente> _ingredientes;

        public string Nome { get => _nome; set => _nome = value; }
        public double PesoPronto { get => _pesoPronto; set => _pesoPronto = value; }
        public double PesoCru { get => _pesoCru; set => _pesoCru = value; }
        public List<Ingrediente> Ingredientes { get => _ingredientes; protected set => _ingredientes = value; }

        public void AdiconarIngrediente(Produto produto, double quantidade)
        {
            var ingrediente = new Ingrediente(ingrediente: produto, quantidade: quantidade);
            {
                _ingredientes.Add(ingrediente);

            }


        }
    }
}
