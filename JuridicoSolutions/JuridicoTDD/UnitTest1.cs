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
    }
}
