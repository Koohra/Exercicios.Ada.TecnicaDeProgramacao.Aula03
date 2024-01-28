using ExerciciosAula3.Exercicios;

while (true)
{
    MostrarMenu();

    if (int.TryParse(Console.ReadLine(), out int escolha))
    {
        switch (escolha)
        {
            case 1 when ExecutarExercicio(() => Exercicio01.MostrarListaFiltrada()):
            case 2 when ExecutarExercicio(() => Exercicio02.ExibirBalanceamentoExpressao()):
            case 3 when ExecutarExercicio(() => { var jogo = new Exercicio03(5); jogo.Jogar(); }):
            case 4 when ExecutarExercicio(() => Exercicio04.ExibirContagemPalavras(Exercicio04.ContarPalavras())):
            case 0:
                Console.WriteLine("Saindo do programa. Até logo!");
                return;

            default:
                Console.WriteLine("Opção inválida. Tente novamente.");
                break;
        }
    }
    else
        Console.WriteLine("Digite um número válido.");

    Console.WriteLine();
}

static bool ExecutarExercicio(Action action)
{
    action.Invoke();
    return true;
}

static void MostrarMenu()
{
    Console.WriteLine("Escolha um exercício:");
    Console.WriteLine("1. Exercicio 01");
    Console.WriteLine("2. Exercicio 02");
    Console.WriteLine("3. Exercício 03");
    Console.WriteLine("4. Exercício 04");
    Console.WriteLine("0. Sair");
}