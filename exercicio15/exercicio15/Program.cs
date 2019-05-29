using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio15
{
    class Program
    {
        static void Main(string[] args)
        {
            String nome = ""; //Adriano Soares
            Console.Write("Digite seu nome: ");
            nome = Console.ReadLine();

            Console.WriteLine("todo o Nome: {0}", nome);
            Console.WriteLine("Primeiro Caracter:{0}", nome.Substring(0, 1));
            Console.WriteLine("Quantidade de Caracter: {0}", nome.Length);
            Console.WriteLine("Último caracter: {0}", nome.Substring(nome.Length - 1, 1));
            Console.WriteLine("Do Primeiro ate o Terceiro: {0}", nome.Substring(0, 3));
            Console.WriteLine("o Quarto Caracter: {0}", nome.Substring(3, 1));
            Console.WriteLine("Todos menos o Primeiro: {0}", nome.Substring(1, nome.Length - 1));
            Console.WriteLine("OS dois último: {0}", nome.Substring(nome.Length - 2, 2));

                


        }

    }
}
