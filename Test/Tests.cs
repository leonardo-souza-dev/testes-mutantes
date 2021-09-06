using System;
using Xunit;
using Service;

namespace Test
{
    public class Tests
    {
        [Fact]
        public void QuandoQtdValida_DeveObterTotal()
        {
            // arrange
            var sut = new CarrinhoService();

            // act
            var result = sut.FecharCarrinho("1234", 2.2M, 2);

            // assert
            Assert.Equal(4.4M, result);
        }

        [Fact]
        public void QuandoQtdInvalida_NaoDeveObterTotal()
        {
            // arrange
            var sut = new CarrinhoService();

            // act & assert
            Assert.Throws<Exception>(() => sut.FecharCarrinho("7890", 2.2M, 100));
        }
    }
}
