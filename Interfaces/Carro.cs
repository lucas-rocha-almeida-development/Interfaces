using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    internal class Carro : IVeiculo
    {
        //implementação de todos os metodos 

        public void Ligar()
        {
            Console.WriteLine("O carro está Ligado!");
        }

        public void Desligar()
        {
            Console.WriteLine("O carro está Desligado!");
        }
        public void AbrirPorta()
        {
            Console.WriteLine("A porta do carro esta Aberta!");
        }

       

        public void FecharPorta()
        {
            Console.WriteLine("A porta do carro esta Fechada!");
        }
        public void Acelerar()
        {
            Console.WriteLine("O carro Acelerou");
        }


    }
}
