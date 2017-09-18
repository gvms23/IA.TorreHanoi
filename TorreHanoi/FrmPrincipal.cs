using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Threading;

namespace IA.TorreHanoi
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
            this.AllowDrop = true;
        }
        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            ReiniciarJogo();
        }

        void ThisBox_ArrastarSoltar(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;
        }

        void ThisBox_QueryContinueDrag(object sender, QueryContinueDragEventArgs e)
        {
            Disco disco = (Disco)sender;
            disco.Location = new Point(Cursor.Position.X - this.Location.X - (disco.Size.Height / 2),
                                             Cursor.Position.Y - this.Location.Y - (disco.Size.Width / 2));

            if (e.Action == DragAction.Drop)
            {
                int numeroDaHasteDeDestino = DeterminarHasteDaPosicaoDoCursor();
                Haste hasteAtual = JogoAtual.EncontrarDisco(disco);
                Movimento movimento = new Movimento(hasteAtual, JogoAtual.Hastes[numeroDaHasteDeDestino]);

                if (movimento.EhValido())
                {
                    EfetuarMovimento(movimento);
                }
                else
                {
                    Movimento moverDeVolta = new Movimento(hasteAtual, hasteAtual);
                    JogoAtual.EfetuarMovimento(moverDeVolta);
                }
            }
        }

        private void EfetuarMovimento(Movimento movimento)
        {
            int movimentoCount = JogoAtual.EfetuarMovimento(movimento);
            movimentoCounter.Text = movimentoCount.ToString();
            if (JogoAtual.EstaResolvido())
            {   
                possivelDeResolver.Text = "Show, resolvido! =) ";
            }
        }

        private void Disco_MouseDown(object sender, MouseEventArgs e)
        {
            Disco disco = (Disco)sender;
            Haste haste = JogoAtual.EncontrarDisco(disco);

            //Checar se o disco é o do topo
            if (!haste.RetornaDiscoDoTopo().Equals(disco))
            {
                return;
            }
            disco.DoDragDrop(disco, DragDropEffects.All);
        }

        private Point RetornaPosicaoDoMouse()  {
            return new Point(Cursor.Position.X - this.Location.X, Cursor.Position.Y - this.Location.Y);
        }

        //Para ver onde o indivíduo está jogando o disco, pegando a haste próxima do cursor
        private int DeterminarHasteDaPosicaoDoCursor()
        {
            Point PosicaoDoMouse = RetornaPosicaoDoMouse();
            if (PosicaoDoMouse.X < JogoAtual.Hastes[0].Location.X)
                return 0;
            if (PosicaoDoMouse.X > JogoAtual.Hastes[1].Location.X - 60 && PosicaoDoMouse.X < JogoAtual.Hastes[2].Location.X - 60)
                return 1;
            if (PosicaoDoMouse.X > JogoAtual.Hastes[2].Location.X - 60 && PosicaoDoMouse.X < JogoAtual.Hastes[2].Location.X + ConstantesJogo.EspacoEntreHastes)
                return 2;
            //Usar haste 0 como padrão
            return 0;
        }

        private void ItemMenuQuantidade_Click(object sender, EventArgs e)
        {
            ToolStripDropDownItem Item = sender as ToolStripDropDownItem;
            ReiniciarJogo(Convert.ToInt16(Item.Text));
        }

        private void Form2_DragOver(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.All;
        }

        private void ItemMenuMostrarSolucao_Click(object sender, EventArgs e)
        {
            ResolverJogo();
        }

        private void ItemMenuReiniciar_Click(object sender, EventArgs e)
        {
            ReiniciarJogo();
        }

        private void ResolverJogo()
        {
           // this.Enabled = false;
            List<Movimento> movimentos = CalculoMovimento.RetornaMovimentos(JogoAtual.NumeroDeDiscos);
            rTxtDicas.Visible = true;
            rTxtDicas.Text = string.Empty;
            rTxtDicas.Text = Properties.Resources.TextoSugestoes;
            foreach (Movimento movimento in movimentos)
            {
                rTxtDicas.Text += movimento.ToString();
                EfetuarMovimento(movimento);
                Application.DoEvents();
                System.Threading.Thread.Sleep(1000);
            }
            this.Enabled = true;
        }

        private void ReiniciarJogo(int numeroDeDiscos)
        {
            JogoAtual.NumeroDeDiscos = numeroDeDiscos;
            ReiniciarJogo();
        }

        private void ReiniciarJogo()
        {
            RemoverTodosDiscos();
            JogoAtual.ReiniciarJogo();
            AddComponents();
            rTxtDicas.Text = "";
            rTxtDicas.Visible = false;
            movimentoCounter.Text = JogoAtual.ContadorMovimento.ToString();
            possivelDeResolver.Text = "É possível resolver esse jogo com " + CalculoMovimento.RetornaContadorMovimentos(JogoAtual.NumeroDeDiscos).ToString() + " movimentos.";
        }

        private void RemoverTodosDiscos()
        {
            foreach (Haste haste in JogoAtual.Hastes)
            {
                foreach (Disco disco in haste.Discos.Values)
                {
                    this.Controls.Remove(disco);
                }
            }
        }

        private void AddComponents()
        {
            PictureBox _base = new PictureBox()
            {
                Image = TorreHanoi.Properties.Resources._base,
                Size = TorreHanoi.Properties.Resources._base.Size,
                BackColor = SystemColors.ControlDarkDark,
                Location = new Point(ConstantesJogo.BaseInicioPosicaoX, ConstantesJogo.BaseInicioPosicaoY)
            };
            this.Controls.Add(_base);
            
            movimentoCounter.Text = JogoAtual.ContadorMovimento.ToString();
            
            foreach (Haste haste in JogoAtual.Hastes)
            {
                InserirHaste(haste);
                foreach (Disco disco in haste.Discos.Values)
                {
                    InserirDisco(disco);
                }
            }
        }

        private void InserirHaste(Haste haste)
        {
            if (!this.Controls.Contains(haste))
            {
                this.Controls.Add(haste);
            }
        }

        private void InserirDisco(Disco disco)
        {
            if (!this.Controls.Contains(disco))
            {
                disco.MouseDown += new MouseEventHandler(Disco_MouseDown);
                disco.QueryContinueDrag += new QueryContinueDragEventHandler(ThisBox_QueryContinueDrag);
                disco.DragDrop += new DragEventHandler(ThisBox_ArrastarSoltar);
                this.Controls.Add(disco);
                this.Controls.SetChildIndex(disco, 0);
            }
        }

        private void FrmPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }

        private void desenvolvidoPorGabrielVicenteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }
    }
}