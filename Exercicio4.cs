// -- Arquivo Exercicio4.cs 
public static class Exercicio4
{
    public static void Executar()
    {
        string nome = "";
        int idade = 0;
        string hobby1 = "";
        string hobby2 = "";
        string graduacao = "";
        Console.Clear();
        Console.Write("Digite o seu nome:");
        nome = Console.ReadLine()!;

        Console.Write("Digite a sua idade");
        idade = int.Parse(Console.ReadLine()!);

        Console.Write("Digite o seu hobby1:");
        hobby1 = Console.ReadLine()!;

        Console.Write("Digite o seu hobby2:");
        hobby2 = Console.ReadLine()!;

        Console.Write("Digite a sua graduacao:");
        graduacao = Console.ReadLine()!;
    }
}