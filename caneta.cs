using System;

namespace ConsoleApp1
{
    class Program
    {

        public class caneta
        {
            public string cor { get; set; }
            public bool tampada { get; set; }
            public float tam_ponta { get; set; }

            public caneta(string Cor, float Tam_ponta)
            {
                Cor = cor;
                Tam_ponta = tam_ponta;
                tampada = true; // a caneta se inicia tampada
            }

                // método para destampar a caneta

                public void destampar()
                {
                    tampada = false;
                    Console.WriteLine("A caneta foi destampada");
                }

                // método para tampar a caneta

                public void tampar()
                {
                    tampada = true;
                    Console.WriteLine("A caneta foi tampada");
                }

                // método para escrever

                public void escrever(string texto)
                {
                    if (tampada)
                    {
                        Console.WriteLine("Não é possivel escrever com a caneta tampada");
                    }
                    else
                    {
                        Console.WriteLine("Escrevendo: " + texto);
                    }
                }
            }

        static void Main(string[] args)
        {
            caneta bic = new caneta("preta", 1f);
            bic.destampar();
            bic.escrever("besteira");
            bic.tampar();
            Console.ReadLine();
        }
    }
}
