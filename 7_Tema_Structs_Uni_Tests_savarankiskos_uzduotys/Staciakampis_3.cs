using System;
using System.Collections.Generic;
using System.Text;

namespace _7_Tema_Structs_Uni_Tests_savarankiskos_uzduotys
{
    struct Staciakampis_3
    {
        double Ilgis;
        double Plotis;

        public Staciakampis_3 (double ilgis, double plotis)
        {
            Ilgis = ilgis;
            Plotis = plotis;
        }

        public void Plotas ()
        {
            double Plotas = Ilgis * Plotis;
            Console.WriteLine($"Staciakampio plotas: {Plotas}");
        }

    }
}
