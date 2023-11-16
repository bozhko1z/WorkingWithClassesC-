namespace MastersDay
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int day = int.Parse(Console.ReadLine());
            PrintDay(day);
        }
        static void PrintDay(int day)
        {
            if (day == 1)
            {
                Console.WriteLine("Днес ще: почиваме след неделята");
                Console.WriteLine("Ще дадем 13% от себе си");
                Console.WriteLine("Ще решаваме ли задачи? ДА");
            }
            else if (day == 2)
            {
                Console.WriteLine("Днес ще: работим усилено");
                Console.WriteLine("Ще дадем 22% от себе си");
                Console.WriteLine("Ще решаваме ли задачи? ДА");
            }
            else if (day == 3)
            {
                Console.WriteLine("Днес ще: се опитаме да работим като вчера");
                Console.WriteLine("Ще дадем 26% от себе си");
                Console.WriteLine("Ще решаваме ли задачи? Нема как иначе");
            }
            else if (day == 4)
            {
                Console.WriteLine("Днес ще: работим малко по-малко от предишните дни");
                Console.WriteLine("Днес ще дадем 35% за жалост");
                Console.WriteLine("Ще решаваме ли задачи? Днеска нема");
            }
            else if (day == 5)
            {
                Console.WriteLine("Днес ще: почиваме преди почивните дни");
                Console.WriteLine("Ще дадем скромните 4% от себе си");
                Console.WriteLine("Ще решаваме ли задачи? айде и днеска нема");
            }
            else if (day == 6)
            {
                Console.WriteLine("Днес ще: спиме до късно и мързелуваме");
                Console.WriteLine("Днес ще дадем 0% от себе си :д");
                Console.WriteLine("Ще гледаме някой филм");
            }
            else if (day == 7)
            {
                Console.WriteLine("Днес ще: спим пак до късно");
                Console.WriteLine("Ще дадем пак 0%");
                Console.WriteLine("Ще се опитаме да се подготвим за утре");
            }
        }

    }
}