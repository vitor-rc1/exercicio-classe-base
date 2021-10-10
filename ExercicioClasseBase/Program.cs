using System;

namespace ExercicioClasseBase
{
    class Program
    {
        static void Main()
        {
            var zoo = new Zoologico();

            // Sapos
            for (int i = 0; i < 6; i++)
            {
                var venenoso = i % 2 == 0;
                Habitat habitat = i % 2 == 0 ? Habitat.AguaDoce : Habitat.AguaSalgada;
                zoo.CadastrarAnimal(new Sapo(venenoso, habitat));
            }

            // Passaros
            for (int i = 0; i < 3; i++)
            {
                zoo.CadastrarAnimal(new Passaro(false, Porte.Pequeno, Habitat.Floresta));
                zoo.CadastrarAnimal(new Passaro(i == 2, Porte.Medio, Habitat.Floresta));

                zoo.CadastrarAnimal(new Passaro(true, Porte.Grande, Habitat.Floresta));
                
            }

            // Cavalos
            for (int i = 0; i < 2; i++)
            {
                zoo.CadastrarAnimal(new Cavalo("Corcel", "Branco", Habitat.Planicie));
                zoo.CadastrarAnimal(new Cavalo("Corcel", "Preto", Habitat.Planicie));
                zoo.CadastrarAnimal(new Cavalo("Corcel", "Marrom", Habitat.Floresta));
                zoo.CadastrarAnimal(new Cavalo("Corcel", "Cinza", Habitat.Floresta));
            }



            // Baleias
            for (int i = 0; i < 8; i++)
            {
                var pesoInicial = 500 + (i * 100);
                var comprimentoInicial = 10 + (i * 10);

                 var habitat = i < 4 ? Habitat.AguaDoce : Habitat.AguaSalgada;

                zoo.CadastrarAnimal(new Baleia(
                    pesoInicial,
                    comprimentoInicial,
                    habitat
                    ));
            }

            zoo.AlimentarAnimais();
            zoo.GerarRelatorio();


        }
    }
}
