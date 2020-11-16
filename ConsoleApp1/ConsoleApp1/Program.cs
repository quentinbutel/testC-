using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Voiture voiture1 = new Voiture();
            VoitureRapide voitureRapide = new VoitureRapide();
            
            Voiture voiture = new VoitureRapide();
            Voiture voitureLente = new VoitureLente();

            voiture1.Rouler();
            voitureRapide.Rouler();
            voiture.Rouler();
            voitureLente.Rouler();
            Console.WriteLine("Welcome on Visual Studio !");
            Console.ReadKey();
        }

       
    }
}
