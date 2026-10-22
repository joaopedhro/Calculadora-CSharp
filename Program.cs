using System.ComponentModel.Design;
using System.Globalization;
using System.Reflection;

Console.WriteLine("===== CALCULADORA C# ======");

int opcao = 0;

do
{
    Console.WriteLine("1 - Soma");
    Console.WriteLine("2 - Subtração");
    Console.WriteLine("3 - Divisão");
    Console.WriteLine("4 - Multiplicação");
    Console.WriteLine("5 - Sair");

    if (!int.TryParse(Console.ReadLine(), out opcao))
    {
        Console.WriteLine("Digite uma opção válida!");
        continue;
    }

    double numero1;
    double numero2;
    double resultado;
//=============================================================================================
switch (opcao)
{
    case 1:
    Console.WriteLine("Você escolheu: Somar!");

    numero1 = LerNumero();
    numero2 = LerNumero();
    resultado = Somar(numero1, numero2);
    Console.WriteLine($"Resultado: {resultado}");

    break;
//=============================================================================================
    case 2:
    Console.WriteLine("Você escolheu: Subtrair!");

    numero1 = LerNumero();
    numero2 = LerNumero();
    resultado = Subtracao(numero1, numero2);
    Console.WriteLine($"Resultado: {resultado}");


    break;
//=============================================================================================
    case 3:
    Console.WriteLine("Você escolheu: Dividir!");

    numero1 = LerNumero();
    numero2 = LerNumero();

    if(numero2 != 0)
    {
    resultado = Divisao(numero1, numero2);
    Console.WriteLine($"Resultado: {resultado}");
    } else
            {
                Console.WriteLine("Não é possível dividir por zero");
            }
    break;
//=============================================================================================
    case 4:
    Console.WriteLine("Você escolheu: Multiplicar!");

    numero1 = LerNumero();
    numero2 = LerNumero();
    resultado = Multiplicacao(numero1, numero2);
    Console.WriteLine($"Resultado: {resultado}");


    break;
//=============================================================================================
    case 5:
    Console.WriteLine("Você escolheu: Sair!");
    break;
//=============================================================================================
    default:
    Console.WriteLine("Opção inválida!");
    break;
}

if (opcao != 5)
    {
        Console.WriteLine("Pressione ENTER pra continuar.");
        Console.ReadLine();
    }

} while (opcao != 5);

static double Somar(double a, double b)
{
    return a + b;
}

static double Subtracao(double a, double b)
{
    return a - b;
}

static double Divisao(double a, double b)
{
    return a / b;
}

static double Multiplicacao(double a, double b)
{
    return a * b;
}

static double LerNumero()
{
    double numero;

    while(true)
    {
        Console.WriteLine("Digite um numero");

    if (!double.TryParse(Console.ReadLine(), out numero))
    {
        Console.WriteLine("Número digitado inválido!");
    } else
        {
            return numero;
        }

    }
}