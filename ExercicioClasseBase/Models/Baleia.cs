using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioClasseBase
{
    public class Baleia : Animal
    {
        public double Kilos { get; set; }
        public double Tamanho { get; set; }
        public Baleia(double kilos, double tamanho, int patas, Habitat habitat) : base(true, patas, habitat)
        {
            Kilos = kilos;
            Tamanho = tamanho;
        }


    }
}
