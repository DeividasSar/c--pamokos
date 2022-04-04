using System;

namespace _7_Tema_Structs_Uni_Tests_savarankiskos_uzduotys
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 1 Uzduotis

            Mokinys mokinys = new Mokinys("Jonas", "Jonauskas", 2022-03-01, 2022-10-21);
            mokinys.ShowMokinys();

            #endregion

            #region 2 Uzduotis

            BibliotekosKnyga_2 bibliotekosKnyga_2 = new BibliotekosKnyga_2("101", "Hamletas", "Jonas", new DateTime (2022, 01, 05));
            bibliotekosKnyga_2.KiekDienuKnygaPasSkaitytoja();

            #endregion

            #region 3 Uzduotis
            Staciakampis_3 staciakampis_3_1 = new Staciakampis_3 (5, 6);
            Staciakampis_3 staciakampis_3_2 = new Staciakampis_3 (4, 9);
            Staciakampis_3 staciakampis_3_3 = new Staciakampis_3 (3, 7);

            staciakampis_3_1.Plotas();
            staciakampis_3_2.Plotas();
            staciakampis_3_3.Plotas();
            #endregion

            #region 4 Uzduotis
            //List<Studentas> StudentasList = new List<Studentas>; 

            #endregion


        }
    }
}
