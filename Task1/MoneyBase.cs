using System;


namespace C__HW_modul_06_ua.Task1
{
    public class MoneyBase
    {
        protected int _dollars { get; set; }
        protected int _cents { get; set; }

        public MoneyBase(int dollars, int cents)
        {
            _dollars = dollars;
            _cents = cents;
        }

        public void PrintAmount()
        {
            Console.WriteLine($"Amount: {_dollars} dollars {_cents} cents");
        }

        public void SetAmount(int dollars, int cents)
        {
            _dollars = dollars;
            _cents = cents;
        }
    }

    
}
