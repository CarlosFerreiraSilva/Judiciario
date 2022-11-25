using Juridico.Models;
using System;
using Xunit;

namespace JuridicoTDD
{
    public class AdvogadoTDD
    {
        [Fact]
        public void AdvogadoRertornarNomeCompletoTrue()
        {
            //Arrange - Preparação
            Advogado adv = new Advogado();
            adv.nome = "Vinicius";
            adv.sobrenome = "Reginaldo";
            string esperado = "Vinicius Reginaldo";
            string resultado;
            //Act
            resultado = adv.getNomeCompleto();

            //Assert
            Assert.Equal(esperado, resultado);
        }
        [Theory]
        [InlineData("Reginaldo", "Vinicius", "Reginaldo Rodrigues")]
        [InlineData("José", "Santos", "José Santos")]
        [InlineData("Bozo", "vai preso", "Bozo vai preso")]
        public void AdvogadoRetornarNomeCompletoVariosCenarios(string nome, string sob, string esperado)
        {
            //Arrange
            Advogado adv = new Advogado();
            adv.nome = nome;
            adv.sobrenome = sob;
            //Act
            string resultado = adv.getNomeCompleto();

            Assert.Equal(resultado, esperado);
        }
    }
}
