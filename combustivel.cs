using System;

class Program {
    static void Main(string[] args) {

      double valorAlcool, valorGasolina, valor;
      int novoCalculo=1;

      do {
			 Console.WriteLine("Informe o preço do alcool: ");
			valorAlcool = double.Parse(Console.ReadLine());
        
			 Console.WriteLine("Informe o preço da gasolina: ");
			valorGasolina = double.Parse(Console.ReadLine());

			valor = (valorAlcool / valorGasolina);

			if (valor < 0.7) {
				 Console.WriteLine("Se este valor for inferior a 0,7, vale a pena o álcool.");
				 Console.WriteLine("Deseja efetuar um novo cálculo? Digite 1-sim e 2-não");
				novoCalculo = int.Parse(Console.ReadLine());
  
			} else if (valor > 0.7) {
				 Console.WriteLine("Se este valor for superior a 0,7, vale a pena a gasolina.");
				 Console.WriteLine("Deseja efetuar um novo cálculo? Digite 1-sim e 2-não");
				novoCalculo = int.Parse(Console.ReadLine());
        
			} else if (valor === 0.7) {
				 Console.WriteLine("Se o valor for exatamente 0,7, tanto faz abastecer com um ou outro");
				 Console.WriteLine("Deseja efetuar um novo cálculo? Digite 1-sim e 2-não");
				novoCalculo = int.Parse(Console.ReadLine());
			}

		} while (novoCalculo == 1);
		 Console.WriteLine("O programa foi encerrado.");
	}

}