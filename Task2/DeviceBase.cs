using System;

namespace C__HW_modul_06_ua.Task2
{
    internal class DeviceBase
    {
        protected string _name;
        protected string _characteristics;

        public DeviceBase(string name, string characteristics)
        {
            this._name = name;
            this._characteristics = characteristics;
        }

        public virtual void Sound()
        {
            Console.WriteLine($"Default sound of {_name}");
        }

        public void Show()
        {
            Console.WriteLine($"Name: {_name}");
        }

        public void Desc()
        {
            Console.WriteLine($"Description: {_characteristics}");
        }
    }
}
