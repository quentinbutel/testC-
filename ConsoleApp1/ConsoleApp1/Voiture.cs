using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Voiture
    {
        public int Vitesse { get; set; }
        public string Couleur { get; set; }
        public string toto { get; set; }
        public virtual void Rouler()
        {
            Console.WriteLine("Je roule");
        }
    }
}
