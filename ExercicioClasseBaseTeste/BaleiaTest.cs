using ExercicioClasseBase;
using System;
using Xunit;

namespace ExercicioClasseBaseTeste
{
    public class BaleiaTest
    {
        [Fact]
        public void RetornaBeberLeiteDadoQueBaleiaEMamifero()
        {
            // arrange
            var baleia = new Baleia(30000, 15, 0, Habitat.AguaSalgada);

            // act
            string comer = baleia.Comer();

            // assert
            Assert.Equal("Beber leite", comer);
        }

        [Theory]
        [InlineData(Habitat.AguaSalgada)]
        [InlineData(Habitat.AguaDoce)]
        public void VerificaHabitatDadoUmHabitatCorreto(Habitat habitat)
        {
            // arrange
            var baleia = new Baleia(30000, 15, 0, habitat);

            // act
            Habitat baleiaHabitat = baleia.Habitat;

            // assert
            Assert.Equal(habitat, baleiaHabitat);
        }

    }
}
