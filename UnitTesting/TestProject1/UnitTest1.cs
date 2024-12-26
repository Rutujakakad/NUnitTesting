using NUnit.Framework;

namespace UnitTesting

{
    public class Tests
    {
        private NUnitTesting demo;
        [SetUp]
        public void Setup()
        {
            demo  = new NUnitTesting();
        }

        [Test]
        public void AddMethodShouldReturnInt()
        {
            //arrange
            int a = 4;
            int b = 5;

            //act
            int result = demo.Add(a, b);

            //Assert
            Assert.AreEqual(9, result);
        }
        public void IsEvenReturnBoolValue()
        {
            //arrange
            int num = 4;

            //act
            bool result = demo.IsEven(num);

            //assert
            Assert.AreEqual(true, result);
        }

       // [DataRow(2, true)]
        //[DataRow(-3, false)]
        public void TestPosOrNeg(int data, bool expected)
        {  
            //arrange
            int num = 4;

            //act
            bool actual = demo.PosOrNeg(data);

            //assert
            Assert.AreEqual(expected, actual);
        }
        
        public void SumOfNatNum(int data, int expected)
        {   //arrange
            int num = 4;

            //act
            int actual = demo.SumOfNatNum(data);
            //assert
            Assert.AreEqual(expected, actual);
        }
        public void IsLeapYrREturnBoolValue(int year, bool expected)
        {   //arrange
            int result = 2004;

            //act
            bool actual = demo.IsLeapYear(year);

            //assert
            Assert.AreEqual(expected, actual);
        }
        
    }
}