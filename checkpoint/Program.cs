using System;

class Program
{
    static void Main()
    {
        int Opcao;

        do
        {
            ExibirMenu();
            Opcao = LerOpcao();

            if (Opcao >= 1 && Opcao <= 4)
            {
                double PrimeiroNumero = LerNumero("Digite o primeiro número: ");
                double SegundoNumero = LerNumero("Digite o segundo número: ");

                switch (Opcao)
                {
                    case 1:
                        Console.WriteLine($"Resultado da adição: {PrimeiroNumero + SegundoNumero}");
                        break;

                    case 2:
                        Console.WriteLine($"Resultado da subtração: {PrimeiroNumero - SegundoNumero}");
                        break;

                    case 3:
                        Console.WriteLine($"Resultado da multiplicação: {PrimeiroNumero * SegundoNumero}");
                        break;

                    case 4:
                        if (SegundoNumero == 0)
                        {
                            Console.WriteLine("Erro: divisão por zero não é permitida.");
                        }
                        else
                        {
                            Console.WriteLine($"Resultado da divisão: {PrimeiroNumero / SegundoNumero}");
                        }
                        break;
                }
            }
            else if (Opcao == 5)
            {
                Console.WriteLine("Encerrando a calculadora...");
            }
            else
            {
                Console.WriteLine("Opção inválida. Tente novamente.");
            }

            if (Opcao != 5)
            {
                Console.WriteLine("\nPressione qualquer tecla para continuar...");
                Console.ReadKey();
                Console.Clear();
            }

        } while (Opcao != 5);
    }

    static void ExibirMenu()
    {
        Console.WriteLine("Calculadora (Adição / Subtração / Multiplicação / Divisão)\n\n");
        Console.WriteLine("Escolha uma opção:");
        Console.WriteLine("1-Adição");
        Console.WriteLine("2-Subtração");
        Console.WriteLine("3-Multiplicação");
        Console.WriteLine("4-Divisão");
        Console.WriteLine("5-Sair");
    }

    static int LerOpcao()
    {
        int Opcao;

        Console.Write("Digite a opção desejada: ");

        while (!int.TryParse(Console.ReadLine(), out Opcao))
        {
            Console.Write("Entrada inválida. Digite um número de 1 a 5: ");
        }

        return Opcao;
    }

    static double LerNumero(string Mensagem)
    {
        double Numero;

        Console.Write(Mensagem);

        while (!double.TryParse(Console.ReadLine(), out Numero))
        {
            Console.Write("Valor inválido. Digite um número válido: ");
        }

        return Numero;
    }
}