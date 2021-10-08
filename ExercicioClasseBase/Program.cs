using System;

namespace ExercicioClasseBase
{
    class Program
    {
        static void Main()
        {
            var zoo = new Zoologico();

            // Sapos
            zoo.CadastrarSapos(3, new Sapo(true, Habitat.AguaDoce));
            zoo.CadastrarSapos(3, new Sapo(false, Habitat.AguaSalgada));

            // Passaros
            zoo.CadastrarPassaros(3, new Passaro(false, Porte.Pequeno, Habitat.Floresta));

            zoo.CadastrarPassaros(2, new Passaro(false, Porte.Medio, Habitat.Floresta));
            zoo.CadastrarPassaros(1, new Passaro(true, Porte.Medio, Habitat.Floresta));

            zoo.CadastrarPassaros(3, new Passaro(true, Porte.Grande, Habitat.Floresta));

            // Cavalos
            zoo.CadastrarCavalos(2, new Cavalo("Corcel", "Branco", Habitat.Planicie));
            zoo.CadastrarCavalos(2, new Cavalo("Corcel", "Preto", Habitat.Planicie));
            zoo.CadastrarCavalos(2, new Cavalo("Corcel", "Marrom", Habitat.Floresta));
            zoo.CadastrarCavalos(2, new Cavalo("Corcel", "Cinza", Habitat.Floresta));

            // Baleias
            zoo.CadastrarBaleias(1, new Baleia(500, 10, Habitat.AguaDoce));
            zoo.CadastrarBaleias(2, new Baleia(600, 20, Habitat.AguaDoce));
            zoo.CadastrarBaleias(1, new Baleia(700, 40, Habitat.AguaDoce));

            zoo.CadastrarBaleias(2, new Baleia(700, 40, Habitat.AguaSalgada));
            zoo.CadastrarBaleias(2, new Baleia(800, 50, Habitat.AguaSalgada));

            zoo.AlimentarAnimais();


        }
    }
}
