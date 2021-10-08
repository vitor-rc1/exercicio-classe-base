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
        public Passaro(bool carnivoro, Porte porte, Habitat habitat) : base(false, 2, habitat)
        {
            Carnivoro = carnivoro;
            if (Enum.IsDefined(typeof(Porte), porte))
            {
                Porte = porte;
            }
            
        }

        public Passaro(bool carnivoro, Habitat habitat) : base(false, 2, habitat)
        {
            Carnivoro = carnivoro;
        }

        public Passaro(bool carnivoro, Porte porte) : base(false, 2)
        {
            Carnivoro = carnivoro;
            Porte = porte;
        }
    }
}
