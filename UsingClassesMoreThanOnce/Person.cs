using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsingClassesMoreThanOnce
{
    public class Person
    {
        private string name;
        private int age;

        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }
        public int Age
        {
            get { return this.age; }
            set { this.age = value; }
        }
        public Person(string name, int age)
        {
            this.name = name;
            this.age = age;
        }
        public void Sleep()
        {
            Console.WriteLine($"{Name} is sleeping {Age} years");
        }
    }
    delegate void MoneyOperation(double amount);
    class Employee : Person
    {
        private BankAccount account;
        public MoneyOperation RecieveSalary;
        public MoneyOperation PayBills;
        public MoneyOperation Donate;
        public string organization;
        public string Organization
        {
            get { return this.organization; }
            set { this.organization = value; }
        }
        public void Work()
        {
            Console.WriteLine($"{Name} is working in {Organization}");
        }

        private BankAccount Account
        {
            get { return this.account; }
            set { this.account = value; }
        }
        public Employee(string name, int age, string organization)
            : base(name, age)
        {
            this.Organization = organization;
            this.account = new BankAccount();
            this.RecieveSalary = account.Deposit;
            this.PayBills = account.Withdraw;
            this.Donate = account.Withdraw;
        }
        public void Introduce()
        {
            Console.WriteLine($"{Name} is {Age} years old and is working in {Organization} with {Account.Balance} in cash");
        }



    }

}

