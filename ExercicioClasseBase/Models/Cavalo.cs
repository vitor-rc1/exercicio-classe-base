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
        public Cavalo(string raca, string cor, int patas, Habitat habitat) : base(true, patas, habitat)
        {
            Raca = raca;
            Cor = cor;
        }
    }
}
