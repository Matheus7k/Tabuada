internal class Program
{
    static void Tabuada(int numero)
    {
        if (numero >= 1 || numero <= 9)
        {
            for (int i = 0; i <= 10; i++)
            {
                Console.WriteLine($"{numero} x {i} = {numero * i}");
            }
        }
    }
    private static void Main(string[] args)
    {
        int numero;

        Console.Write("Informe um numero para a tabuada: ");
        numero = int.Parse(Console.ReadLine());

        Tabuada(numero);
    }
}