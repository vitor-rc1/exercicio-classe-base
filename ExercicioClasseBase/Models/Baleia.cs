using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioClasseBase
{
    public class Baleia : Animal
    {
        public double Quilos { get; set; }
        public double Tamanho { get; set; }
        public Baleia(double quilos, double tamanho, int patas, Habitat habitat) : base(true, patas, habitat)
        {
            Quilos = quilos;
            Tamanho = tamanho;
        }


    }
}
