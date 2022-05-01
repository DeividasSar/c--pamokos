using System;
using System.IO;
using System.Text;

namespace E_Shop.Common
{
    public class AddCustomerToCSV
    {
        public AddCustomerToCSV()
        { }
        public void AddCustomerToCsv(string name, int orderId, int phoneNumber, string address, int itemId, string delivery, string payment, string loginName, string loginPasword)
        {
            string csvPath = @"C:\Users\Win 10\Desktop\.NET_mokymai\C#\13_tema_egzaminas\bag's\Customers.csv";
            string csvLine = $"{name};{orderId};{phoneNumber};{address};{itemId};{delivery};{payment};{loginName};{loginPasword};" + Environment.NewLine;
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
