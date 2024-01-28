using System.Runtime.Intrinsics.X86;

namespace ExerciciosAula3.Exercicios;

internal class Exercicio03
{
    //Escreva uma função que simule o jogo de batata quente. 
    //Nesse jogo, jogadores passam a batata quente por um círculo até ela explodir.
    //O jogador que estiver com a batata quando explodir está fora do jogo


    private Queue<int> jogadores;
    private int passesAteExplodir;

    public Exercicio03(int numJogadores)
    {
        InicializarJogadores(numJogadores);
        InicializarPassesAteExplodir();
    }

    private void InicializarJogadores(int numJogadores)
    {
        jogadores = new Queue<int>(numJogadores);

        for (int i = 1; i <= numJogadores; i++)
            jogadores.Enqueue(i);
    }

    private void InicializarPassesAteExplodir()
    {
        Random random = new Random();
        passesAteExplodir = random.Next(1, 101);
    }

    public void Jogar()
    {
        Console.WriteLine($"Iniciando o jogo de batata quente com {jogadores.Count} jogadores.");

        while (jogadores.Count > 1)
        {
            RealizarRodada();
        }

        int jogadorVencedor = jogadores.Dequeue();
        Console.WriteLine($"O jogador {jogadorVencedor} venceu o jogo de batata quente!");
    }

    private void RealizarRodada()
    {
        for (int passagem = 1; passagem <= passesAteExplodir; passagem++)
        {
            int jogadorAtual = jogadores.Dequeue();
            jogadores.Enqueue(jogadorAtual);

            Console.WriteLine($"Jogador {jogadorAtual} passa a batata para o próximo...");
            Thread.Sleep(500);
        }

        int jogadorEliminado = jogadores.Dequeue();
        Console.WriteLine($"A batata explodiu! O jogador {jogadorEliminado} está fora do jogo.");
        Thread.Sleep(1000);

        if (jogadores.Count > 1)
        {
            Console.WriteLine("Iniciando uma nova rodada...");
            Thread.Sleep(2000);
        }
    }
}
