namespace DiamanteLetras
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Digite uma letra: ");
            string letra = (Console.ReadLine()).ToUpper();

            string alfabeto = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            char[] alfabetoArray = alfabeto.ToCharArray();


            int indexLetra = alfabeto.IndexOf(letra);


            for (int i = 0; i <= indexLetra; i++)
            {
                Console.WriteLine("\n");
                for (int k = 0; k < indexLetra - i; k++)
                {
                    Console.Write(" ");
                }
                for (int h = 0; h < 1; h++)
                {
                    Console.Write(alfabetoArray[i]);

                    for (int k = 0; k <= 2 * i - 2; k++)
                    {
                        Console.Write(" ");
                    }

                    if (i != 0)
                    {
                        Console.WriteLine(alfabetoArray[i]);
                    }
                }

            }

            for (int i = indexLetra - 1; i >= 0; i--)
            {
                Console.WriteLine("\n");
                for (int k = 0; k < indexLetra - i; k++)
                {
                    Console.Write(" ");
                }
                for (int h = 0; h < 1; h++)
                {
                    Console.Write(alfabetoArray[i]);

                    for (int k = 0; k <= 2 * i - 2; k++)
                    {
                        Console.Write(" ");
                    }
                    if (i != 0)
                    {
                        Console.WriteLine(alfabetoArray[i]);
                    }
                }
            }
            Console.ReadLine();
        }
    }
}