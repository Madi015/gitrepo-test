namespace gitrepo_test
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Console.WriteLine("Hej och välkommen till beräkningsprogrammet.");

            int n = 2;
            int sum = 0;
            Console.WriteLine(" the squar is " + n * n);
            for (int i = 0; i < 64; i++)
            {
                n = i * i;
                sum = n * n;
                Console.WriteLine(sum);

            }

            {
                Console.WriteLine($"plus - addera två tal");
                Console.WriteLine($"minus - subtrahera två tal");
                Console.WriteLine($"gånger - multiplicera två tal");
                Console.WriteLine($"delat - dividera två tal");
                Console.WriteLine($"kvadrat - multiplicera tal med sig självt");
                Console.WriteLine($"sluta - avsluta programmet");
            }
        }
    }
}