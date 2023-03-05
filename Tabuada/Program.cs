internal class Program
{
    private static void Main(string[] args)
    {
        int nTabuada;

        Console.WriteLine("Digite um número: ");
        if (!int.TryParse(Console.ReadLine(), out nTabuada))
        {
            Console.WriteLine("Errou");
        }
        else
        {
            if ((nTabuada < 1)|(nTabuada > 9))
            {
                Console.WriteLine("Número deve ser entre 1 e 9");
            }
            else
            {
                for (int i = 0; i <= 10; i++)
                {
                    Console.WriteLine($"{nTabuada} x {i} = {nTabuada*i}");
                }
            }
        }

    }
}