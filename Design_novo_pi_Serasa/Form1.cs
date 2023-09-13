using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Design_novo_pi_Serasa
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;
            panelCima.Size = new Size(ClientSize.Width, 200);
            panelEsquerdo.Size=new Size(200,ClientSize.Height);

            painelMeio.Location = new Point(ClientSize.Width / 2 - painelMeio.Size.Width / 2 + 100 , ClientSize.Height / 2 - painelMeio.Size.Height / 2 + 100);


            pictureBox1.Size = new Size(150, 150); // Defina o tamanho desejado para a PictureBox

            int deslocamentoHorizontal = 100; // Ajuste o deslocamento horizontal
            int deslocamentoVertical = 100;   // Ajuste o deslocamento vertical

            // Calcula a posição do painelMeio
            int xPainel = ClientSize.Width / 2 - painelMeio.Size.Width / 2;
            int yPainel = ClientSize.Height / 2 - painelMeio.Size.Height / 2;

            // Calcula a posição da PictureBox abaixo do painelMeio
            int xPictureBox = ClientSize.Width / 2 - pictureBox1.Size.Width / 2 + deslocamentoHorizontal;
            int yPictureBox = yPainel + painelMeio.Size.Height + deslocamentoVertical;

            pictureBox1.Location = new Point(xPictureBox, yPictureBox);

            this.Controls.Add(pictureBox1); // Adiciona a PictureBox ao formulário

        }

        private void Doarsangue_Click(object sender, EventArgs e)
        {
            Sangue doarsangue = new Sangue();
            painelMeio.Size = new Size(ClientSize.Width, ClientSize.Height);
            painelMeio.Location = new Point(ClientSize.Width / 2 - painelMeio.Size.Width / 2 + 100, ClientSize.Height / 2 - painelMeio.Size.Height / 2 + 100);
            doarsangue.TopLevel = false; 
            painelMeio.Controls.Add(doarsangue);
            doarsangue.Show();
        }
    }
}
