using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using hinaliA2QA;
using NUnit.Framework;

namespace Assignment2Tests
{
    [TestFixture]
     class Assignment2Tests
    {      
        [Test]
        public void check_forinput1_1_3expectedResultEqualsIsosceles()
        {
            //Arrange
            int int1 = 1;
            int int2 = 1;
            int int3 = 3;
            string expectedResult = "Isosceles";

            TriangleSolver t = new hinaliA2QA.TriangleSolver();

            //Act
            string result = t.Analyze(int1, int2, int3);

            //Assert
            Assert.AreEqual(result, expectedResult);
        }

        public void check_forinput5_5_5expectedResultEqualsEquilateral()
        {
            //Arrange
            int int1 = 5;
            int int2 = 5;
            int int3 = 5;
            string expectedResult = "Equilateral";

            TriangleSolver t = new hinaliA2QA.TriangleSolver();

            //Act
            string result = t.Analyze(int1, int2, int3);

            //Assert
            Assert.AreEqual(result, expectedResult);
        }
        public void check_forinput1_2_3expectedResultEqualsScalene()
        {
            //Arrange
            int int1 = 1;
            int int2 = 2;
            int int3 = 3;
            string expectedResult = "Scalene";

            TriangleSolver t = new hinaliA2QA.TriangleSolver();

            //Act
            string result = t.Analyze(int1, int2, int3);

            //Assert
            Assert.AreEqual(result, expectedResult);
        }
        public void check_forinput4_7_4expectedResultEqualsIsosceles()
        {
            //Arrange
            int int1 = 4;
            int int2 = 7;
            int int3 = 4;
            string expectedResult = "Isosceles";

            TriangleSolver t = new hinaliA2QA.TriangleSolver();

            //Act
            string result = t.Analyze(int1, int2, int3);

            //Assert
            Assert.AreEqual(result, expectedResult);
        }

        public void check_forinput2_2_2expectedResultEqualsEquilateral()
        {
            //Arrange
            int int1 = 2;
            int int2 = 2;
            int int3 = 2;
            string expectedResult = "Equilateral";

            TriangleSolver t = new hinaliA2QA.TriangleSolver();

            //Act
            string result = t.Analyze(int1, int2, int3);

            //Assert
            Assert.AreEqual(result, expectedResult);
        }
        public void check_forinput7_4_3expectedResultEqualsScalene()
        {
            //Arrange
            int int1 = 7;
            int int2 = 4;
            int int3 = 3;
            string expectedResult = "Scalene";

            TriangleSolver t = new hinaliA2QA.TriangleSolver();

            //Act
            string result = t.Analyze(int1, int2, int3);

            //Assert
            Assert.AreEqual(result, expectedResult);
        }
        public void check_forinput8_8_8expectedResultEqualsEquilateral()
        {
            //Arrange
            int int1 = 8;
            int int2 = 8;
            int int3 = 8;
            string expectedResult = "Equilateral";

            TriangleSolver t = new hinaliA2QA.TriangleSolver();

            //Act
            string result = t.Analyze(int1, int2, int3);

            //Assert
            Assert.AreEqual(result, expectedResult);
        }
        public void check_forinput9_3_2expectedResultEqualsScalene()
        {
            //Arrange
            int int1 = 9;
            int int2 = 3;
            int int3 = 2;
            string expectedResult = "Scalene";

            TriangleSolver t = new hinaliA2QA.TriangleSolver();

            //Act
            string result = t.Analyze(int1, int2, int3);

            //Assert
            Assert.AreEqual(result, expectedResult);
        }


    }
}
