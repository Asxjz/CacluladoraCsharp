using System;
using System.Collections.Generic;
using System.IO.Pipes;
using System.Text;
using System.Threading.Channels;
using System.Globalization;

namespace Calculadora_Simples {
    internal class Primeira_Calculadora_Simples {
        static void Main(string[] args) {

            while (true) { 
                // Loop da Calculadora Tchola

                // Primeiro Numero
                double valory = 0;
                bool valorY = false;
                while (!valorY) {
                    Thread.Sleep(500);
                    Console.Write("Insira o seu primeiro valor: ");
                    string valor1 = Console.ReadLine();
                    valorY = double.TryParse(valor1, out valory);

                    if (!valorY) {
                        Thread.Sleep(500);
                        Console.WriteLine("Digite um valor numerico!");
                    }
                }
                // Segundo Numero
                double valorx = 0;
                bool valorX = false;
                while (!valorX) {
                    Thread.Sleep(500);
                    Console.Write("Insira o seu segundo valor: ");
                    string valor2 = Console.ReadLine();
                    valorX = double.TryParse(valor2, out valorx);
                    if (!valorX) {
                        Thread.Sleep(500);
                        Console.WriteLine("Digite um valor numerico!");
                    }
                }
                // Operação Utilizada
                string operacao = "";
                bool opValidez = false;
                while (!opValidez) {
                    Thread.Sleep(500);
                    Console.Write("Escolha o tipo de operação( + - / * ): ");
                    operacao = Console.ReadLine();
                    if (operacao == "+" || operacao == "-" || operacao == "/" || operacao == "*") {
                        opValidez = true;
                    } else {
                        Thread.Sleep(500);
                        Console.WriteLine("Digite uma operação valida!");
                    }
                }

                // Matematica da Calculadora
                switch (operacao) {
                    case "+":
                        Thread.Sleep(500);
                        Console.WriteLine($"O resultado da sua soma é {valory + valorx}");
                        break;
                    case "-":
                        Thread.Sleep(500);
                        Console.WriteLine($"O resultado da sua subtração é {valory - valorx}");
                        break;
                    case "/":
                        if (valorx == 0) {
                            Thread.Sleep(500);
                            Console.WriteLine("Não se pode fazer divisão com o denominador 0");
                        } else {
                            Thread.Sleep(500);
                            Console.WriteLine($"O resultado da sua divisão é {valory / valorx}");
                        }
                        break;
                    case "*":
                        Thread.Sleep(500);
                        Console.WriteLine($"O resultado da sua multiplicação é {valory * valorx}");
                        break;
                    default:
                        Console.WriteLine("Operações invalidas tente novamente!");
                        break;
                }
                //Pergunta se ainda quer utilizar novamente
                Thread.Sleep(500);
                Console.WriteLine("Quer realizar outra operação? (s/n)");
                string resposta = Console.ReadLine().ToLower();
                if (resposta != "s") {
                    Thread.Sleep(500);
                    Console.WriteLine("Fim da Calculadora");
                    break;
                }

                Console.WriteLine();
            }
        }
    }
}
