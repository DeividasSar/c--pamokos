using E_Shop.BusinessLogic;
using E_Shop.Common;
using E_Shop.Repositories;
using E_Shop.Repositories.Entities;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.IO;

namespace E_Shop.Test
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
            var bagRepository = new BagRepository();
            var obj = bagRepository.Bags;
            string expectedResult = @"C:\Users\Win 10\Desktop\.NET_mokymai\C#\13_tema_egzaminas\bag's\Bags_TEST.txt";

            //Act
            string actualResult=null;
            AddBagToCSV.WriteObjectToTxt(bagRepository.Bags, expectedResult);
            string Name = "Bags_TEST";
            DirectoryInfo directory = new DirectoryInfo(@"C:\Users\Win 10\Desktop\.NET_mokymai\C#\13_tema_egzaminas\bag's");
            FileInfo[] filesInDir = directory.GetFiles("*" + Name + "*.*");
            foreach (FileInfo foundFile in filesInDir)
            {
                actualResult = foundFile.FullName;
            }
            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }
        [Test]
        public void TestingFindExistingCustomerLogin()
        {
            //Arrange
            string name = "Petras";
            string expectedResult = "Petras"; //nes vardas ir Login name vienodi

            //Act
            string actualResult = LoginToExistingAcount.FindExistingCustomerLogin(name);

            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }


    }

}