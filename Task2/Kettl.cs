using System;

namespace C__HW_modul_06_ua.Task2
{
    internal class Kettle : DeviceBase
    {
        public Kettle(string name, string characteristics) : base(name, characteristics)
        {
        }

        public override void Sound()
        {
            Console.WriteLine("Whistling sound of kettle");
        }
    }
}
