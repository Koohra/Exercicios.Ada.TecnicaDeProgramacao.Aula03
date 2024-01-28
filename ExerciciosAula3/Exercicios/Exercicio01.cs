namespace ExerciciosAula3.Exercicios;

internal class Exercicio01
{
    //Escreva uma função que receba uma lista de strings e
    //retorne uma nova lista contendo somente strings que contenham 10 ou mais caracteres.
    internal static List<string> input = new List<string>{
  "Idiossincrasia",
  "Ambivalente",
  "Quimérica",
  "Perpendicular",
  "Efêmero",
  "Pletora",
  "Obnubilado",
  "Xilografia",
  "Quixote",
  "Inefável"
    };

    public static List<string> DezOuMaisCaracteres()
    {
        List<string> output = new List<string>();

        foreach (string inputItem in input)
        {
            if (inputItem.Length >= 10)
                output.Add(inputItem);
        }
        return output;
    }
    public static void MostrarListaFiltrada()
    {
        List<string> listFiltrada = DezOuMaisCaracteres();

        Console.WriteLine("Imprimindo palavras da lista que possuem 10 ou mais caracteres:");
        foreach (string inputItem in listFiltrada)
            Console.WriteLine(inputItem);
    }
}
