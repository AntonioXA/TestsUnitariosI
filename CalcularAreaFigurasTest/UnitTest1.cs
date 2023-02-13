using Microsoft.VisualStudio.TestTools.UnitTesting;
using static CalcularAreaFiguras.Program;
using System;

namespace CalcularAreaFigurasTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestCuadrilaterosCorrecto()
        {
            double n = 20;

            double resultado = Cuadrilateros(4,5);

            Assert.AreEqual(n, resultado);
        }

        [TestMethod]
        public void TestCuadrilaterosIncorrecto()
        {
            double n = 23;

            double resultado = Cuadrilateros(2, 3);

            Assert.AreNotEqual(n, resultado);
        }

        [TestMethod]
        public void TestCirculoCorrecto()
        {
            double n = 314.1592653589793;

            double resultado = Circulo(10);

            Assert.AreEqual(n, resultado);
        }

        [TestMethod]
        public void TestCirculoIncorrecto()
        {
            double n = 200;

            double resultado = Circulo(8);

            Assert.AreNotEqual(n, resultado);
        }

        [TestMethod]
        public void TestTrianguloCorrecto()
        {
            double n = 17;

            double resultado = Triangulo(5,7);

            Assert.AreEqual(n, resultado);
        }

        [TestMethod]
        public void TestTrianguloIncorrecto()
        {
            double n = 90;

            double resultado = Triangulo(10, 2);

            Assert.AreNotEqual(n, resultado);
        }
    }
}
