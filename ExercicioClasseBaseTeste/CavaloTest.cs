using ExercicioClasseBase;
using System;
using Xunit;

namespace ExercicioClasseBaseTeste
{
    public class CavaloTest
    {
        [Fact]
        public void RetornaBeberLeiteDadoQueCavaloEMamifero()
        {
            // arrange
            var cavalo = new Cavalo("Corcel", "Branco", 4, Habitat.planicie);

            // act
            string comer = cavalo.Comer();

            // assert

            Assert.Equal("Beber leite", comer);
        }
    }
}