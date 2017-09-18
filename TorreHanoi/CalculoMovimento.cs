using System;
using System.Collections.Generic;

namespace IA.TorreHanoi
{
    public static class CalculoMovimento
    {
        private static List<Movimento> Movimentos { get; set; }

        public static List<Movimento> RetornaMovimentos(int numeroDeDiscos)
        {
            Movimentos = new List<Movimento>();
            Calcular(numeroDeDiscos - 1, 0, 2);
            return Movimentos;
        }

        public static int RetornaContadorMovimentos(int numeroDeDiscos)
        {
            Double numeroDeDiscos_Double = (Double) numeroDeDiscos;
            //(Eleva 2.0 ao número de discos) -1
            return (int) Math.Pow(2.0, numeroDeDiscos_Double) - 1;
        }

        private static void Calcular(int n, int deHaste, int paraHaste)
        {
            if (n == -1)
            {
                return; // estamos prontos
            }
            int hasteIntermediaria = RetornaHasteIntermediaria(deHaste, paraHaste);
            
            Calcular(n - 1, deHaste, hasteIntermediaria);
            Movimentos.Add(new Movimento(deHaste, paraHaste));
            Calcular(n - 1, hasteIntermediaria, paraHaste);
        }

        private static int RetornaHasteIntermediaria(int hasteInicio, int hasteFinal)
        {
            return (3 - hasteInicio - hasteFinal);
        }
    }
}
