namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double n1;
            Console.WriteLine("Informe um numero: ");
            n1 = Convert.ToDouble(Console.ReadLine());  

            if (n1 % 2 ==  0)
            {
                Console.WriteLine("Numero par");
            }
            else
            {
                Console.WriteLine("Numero impar");
            }
            Console.ReadLine();
        }
    }
}