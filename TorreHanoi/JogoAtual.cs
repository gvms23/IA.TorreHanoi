using System.Collections.Generic;
using System.Drawing;
using System;
namespace IA.TorreHanoi
{
    public static class JogoAtual
    {
        public static List<Haste> Hastes = new List<Haste>();
        public static List<Bitmap> ListaImagens = new List<Bitmap>();
        public static int ContadorMovimento = 0;
        public static int NumeroDeDiscos = 0;
        
        // Inicia o jogo
        static JogoAtual()
        {
            CarregarImagensDeResources();
            ReiniciarJogo(3);
        }

        public static int EfetuarMovimento(Movimento movimento)
        {
            if (movimento == null || movimento.DeHaste == null || movimento.ParaHaste == null)
            {
                return -1;
            }
            if (movimento.EfeitoContagem())
            {
                ContadorMovimento++;
            }
            
            if (movimento.EhValido())
            {
                Disco disco = movimento.DeHaste.RetornaDiscoDoTopo();
                Hastes[movimento.DeHaste.Numero].RemoverDisco();
                Hastes[movimento.ParaHaste.Numero].AdicionarDisco(disco);
                return ContadorMovimento;
            }

            else //movimento invalido
            {
                return -1;
            }
        }

        public static bool EstaResolvido()
        {
            return (Hastes[(Convert.ToInt32(Properties.Settings.Default.HasteFim))].Discos.Count == NumeroDeDiscos);
        }

        public static Haste EncontrarDisco(Disco discoParaEncontrar)
        {
            foreach (Haste haste in Hastes)
            {
                if (haste.Discos.ContainsValue(discoParaEncontrar))
                {
                    return haste;
                }
            }
            return null;
        }

        public static void ReiniciarJogo()
        {
            ContadorMovimento = 0;
            Hastes = new List<Haste>
            {
                new Haste(0),
                new Haste(1),
                new Haste(2)
            };

            /*
             * Ex: a quantidade de discos escolhida é 4, então é de 3 até 0 (3, 2, 1 e 0) para o vetor
             */
            for (int i = NumeroDeDiscos - 1; i >= 0; i--)
            {
                //cria os discos
                Disco disco = new Disco(i);
                
                //Colocar todos na primeira haste
                Hastes[0].AdicionarDisco(disco);
            }
        }

        public static void ReiniciarJogo(int numeroDeDiscos)
        {
            NumeroDeDiscos = numeroDeDiscos;
            ReiniciarJogo();
        }
        
        private static void CarregarImagensDeResources()
        {
            ListaImagens.Add(TorreHanoi.Properties.Resources.disco1);
            ListaImagens.Add(TorreHanoi.Properties.Resources.disco2);
            ListaImagens.Add(TorreHanoi.Properties.Resources.disco3);
            ListaImagens.Add(TorreHanoi.Properties.Resources.disco4);
            ListaImagens.Add(TorreHanoi.Properties.Resources.disco5);
            ListaImagens.Add(TorreHanoi.Properties.Resources.disco6);
        }
    }
}

