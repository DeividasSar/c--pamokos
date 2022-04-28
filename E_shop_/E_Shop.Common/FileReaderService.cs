using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace E_Shop.Common
{
    public class FileReaderService
    {
        public List <string[]> ReadFile (string filePath)
        {
            using (var reader = new StreamReader(filePath))
            {
                List<string[]> data = new List<string[]>();
                while (!reader.EndOfStream)
                {
                    var line = reader.ReadLine();
                    var values = line.Split(';');
                    data.Add(values);
                }
                return data;
            }

        }
    }
}
