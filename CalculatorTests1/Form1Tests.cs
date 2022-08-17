using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace Calculator.Tests
{
    [TestClass()]
    public class Form1Tests
    {
        [TestMethod()]
        public void Addition()
        {
            var calculator = new Form1();

            if(calculator.Add(5, 6) != 11)
                throw new InvalidOperationException();
        }

        [TestMethod()]
        public void Subtration()
        {
            var calculator = new Form1();

            if (calculator.Sub(10, 5) != 5)
                throw new InvalidOperationException();

            if (calculator.Sub(5.5, 5) != 0.5)
                throw new InvalidOperationException();
        }

        [TestMethod()]
        public void Multiplication()
        {
            var calculator = new Form1();

            if (calculator.Mul(10, 10) != 100)
                throw new InvalidOperationException();

            if (calculator.Mul(7.5, 2.6) != 19.5)
                throw new InvalidOperationException();
        }

        [TestMethod()]
        public void Division()
        {
            var calculator = new Form1();

            if (calculator.Div(60, 6) != 10)
                throw new InvalidOperationException();
        }

        [TestMethod()]
        public void Remainder()
        {
            var calculator = new Form1();

            if (calculator.Rem(17, 5) != 2)
                throw new InvalidOperationException();
        }
    }
}