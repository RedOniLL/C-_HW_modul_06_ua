using System;

namespace C__HW_modul_06_ua.Task3
{
    internal class Ukulele : MusicalInstrumentBase
    {
        public Ukulele(string name, string characteristics) : base(name, characteristics)
        {
        }

        public override void Sound()
        {
            Console.WriteLine("Sound of ukulele: cheerful and bright");
        }

        public override void History()
        {
            Console.WriteLine("The ukulele originated in the 19th century as a Hawaiian adaptation of the Portuguese machete.");
        }
    }
}
