using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Assignment_2;
using NUnit.Framework;


namespace TestCase
{
    [TestFixture]
    public class TriangleTestCases
    {
        [Test]
        public void Analyze_IfTriangleIsValidAndThreeSidesEqual3_TriangleIsEquilateral()
        {
            //Arrange
            int n1 = 3;
            int n2 = 3;
            int n3 = 3;
            string answer = "The Triangle is Equilateral";
            TriangleSolver t = new TriangleSolver();

            //Act
            string result = t.Analyze(n1, n2, n3);

            //Assert
            Assert.AreEqual(result, answer);
        }

        [Test]

        public void Analyze_IfTriangleIsValidAndInputIs12and12and13_TriangleIsIsosceles()
        {
            //Arrange
            int n1 = 12;
            int n2 = 12;
            int n3 = 13;
            string answer = "The Triangle is Isosceles";

            TriangleSolver t = new TriangleSolver();

            //Act
            string result = t.Analyze(n1, n2, n3);

            //Assert
            Assert.AreEqual(result, answer);

        }

        [Test]
        public void Analyze_IfTriangleIsValidAndInputIs12and13and14_TriangleIsScalene()
        {
            //Arrange
            int n1 = 12;
            int n2 = 13;
            int n3 = 14;
            string answer = "The Triangle is Scalene";

            TriangleSolver t = new TriangleSolver();

            //Act
            string result = t.Analyze(n1, n2, n3);

            //Assert
            Assert.AreEqual(result, answer);

        }

        [Test]
        public void Analyze_IfAllValuesIsnegative_ThrowsError()
        {
            int n1 = -12;
            int n2 = -12;
            int n3 = -15;
            string answer = "error";

            TriangleSolver t = new TriangleSolver();

            //Act
            string result = t.Analyze(n1, n2, n3);

            //Assert
            Assert.AreEqual(result, answer);
        }

        [Test]
        public void Analyze_IfOneOfTheThreeValuesIsnegative_ThrowsError()
        {
            int n1 = 12;
            int n2 = 12;
            int n3 = -15;
            string answer = "error";

            TriangleSolver t = new TriangleSolver();

            //Act
            string result = t.Analyze(n1, n2, n3);

            //Assert
            Assert.AreEqual(result, answer);
        }

        [Test]
        public void Analyze_IfDoesNotFormATriangleAndValuesInput1and2and3_ThrowsErrorInvalidInput()
        {
            int n1 = 1;
            int n2 = 2;
            int n3 = 3;
            string answer = "error";

            TriangleSolver t = new TriangleSolver();

            //Act
            string result = t.Analyze(n1, n2, n3);

            //Assert
            Assert.AreEqual(result, answer);
        }
        [Test]
        public void Analyze_InputsTwoValues2and3and0_ThrowsError()
        {
            int n1 = 11;
            int n2 = 12;
            int n3 = 0;

            string answer = "error";
            TriangleSolver t = new TriangleSolver();

            //Act
            string result = t.Analyze(n1, n2, n3);

            //Assert
            Assert.AreEqual(result, answer);

        }

        [Test]
        public void Analyze_Inputs0and0and0_ThrowsError()
        {
            int n1 = 0;
            int n2 = 0;
            int n3 = 0;

            string answer = "error";
            TriangleSolver t = new TriangleSolver();

            //Act
            string result = t.Analyze(n1, n2, n3);

            //Assert
            Assert.AreEqual(result, answer);

        }

    }
}


