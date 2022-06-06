using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Restaurant.Common
{
    public class TableReservation
    {
        public TableReservation()
        { }
        public static void TableReservations(decimal Number, decimal Seats, string FreeOrTaken)
        {
            var path = @"G:\.NET_mokymai\C#\Advanced_level\Egzamino_uzduotis\data\Tables.csv";
            var allLines = File.ReadAllLines(path);
            int line = Convert.ToInt32(Globals._TableNumber)-1;
            allLines[line] = $"{Number};{Seats};{FreeOrTaken}";
            File.WriteAllLines(path, allLines);

        }
        public static void WriteObjectToTxt(object obj, string path)
        {
            var json = JsonConvert.SerializeObject(obj, Formatting.Indented);

            using (var sw = new StreamWriter(path))
            {
                sw.Write(json);
            }
        }


    }
}
