

using Pierwiastek_kwadratowy;

namespace Pierwiastek_kwadratowy.Test
{
    public class QuadraticEquationTest
    {
        [Theory]
        [InlineData (1, 2, 1, 0)]
        [InlineData (1, 1, -6, 25)]
        [InlineData (1 , 0, 1, -4)]
        [InlineData(1, 0, 0, 0)]
        public void calculateDelta_calcDelta_getTheValues(int a, int b, int c, double expect)
        {
            //Arrange
            QuadraticEquation qe = new QuadraticEquation ();

            //Act
            double result = qe.calcDelta(a, b, c);

            //Assert
            Assert.Equal(expect, result);

        }

        [Fact]
        public void choosingRightOption_calcDeltaZeros_deltaLessThanZero()
        {
            //Arrange
            QuadraticEquation qe = new QuadraticEquation();
            qe.a = 1;
            qe.b = 0;
            qe.c = 1;
            //delta  < 0
            //Act
            qe.calcDeltaZeros(qe.a, qe.b, qe.c);
            //Asert
            Assert.Equal(qe.x0, 8);
            Assert.Equal(qe.x1, 16);
            Assert.Equal(qe.x2, 32);
            
        }

        [Fact]
        public void choosingRightOption_calcDeltaZeros_deltaEqualZero()
        {
            //Arrange
            QuadraticEquation qe = new QuadraticEquation();
            qe.a = 1;
            qe.b = 2;
            qe.c = 1;
            bool expect = false;
            // delta = 0 
            //Act
            qe.calcDeltaZeros(qe.a, qe.b, qe.c);
            expect = qe.x0 == -1;
            //Asert
            Assert.True(expect);
            
        }

        [Fact]
        public void choosingRightOption_calcDeltaZeros_deltaGreaterThanZero()
        {
            //Arrange
            QuadraticEquation qe = new QuadraticEquation();
            qe.a = 1;
            qe.b = 1;
            qe.c = -6;
            //delta  < 0
            //Act
            qe.calcDeltaZeros(qe.a, qe.b, qe.c);
            //Asert
            Assert.Equal(qe.x1, -3);
            Assert.False(qe.x2 != 2);

        }
    }
}