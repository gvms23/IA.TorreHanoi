using System.Drawing;
using System.Windows.Forms;

namespace IA.TorreHanoi
{
    public class Disco : PictureBox
    {
        public int Numero { get; set; }

        public Disco(int numero) : base()
        {
            Numero = numero;
            Image = JogoAtual.ListaImagens[Numero];
            Size = Image.Size;
        }

        public void MovimentoParaHaste(Haste hasteDeDestino)
        {
            if (hasteDeDestino == null || hasteDeDestino.Discos == null)
            {
                return;
            }
            int numeroDeRungsOnSelectedHaste = hasteDeDestino.Discos.Count;         
            int x = (hasteDeDestino.Location.X + hasteDeDestino.Width) - (hasteDeDestino.Width / 2)  - (this.Size.Width / 2);
            int y = hasteDeDestino.Location.Y + hasteDeDestino.Size.Height - ((numeroDeRungsOnSelectedHaste + 1) * this.Size.Height) - TorreHanoi.Properties.Resources._base.Size.Height;
            this.Location = new Point(x, y);
        }

        public override string ToString()
        {
            return Numero.ToString();
        }

        public override bool Equals(object obj)
        {
            if (obj == null)
            {
                return false;
            }
         
            Disco disco = obj as Disco;
            if ((System.Object)disco == null)
            {
                return false;
            }
            return disco.Numero == Numero;
        }
    }
}

