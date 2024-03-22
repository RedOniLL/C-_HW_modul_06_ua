using System;


namespace C__HW_modul_06_ua.Task1
{
    public class Product : MoneyBase
    {
        public Product(int dollars, int cents) : base(dollars, cents)
        {
        }

        public void DecreasePrice(int decreaseAmountDollars, int decreaseAmountCents)
        {
            int newDollars = _dollars - decreaseAmountDollars;
            int newCents = _cents - decreaseAmountCents;

            if (newCents < 0)
            {
                newDollars--;
                newCents += 100;
            }

            if (newDollars < 0)
            {
                Console.WriteLine("Price cannot be negative.");
            }
            else
            {
                Console.WriteLine($"New price: {newDollars} dollars {newCents} cents");
            }
        }
    }
}
