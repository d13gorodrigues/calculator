using Microsoft.VisualStudio.TestTools.UnitTesting;
using WindowsFormsApplication1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1.Tests
{
    [TestClass()]
    public class CalcTests
    {
        [TestMethod()]
        public void Soma()
        {
            var resultado = Calc.Calcula("25 + 5");
            Assert.IsTrue(resultado == 30);
        }

        [TestMethod()]
        public void Diferenca()
        {
            var resultado = Calc.Calcula("25 - 5");
            Assert.IsTrue(resultado == 20);
        }

        [TestMethod()]
        public void Multiplicacao()
        {
            var resultado = Calc.Calcula("25 * 5");
            Assert.IsTrue(resultado == 125);
        }

        [TestMethod()]
        public void Divisao()
        {
            var resultado = Calc.Calcula("25 / 5");
            Assert.IsTrue(resultado == 5);
        }

        [TestMethod()]
        public void Potencia()
        {
            var resultado = Calc.CalculaPotencia(5, 2);
            Assert.IsTrue(resultado == 25);
        }


    }
}