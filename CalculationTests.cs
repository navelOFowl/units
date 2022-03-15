using Microsoft.VisualStudio.TestTools.UnitTesting;
using WSUniversalLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WSUniversalLib.Tests
{
    [TestClass()]
    public class CalculationTests
    {
        [TestMethod()]
        public void GetQuant_Pord3Mat1_Return114148()
        {
            //Arrange
            int productType = 3, materialType = 1, count = 15, expected = 114148;
            float width = 20, length = 45;

            //Act
            int actual = Calculation.GetQuantityForProduct(productType, materialType, count, width, length);

            //Assert
            Assert.AreEqual(expected, actual);

        }

        [TestMethod()]
        public void GetQuant_Pord1Mat1_Return1655()
        {
            //Arrange
            int productType = 1, materialType = 1, count = 10, expected = 1655;
            float width = 10, length = 15;

            //Act
            int actual = Calculation.GetQuantityForProduct(productType, materialType, count, width, length);

            //Assert
            Assert.AreEqual(expected, actual);

        }

        [TestMethod()]
        public void GetQuant_Pord2Mat1_Return4702()
        {
            //Arrange
            int productType = 2, materialType = 1, count = 25, expected = 4702;
            float width = 5, length = 15;

            //Act
            int actual = Calculation.GetQuantityForProduct(productType, materialType, count, width, length);

            //Assert
            Assert.AreEqual(expected, actual);

        }

        [TestMethod()]
        public void GetQuant_Pord1Mat2_Return375()
        {
            //Arrange
            int productType = 1, materialType = 2, count = 7, expected = 375;
            float width = 6, length = 8;

            //Act
            int actual = Calculation.GetQuantityForProduct(productType, materialType, count, width, length);

            //Assert
            Assert.AreEqual(expected, actual);

        }

        [TestMethod()]
        public void GetQuant_Pord2Mat2_Return608()
        {
            //Arrange
            int productType = 2, materialType = 2, count = 3, expected = 608;
            float width = 10, length = 8;

            //Act
            int actual = Calculation.GetQuantityForProduct(productType, materialType, count, width, length);

            //Assert
            Assert.AreEqual(expected, actual);

        }

        [TestMethod()]
        public void GetQuant_Pord3Mat2_Return5632()
        {
            //Arrange
            int productType = 3, materialType = 2, count = 11, expected = 5632;
            float width = 3, length = 20;

            //Act
            int actual = Calculation.GetQuantityForProduct(productType, materialType, count, width, length);

            //Assert
            Assert.AreEqual(expected, actual);

        }

        [TestMethod()]
        public void GetQuant_Rand1_Return398()
        {
            //Arrange
            int productType = 1, materialType = 1, count = 15, expected = 398;
            float width = 8, length = 3;

            //Act
            int actual = Calculation.GetQuantityForProduct(productType, materialType, count, width, length);

            //Assert
            Assert.AreEqual(expected, actual);

        }

        [TestMethod()]
        public void GetQuant_Rand2_Return161()
        {
            //Arrange
            int productType = 1, materialType = 2, count = 8, expected = 161;
            float width = 9, length = 2;

            //Act
            int actual = Calculation.GetQuantityForProduct(productType, materialType, count, width, length);

            //Assert
            Assert.AreEqual(expected, actual);

        }

        [TestMethod()]
        public void GetQuant_Rand3_Return2809()
        {
            //Arrange
            int productType = 2, materialType = 1, count = 14, expected = 2809;
            float width = 10, length = 8;

            //Act
            int actual = Calculation.GetQuantityForProduct(productType, materialType, count, width, length);

            //Assert
            Assert.AreEqual(expected, actual);

        }

        [TestMethod()]
        public void GetQuant_Rand4_Return2345()
        {
            //Arrange
            int productType = 1, materialType = 2, count = 13, expected = 2345;
            float width = 27, length = 6;

            //Act
            int actual = Calculation.GetQuantityForProduct(productType, materialType, count, width, length);

            //Assert
            Assert.AreEqual(expected, actual);

        }

        [TestMethod()]
        public void GetQuant_HardBignumbers1_Return834103()
        {
            //Arrange
            int productType = 1, materialType = 1, count = 420, expected = 834103;
            float width = 60, length = 30;

            //Act
            int actual = Calculation.GetQuantityForProduct(productType, materialType, count, width, length);

            //Assert
            Assert.AreEqual(expected, actual);

        }

        [TestMethod()]
        public void GetQuant_HardBignumbers2_Return206595()
        {
            //Arrange
            int productType = 2, materialType = 1, count = 535, expected = 206595;
            float width = 77, length = 2;

            //Act
            int actual = Calculation.GetQuantityForProduct(productType, materialType, count, width, length);

            //Assert
            Assert.AreEqual(expected, actual);

        }

        [TestMethod()]
        public void GetQuant_HardBelowZero1_ReturnError()
        {
            //Arrange
            int productType = 1, materialType = 1, count = -8, expected = -1;
            float width = 5, length = -2;

            //Act
            int actual = Calculation.GetQuantityForProduct(productType, materialType, count, width, length);

            //Assert
            Assert.AreEqual(expected, actual);

        }

        [TestMethod()]
        public void GetQuant_HardBelowZero2_ReturnError()
        {
            //Arrange
            int productType = 2, materialType = 2, count = -5, expected = -1;
            float width = -5, length = 0;

            //Act
            int actual = Calculation.GetQuantityForProduct(productType, materialType, count, width, length);

            //Assert
            Assert.AreEqual(expected, actual);

        }

        [TestMethod()]
        public void GetQuant_HardMoreDecimal_Return1810()
        {
            //Arrange
            int productType = 1, materialType = 2, count = 30, expected = 1810;
            float width = 8.5382F, length = 6.3460F;

            //Act
            int actual = Calculation.GetQuantityForProduct(productType, materialType, count, width, length);

            //Assert
            Assert.AreEqual(expected, actual);

        }
    }
}