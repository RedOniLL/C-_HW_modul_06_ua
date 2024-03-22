using System;
namespace C__HW_modul_06_ua.Task3
{
    internal class Cello : MusicalInstrumentBase
    {
        public Cello(string name, string characteristics) : base(name, characteristics)
        {
        }

        public override void Sound()
        {
            Console.WriteLine("Sound of cello: rich and deep");
        }

        public override void History()
        {
            Console.WriteLine("The cello emerged in the early 16th century as part of the violin family.");
        }
    }
}
