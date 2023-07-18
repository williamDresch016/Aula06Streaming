using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aula06Streaming
{
    public partial class Form2 : Form
    {

        public string titulo;
        public string descricao;
        public string caminho_imagem;
        public string link_video;

        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            lblTitulo.Text = titulo;
            lblDescricao.Text = descricao;
            imgFundo.ImageLocation = caminho_imagem;
            wvVideo.Source = new Uri(link_video);


        }

        private void button1_Click(object sender, EventArgs e)
        {
            wvVideo.Visible = true; 
        }
    }
}
