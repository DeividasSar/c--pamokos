using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace E_Shop.Common
{
    public class AddBagToCSV
    {
        public AddBagToCSV()
        { }
        public void AddBagToCsv(string name, int itemId, string color, string Type, int price, string material, string whom, int inStock)
        {
            string csvPath = @"C:\Users\Win 10\Desktop\.NET_mokymai\C#\13_tema_egzaminas\bag's\Bags.csv";
            string csvLine = $"{name};{itemId};{color};{Type};{price};{material};{whom};{inStock}" + Environment.NewLine;
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
    }
}
