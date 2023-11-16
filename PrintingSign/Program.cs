namespace PrintingSign
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            PrintSign(num);
        }
        static void PrintSign(int num)
        {
            if (num > 0)
            {
                Console.WriteLine("polojitelno");
            }
            else if (num < 0)
            {
                Console.WriteLine("otricatelno");
            }
            else
            {
                Console.WriteLine("null");
            }

        }
    }  }