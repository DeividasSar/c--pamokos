using NUnit.Framework;
using Restaurant.Common;
using Restaurant.Repositories;
using System.IO;

namespace Restaurant.Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void TestingWriteObjectToTxt()
        {
 
        //Arrange
        var tableRepository = new TableRepository();
        var obj = tableRepository.Tables;
            string expectedResult = $@"G:\.NET_mokymai\C#\Advanced_level\Egzamino_uzduotis\data\Tables.txt";

            //Act
            string actualResult = null;
            FileReaderService.WriteObjectToTxt(tableRepository.Tables, expectedResult);
            string Name = "Table";
            DirectoryInfo directory = new DirectoryInfo(@"G:\.NET_mokymai\C#\Advanced_level\Egzamino_uzduotis\data");
            FileInfo[] filesInDir = directory.GetFiles("*" + Name + "*.*");
            foreach (FileInfo foundFile in filesInDir)
            {
                actualResult = foundFile.FullName;
            }
            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}