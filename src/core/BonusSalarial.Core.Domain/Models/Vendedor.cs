using BonusSalarial.CoreShared.Exceptions;

namespace BonusSalarial.Core.Domain.Models
{
    public sealed class Vendedor
    {
        public string Nome { get; private set; }

        public decimal Salario { get; private set; }

        public decimal ValorVendas { get; private set; }

        public decimal Comissao { get; private set; }

        public Vendedor(string nome, decimal salario, decimal valorVenda)
        {
            Validate(nome, salario, valorVenda);

            Nome = nome;
            Salario = GerarComissao(valorVenda, salario);
            ValorVendas = valorVenda;
        }


        private decimal GerarComissao(decimal valorVenda, decimal salario)
        {
            Comissao = (valorVenda / 100) * 15;

            return salario + Comissao;
        }


        private static void Validate(string nome, decimal salario, decimal valorVenda)
        {
            DomainException.When(string.IsNullOrEmpty(nome), "Campo nome é obrigatório!");
            DomainException.When(salario <= 0, "Campo salario não pode er menor ou igual a 0!");
            DomainException.When(valorVenda < 0, "Campo valor de venda não pode ser negativo!");
        }
    }
}
