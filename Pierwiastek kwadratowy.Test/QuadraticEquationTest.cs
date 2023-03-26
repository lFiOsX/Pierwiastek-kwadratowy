

using Pierwiastek_kwadratowy;

namespace Pierwiastek_kwadratowy.Test
{
    public class QuadraticEquationTest
    {
        [Theory]
        [InlineData (1,2,1,0)]
        [InlineData (1,1,-6,25)]
        [InlineData (1,0,1,-4)]
        public void calculateDelta_calcDelta_getTheValues(int a, int b, int c, double expect)
        {
            //Arrange
            QuadraticEquation qe = new QuadraticEquation ();

            //Act
            double result = qe.calcDelta(a, b, c);

            //Asert
            Assert.Equal(expect, result);

        }





        //[Theory]
        //[InlineData(1, 2, 1, $"delta = 0 \nMiejsce zerowe x0 = -1")]
        //[InlineData(1, 1, -6, "")]
        //[InlineData(1, 0, 1, "sas")]
        //public void chooseRightOption_calcDeltaZeros_displayRightValue(int a, int b, int c, string expect)
        //{
        //    //Arrange
        //    QuadraticEquation qe = new QuadraticEquation();

        //    //Act


        //    //Asert
        //    Assert.(expect, qe.calcDeltaZeros(a, b, c));

        //}
    }
}