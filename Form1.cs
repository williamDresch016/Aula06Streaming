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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            


        }

        private void pictureBox2_Click_1(object sender, EventArgs e)
        {
            string titulo = "Capitao America 2";
            string descricao = "Steve Rogers é um jovem que participa de experiências visando a criação do supersoldado americano. Quando os oficiais militares conseguem transformá-lo em uma arma humana, eles percebem que não podem arriscar a vida do jovem nas batalhas de guerra";
            string caminho_imagem = "C:/Users//william.dresch/source/repos/Aula06Streaming/Aula06Streaming/imagens/Capitao_2.jpg";
            string link_video = "https://www.youtube.com/embed/dKrVegVI0Us";



            Form2 telaInfo = new Form2();
            telaInfo.titulo = titulo;
            telaInfo.descricao = descricao;
            telaInfo.caminho_imagem = caminho_imagem;
            telaInfo.link_video = link_video;
            telaInfo.Show();

        }
    }
}
