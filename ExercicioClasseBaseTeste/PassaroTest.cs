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
            var passaro = new Passaro(false, Porte.Pequeno, 2, Habitat.planicie);

            // act
            string comer = passaro.Comer();

            // assert
            Assert.Equal("Comer comida", comer);
        }
    }
}
