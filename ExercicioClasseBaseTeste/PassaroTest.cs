using ExercicioClasseBase;
using System;
using Xunit;

namespace ExercicioClasseBaseTeste
{
    public class PassaroTest
    {
        [Fact]
        public void RetornaComerComidaDadoQuePassaroNaoEMamifero()
        {
            // arrange
            var passaro = new Passaro(false, Porte.Pequeno, 2, Habitat.Planicie);

            // act
            string comer = passaro.Comer();

            // assert
            Assert.Equal("Comer comida", comer);
        }

        [Fact]
        public void PortePermaneceNuloDadoQueEUmPorteInvalido()
        {
            // arrange
            var passaro = new Passaro(false, 2, Habitat.Planicie);

            // act
            Porte porte = passaro.Porte;

            // assert
            Assert.Equal(Porte.NãoIdentificado, porte);
        }

        [Theory]
        [InlineData(false, Porte.Pequeno, 2, Habitat.Planicie)]
        [InlineData(false, Porte.Medio, 3, Habitat.Floresta)]
        [InlineData(false, Porte.Grande, 2, Habitat.Planicie)]
        public void RetornaPorteCorretoDadoUmPorteValido(
            bool carnivoro,
            Porte porte,
            int patas,
            Habitat habitat)
        {
            // arrange
            var passaro = new Passaro(carnivoro, porte, patas, habitat);

            // act
            Porte passaroPorte = passaro.Porte;

            // assert
            Assert.Equal(porte, passaroPorte);
        }
    }
}
