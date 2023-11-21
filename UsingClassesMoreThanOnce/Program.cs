namespace UsingClassesMoreThanOnce
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int age = int.Parse(Console.ReadLine());
            string firm = Console.ReadLine();
            var person = new Employee(name, age, firm);
            person.Work();
            person.Introduce();
            person.RecieveSalary(2500);
            person.PayBills(300);
            person.Donate(200);
            person.Introduce();
            person.Sleep();

        }
    }
}
