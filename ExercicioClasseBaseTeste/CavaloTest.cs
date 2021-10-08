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
            var cavalo = new Cavalo("Corcel", "Branco", Habitat.Planicie);

            // act
            string comer = cavalo.Comer();

            // assert

            Assert.Equal("Beber leite", comer);
        }
    }
}
