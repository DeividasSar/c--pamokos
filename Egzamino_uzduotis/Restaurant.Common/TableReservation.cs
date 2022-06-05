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
            //string csvPath = @"G:\.NET_mokymai\C#\Advanced_level\Egzamino_uzduotis\data\Tables.csv";
            //string csvLine = $"{Number};{Seats};{FreeOrTaken}" + Environment.NewLine;
            //byte[] csvLineBytes = Encoding.Default.GetBytes(csvLine);
            //using (MemoryStream ms = new MemoryStream())
            //{
            //    ms.Write(csvLineBytes, 0, csvLineBytes.Length);
            //    using (FileStream file = new FileStream(csvPath, FileMode.Open, FileAccess.Read))
            //    {
            //        byte[] bytes = new byte[file.Length];
            //        file.Read(bytes, 0, (int)file.Length);
            //        ms.Write(bytes, 0, (int)file.Length);
            //    }
            //    using (FileStream file = new FileStream(csvPath, FileMode.Open, FileAccess.Write))
            //    {
            //        ms.WriteTo(file);
            //    }
            //}
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
