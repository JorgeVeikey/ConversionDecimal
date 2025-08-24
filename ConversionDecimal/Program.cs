using System.Collections;

namespace ConversionDecimal
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                const int BASE = 2;

                Console.Write("Ingrese el numero: ");
                int num = Convert.ToInt32(Console.ReadLine());
                
                ArrayList resultado = new ArrayList();

                Console.Write($"El numero {num} en binario es: ");

                while (num > 0)
                {
                    resultado.Add(num % BASE);
                    num /= BASE;
                }

                for (int i = resultado.Count - 1; i >= 0; i--)
                {
                    Console.Write (resultado[i]);
                }
            }

            catch (Exception ex)
            {
                Console.WriteLine("Numero no valido");
            }
        }
    }
}
