# Interfaces

#Exemplo de Interfaces

1ª interface IVeiculo (apresenta 4 atributos que seram utilizados em 2 classes criadas "Carro & Aviao" )

2ª Cada class criada sera obrigatorio implementar da interface para que possa utilizar os metodos que criados
internal class Carro : IVeiculo

3ª as classes poderam criar outros metodos de forma exclusivas que não contem na interface, ou seja, não sou obrigado a declarar na interface os atributos para que possa somente depois criar os metodos, posso de forma independente cria-los.

4º cada variavel criada pelo tipo interface não pode se beneficiar de um metodo criado de forma indivual dentro da interface 
IVeiculo meuVeiculoAviaoInterface = new Aviao();

aqui não sera possivel utilizar o metodo   MeuAviao.Decolar(); porque o metodo decolar e exclusivo da class avião e não foi atribuido dentro da Interface IVeiculos.
