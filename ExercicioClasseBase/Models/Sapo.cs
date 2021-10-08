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
        public Sapo(bool venenoso, Habitat habitat) : base(false, 4, habitat)
        {
            Venenoso = venenoso;
        }
    }
}
