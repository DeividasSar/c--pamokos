using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Restaurant.Common
{
    public class OrderDatabase
    {
        public OrderDatabase()
        { }
        public static void AddOrder (int Id, string Name, decimal Price, int Pcs)
        {
            string table = Convert.ToString(Globals._TableNumber);
            string csvPath = @$"G:\.NET_mokymai\C#\Advanced_level\Egzamino_uzduotis\data\Tables\{table}.csv";
            string csvLine = $"{Id};{Name};{Price};{Pcs};{"Nesumoketa"}" + Environment.NewLine;
            byte[] csvLineBytes = Encoding.Default.GetBytes(csvLine);
            using (MemoryStream ms = new MemoryStream())
            {
                ms.Write(csvLineBytes, 0, csvLineBytes.Length);
                using (FileStream file = new FileStream(csvPath, FileMode.Open, FileAccess.Read))
                {
                    byte[] bytes = new byte[file.Length];
                    file.Read(bytes, 0, (int)file.Length);
                    ms.Write(bytes, 0, (int)file.Length);
                }
                using (FileStream file = new FileStream(csvPath, FileMode.Open, FileAccess.Write))
                {
                    ms.WriteTo(file);
                }
            }

        }
        public static void PayOrder(int Id, string Name, decimal Price, int Pcs)
        {
            //string table = Convert.ToString(Globals._TableNumber);
            //var path = @$"G:\.NET_mokymai\C#\Advanced_level\Egzamino_uzduotis\data\Tables\{table}.csv";
            //var allLines = File.ReadAllLines(path);
            //int line = Convert.ToInt32(Globals._TableNumber) - 1;
            //allLines[line] = $"{Id};{Name};{Price};{Pcs};{"Sumoketa"}";
            //File.WriteAllLines(path, allLines);
    }
    }    
}
