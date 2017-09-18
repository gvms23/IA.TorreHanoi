namespace IA.TorreHanoi
{
    public class Configuracao
    {
        public int HasteInicio {get; set;}
        public int HasteFim { get; set; }
        public int QuantidadeDeDiscos { get; set; }

        public Configuracao(int hasteInicio, int hasteFim, int quantidadeDeDiscos)
        {
            HasteInicio = hasteInicio;
            HasteFim = hasteFim;
            QuantidadeDeDiscos = quantidadeDeDiscos;

        }

    }
}
