using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Voiture voiturelente = new Voiture();
            VoitureRapide voitureRapide = new VoitureRapide();
            Voiture voiture = new VoitureRapide();

            voiturelente.Rouler();
            voitureRapide.Rouler();
            voiture.Rouler();

        }

       
    }
}
