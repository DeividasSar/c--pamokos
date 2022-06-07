using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Restaurant.Common
{
    public class FileReaderService
    {
        public List<string[]> ReadFile(string filePath)
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
