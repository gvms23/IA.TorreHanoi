using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace IA.TorreHanoi
{
    public class Haste : PictureBox
    {
        public SortedList<int, Disco> Discos { get; set; }
        public int Numero { get; set; }

        public Haste(int numero)
        {
            Discos = new SortedList<int, Disco>();
            this.Numero = numero;
            this.Image = TorreHanoi.Properties.Resources.haste;
            this.Size = TorreHanoi.Properties.Resources.haste.Size;
            int PosicaoX = ConstantesJogo.BaseInicioPosicaoX + ((numero + 1) * ConstantesJogo.EspacoEntreHastes);
            int PosicaoY = ConstantesJogo.BaseInicioPosicaoY + TorreHanoi.Properties.Resources._base.Size.Height - this.Size.Height;
            this.Location = new Point(PosicaoX, PosicaoY);
        }

        public bool EstaVazio()
        {
            return Discos.Count == 0;
        }

        public bool PermitirDisco(Disco disco)
        {
            if (disco == null)
            {
                return false;
            }
            if (Discos.Count == 0)
            {
                return true;
            }
            return RetornaDiscoDoTopo().Numero > disco.Numero;
        }

        public Disco RetornaDiscoDoTopo()
        {
            if (Discos.Count > 0)
            {
                return Discos.First().Value;
            }
            return null;
        }

        public void RemoverDisco()
        {
            Discos.Remove(Discos.First().Key);
        }

        public void AdicionarDisco(Disco disco)
        {
            if (disco == null)
            {
                return;
            }
            if (PermitirDisco(disco))
            {
                disco.MovimentoParaHaste(this);
                Discos.Add(disco.Numero, disco);
            }
        }

        override public string ToString()
        {
            return Convert.ToString(Numero);
        }

        public override bool Equals(object obj)
        {
            if (obj == null)
            {
                return false;
            }

            Haste haste = obj as Haste;
            if ((System.Object)haste == null)
            {
                return false;
            }
            return haste.Numero == Numero;
        }
    }
}

