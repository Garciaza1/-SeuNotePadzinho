namespace MeuNotePadzinho
{
    partial class FrmPrincipal
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPrincipal));
            this.arquivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.novoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.abrirUmVelhoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salvarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.sairquerMesmoSairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copiarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.colarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.notasAbridasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.recortarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // arquivoToolStripMenuItem
            // 
            this.arquivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.novoToolStripMenuItem,
            this.toolStripSeparator1,
            this.abrirUmVelhoToolStripMenuItem,
            this.salvarToolStripMenuItem,
            this.toolStripSeparator2,
            this.sairquerMesmoSairToolStripMenuItem});
            this.arquivoToolStripMenuItem.Name = "arquivoToolStripMenuItem";
            this.arquivoToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.arquivoToolStripMenuItem.Text = "&Arquivo";
            // 
            // novoToolStripMenuItem
            // 
            this.novoToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("novoToolStripMenuItem.Image")));
            this.novoToolStripMenuItem.Name = "novoToolStripMenuItem";
            this.novoToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.novoToolStripMenuItem.Size = new System.Drawing.Size(236, 22);
            this.novoToolStripMenuItem.Text = "&Novo";
            this.novoToolStripMenuItem.Click += new System.EventHandler(this.novoToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(233, 6);
            // 
            // abrirUmVelhoToolStripMenuItem
            // 
            this.abrirUmVelhoToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("abrirUmVelhoToolStripMenuItem.Image")));
            this.abrirUmVelhoToolStripMenuItem.Name = "abrirUmVelhoToolStripMenuItem";
            this.abrirUmVelhoToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.abrirUmVelhoToolStripMenuItem.Size = new System.Drawing.Size(236, 22);
            this.abrirUmVelhoToolStripMenuItem.Text = "Abrir um velho";
            this.abrirUmVelhoToolStripMenuItem.Click += new System.EventHandler(this.abrirUmVelhoToolStripMenuItem_Click);
            // 
            // salvarToolStripMenuItem
            // 
            this.salvarToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("salvarToolStripMenuItem.Image")));
            this.salvarToolStripMenuItem.Name = "salvarToolStripMenuItem";
            this.salvarToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.salvarToolStripMenuItem.Size = new System.Drawing.Size(236, 22);
            this.salvarToolStripMenuItem.Text = "&Salvar";
            this.salvarToolStripMenuItem.Click += new System.EventHandler(this.salvarToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(233, 6);
            // 
            // sairquerMesmoSairToolStripMenuItem
            // 
            this.sairquerMesmoSairToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("sairquerMesmoSairToolStripMenuItem.Image")));
            this.sairquerMesmoSairToolStripMenuItem.Name = "sairquerMesmoSairToolStripMenuItem";
            this.sairquerMesmoSairToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.sairquerMesmoSairToolStripMenuItem.Size = new System.Drawing.Size(236, 22);
            this.sairquerMesmoSairToolStripMenuItem.Text = "Sa&r (quer mesmo sair?)";
            this.sairquerMesmoSairToolStripMenuItem.Click += new System.EventHandler(this.sairquerMesmoSairToolStripMenuItem_Click);
            // 
            // editarToolStripMenuItem
            // 
            this.editarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.copiarToolStripMenuItem,
            this.colarToolStripMenuItem,
            this.recortarToolStripMenuItem});
            this.editarToolStripMenuItem.Name = "editarToolStripMenuItem";
            this.editarToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
            this.editarToolStripMenuItem.Text = "&Editar";
            // 
            // copiarToolStripMenuItem
            // 
            this.copiarToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("copiarToolStripMenuItem.Image")));
            this.copiarToolStripMenuItem.Name = "copiarToolStripMenuItem";
            this.copiarToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.copiarToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.copiarToolStripMenuItem.Text = "&Copiar";
            this.copiarToolStripMenuItem.Click += new System.EventHandler(this.copiarToolStripMenuItem_Click);
            // 
            // colarToolStripMenuItem
            // 
            this.colarToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("colarToolStripMenuItem.Image")));
            this.colarToolStripMenuItem.Name = "colarToolStripMenuItem";
            this.colarToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.colarToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.colarToolStripMenuItem.Text = "C&olar";
            this.colarToolStripMenuItem.Click += new System.EventHandler(this.colarToolStripMenuItem_Click);
            // 
            // notasAbridasToolStripMenuItem
            // 
            this.notasAbridasToolStripMenuItem.Name = "notasAbridasToolStripMenuItem";
            this.notasAbridasToolStripMenuItem.Size = new System.Drawing.Size(93, 20);
            this.notasAbridasToolStripMenuItem.Text = "&Notas Abridas";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.arquivoToolStripMenuItem,
            this.editarToolStripMenuItem,
            this.notasAbridasToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.MdiWindowListItem = this.notasAbridasToolStripMenuItem;
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(771, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // recortarToolStripMenuItem
            // 
            this.recortarToolStripMenuItem.Name = "recortarToolStripMenuItem";
            this.recortarToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.recortarToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.recortarToolStripMenuItem.Text = "Recor&tar";
            this.recortarToolStripMenuItem.Click += new System.EventHandler(this.recortarToolStripMenuItem_Click);
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(771, 483);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmPrincipal";
            this.Text = "Seu NotePadzinho";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStripMenuItem arquivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem novoToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem abrirUmVelhoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salvarToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem sairquerMesmoSairToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copiarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem colarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem notasAbridasToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem recortarToolStripMenuItem;
    }
}

