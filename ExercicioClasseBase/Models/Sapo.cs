using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioClasseBase
{
    public class Sapo: Animal
    {
        public bool Venenoso { get; set; }
        public Sapo(bool venenoso, int patas, Habitat habitat) : base(false, patas, habitat)
        {
            Venenoso = venenoso;
        }
    }
}
