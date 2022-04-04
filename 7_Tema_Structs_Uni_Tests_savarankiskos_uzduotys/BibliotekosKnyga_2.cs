using System;
using System.Collections.Generic;
using System.Text;

namespace _7_Tema_Structs_Uni_Tests_savarankiskos_uzduotys
{
    struct BibliotekosKnyga_2
    {
        public string ID;
        public string Pavadinimas;
        public string SkaitytojoVardas;
        public DateTime PaemimoData;

        public BibliotekosKnyga_2 (string id, string pavadinimas, string skaitytojoVardas, DateTime paemimoData)
        {
            ID = id;
            Pavadinimas = pavadinimas;
            SkaitytojoVardas = skaitytojoVardas;
            PaemimoData = paemimoData;

        }

        public void KiekDienuKnygaPasSkaitytoja()
        {
            Console.WriteLine($"Knyga {Pavadinimas}, kurios ID {ID} yra {DateTime.Today - PaemimoData} dienu pas skaitytoja {SkaitytojoVardas}");
        }

    }
}
