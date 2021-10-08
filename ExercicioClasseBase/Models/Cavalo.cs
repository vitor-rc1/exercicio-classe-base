using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioClasseBase
{
    public class Cavalo: Animal
    {
        public string Raca { get; set; }
        public string Cor { get; set; }
        public Cavalo(string raca, string cor, Habitat habitat) : base(true, 4, habitat)
        {
            Raca = raca;
            Cor = cor;
        }
    }
}
