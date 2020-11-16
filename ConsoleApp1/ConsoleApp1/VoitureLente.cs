using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class VoitureLente : Voiture
    {
        public override void Rouler()
        {
            Console.WriteLine("Je roule lentement");
        }
    }
}
