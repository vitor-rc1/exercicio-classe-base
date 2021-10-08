using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioClasseBase
{
    class Zoologico
    {
        //public List<Animal> animais = new List<Animal>();

        public List<Baleia> Baleias = new List<Baleia>();
        public List<Cavalo> Cavalos = new List<Cavalo>();
        public List<Passaro> Passaros = new List<Passaro>();
        public List<Sapo> Sapos = new List<Sapo>();


        public void CadastrarBaleias(int qtd, Baleia baleia)
        {
            for (int i = 0; i < qtd; i++)
            {
                Baleias.Add(baleia);
            }
        }

        public void CadastrarCavalos(int qtd, Cavalo cavalo)
        {
            for (int i = 0; i < qtd; i++)
            {
                Cavalos.Add(cavalo);
            }
        }

        public void CadastrarPassaros(int qtd, Passaro passaro)
        {
            for (int i = 0; i < qtd; i++)
            {
                Passaros.Add(passaro);
            }
        }

        public void CadastrarSapos(int qtd, Sapo sapo)
        {
            for (int i = 0; i < qtd; i++)
            {
                Sapos.Add(sapo);
            }
        }

        public void AlimentarAnimais()
        {
            
            foreach (var baleia in Baleias)
            {
                Console.WriteLine(baleia.Comer());
            }
            foreach (var cavalo in Cavalos)
            {
                Console.WriteLine(cavalo.Comer());
            }
            foreach (var passaro in Passaros)
            {
                Console.WriteLine(passaro.Comer());
            }
            foreach (var sapo in Sapos)
            {
                Console.WriteLine(sapo.Comer());
            }
        }

        public void Relatorio()
        {
            
        }

    }
}
