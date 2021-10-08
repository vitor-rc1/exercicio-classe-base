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

    }
}
