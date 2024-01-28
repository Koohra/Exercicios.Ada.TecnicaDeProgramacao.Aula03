namespace ExerciciosAula3.Exercicios;

internal class Exercicio02
{
    //Escreva uma função que receba uma expressão mátemática como entrada
    //e verifique se a expressão está balanceada.
    //Uma expressão está balanceada se para cada parênteses de abertura,
    //existe um parênteses de fechamento correspondente.

    //Exemplo de expressão balanceada: (2+1)*80/(7-[√9 + {4² * 0}])
    //Exemplo de expressão não balanceada: ([{35 - 2} +5 * 3} +0 / 15) - [3 + 5³] * 11)

    public static string expressao = "([{35 - 2} +5 * 3} +0 / 15) - [3 + 5³] * 11)";
    public static bool ExpressaoBalanceada(string expressao)
    {
        Stack<char> pilha = new Stack<char>();

        foreach (char caractere in expressao)
        {
            if (caractere == '(' || caractere == '{' || caractere == '[')
            {
                pilha.Push(caractere);
            }
            else if (caractere == ')' && (pilha.Count == 0 || pilha.Pop() != '('))
            {
                return false;
            }
            else if (caractere == '}' && (pilha.Count == 0 || pilha.Pop() != '{'))
            {
                return false;
            }
            else if (caractere == ']' && (pilha.Count == 0 || pilha.Pop() != '['))
            {
                return false;
            }
        }

        return pilha.Count == 0;
    }
    public static void ExibirBalanceamentoExpressao()
    {
        bool expressaoVerificada = ExpressaoBalanceada(expressao);

        if (expressaoVerificada == true)
            Console.WriteLine("A expressão é balanceada");
        else
            Console.WriteLine("A expressão não é balanceada");
    }
}

