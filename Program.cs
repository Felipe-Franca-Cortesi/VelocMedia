using System;

namespace VelocMedia
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Console.WriteLine("\n ---- Velocidade média ----");
            Console.Write("\n Digite a distância percorrida (m): ");
            double distanciaPercorrida = Convert.ToDouble(Console.ReadLine());
            Console.Write("\n Digite o tempo gasto (s) : ");
            double tempoGasto = Convert.ToDouble(Console.ReadLine());

            double velocidadeMedia = distanciaPercorrida / tempoGasto;
            Console.WriteLine($"\n Velocidade média: {velocidadeMedia}");
            Console.Write("\n Pressione qualquer tecla para sair");
            Console.ReadKey();
        }
    }
}
