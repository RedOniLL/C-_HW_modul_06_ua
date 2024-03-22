using System;

namespace C__HW_modul_06_ua.Task2
{
    internal class Microwave : DeviceBase
    {
        public Microwave(string name, string characteristics) : base(name, characteristics)
        {
        }

        public override void Sound()
        {
            Console.WriteLine("Beeping sound of microwave");
        }
    }
}
