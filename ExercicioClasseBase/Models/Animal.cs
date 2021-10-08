using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioClasseBase
{
    public enum Habitat
    {
        Floresta,
        planicie,
        AguaSalgada,
        AguaDoce
    }
    public abstract class Animal
    {
        public bool Mamifero { get; set; }
        public int Patas { get; set; }
        public Habitat Habitat { get; set; }

        public Animal(bool mamifero, int patas, Habitat habitat)
        {
            Mamifero = mamifero;
            Patas = patas;
            if (Enum.IsDefined(typeof(Habitat), habitat))
            {
                Habitat = habitat;
            }
        }

        public string Comer()
        {
            if (Mamifero)
            {
                return "Beber leite";
            }
            return "Comer comida";
        }
    }
}
