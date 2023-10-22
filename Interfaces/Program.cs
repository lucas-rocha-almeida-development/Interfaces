using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Carro MeuCarro = new Carro(); // criando uma variavel do tipo carro (atribuição do objeto)
            //metodos da Interface
            MeuCarro.AbrirPorta();
            MeuCarro.FecharPorta();
            MeuCarro.Ligar();
            MeuCarro.Desligar();
            MeuCarro.Acelerar();
            Console.WriteLine("================================================");
            Aviao MeuAviao = new Aviao(); //// criando uma variavel do tipo carro (atribuição do objeto)
                                          //metodos da Interface
            MeuAviao.AbrirPorta();
            MeuAviao.FecharPorta();
            MeuAviao.Ligar();
            MeuAviao.Desligar();
            MeuAviao.Decolar(); 
            Console.WriteLine("-----------------------\n-----------------------");
            //Podemos criar uma variavel do proprio tipo da Interface (IVeiculo)
            IVeiculo meuVeiculoInterface = new Carro();
            meuVeiculoInterface.AbrirPorta();
            meuVeiculoInterface.FecharPorta();
            meuVeiculoInterface.Ligar();
            meuVeiculoInterface.Desligar();

            Console.WriteLine("=============================================");

            IVeiculo meuVeiculoAviaoInterface = new Aviao();
            meuVeiculoAviaoInterface.AbrirPorta();
            meuVeiculoAviaoInterface.FecharPorta();
            meuVeiculoAviaoInterface.Ligar();
            meuVeiculoAviaoInterface.Desligar();

        }
    }
}
