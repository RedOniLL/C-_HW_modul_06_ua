using System;

namespace C__HW_modul_06_ua.Task2
{
    internal class Steamboat : DeviceBase
    {
        public Steamboat(string name, string characteristics) : base(name, characteristics)
        {
        }

        public override void Sound()
        {
            Console.WriteLine("Steam whistle sound of steamboat");
        }
    }
}
