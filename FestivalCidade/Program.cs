using FestivalCidade;

class Program
{

    static void Main(string[] args)
    {
        Ingresso ingresso = new Ingresso();

        Console.Write("Digite o Nome do Fã: ");
        ingresso.NomeFa = Console.ReadLine();

        Console.Write("Digite a Quantidade de Dias de Show: ");
        ingresso.DiasShow = int.Parse(Console.ReadLine());

        Console.Write("Digite o Cupom de Desconto: ");
        ingresso.Cupom = Console.ReadLine();

        Console.Write("Digite a Pontuação do Clube de Fidelidade: ");
        ingresso.PontosFidelidade = int.Parse(Console.ReadLine());

        Console.WriteLine("\n--- Resumo do Checkout ---");
        Console.WriteLine($"Fã: {ingresso.NomeFa.ToUpper()}");
        Console.WriteLine($"Valor Bruto: {ingresso.CalcularCustoBruto():C2}");
        Console.WriteLine($"Valor Final a ser cobrado: {ingresso.CalcularValorFinal():C2}");
        Console.WriteLine($"Acesso ao Lounge VIP: {ingresso.VerificarAcessoVip()}");

        Console.ReadKey();
    }
}