double valorEmprestimo;
double rendaMensal;
double limiteEmprestimo;
int quantidadeParcelas;

Console.Clear();

Console.WriteLine("Digite o valor do empréstimo desejado: ");
valorEmprestimo = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Digite em quantas parcelas serão pagas: ");
quantidadeParcelas = Convert.ToInt16(Console.ReadLine());

Console.WriteLine("Digite o valor da renda mensal comprovada: ");
rendaMensal = Convert.ToDouble(Console.ReadLine());

limiteEmprestimo = rendaMensal * 0.3;

if (valorEmprestimo > limiteEmprestimo)
{
    Console.WriteLine("O empréstimo não poderá ser realizado!");
    return;
}
else
{
    Console.Clear();
    Console.WriteLine("O empréstimo foi autorizado!");

    Console.WriteLine($"Valor da renda mensal: {rendaMensal:C2}");
    Console.WriteLine($"Valor do empréstimo solicitado: {valorEmprestimo:C2}");
    Console.WriteLine($"Quantidade de parcelas: {quantidadeParcelas}");
}
