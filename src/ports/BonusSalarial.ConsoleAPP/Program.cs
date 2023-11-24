// See https://aka.ms/new-console-template for more information
using BonusSalarial.Core.Domain.Models;


void Init ()
{
    Console.WriteLine("******************************** FORMULÁRIO ***********************************");

    Console.Write("Vendendor: ");
    var nome = Console.ReadLine()?.ToUpper();

    Console.WriteLine("---------------------------------------");

    Console.Write("Salario: ");
    var salario = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("---------------------------------------");

    Console.Write("Vendas: ");
    var valorVenda = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("---------------------------------------");

    Console.WriteLine("*******************************************************************************");

    Console.WriteLine(" ");

    Console.WriteLine("******************************** RESULTADO ************************************");
    Vendedor vendedor = new(nome, salario, valorVenda);

    Console.WriteLine($"Vendedor: {vendedor.Nome}");
    Console.WriteLine($"Vendas: {vendedor.ValorVendas}");
    Console.WriteLine($"Comissão: {vendedor.Comissao}");
    Console.WriteLine($"Salario: {vendedor.Salario}");

    Console.WriteLine("********************************************************************************");

}

try
{
    Init();
}catch(Exception ex)
{
    Console.WriteLine(ex.Message);
}