using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioClasseBase
{
    class Zoologico
    {
        public List<Animal> Animais = new();


        public void CadastrarAnimal(Animal animal)
        {
            Animais.Add(animal);
        }

        public void AlimentarAnimais()
        {
            int i = 0;
            foreach (var animal in Animais)
            {
                Console.WriteLine(animal.Comer() + " " + animal.GetType().Name);
                i++;
            }
        }

        public void GerarRelatorio()
        {
            var qtdMamiferos = Animais
                .Where(animal => animal.Mamifero)
                .Count();

            var totalPatas = Animais
                .Select(animal => animal.Patas)
                .Sum();

            var baleias = Animais.OfType<Baleia>();

            var pesoMedioBaleias = baleias
                .Select(baleia => baleia.Quilos)
                .Average();

            var comprimentoBaleias = baleias
                .Select(baleia => baleia.Tamanho)
                .Sum();


            Console.WriteLine(qtdMamiferos);
            Console.WriteLine(pesoMedioBaleias);
            Console.WriteLine(comprimentoBaleias);
            Console.WriteLine(totalPatas);
        }

    }
}
