using System.Reflection;
using System.Windows.Forms;

namespace Editor_de_Grafos
{
    partial class Editor
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
            if(disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.arquivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.BtNovo = new System.Windows.Forms.ToolStripMenuItem();
            this.BtAbrir = new System.Windows.Forms.ToolStripMenuItem();
            this.BtSalvar = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.BtSair = new System.Windows.Forms.ToolStripMenuItem();
            this.algoritmosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.BtGrafoEuleriano = new System.Windows.Forms.ToolStripMenuItem();
            this.BtGrafoUnicursal = new System.Windows.Forms.ToolStripMenuItem();
            this.BtParesOrd = new System.Windows.Forms.ToolStripMenuItem();
            this.profundidadeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.larguraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.éÁrvoreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.árvoreGeradoraMínimaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.caminhoMínimoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.númeroCromáticoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ferramentasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.BtPeso = new System.Windows.Forms.ToolStripMenuItem();
            this.BtPesoAleatorio = new System.Windows.Forms.ToolStripMenuItem();
            this.completarGrafoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.BtSobre = new System.Windows.Forms.ToolStripMenuItem();
            this.lIMPARGRAFOToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.OPFile = new System.Windows.Forms.OpenFileDialog();
            this.SVFile = new System.Windows.Forms.SaveFileDialog();
            this.g = new Editor_de_Grafos.Grafo();
            this.destino = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.Control;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.arquivoToolStripMenuItem,
            this.algoritmosToolStripMenuItem,
            this.ferramentasToolStripMenuItem,
            this.sToolStripMenuItem,
            this.lIMPARGRAFOToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(631, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // arquivoToolStripMenuItem
            // 
            this.arquivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.BtNovo,
            this.BtAbrir,
            this.BtSalvar,
            this.toolStripSeparator1,
            this.BtSair});
            this.arquivoToolStripMenuItem.Name = "arquivoToolStripMenuItem";
            this.arquivoToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.arquivoToolStripMenuItem.Text = "&Arquivo";
            // 
            // BtNovo
            // 
            this.BtNovo.Name = "BtNovo";
            this.BtNovo.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.BtNovo.Size = new System.Drawing.Size(146, 22);
            this.BtNovo.Text = "Novo";
            this.BtNovo.Click += new System.EventHandler(this.BtNovo_Click);
            // 
            // BtAbrir
            // 
            this.BtAbrir.Name = "BtAbrir";
            this.BtAbrir.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.BtAbrir.Size = new System.Drawing.Size(146, 22);
            this.BtAbrir.Text = "Abrir";
            this.BtAbrir.Click += new System.EventHandler(this.BtAbrir_Click);
            // 
            // BtSalvar
            // 
            this.BtSalvar.Name = "BtSalvar";
            this.BtSalvar.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.BtSalvar.Size = new System.Drawing.Size(146, 22);
            this.BtSalvar.Text = "Salvar";
            this.BtSalvar.Click += new System.EventHandler(this.BtSalvar_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(143, 6);
            // 
            // BtSair
            // 
            this.BtSair.Name = "BtSair";
            this.BtSair.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.X)));
            this.BtSair.Size = new System.Drawing.Size(146, 22);
            this.BtSair.Text = "Sair";
            this.BtSair.Click += new System.EventHandler(this.BtSair_Click);
            // 
            // algoritmosToolStripMenuItem
            // 
            this.algoritmosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.BtGrafoEuleriano,
            this.BtGrafoUnicursal,
            this.BtParesOrd,
            this.profundidadeToolStripMenuItem,
            this.larguraToolStripMenuItem,
            this.éÁrvoreToolStripMenuItem,
            this.árvoreGeradoraMínimaToolStripMenuItem,
            this.caminhoMínimoToolStripMenuItem,
            this.númeroCromáticoToolStripMenuItem});
            this.algoritmosToolStripMenuItem.Name = "algoritmosToolStripMenuItem";
            this.algoritmosToolStripMenuItem.Size = new System.Drawing.Size(78, 20);
            this.algoritmosToolStripMenuItem.Text = "&Algoritmos";
            // 
            // BtGrafoEuleriano
            // 
            this.BtGrafoEuleriano.Name = "BtGrafoEuleriano";
            this.BtGrafoEuleriano.Size = new System.Drawing.Size(203, 22);
            this.BtGrafoEuleriano.Text = "Grafo Euleriano";
            this.BtGrafoEuleriano.Click += new System.EventHandler(this.BtGrafoEuleriano_Click);
            // 
            // BtGrafoUnicursal
            // 
            this.BtGrafoUnicursal.Name = "BtGrafoUnicursal";
            this.BtGrafoUnicursal.Size = new System.Drawing.Size(203, 22);
            this.BtGrafoUnicursal.Text = "Grafo Unicursal";
            this.BtGrafoUnicursal.Click += new System.EventHandler(this.BtGrafoUnicursal_Click);
            // 
            // BtParesOrd
            // 
            this.BtParesOrd.Name = "BtParesOrd";
            this.BtParesOrd.Size = new System.Drawing.Size(203, 22);
            this.BtParesOrd.Text = "Pares Ordenados";
            this.BtParesOrd.Click += new System.EventHandler(this.BtParesOrd_Click);
            // 
            // profundidadeToolStripMenuItem
            // 
            this.profundidadeToolStripMenuItem.Name = "profundidadeToolStripMenuItem";
            this.profundidadeToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            this.profundidadeToolStripMenuItem.Text = "Profundidade";
            this.profundidadeToolStripMenuItem.Click += new System.EventHandler(this.profundidadeToolStripMenuItem_Click);
            // 
            // larguraToolStripMenuItem
            // 
            this.larguraToolStripMenuItem.Name = "larguraToolStripMenuItem";
            this.larguraToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            this.larguraToolStripMenuItem.Text = "Largura";
            this.larguraToolStripMenuItem.Click += new System.EventHandler(this.larguraToolStripMenuItem_Click);
            // 
            // éÁrvoreToolStripMenuItem
            // 
            this.éÁrvoreToolStripMenuItem.Name = "éÁrvoreToolStripMenuItem";
            this.éÁrvoreToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            this.éÁrvoreToolStripMenuItem.Text = "É árvore";
            this.éÁrvoreToolStripMenuItem.Click += new System.EventHandler(this.éÁrvoreToolStripMenuItem_Click);
            // 
            // árvoreGeradoraMínimaToolStripMenuItem
            // 
            this.árvoreGeradoraMínimaToolStripMenuItem.Name = "árvoreGeradoraMínimaToolStripMenuItem";
            this.árvoreGeradoraMínimaToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            this.árvoreGeradoraMínimaToolStripMenuItem.Text = "Árvore geradora mínima";
            this.árvoreGeradoraMínimaToolStripMenuItem.Click += new System.EventHandler(this.árvoreGeradoraMínimaToolStripMenuItem_Click);
            // 
            // caminhoMínimoToolStripMenuItem
            // 
            this.caminhoMínimoToolStripMenuItem.Name = "caminhoMínimoToolStripMenuItem";
            this.caminhoMínimoToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            this.caminhoMínimoToolStripMenuItem.Text = "Caminho mínimo";
            this.caminhoMínimoToolStripMenuItem.Click += new System.EventHandler(this.caminhoMínimoToolStripMenuItem_Click);
            // 
            // númeroCromáticoToolStripMenuItem
            // 
            this.númeroCromáticoToolStripMenuItem.Name = "númeroCromáticoToolStripMenuItem";
            this.númeroCromáticoToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            this.númeroCromáticoToolStripMenuItem.Text = "Número cromático";
            this.númeroCromáticoToolStripMenuItem.Click += new System.EventHandler(this.númeroCromáticoToolStripMenuItem_Click);
            // 
            // ferramentasToolStripMenuItem
            // 
            this.ferramentasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.BtPeso,
            this.BtPesoAleatorio,
            this.completarGrafoToolStripMenuItem});
            this.ferramentasToolStripMenuItem.Name = "ferramentasToolStripMenuItem";
            this.ferramentasToolStripMenuItem.Size = new System.Drawing.Size(84, 20);
            this.ferramentasToolStripMenuItem.Tag = "";
            this.ferramentasToolStripMenuItem.Text = "&Ferramentas";
            // 
            // BtPeso
            // 
            this.BtPeso.Name = "BtPeso";
            this.BtPeso.Size = new System.Drawing.Size(191, 22);
            this.BtPeso.Text = "Exibir Pesos";
            this.BtPeso.Click += new System.EventHandler(this.BtPeso_Click);
            // 
            // BtPesoAleatorio
            // 
            this.BtPesoAleatorio.Name = "BtPesoAleatorio";
            this.BtPesoAleatorio.Size = new System.Drawing.Size(191, 22);
            this.BtPesoAleatorio.Text = "Gerar Pesos Aleatorios";
            this.BtPesoAleatorio.Click += new System.EventHandler(this.BtPesoAleatorio_Click);
            // 
            // completarGrafoToolStripMenuItem
            // 
            this.completarGrafoToolStripMenuItem.Name = "completarGrafoToolStripMenuItem";
            this.completarGrafoToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.completarGrafoToolStripMenuItem.Text = "Completar Grafo";
            this.completarGrafoToolStripMenuItem.Click += new System.EventHandler(this.completarGrafoToolStripMenuItem_Click);
            // 
            // sToolStripMenuItem
            // 
            this.sToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.BtSobre});
            this.sToolStripMenuItem.Name = "sToolStripMenuItem";
            this.sToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.sToolStripMenuItem.Text = "Ajuda";
            // 
            // BtSobre
            // 
            this.BtSobre.Name = "BtSobre";
            this.BtSobre.ShortcutKeys = System.Windows.Forms.Keys.F1;
            this.BtSobre.Size = new System.Drawing.Size(123, 22);
            this.BtSobre.Text = "Sobre";
            this.BtSobre.Click += new System.EventHandler(this.BtSobre_Click);
            // 
            // lIMPARGRAFOToolStripMenuItem
            // 
            this.lIMPARGRAFOToolStripMenuItem.Name = "lIMPARGRAFOToolStripMenuItem";
            this.lIMPARGRAFOToolStripMenuItem.Size = new System.Drawing.Size(101, 20);
            this.lIMPARGRAFOToolStripMenuItem.Text = "LIMPAR GRAFO";
            this.lIMPARGRAFOToolStripMenuItem.Click += new System.EventHandler(this.lIMPARGRAFOToolStripMenuItem_Click);
            // 
            // OPFile
            // 
            this.OPFile.DefaultExt = "*.grf";
            this.OPFile.Filter = "Grafo Files|*.grf";
            this.OPFile.Title = "Selecione o Arquivo do Grafo";
            // 
            // SVFile
            // 
            this.SVFile.DefaultExt = "*.grf";
            this.SVFile.Filter = "Grafo Files|*.grf";
            this.SVFile.Title = "Defina local para salvar";
            // 
            // g
            // 
            this.g.AutoScroll = true;
            this.g.Dock = System.Windows.Forms.DockStyle.Fill;
            this.g.Location = new System.Drawing.Point(0, 24);
            this.g.Name = "g";
            this.g.Size = new System.Drawing.Size(631, 401);
            this.g.TabIndex = 1;
            // 
            // destino
            // 
            this.destino.Location = new System.Drawing.Point(563, 4);
            this.destino.Name = "destino";
            this.destino.Size = new System.Drawing.Size(56, 20);
            this.destino.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(380, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(177, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Digite o rótulo do vértice de destino:";
            // 
            // Editor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(631, 425);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.destino);
            this.Controls.Add(this.g);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Editor";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Editor de Grafos - 2021/1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem arquivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem BtNovo;
        private System.Windows.Forms.ToolStripMenuItem BtAbrir;
        private System.Windows.Forms.ToolStripMenuItem BtSalvar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem BtSair;
        private System.Windows.Forms.ToolStripMenuItem algoritmosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ferramentasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem BtParesOrd;
        private System.Windows.Forms.ToolStripMenuItem BtGrafoEuleriano;
        private System.Windows.Forms.ToolStripMenuItem BtGrafoUnicursal;
        private System.Windows.Forms.ToolStripMenuItem BtPeso;
        private System.Windows.Forms.ToolStripMenuItem BtPesoAleatorio;
        private System.Windows.Forms.ToolStripMenuItem BtSobre;
        public Grafo g;
        private System.Windows.Forms.OpenFileDialog OPFile;
        private SaveFileDialog SVFile;
        private ToolStripMenuItem completarGrafoToolStripMenuItem;
        private ToolStripMenuItem profundidadeToolStripMenuItem;
        private ToolStripMenuItem larguraToolStripMenuItem;
        private ToolStripMenuItem éÁrvoreToolStripMenuItem;
        private ToolStripMenuItem lIMPARGRAFOToolStripMenuItem;
        private ToolStripMenuItem árvoreGeradoraMínimaToolStripMenuItem;
        private ToolStripMenuItem caminhoMínimoToolStripMenuItem;
        private ToolStripMenuItem númeroCromáticoToolStripMenuItem;
        private TextBox destino;
        private Label label1;
    }
}

