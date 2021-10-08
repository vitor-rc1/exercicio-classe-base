using ExercicioClasseBase;
using System;
using Xunit;

namespace ExercicioClasseBaseTeste
{
    public class SapoTest
    {
        [Fact]
        public void RetornaComerComidaDadoQueSapoNaoEMamifero()
        {
            // arrange
            var sapo = new Sapo(true, 4, Habitat.Floresta);

            // act
            string comer = sapo.Comer();

            // assert
            Assert.Equal("Comer comida", comer);
        }
    }
}
