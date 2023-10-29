using System;
using Xunit;
using ProjetoCalculadora;

namespace TesteCalculadora
{
    public class UnitTest1
    {

        public Calculadora ConstruirClasse()
        {
            string data = "29/10/2023";
            Calculadora calc = new Calculadora(data);

            return calc;
        }

        [Theory]
        [InlineData (1, 2, 3)]
        [InlineData(4, 2, 6)]
        [InlineData(20, 15, 35)]
        public void TesteSomar(int num1, int num2, int resEsperado)
        {
            Calculadora calc = new Calculadora("03/09/2022");

            int resultado = calc.Somar(num1, num2);

            Assert.Equal(resEsperado, resultado); 
        }

        [Theory]
        [InlineData(2, 1, 1)]
        [InlineData(4, 2, 2)]
        [InlineData(20, 15, 5)]
        public void TesteSubtrair(int num1, int num2, int resEsperado)
        {
            Calculadora calc = new Calculadora("12/04/2021");

            int resultado = calc.Subtrair(num1, num2);

            Assert.Equal(resEsperado, resultado);
        }

        [Theory]
        [InlineData(1, 2, 2)]
        [InlineData(4, 2, 8)]
        [InlineData(20, 15, 300)]
        public void TesteMultiplicar(int num1, int num2, int resEsperado)
        {
            Calculadora calc = new Calculadora("07/09/2014");

            int resultado = calc.Multiplicar(num1, num2);

            Assert.Equal(resEsperado, resultado);
        }

        [Theory]
        [InlineData(10, 2, 5)]
        [InlineData(4, 2, 2)]
        [InlineData(20, 5, 4)]
        public void TesteDividir(int num1, int num2, int resEsperado)
        {
            Calculadora calc = new Calculadora("27/02/2017");

            int resultado = calc.Dividir(num1, num2);

            Assert.Equal(resEsperado, resultado);
        }


        [Fact]
        public void TestarDivisaoPorZero()
        {
            Calculadora calc = new Calculadora("30/10/2007");

            Assert.Throws<DivideByZeroException>(() => calc.Dividir(3, 0));
        }

        [Fact]
        public void TestarHistorico()
        {
            Calculadora calc = new Calculadora("27/05/2001");

            calc.Somar(1, 2);
            calc.Somar(490, 126);
            calc.Somar(13, 22);

            var lista = calc.Historico();

            Assert.NotEmpty(lista);
            Assert.Equal(3, lista.Count);
        }
    }
}
