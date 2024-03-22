using System;

namespace C__HW_modul_06_ua.Task2
{
    internal class Car : DeviceBase
    {
        public Car(string name, string characteristics) : base(name, characteristics)
        {
        }

        public override void Sound()
        {
            Console.WriteLine("Engine sound of car");
        }
    }
}
