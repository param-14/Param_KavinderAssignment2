﻿using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
 
namespace Assignment01.Tests
{
    public class RectangleTest
    {
        [Test]
        public void test_Using_Default_Value_Get_Legth_of_Rectagle()
        {
            //Arrange
            Rectangle rectangle = new Rectangle();

            //Act
            int lengthRectangle = 0;
            lengthRectangle = rectangle.GetLength();

            //Assert
            int expectedLengthRectangle = 1;
            //Assert.That(expectedLengthRectangle == lengthRectangle, "Consition is not match", new[] { expectedLengthRectangle, lengthRectangle });
            Assert.That(expectedLengthRectangle == lengthRectangle, "Rectagle is not matched", new[] { expectedLengthRectangle, lengthRectangle });
            //Assert.AreEqual(expectedLengthRectangle, lengthRectangle);
        }
        [Test]
        public void test_Using_Default_Value_Get_Width_of_Rectagle()
        {
            //Arrange
            Rectangle rectangle = new Rectangle();

            //Act
            int widthRectangle = 0;
            widthRectangle = rectangle.GetWidth();

            //Assert
            int expectedWidthRectangle = 1;
            Assert.AreEqual(expectedWidthRectangle, widthRectangle);
        }
        [Test]
        public void test_Using_Default_Value_Get_Area_of_Rectagle()
        {
            //Arrange
            Rectangle rectangle = new Rectangle();

            //Act
            int areaOfRectangle = 0;
            areaOfRectangle = rectangle.GetArea();

            //Assert
            int expectedAreaOfRectangle = 1;
            Assert.AreEqual(expectedAreaOfRectangle, areaOfRectangle);
        }
        [Test]
        public void test_Using_Default_Value_Get_Perimeter_of_Rectagle()
        {
            //Arrange
            Rectangle rectangle = new Rectangle();

            //Act
            int perimeterOfRectangle = 0;
            perimeterOfRectangle = rectangle.GetPerimeter();

            //Assert
            int expectedPerimeterOfRectangle = 4;
            Assert.AreEqual(expectedPerimeterOfRectangle, perimeterOfRectangle);
        }


        [Test]
        public void test_Using_Setting_Length_Get_Length_of_Rectagle()
        {
            //Arrange
            Rectangle rectangle = new Rectangle();

            //Act
            int lengthRectangle = 0;
            lengthRectangle = rectangle.SetLength(10);
            int lengthGetRectangle = 0;
            lengthGetRectangle = rectangle.GetLength();

            //Assert
            int expectedLengthRectangle = 10;
            Assert.AreEqual(expectedLengthRectangle, lengthGetRectangle);
        }
        [Test]
        public void test_Using_Setting_Length_Get_Area_of_Rectagle()
        {
            //Arrange
            Rectangle rectangle = new Rectangle();

            //Act

            int lengthRectangle = 0;
            lengthRectangle = rectangle.SetLength(10);

            int areaOfRectangle = 0;
            areaOfRectangle = rectangle.GetArea();

            //Assert
            int expectedAreaOfRectangle = 10;
            Assert.AreEqual(expectedAreaOfRectangle, areaOfRectangle);
        }
        [Test]
        public void test_Using_Setting_Length_Get_Perimeter_of_Rectagle()
        {
            //Arrange
            Rectangle rectangle = new Rectangle();

            //Act
            int lengthRectangle = 0;
            lengthRectangle = rectangle.SetLength(10);

            int perimeterOfRectangle = 0;
            perimeterOfRectangle = rectangle.GetPerimeter();

            //Assert
            int expectedPerimeterOfRectangle = 22;
            Assert.AreEqual(expectedPerimeterOfRectangle, perimeterOfRectangle);
        }
        [Test]
        public void test_Using_Setting_Width_Get_Width_of_Rectagle()
        {
            //Arrange
            Rectangle rectangle = new Rectangle();

            //Act
            int widthRectangle = 0;
            widthRectangle = rectangle.SetWidth(10);

            int widthGetRectangle = 0;
            widthGetRectangle = rectangle.GetWidth();

            //Assert
            int expectedWidthRectangle = 10;
            Assert.AreEqual(expectedWidthRectangle, widthGetRectangle);
        }
        [Test]
        public void test_Using_Setting_Width_Get_Area_of_Rectagle()
        {
            //Arrange
            Rectangle rectangle = new Rectangle();

            //Act
            int widthRectangle = 0;
            widthRectangle = rectangle.SetWidth(10);

            int areaOfRectangle = 0;
            areaOfRectangle = rectangle.GetArea();

            //Assert
            int expectedAreaOfRectangle = 10;
            Assert.AreEqual(expectedAreaOfRectangle, areaOfRectangle);
        }
        [Test]
        public void test_Using_Setting_Width_Get_Perimeter_of_Rectagle()
        {
            //Arrange
            Rectangle rectangle = new Rectangle();

            //Act
            int widthRectangle = 0;
            widthRectangle = rectangle.SetWidth(10);

            int perimeterOfRectangle = 0;
            perimeterOfRectangle = rectangle.GetPerimeter();

            //Assert
            int expectedPerimeterOfRectangle = 22;
            Assert.AreEqual(expectedPerimeterOfRectangle, perimeterOfRectangle);
        }
        [Test]
        public void test_Using_Setting_Length_Width_Get_Area_of_Rectagle()
        {
            //Arrange
            Rectangle rectangle = new Rectangle();

            //Act
            int widthRectangle = 0, lengthRectangle = 0;
            widthRectangle = rectangle.SetWidth(10);
            lengthRectangle = rectangle.SetLength(10);

            int areaOfRectangle = 0;
            areaOfRectangle = rectangle.GetArea();

            //Assert
            int expectedAreaOfRectangle = 100;
            Assert.AreEqual(expectedAreaOfRectangle, areaOfRectangle);
        }
        [Test]
        public void test_Using_Setting_Length_Width_Get_Perimeter_of_Rectagle()
        {
            //Arrange
            Rectangle rectangle = new Rectangle();

            //Act
            int widthRectangle = 0, lengthRectangle = 0;
            widthRectangle = rectangle.SetWidth(10);
            lengthRectangle = rectangle.SetLength(10);

            int perimeterOfRectangle = 0;
            perimeterOfRectangle = rectangle.GetPerimeter();

            //Assert
            int expectedPerimeterOfRectangle = 40;
            Assert.AreEqual(expectedPerimeterOfRectangle, perimeterOfRectangle);
        }
        [Test]
        public void test_Using_Setting_Max_Length_Width_Get_Area_of_Rectagle()
        {
            //Arrange
            Rectangle rectangle = new Rectangle();

            //Act
            int widthRectangle = 0, lengthRectangle = 0;
            widthRectangle = rectangle.SetWidth(4500);
            lengthRectangle = rectangle.SetLength(4500);

            int areaOfRectangle = 0;
            areaOfRectangle = rectangle.GetArea();

            //Assert
            int expectedAreaOfRectangle = 20250000;
            Assert.AreEqual(expectedAreaOfRectangle, areaOfRectangle);
        }
        [Test]
        public void test_Using_Setting_Max_Length_Width_Get_Perimeter_of_Rectagle()
        {
            //Arrange
            Rectangle rectangle = new Rectangle();

            //Act
            int widthRectangle = 0, lengthRectangle = 0;
            widthRectangle = rectangle.SetWidth(4500);
            lengthRectangle = rectangle.SetLength(4500);

            int perimeterOfRectangle = 0;
            perimeterOfRectangle = rectangle.GetPerimeter();

            //Assert
            int expectedPerimeterOfRectangle = 18000;
            Assert.AreEqual(expectedPerimeterOfRectangle, perimeterOfRectangle);
        }
        [Test]
        public void test_Using_Setting_Zero_Length_Width_Get_Area_of_Rectagle()
        {
            //Arrange
            Rectangle rectangle = new Rectangle();

            //Act
            int widthRectangle = 0, lengthRectangle = 0;
            widthRectangle = rectangle.SetWidth(0);
            lengthRectangle = rectangle.SetLength(0);

            int areaOfRectangle = 0;
            areaOfRectangle = rectangle.GetArea();

            //Assert
            int expectedAreaOfRectangle = 0;
            Assert.AreEqual(expectedAreaOfRectangle, areaOfRectangle);
        }
        [Test]
        public void test_Using_Setting_Zero_Length_Width_Get_Perimeter_of_Rectagle()
        {
            //Arrange
            Rectangle rectangle = new Rectangle();

            //Act
            int widthRectangle = 0, lengthRectangle = 0;
            widthRectangle = rectangle.SetWidth(0);
            lengthRectangle = rectangle.SetLength(0);

            int perimeterOfRectangle = 0;
            perimeterOfRectangle = rectangle.GetPerimeter();

            //Assert
            int expectedPerimeterOfRectangle = 0;
            Assert.AreEqual(expectedPerimeterOfRectangle, perimeterOfRectangle);
        }
        [Test]
        public void test_Using_Setting_Zero_Length_Get_Length_of_Rectagle()
        {
            //Arrange
            Rectangle rectangle = new Rectangle();

            //Act
            int lengthRectangle = 0;

            lengthRectangle = rectangle.SetLength(0);

            int lengthOfRectangle = 0;
            lengthOfRectangle = rectangle.GetLength();

            //Assert
            int expectedlengthOfRectangle = 0;
            Assert.AreEqual(expectedlengthOfRectangle, lengthOfRectangle);
        }
        [Test]
        public void test_Using_Setting_Zero_Width_Get_Width_of_Rectagle()
        {
            //Arrange
            Rectangle rectangle = new Rectangle();

            //Act
            int widthRectangle = 0;
            widthRectangle = rectangle.SetWidth(0);

            int WidthOfRectangle = 0;
            WidthOfRectangle = rectangle.GetWidth();

            //Assert
            int expectedWidthOfRectangle = 0;
            Assert.AreEqual(expectedWidthOfRectangle, WidthOfRectangle);
        }
    }
}