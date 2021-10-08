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
        public Baleia(double quilos, double tamanho, Habitat habitat) : base(true, 0, habitat)
        {
            Quilos = quilos;
            Tamanho = tamanho;
        }


    }
}
