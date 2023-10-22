using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    internal class Aviao : IVeiculo
    {
        //implementação de todos os metodos 

        public void Ligar()
        {
            Console.WriteLine("O Avião está Ligado!");
        }

        public void Desligar()
        {
            Console.WriteLine("O Avião está Desligado!");
        }
        public void AbrirPorta()
        {
            Console.WriteLine("A porta do Avião esta Aberta!");
        }



        public void FecharPorta()
        {
            Console.WriteLine("A porta do Avião esta Fechada!");
        }

        public void Decolar()
        {
            Console.WriteLine("O Avião decolou!");
        }

    }
}
