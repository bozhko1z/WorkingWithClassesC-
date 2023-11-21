namespace UsingClassesMoreThanOnce
{
    public class BankAccount
    {
        private double balance = 0;
        private int id;
        public int ID
        {
            get { return this.id; }
            set { this.id = value; }
        }
        public double Balance { get => this.balance; }
        public void Deposit(double amount)
        {
            this.balance += amount;
        }
        public void Withdraw(double amount)
        {
            this.balance -= amount;
        }

    }
}