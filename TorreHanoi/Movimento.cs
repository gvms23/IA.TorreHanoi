namespace IA.TorreHanoi
{
    public class Movimento
    {
        public Haste DeHaste { get; set; }
        public Haste ParaHaste { get; set; }

        public Movimento(Haste deHaste, Haste paraHaste)
        {
            this.DeHaste = deHaste;
            this.ParaHaste = paraHaste;
        }

        public bool EfeitoContagem()
        {
            //Se o disco não mudar de haste, não conta o movimento
            if (ParaHaste.Equals(DeHaste))
            {
                return false;
            }
            return EhValido();
        }            

        public bool EhValido()
        {
            //Todosow a movimento where the haste dont change
            if (ParaHaste.Equals(DeHaste))
            {
                return true;
            }
            return ParaHaste.PermitirDisco(DeHaste.RetornaDiscoDoTopo());
        }

        public Movimento(int deHasteNumero, int paraHasteNumero)
        {
            this.DeHaste = JogoAtual.Hastes[deHasteNumero];
            this.ParaHaste = JogoAtual.Hastes[paraHasteNumero];
        }

        override public string ToString()
        {
            if (DeHaste == null || ParaHaste == null)
            {
                return "Hastes Perdidas";
            }
            return "Movimento o disco do topo de " + DeHaste.ToString() + " para " + ParaHaste.ToString() + "\n";
        }

        public override bool Equals(object obj)
        {
            // Se o parâmetro é vazio, retorna falseo
            if (obj == null)
            {
                return false;
            }
            // Se o objeto não puder ser convertido para movimento, retorne falso
            Movimento movimento = obj as Movimento;
            if ((System.Object)movimento == null)
            {
                return false;
            }
            return movimento.DeHaste.Numero == movimento.DeHaste.Numero &&
                movimento.ParaHaste.Numero == movimento.ParaHaste.Numero;
        }
    }
}