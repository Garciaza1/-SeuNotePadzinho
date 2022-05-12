using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace MeuNotePadzinho
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }
        private void novoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmFilha f = new FrmFilha();
            f.Text = String.Format("novo Documento - {0}",this.MdiChildren.Length + 1);
            f.MdiParent = this;
            f.Show();
        }

        private void sairquerMesmoSairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("deseja realmente sair?",
                "sair", MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if(dialogResult == DialogResult.Yes)
            {
                Application.Exit();
            }

        }

        private void salvarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            FrmFilha filhaAtiva = (FrmFilha)this.ActiveMdiChild;
            try
            {
                if (filhaAtiva != null)
                {
                    RichTextBox rtTexto = filhaAtiva.rtTextoUsuario;
                    SaveFileDialog saveFileDialog = new SaveFileDialog();
                    saveFileDialog.Filter = "arquivo de texto | *.txt";
                    saveFileDialog.FileName = "arquivo.txt*";
                    saveFileDialog.RestoreDirectory = true;

                    if (saveFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        StreamWriter writer = new StreamWriter(saveFileDialog.OpenFile());
                        for (int i = 0; i < rtTexto.Lines.Length; i++)
                        {
                            writer.WriteLine(rtTexto.Lines[i]);
                        }
                        filhaAtiva.Text = saveFileDialog.FileName;

                        writer.Dispose();
                        writer.Close();
                    }
                }
            }
            catch
            {
                MessageBox.Show("ops... algo deu errado!");
            }
        
        }

        private void abrirUmVelhoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmFilha frmFilha = new FrmFilha();
            frmFilha.MdiParent = this;
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "arquivo de texto | *.txt";

            if(openFileDialog.ShowDialog() == DialogResult.OK)
            {
                StreamReader reader = new StreamReader(openFileDialog.OpenFile());

                frmFilha.rtTextoUsuario.Text = reader.ReadToEnd();
                reader.Dispose();
                reader.Close();
                frmFilha.Text = openFileDialog.FileName;
                frmFilha.Show();

            }
        }

        private void copiarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            copiar_recortar(false);
        }
        private void copiar_recortar(bool recortando)
        {
            FrmFilha frmFilha = (FrmFilha)this.ActiveMdiChild;
            if(frmFilha != null)
            {
                try
                {
                    RichTextBox textBox = frmFilha.rtTextoUsuario;
                    if(textBox != null)
                    {
                        Clipboard.SetText(textBox.SelectedText, TextDataFormat.UnicodeText);
                        if (recortando)
                        {
                            textBox.SelectedText = String.Empty;
                        }
                    }
                }
                catch
                {
                    MessageBox.Show("erro ao copiar");
                }
            }
        }

        private void recortarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            copiar_recortar(true);
        }

        private void colarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmFilha frmFilha = (FrmFilha)this.ActiveMdiChild;
            if (frmFilha != null)
            {
                try
                {
                    RichTextBox textBox = frmFilha.rtTextoUsuario;
                    if (textBox != null)
                    {
                        IDataObject data = Clipboard.GetDataObject();
                        if (data.GetDataPresent(DataFormats.StringFormat))
                        {
                            textBox.SelectedText = data.GetData(DataFormats.StringFormat).ToString();
                        }
                    }
                }
                catch
                {
                    MessageBox.Show("Erro ao colar...");
                }
            }
        }
    }
}

