namespace IA.TorreHanoi
{
	partial class FrmPrincipal
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents de this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPrincipal));
            this.menuOpcoesJogo = new System.Windows.Forms.MenuStrip();
            this.menuPaiOpcoesJogo = new System.Windows.Forms.ToolStripMenuItem();
            this.itemMenuQuantidadeDiscos = new System.Windows.Forms.ToolStripMenuItem();
            this.ItemMenuQuantidade3 = new System.Windows.Forms.ToolStripMenuItem();
            this.ItemMenuQuantidade4 = new System.Windows.Forms.ToolStripMenuItem();
            this.ItemMenuQuantidade5 = new System.Windows.Forms.ToolStripMenuItem();
            this.ItemMenuQuantidade6 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemMostrarSolucao = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemReiniciar = new System.Windows.Forms.ToolStripMenuItem();
            this.desenvolvidoPorGabrielVicenteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusMovimento = new System.Windows.Forms.StatusStrip();
            this.movimentoCounterLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.movimentoCounter = new System.Windows.Forms.ToolStripStatusLabel();
            this.possivelDeResolver = new System.Windows.Forms.ToolStripStatusLabel();
            this.rTxtDicas = new System.Windows.Forms.RichTextBox();
            this.menuOpcoesJogo.SuspendLayout();
            this.statusMovimento.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuOpcoesJogo
            // 
            this.menuOpcoesJogo.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuPaiOpcoesJogo,
            this.desenvolvidoPorGabrielVicenteToolStripMenuItem});
            this.menuOpcoesJogo.Location = new System.Drawing.Point(0, 0);
            this.menuOpcoesJogo.Name = "menuOpcoesJogo";
            this.menuOpcoesJogo.Size = new System.Drawing.Size(992, 24);
            this.menuOpcoesJogo.TabIndex = 0;
            this.menuOpcoesJogo.Text = "menuStrip1";
            // 
            // menuPaiOpcoesJogo
            // 
            this.menuPaiOpcoesJogo.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.itemMenuQuantidadeDiscos,
            this.menuItemMostrarSolucao,
            this.menuItemReiniciar});
            this.menuPaiOpcoesJogo.Name = "menuPaiOpcoesJogo";
            this.menuPaiOpcoesJogo.Size = new System.Drawing.Size(103, 20);
            this.menuPaiOpcoesJogo.Text = "Opções de Jogo";
            // 
            // itemMenuQuantidadeDiscos
            // 
            this.itemMenuQuantidadeDiscos.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ItemMenuQuantidade3,
            this.ItemMenuQuantidade4,
            this.ItemMenuQuantidade5,
            this.ItemMenuQuantidade6});
            this.itemMenuQuantidadeDiscos.Name = "itemMenuQuantidadeDiscos";
            this.itemMenuQuantidadeDiscos.Size = new System.Drawing.Size(189, 22);
            this.itemMenuQuantidadeDiscos.Text = "Quantidade de Discos";
            // 
            // ItemMenuQuantidade3
            // 
            this.ItemMenuQuantidade3.Name = "ItemMenuQuantidade3";
            this.ItemMenuQuantidade3.Size = new System.Drawing.Size(80, 22);
            this.ItemMenuQuantidade3.Text = "3";
            this.ItemMenuQuantidade3.Click += new System.EventHandler(this.ItemMenuQuantidade_Click);
            // 
            // ItemMenuQuantidade4
            // 
            this.ItemMenuQuantidade4.Name = "ItemMenuQuantidade4";
            this.ItemMenuQuantidade4.Size = new System.Drawing.Size(80, 22);
            this.ItemMenuQuantidade4.Text = "4";
            this.ItemMenuQuantidade4.Click += new System.EventHandler(this.ItemMenuQuantidade_Click);
            // 
            // ItemMenuQuantidade5
            // 
            this.ItemMenuQuantidade5.Name = "ItemMenuQuantidade5";
            this.ItemMenuQuantidade5.Size = new System.Drawing.Size(80, 22);
            this.ItemMenuQuantidade5.Text = "5";
            this.ItemMenuQuantidade5.Click += new System.EventHandler(this.ItemMenuQuantidade_Click);
            // 
            // ItemMenuQuantidade6
            // 
            this.ItemMenuQuantidade6.Name = "ItemMenuQuantidade6";
            this.ItemMenuQuantidade6.Size = new System.Drawing.Size(80, 22);
            this.ItemMenuQuantidade6.Text = "6";
            this.ItemMenuQuantidade6.Click += new System.EventHandler(this.ItemMenuQuantidade_Click);
            // 
            // menuItemMostrarSolucao
            // 
            this.menuItemMostrarSolucao.Name = "menuItemMostrarSolucao";
            this.menuItemMostrarSolucao.Size = new System.Drawing.Size(189, 22);
            this.menuItemMostrarSolucao.Text = "Mostrar solução";
            this.menuItemMostrarSolucao.Click += new System.EventHandler(this.ItemMenuMostrarSolucao_Click);
            // 
            // menuItemReiniciar
            // 
            this.menuItemReiniciar.Name = "menuItemReiniciar";
            this.menuItemReiniciar.Size = new System.Drawing.Size(189, 22);
            this.menuItemReiniciar.Text = "Reiniciar";
            this.menuItemReiniciar.Click += new System.EventHandler(this.ItemMenuReiniciar_Click);
            // 
            // desenvolvidoPorGabrielVicenteToolStripMenuItem
            // 
            this.desenvolvidoPorGabrielVicenteToolStripMenuItem.Name = "desenvolvidoPorGabrielVicenteToolStripMenuItem";
            this.desenvolvidoPorGabrielVicenteToolStripMenuItem.Size = new System.Drawing.Size(270, 20);
            this.desenvolvidoPorGabrielVicenteToolStripMenuItem.Text = "Desenvolvido por <gvms23> e <recheter220> ;)";
            this.desenvolvidoPorGabrielVicenteToolStripMenuItem.Click += new System.EventHandler(this.desenvolvidoPorGabrielVicenteToolStripMenuItem_Click);
            // 
            // statusMovimento
            // 
            this.statusMovimento.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.movimentoCounterLabel,
            this.movimentoCounter,
            this.possivelDeResolver});
            this.statusMovimento.Location = new System.Drawing.Point(0, 357);
            this.statusMovimento.Name = "statusMovimento";
            this.statusMovimento.Size = new System.Drawing.Size(992, 22);
            this.statusMovimento.TabIndex = 8;
            this.statusMovimento.Text = "statusStrip1";
            // 
            // movimentoCounterLabel
            // 
            this.movimentoCounterLabel.Name = "movimentoCounterLabel";
            this.movimentoCounterLabel.Size = new System.Drawing.Size(77, 17);
            this.movimentoCounterLabel.Text = "Movimentos:";
            // 
            // movimentoCounter
            // 
            this.movimentoCounter.Name = "movimentoCounter";
            this.movimentoCounter.Size = new System.Drawing.Size(0, 17);
            // 
            // possivelDeResolver
            // 
            this.possivelDeResolver.Name = "possivelDeResolver";
            this.possivelDeResolver.Size = new System.Drawing.Size(0, 17);
            // 
            // rTxtDicas
            // 
            this.rTxtDicas.Dock = System.Windows.Forms.DockStyle.Right;
            this.rTxtDicas.Location = new System.Drawing.Point(838, 24);
            this.rTxtDicas.Name = "rTxtDicas";
            this.rTxtDicas.Size = new System.Drawing.Size(154, 333);
            this.rTxtDicas.TabIndex = 9;
            this.rTxtDicas.Text = "";
            this.rTxtDicas.Visible = false;
            // 
            // FrmPrincipal
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(992, 379);
            this.Controls.Add(this.rTxtDicas);
            this.Controls.Add(this.statusMovimento);
            this.Controls.Add(this.menuOpcoesJogo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuOpcoesJogo;
            this.MinimumSize = new System.Drawing.Size(1008, 418);
            this.Name = "FrmPrincipal";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "IA | Torre de Hanói";
            this.TopMost = true;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmPrincipal_FormClosing);
            this.Load += new System.EventHandler(this.FrmPrincipal_Load);
            this.DragOver += new System.Windows.Forms.DragEventHandler(this.Form2_DragOver);
            this.menuOpcoesJogo.ResumeLayout(false);
            this.menuOpcoesJogo.PerformLayout();
            this.statusMovimento.ResumeLayout(false);
            this.statusMovimento.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

        private System.Windows.Forms.MenuStrip menuOpcoesJogo;
        private System.Windows.Forms.ToolStripMenuItem menuPaiOpcoesJogo;
        private System.Windows.Forms.ToolStripMenuItem itemMenuQuantidadeDiscos;
        private System.Windows.Forms.ToolStripMenuItem ItemMenuQuantidade3;
        private System.Windows.Forms.ToolStripMenuItem ItemMenuQuantidade4;
        private System.Windows.Forms.ToolStripMenuItem ItemMenuQuantidade5;
        private System.Windows.Forms.ToolStripMenuItem ItemMenuQuantidade6;
        private System.Windows.Forms.ToolStripMenuItem menuItemMostrarSolucao;
        private System.Windows.Forms.ToolStripMenuItem menuItemReiniciar;
        private System.Windows.Forms.StatusStrip statusMovimento;
        private System.Windows.Forms.ToolStripStatusLabel movimentoCounterLabel;
        private System.Windows.Forms.ToolStripStatusLabel movimentoCounter;
        private System.Windows.Forms.ToolStripStatusLabel possivelDeResolver;
        private System.Windows.Forms.RichTextBox rTxtDicas;
        private System.Windows.Forms.ToolStripMenuItem desenvolvidoPorGabrielVicenteToolStripMenuItem;
    }
}