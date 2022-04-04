using System;
using System.Collections.Generic;
using System.Text;

namespace _7_Tema_Structs_Uni_Tests_savarankiskos_uzduotys
{
    struct Studentas
    {
        public int ID { get; set; }
        public bool Iskaita { get; set; }

        public Studentas (int id, bool iskaita)
        {
            ID = id;
            Iskaita = iskaita;
        }

        public void StudentasList ()
        {
            List<Studentas> StudentasList = new List<Studentas>();
            StudentasList.Add(new Studentas(ID));

        }



    }
}
