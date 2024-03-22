using System;


namespace C__HW_modul_06_ua.Task3
{
    internal class MusicalInstrumentBase
    {
        protected string name;
        protected string characteristics;

        public MusicalInstrumentBase(string name, string characteristics)
        {
            this.name = name;
            this.characteristics = characteristics;
        }

        public virtual void Sound()
        {
            Console.WriteLine($"Default sound of {name}");
        }

        public void Show()
        {
            Console.WriteLine($"Name: {name}");
        }

        public void Desc()
        {
            Console.WriteLine($"Description: {characteristics}");
        }

        public virtual void History()
        {
            Console.WriteLine($"{name} has a rich history.");
        }
    }
}
