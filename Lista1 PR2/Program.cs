using System;
using System.Drawing;
using System.Runtime.ConstrainedExecution;

class Program
{

    static void Main(string[] args)
    {
        {
            // 1- centimetros e militetros 
            //Console.Write("Digite o valor em metros: ");
            //double metros = double.Parse(Console.ReadLine());

            //double centimetros = metros * 100;
            //double milimetros = metros * 1000;

            //Console.WriteLine("{0} metros é igual a {1} centímetros e {2} milímetros.", metros, centimetros, milimetros);



            // 2- cálculo fahrenheit a)

            //Console.Write("Digite quantos graus está em fahrenheit: ");
            //float fahrenheit = float.Parse(Console.ReadLine());

            //float celsius = (fahrenheit - 32.0f) * (5.0f / 9.0f);

            //Console.WriteLine("{0} graus Fahrenheit equivalem a {1:F2} graus Celsius.", fahrenheit, celsius);

            //b) 

            //Console.Write("Digite quantos gruas está em Fahrenheit: ");
            //int fahrenheit = int.Parse(Console.ReadLine());

            //int celsius = (fahrenheit - 32) * (5 / 9);

            //Console.WriteLine("{0} graus Fahrenheit equivalem a {1} graus Celsius.", fahrenheit, celsius);




            // 3- cálculo do IMC corporal

            //    Console.Write("Digite o peso em kg: ");
            //    double peso = double.Parse(Console.ReadLine());

            //    Console.Write("Digite a altura em metros: ");
            //    double altura = double.Parse(Console.ReadLine());

            //    double imc = peso / (altura * altura);

            //    Console.WriteLine("Seu IMC é: {0:F2}", imc);




            // 4- Cálculo média ponderada

            //Console.Write("Digite o primeiro número: ");
            //double num1 = double.Parse(Console.ReadLine());

            //Console.Write("Digite o segundo número: ");
            //double num2 = double.Parse(Console.ReadLine());

            //Console.Write("Digite o terceiro número: ");
            //double num3 = double.Parse(Console.ReadLine());

            //Console.Write("Digite o peso do primeiro número: ");
            //double peso1 = double.Parse(Console.ReadLine());

            //Console.Write("Digite o peso do segundo número: ");
            //double peso2 = double.Parse(Console.ReadLine());

            //Console.Write("Digite o peso do terceiro número: ");
            //double peso3 = double.Parse(Console.ReadLine());

            //double mediaPonderada = (num1 * peso1 + num2 * peso2 + num3 * peso3) / (peso1 + peso2 + peso3);

            //Console.WriteLine("A média ponderada é: {0}", mediaPonderada);




            // 5-  Console.Write("Digite a frequência da onda (em Hz): ");


            //double freq = Convert.ToDouble(Console.ReadLine());


            //double c = 299792458; // m/s


            //double lambda = c / freq;


            //Console.WriteLine("O comprimento de onda é de {0} metros.", lambda);




            // 6- cálculo do aumento do salário de um funcionário

            //double SalarioAtual, SalarioFuturo;


            //Console.Write("qual é o salário do funcionário: ");
            //SalarioAtual = double.Parse(Console.ReadLine());


            //SalarioFuturo = SalarioAtual * 1.25;


            //Console.WriteLine("O novo salário do funcionário é: " + SalarioFuturo);



            // 7- Cálculo dolar 

            // double Real, cotacaoDolar, Dolar;

            // Console.Write("Digite o valor em reais: ");
            // Real = double.Parse(Console.ReadLine());


            // Console.Write("Digite quanto qual o valor do dólar: ");
            // cotacaoDolar = double.Parse(Console.ReadLine());

            //Dolar = Real / cotacaoDolar;

            // Console.WriteLine(" O valor em dólares é: " + Dolar);



            // 8- cálculo de um número inteiro + a soma dele com o sucessor de seu triplo e o antecessor de seu dobro 

            //int triplo, dobro, soma, num;

            //Console.Write("Digite um número inteiro: ");
            //num = int.Parse(Console.ReadLine());

            //triplo = 3 * num;
            //dobro = 2 * num;
            //soma = (triplo + 1) + (dobro - 1);

            //Console.WriteLine("O resultado desse valor é: " + soma);


            // 9- ler um número inteiro de 4 digitos

            //int num;

            //Console.Write("Digite um número que seja inteiro, de  4 dígitos: ");
            //num = int.Parse(Console.ReadLine());

            //Console.WriteLine(num / 1000);
            //Console.WriteLine((num / 100) % 10);
            //Console.WriteLine((num / 10) % 10);
            //Console.WriteLine(num % 10);



            // 10- Cálculo de investimento do marquesito

            // Dia 1: ocorreu uma queda de 3,4%
            //investimento = investimento * (1 - 0.034);

            //// Dia 2:  obteve uma subida de 2,8%
            //investimento = investimento * (1 + 0.028);

            //// Dia 3: obteve mais uma subida de 14%
            //investimento = investimento * (1 + 0.14);

            //// Dia 4: ocorreu mais uma queda, mas agora é de 8,5%
            //investimento = investimento * (1 - 0.085);

            //Console.WriteLine("O valor atual dos investimentos é de R${0:0.00}", investimento);




            // 11- calcular o quadrado e o cubo de um valor

            //Console.Write("Digite um número: ");
            //int n = int.Parse(Console.ReadLine());

            //int quadrado = n * n;
            //int cubo = n * n * n;

            //Console.WriteLine("O número {0} ao quadrado é {1}", n, quadrado);
            //Console.WriteLine("O número {0} ao cubo é {1}", n, cubo); 



            // 12- peso ideal para mulheres e homens

            //a)
            //Console.Write("Digite a altura em metros: ");
            //double altura = double.Parse(Console.ReadLine());

            //double pesoIdeal = (72.7 * altura) - 58;

            //Console.WriteLine("Com base nessas características, esse resultado deve ser o seu peso ideal {0}m é {1}kg", altura, pesoIdeal);

            //b)
            //double pesoIdeal//Console.Write("Digite a altura em metros: ");
            //double altura = double.Parse(Console.ReadLine());

            //double pesoIdeal = (62.1*h) -44.7
            //Console.WriteLine("Com base nessas características, esse resultado deve ser o seu peso ideal {0}m é {1}kg", altura, pesoIdeal);
        }
    }
}