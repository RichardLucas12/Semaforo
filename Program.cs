using System;

namespace Nova_pasta
{
    class Program
    {
        static void Main(string[] args)
        {

            string amarelo = "amarelo";
            string vermelho = "vermelho";
             
           Console.WriteLine("cor qual a cor do semaforo");
           string cor = Console.ReadLine();

            if (cor == vermelho )
            {
                Console.WriteLine("PARE");
            }
            else
            {
                if(cor == amarelo )
                {
                    Console.WriteLine(" sinal, Amarelo atenção diminua a velocidade");
                }
                else{
                    Console.WriteLine("sinal verde, continue em frente");
                }

            }

        }
    }
}
