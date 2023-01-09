using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Text;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace MyNotepad
{
    public partial class Form1 : Form
    {
        private string ficheiro = "";
        public Form1()
        {
            InitializeComponent();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void menuFicheiroNovo_Click(object sender, EventArgs e)
        {
            VerificarAlteracoes();

            rbTexto.ResetText();
            rbTexto.Modified = false;
            ficheiro = null;

              
        }

        private void menuFicheiroAbrir_Click(object sender, EventArgs e)
        {
            VerificarAlteracoes();

            openFileDialog1.Filter = "Ficheiros RTF| *.rtf | Ficheiros TXT | +.txt | Todos |+.+";
            openFileDialog1.FileName = "";

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                ficheiro=openFileDialog1.FileName;
                rbTexto.LoadFile(ficheiro);
                rbTexto.Modified = false ;
            }
        }

        private void menuFicheiro_Click(object sender, EventArgs e)
        {

        }

        private void menuFicheiroGuardar_Click(object sender, EventArgs e)
        {
            if (ficheiro != "")
            {
                rbTexto.SaveFile(ficheiro);
                rbTexto.Modified = false;
            }
            else
            {
                GuardarFicheiro();

            }
        }

        private void menuFicheiroSair_Click(object sender, EventArgs e)
        {
            DialogResult resposta = MessageBox.Show("Deseja sair da aplicação?", "Aviso",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resposta == DialogResult.Yes)
            {
                VerificarAlteracoes();
            }
        
        }
        
        private void VerificarAlteracoes()
        {
            if (rbTexto.Modified == true)
            {
                DialogResult resposta = MessageBox.Show("Deseja guadar o texto atual?", "Âtenção",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (resposta != DialogResult.Yes)
                {
                    if (ficheiro !="")
                    {
                        rbTexto.SaveFile(ficheiro);
                        rbTexto.Modified = false;
                    }
                    else
                    {
                        GuardarFicheiro();
                    }
                 }
            }
        }


        private void GuardarFicheiro()
        {
            saveFileDialog1.Filter = "Ficheiros RTF | *.rtf | Ficheiros TXT | *.txt";

            saveFileDialog1.FileName = "";

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                ficheiro = saveFileDialog1.FileName;
                rbTexto.SaveFile(ficheiro);
                rbTexto.Modified = false;
            }
        }

        private void menuEditarCortar_Click(object sender, EventArgs e)
        {
            rbTexto.Cut();
        }

        private void menuEditarCopiar_Click(object sender, EventArgs e)
        {
            rbTexto.Copy();
        }

        private void menuEditarColar_Click(object sender, EventArgs e)
        {
            rbTexto.Paste();

        }

        private void menuEditarSelecionarTudo_Click(object sender, EventArgs e)
        {
            rbTexto.SelectAll();
        }

        private void menuEditarProcurar_Click(object sender, EventArgs e)
        {
            string txtProcura = Interaction.InputBox("Digite o que procura:",
                   "Procurar", "", 150, 200);

            int resultado = rbTexto.Find(txtProcura);
            if (resultado == -1)
            {
                MessageBox.Show(" Aviso ", "Não foi encontrada a sua procura.",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
       }

        private void menuFormatarLetra_Click(object sender, EventArgs e)
        {
            if(rbTexto.SelectionFont !=null)
            {
                fontDialog1.Font = rbTexto.SelectionFont;

            }
            else
            {
                fontDialog1.Font = null;
            }

            fontDialog1.ShowDialog();
            rbTexto.SelectionFont = fontDialog1.Font;
        }

        private void menoFormatarCoresLetra_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            rbTexto.SelectionColor= colorDialog1.Color;
        }

        private void menuFormatarCoresFundos_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            rbTexto.SelectionBackColor= colorDialog1.Color;
        }

        private void menuFormatarAlinhamentos_Click(object sender, EventArgs e)
        {

        }

        private void menuFormatarAlinhamentosEsquerda_Click(object sender, EventArgs e)
        {
            rbTexto.SelectionAlignment = HorizontalAlignment.Left;
        }

        private void menuFormatarAlinhamentosCentro_Click(object sender, EventArgs e)
        {
            rbTexto.SelectionAlignment = HorizontalAlignment.Center;
        }

        private void menuFormatarAlinhamentosDireito_Click(object sender, EventArgs e)
        {
            rbTexto.SelectionAlignment = HorizontalAlignment.Right;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult resposta = MessageBox.Show("Deseja sair da aplicação?", "MyNotepad",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resposta == DialogResult.Yes)
            {
                VerificarAlteracoes();
            }
            else
            {
                e.Cancel = true;
            }
            {
               
            }
        }
    }
}
