﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class VoitureRapide : Voiture

    {
        public new void Rouler()
        {
            Console.WriteLine("Je roule vite");
        }
    }
}
