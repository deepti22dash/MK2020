using System;

namespace delegates
{
  public   class Account
    {
        public int bal = 4000;
        public string Deposit( int amt)
        {
            bal = bal + amt;
            return "amount deposited , balance is " + bal;
        }
        public string Withdrawl(int amt)
        {
            bal = bal - amt;
            return "amount withdrawl, balance is " + bal;
        }
    }
    class Program
    {
        public delegate string accountdelegates(int amt);

        static void Main(string[] args)
        {

            Console.WriteLine(" enter the amount ");
            int amount = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(" enter the Deposit or Withdraw");
            string st = Console.ReadLine();
            Account act = new Account();
            accountdelegates ad = null;
            switch (st)
            {
                case "deposit":
                    ad = new accountdelegates(act.Deposit);
                    break;
                case "withdraw":
                    ad = new accountdelegates(act.Withdrawl);
                    break;
                default:
                    Console.WriteLine(" enter valid inputs ");
                    break;
            }
            if (ad != null)
            {
                string result = ad(amount);
                Console.WriteLine(result);
            }
            Console.ReadKey();
        }                   
    }
}
