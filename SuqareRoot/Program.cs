namespace SuqareRoot
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                int num = int.Parse(Console.ReadLine());
                if (num >= 1 && num <= 1000)
                {
                    Console.WriteLine(SquareRootPr.GetSqrt(num));
                }
                else
                {
                    Console.WriteLine("slagai mejdu 1 i 1000");
                }
            }

        }
    }
}
