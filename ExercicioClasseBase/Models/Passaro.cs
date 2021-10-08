using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioClasseBase
{
    public class Passaro : Animal
    {
        public bool Carnivoro { get; set; }
        public Porte Porte { get; set; }
        public Passaro(bool carnivoro, Porte porte, int patas, Habitat habitat) : base(false, patas, habitat)
        {
            Carnivoro = carnivoro;
            if (Enum.IsDefined(typeof(Porte), porte))
            {
                Porte = porte;
            }
            
        }
    }
}
