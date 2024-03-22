using System;

namespace C__HW_modul_06_ua.Task3
{
    internal class Trombone : MusicalInstrumentBase
    {
        public Trombone(string name, string characteristics) : base(name, characteristics)
        {
        }

        public override void Sound()
        {
            Console.WriteLine("Sound of trombone: brassy and bold");
        }

        public override void History()
        {
            Console.WriteLine("The trombone evolved from earlier brass instruments in the 15th century.");
        }
    }
}
