namespace MyNotepad
{
    partial class Form1
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuFicheiro = new System.Windows.Forms.ToolStripMenuItem();
            this.menuFicheiroNovo = new System.Windows.Forms.ToolStripMenuItem();
            this.menuFicheiroAbrir = new System.Windows.Forms.ToolStripMenuItem();
            this.menuFicheiroGuardar = new System.Windows.Forms.ToolStripMenuItem();
            this.menuFicheiroSair = new System.Windows.Forms.ToolStripMenuItem();
            this.menuEditar = new System.Windows.Forms.ToolStripMenuItem();
            this.menuEditarCortar = new System.Windows.Forms.ToolStripMenuItem();
            this.menuEditarCopiar = new System.Windows.Forms.ToolStripMenuItem();
            this.menuEditarColar = new System.Windows.Forms.ToolStripMenuItem();
            this.menuEditarSelecionarTudo = new System.Windows.Forms.ToolStripMenuItem();
            this.menuEditarProcurar = new System.Windows.Forms.ToolStripMenuItem();
            this.menuFormatar = new System.Windows.Forms.ToolStripMenuItem();
            this.menuFormatarLetra = new System.Windows.Forms.ToolStripMenuItem();
            this.menoFormatarCores = new System.Windows.Forms.ToolStripMenuItem();
            this.menoFormatarCoresLetra = new System.Windows.Forms.ToolStripMenuItem();
            this.menuFormatarCoresFundos = new System.Windows.Forms.ToolStripMenuItem();
            this.menuFormatarAlinhamentos = new System.Windows.Forms.ToolStripMenuItem();
            this.menuFormatarAlinhamentosEsquerda = new System.Windows.Forms.ToolStripMenuItem();
            this.menuFormatarAlinhamentosCentro = new System.Windows.Forms.ToolStripMenuItem();
            this.menuFormatarAlinhamentosDireito = new System.Windows.Forms.ToolStripMenuItem();
            this.rbTexto = new System.Windows.Forms.RichTextBox();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuFicheiro,
            this.menuEditar,
            this.menuFormatar});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(784, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuFicheiro
            // 
            this.menuFicheiro.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuFicheiroNovo,
            this.menuFicheiroAbrir,
            this.menuFicheiroGuardar,
            this.menuFicheiroSair});
            this.menuFicheiro.Image = global::MyNotepad.Properties.Resources.Data_Filing_Cabinet_icon;
            this.menuFicheiro.Name = "menuFicheiro";
            this.menuFicheiro.Size = new System.Drawing.Size(77, 20);
            this.menuFicheiro.Text = "Ficheiro";
            this.menuFicheiro.Click += new System.EventHandler(this.menuFicheiro_Click);
            // 
            // menuFicheiroNovo
            // 
            this.menuFicheiroNovo.Image = global::MyNotepad.Properties.Resources.Document_Blank_icon;
            this.menuFicheiroNovo.Name = "menuFicheiroNovo";
            this.menuFicheiroNovo.Size = new System.Drawing.Size(180, 22);
            this.menuFicheiroNovo.Text = "Novo";
            this.menuFicheiroNovo.Click += new System.EventHandler(this.menuFicheiroNovo_Click);
            // 
            // menuFicheiroAbrir
            // 
            this.menuFicheiroAbrir.Image = global::MyNotepad.Properties.Resources.Documents_icon;
            this.menuFicheiroAbrir.Name = "menuFicheiroAbrir";
            this.menuFicheiroAbrir.Size = new System.Drawing.Size(180, 22);
            this.menuFicheiroAbrir.Text = "Abrir";
            this.menuFicheiroAbrir.Click += new System.EventHandler(this.menuFicheiroAbrir_Click);
            // 
            // menuFicheiroGuardar
            // 
            this.menuFicheiroGuardar.Image = global::MyNotepad.Properties.Resources.Actions_document_save_icon;
            this.menuFicheiroGuardar.Name = "menuFicheiroGuardar";
            this.menuFicheiroGuardar.Size = new System.Drawing.Size(180, 22);
            this.menuFicheiroGuardar.Text = "Guardar";
            this.menuFicheiroGuardar.Click += new System.EventHandler(this.menuFicheiroGuardar_Click);
            // 
            // menuFicheiroSair
            // 
            this.menuFicheiroSair.Image = global::MyNotepad.Properties.Resources.Actions_process_stop_icon;
            this.menuFicheiroSair.Name = "menuFicheiroSair";
            this.menuFicheiroSair.Size = new System.Drawing.Size(180, 22);
            this.menuFicheiroSair.Text = "Sair";
            this.menuFicheiroSair.Click += new System.EventHandler(this.menuFicheiroSair_Click);
            // 
            // menuEditar
            // 
            this.menuEditar.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuEditarCortar,
            this.menuEditarCopiar,
            this.menuEditarColar,
            this.menuEditarSelecionarTudo,
            this.menuEditarProcurar});
            this.menuEditar.Image = global::MyNotepad.Properties.Resources.Pencil_icon;
            this.menuEditar.Name = "menuEditar";
            this.menuEditar.Size = new System.Drawing.Size(65, 20);
            this.menuEditar.Text = "Editar";
            // 
            // menuEditarCortar
            // 
            this.menuEditarCortar.Image = global::MyNotepad.Properties.Resources.cut_icon;
            this.menuEditarCortar.Name = "menuEditarCortar";
            this.menuEditarCortar.Size = new System.Drawing.Size(180, 22);
            this.menuEditarCortar.Text = "Cortar";
            this.menuEditarCortar.Click += new System.EventHandler(this.menuEditarCortar_Click);
            // 
            // menuEditarCopiar
            // 
            this.menuEditarCopiar.Image = global::MyNotepad.Properties.Resources.copy_icon;
            this.menuEditarCopiar.Name = "menuEditarCopiar";
            this.menuEditarCopiar.Size = new System.Drawing.Size(180, 22);
            this.menuEditarCopiar.Text = "Copiar";
            this.menuEditarCopiar.Click += new System.EventHandler(this.menuEditarCopiar_Click);
            // 
            // menuEditarColar
            // 
            this.menuEditarColar.Image = global::MyNotepad.Properties.Resources.paste_icon;
            this.menuEditarColar.Name = "menuEditarColar";
            this.menuEditarColar.Size = new System.Drawing.Size(180, 22);
            this.menuEditarColar.Text = "Colar";
            this.menuEditarColar.Click += new System.EventHandler(this.menuEditarColar_Click);
            // 
            // menuEditarSelecionarTudo
            // 
            this.menuEditarSelecionarTudo.Image = global::MyNotepad.Properties.Resources.Path_selection_tool_icon;
            this.menuEditarSelecionarTudo.Name = "menuEditarSelecionarTudo";
            this.menuEditarSelecionarTudo.Size = new System.Drawing.Size(180, 22);
            this.menuEditarSelecionarTudo.Text = "Selecionar Tudo";
            this.menuEditarSelecionarTudo.Click += new System.EventHandler(this.menuEditarSelecionarTudo_Click);
            // 
            // menuEditarProcurar
            // 
            this.menuEditarProcurar.Image = global::MyNotepad.Properties.Resources.Start_Menu_Search_icon;
            this.menuEditarProcurar.Name = "menuEditarProcurar";
            this.menuEditarProcurar.Size = new System.Drawing.Size(180, 22);
            this.menuEditarProcurar.Text = "Procurar";
            this.menuEditarProcurar.Click += new System.EventHandler(this.menuEditarProcurar_Click);
            // 
            // menuFormatar
            // 
            this.menuFormatar.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuFormatarLetra,
            this.menoFormatarCores,
            this.menuFormatarAlinhamentos});
            this.menuFormatar.Image = global::MyNotepad.Properties.Resources.Utilities_icon;
            this.menuFormatar.Name = "menuFormatar";
            this.menuFormatar.Size = new System.Drawing.Size(83, 20);
            this.menuFormatar.Text = "Formatar";
            // 
            // menuFormatarLetra
            // 
            this.menuFormatarLetra.Image = global::MyNotepad.Properties.Resources.Letters_icon;
            this.menuFormatarLetra.Name = "menuFormatarLetra";
            this.menuFormatarLetra.Size = new System.Drawing.Size(180, 22);
            this.menuFormatarLetra.Text = "Letra";
            this.menuFormatarLetra.Click += new System.EventHandler(this.menuFormatarLetra_Click);
            // 
            // menoFormatarCores
            // 
            this.menoFormatarCores.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menoFormatarCoresLetra,
            this.menuFormatarCoresFundos});
            this.menoFormatarCores.Image = global::MyNotepad.Properties.Resources.Apps_Color_B_icon;
            this.menoFormatarCores.Name = "menoFormatarCores";
            this.menoFormatarCores.Size = new System.Drawing.Size(180, 22);
            this.menoFormatarCores.Text = "Cores";
            // 
            // menoFormatarCoresLetra
            // 
            this.menoFormatarCoresLetra.Image = global::MyNotepad.Properties.Resources.Letter_A_icon;
            this.menoFormatarCoresLetra.Name = "menoFormatarCoresLetra";
            this.menoFormatarCoresLetra.Size = new System.Drawing.Size(180, 22);
            this.menoFormatarCoresLetra.Text = "Letra";
            this.menoFormatarCoresLetra.Click += new System.EventHandler(this.menoFormatarCoresLetra_Click);
            // 
            // menuFormatarCoresFundos
            // 
            this.menuFormatarCoresFundos.Image = global::MyNotepad.Properties.Resources.Paint_Bucket_Can_icon;
            this.menuFormatarCoresFundos.Name = "menuFormatarCoresFundos";
            this.menuFormatarCoresFundos.Size = new System.Drawing.Size(180, 22);
            this.menuFormatarCoresFundos.Text = "Fundo";
            this.menuFormatarCoresFundos.Click += new System.EventHandler(this.menuFormatarCoresFundos_Click);
            // 
            // menuFormatarAlinhamentos
            // 
            this.menuFormatarAlinhamentos.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuFormatarAlinhamentosEsquerda,
            this.menuFormatarAlinhamentosCentro,
            this.menuFormatarAlinhamentosDireito});
            this.menuFormatarAlinhamentos.Image = global::MyNotepad.Properties.Resources.edit_alignment_justify_icon;
            this.menuFormatarAlinhamentos.Name = "menuFormatarAlinhamentos";
            this.menuFormatarAlinhamentos.Size = new System.Drawing.Size(180, 22);
            this.menuFormatarAlinhamentos.Text = "Alinhamentos";
            this.menuFormatarAlinhamentos.Click += new System.EventHandler(this.menuFormatarAlinhamentos_Click);
            // 
            // menuFormatarAlinhamentosEsquerda
            // 
            this.menuFormatarAlinhamentosEsquerda.Image = global::MyNotepad.Properties.Resources.edit_alignment_icon;
            this.menuFormatarAlinhamentosEsquerda.Name = "menuFormatarAlinhamentosEsquerda";
            this.menuFormatarAlinhamentosEsquerda.Size = new System.Drawing.Size(180, 22);
            this.menuFormatarAlinhamentosEsquerda.Text = "Esquerda";
            this.menuFormatarAlinhamentosEsquerda.Click += new System.EventHandler(this.menuFormatarAlinhamentosEsquerda_Click);
            // 
            // menuFormatarAlinhamentosCentro
            // 
            this.menuFormatarAlinhamentosCentro.Image = global::MyNotepad.Properties.Resources.edit_alignment_center_icon;
            this.menuFormatarAlinhamentosCentro.Name = "menuFormatarAlinhamentosCentro";
            this.menuFormatarAlinhamentosCentro.Size = new System.Drawing.Size(180, 22);
            this.menuFormatarAlinhamentosCentro.Text = "Centro";
            this.menuFormatarAlinhamentosCentro.Click += new System.EventHandler(this.menuFormatarAlinhamentosCentro_Click);
            // 
            // menuFormatarAlinhamentosDireito
            // 
            this.menuFormatarAlinhamentosDireito.Image = global::MyNotepad.Properties.Resources.edit_alignment_right_icon;
            this.menuFormatarAlinhamentosDireito.Name = "menuFormatarAlinhamentosDireito";
            this.menuFormatarAlinhamentosDireito.Size = new System.Drawing.Size(180, 22);
            this.menuFormatarAlinhamentosDireito.Text = "Direito";
            this.menuFormatarAlinhamentosDireito.Click += new System.EventHandler(this.menuFormatarAlinhamentosDireito_Click);
            // 
            // rbTexto
            // 
            this.rbTexto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rbTexto.Location = new System.Drawing.Point(0, 24);
            this.rbTexto.Name = "rbTexto";
            this.rbTexto.Size = new System.Drawing.Size(784, 717);
            this.rbTexto.TabIndex = 1;
            this.rbTexto.Text = "";
            this.rbTexto.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 719);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(784, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 741);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.rbTexto);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "MyNotepad";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuFicheiro;
        private System.Windows.Forms.ToolStripMenuItem menuEditar;
        private System.Windows.Forms.ToolStripMenuItem menuFormatar;
        private System.Windows.Forms.ToolStripMenuItem menuFicheiroNovo;
        private System.Windows.Forms.ToolStripMenuItem menuFicheiroAbrir;
        private System.Windows.Forms.ToolStripMenuItem menuFicheiroGuardar;
        private System.Windows.Forms.ToolStripMenuItem menuFicheiroSair;
        private System.Windows.Forms.ToolStripMenuItem menuEditarCortar;
        private System.Windows.Forms.ToolStripMenuItem menuEditarCopiar;
        private System.Windows.Forms.ToolStripMenuItem menuEditarColar;
        private System.Windows.Forms.ToolStripMenuItem menuEditarSelecionarTudo;
        private System.Windows.Forms.ToolStripMenuItem menuEditarProcurar;
        private System.Windows.Forms.ToolStripMenuItem menuFormatarLetra;
        private System.Windows.Forms.ToolStripMenuItem menoFormatarCores;
        private System.Windows.Forms.ToolStripMenuItem menoFormatarCoresLetra;
        private System.Windows.Forms.ToolStripMenuItem menuFormatarCoresFundos;
        private System.Windows.Forms.ToolStripMenuItem menuFormatarAlinhamentos;
        private System.Windows.Forms.ToolStripMenuItem menuFormatarAlinhamentosEsquerda;
        private System.Windows.Forms.ToolStripMenuItem menuFormatarAlinhamentosCentro;
        private System.Windows.Forms.ToolStripMenuItem menuFormatarAlinhamentosDireito;
        private System.Windows.Forms.RichTextBox rbTexto;
        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.StatusStrip statusStrip1;
    }
}

