using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using static PropiedadesNum.Program;
namespace PropiedadesNumTest
{
    [TestClass]
    public class PropiedadesNumPruebas
    {
        private int n2;

        [TestInitialize]
        public void Inicializar()
        {
            n2 = 5;

        }

        [TestMethod]
        public void TestFactorialCorrecto()
        {
            int n = 120;
            int resultado = Factorial(n2);

            Assert.AreEqual(n, resultado);
        }

        [TestMethod]
        public void TestFactorialIncorrecto()
        {
            int n = 10;
            int resultado = Factorial(n2);

            Assert.AreNotEqual(n, resultado);
        }

        [TestMethod]
//[ExpectedException(typeof(StackOverflowException))]
//Cuando el numero obtenido supera el limite retorna 0
        public void TestFactorialExcepcion()
        {
            int n = 0;
            int resultado = Factorial(1000);
            Assert.AreEqual(n, resultado);
        }

        [TestMethod]
        [ExpectedException(typeof(StackOverflowException))]
        public void TestFactorialExcepcionNegativo()
        {
            int n = -5;
            int resultado = Factorial(n);
           
        }

        [TestMethod]
        [DataRow(1, 1)]
        [DataRow(0, 1)]
        public void TestFactorial0y1(int n, int n2)
        {
            int resultado = Factorial(n);
            Assert.AreEqual(n2, resultado);
        }

        [TestMethod]
        public void TestesPrimoCorrecto()
        {
            bool esnumeroPrimo = true;
            bool funciona = esPrimo(ref n2);

            Assert.AreEqual(esnumeroPrimo, funciona);
        }

        [TestMethod]
        public void TestesPrimoIncorrecto()
        {
            int n = 14;
            bool esnumeroPrimo = true;
            bool funciona = esPrimo(ref n);

            Assert.AreNotEqual(esnumeroPrimo, funciona);
        }

        [TestMethod]
        public void TestDivisoresCorrecto()
        {
            int n = 8;
            int cont = 4;
            bool resultado = divisores(n, cont);
            Assert.IsTrue(resultado);
        }

        [TestMethod]
        [ExpectedException(typeof(DivideByZeroException))]
        public void TestDivisoresExcepcion()
        {
            int cont = 0;
            bool resultado = divisores(n2, cont);
        }
    }
}
