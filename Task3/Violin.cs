using System;

namespace C__HW_modul_06_ua.Task3
{
    internal class Violin : MusicalInstrumentBase
    {
        public Violin(string name, string characteristics) : base(name, characteristics)
        {
        }

        public override void Sound()
        {
            Console.WriteLine("Sound of violin: screeching");
        }

        public override void History()
        {
            Console.WriteLine("Violin has a long history dating back to the 16th century.");
        }
    }
}
