using System;
using EquationProgram;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace EquationsTest
{
    [TestClass]
    public class EquationTest
    {
        [TestMethod]

        public void TestEquations()
        {
            // Создание функции с известными параметрами A,B,C,X,Y
            Equations equastions = new Equations(4, 5, 6, 7, 3);
            //Сравнение действительного значение функции от вычисляемого 
            //(в методе записываются значения степеней в зависимости от вида функции)
            Assert.AreEqual(62, equastions.FunctionXY(1, 1));

            Assert.AreEqual(226, equastions.FunctionXY(2, 2));
            Assert.AreEqual(950, equastions.FunctionXY(3, 3));
            Assert.AreEqual(4474, equastions.FunctionXY(4, 4));
        }
    }
}
