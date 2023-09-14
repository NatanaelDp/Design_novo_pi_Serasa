using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
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
            panelFundo.Size = new Size(ClientSize.Width+950,ClientSize.Height+500);
            panelFundo.Location = new Point(ClientSize.Width - 615, ClientSize.Height - 254);


            WindowState = FormWindowState.Maximized;
            panelCima.Size = new Size(ClientSize.Width, 200);
            panelEsquerdo.Size=new Size(200,ClientSize.Height);

           // panelFundo.Location = new Point(ClientSize.Width / 2 - panelFundo.Size.Width / 2 + 100 , ClientSize.Height / 2 - panelFundo.Size.Height / 2 + 100);


            pictureBox1.Size = new Size(150, 150); // Defina o tamanho desejado para a PictureBox

            int deslocamentoHorizontal = 100; // Ajuste o deslocamento horizontal
            int deslocamentoVertical = 100;   // Ajuste o deslocamento vertical

            // Calcula a posição do painelMeio
            int xPainel = ClientSize.Width / 2 - panelFundo.Size.Width / 2;
            int yPainel = ClientSize.Height / 2 - panelFundo.Size.Height / 2;

            // Calcula a posição da PictureBox abaixo do painelMeio
            int xPictureBox = ClientSize.Width / 2 - pictureBox1.Size.Width / 2 + deslocamentoHorizontal;
            int yPictureBox = yPainel + panelFundo.Size.Height + deslocamentoVertical;

            pictureBox1.Location = new Point(xPictureBox, yPictureBox);



            this.Controls.Add(pictureBox1); // Adiciona a PictureBox ao formulário

        }
        public void carregaTela(Form form)
        {
            form.TopLevel= false;
            panelFundo.Controls.Clear();
            panelFundo.Controls.Add(form);
           // form.Location = new Point(panelFundo.Width,panelFundo.Height);
            form.Size = new Size(panelFundo.Width, panelFundo.Width);
            form.Show();
        }

        private void Doarsangue_Click(object sender, EventArgs e)
        {
            // Sangue doarsangue = new Sangue();
            //panelFundo.Size = new Size(ClientSize.Width, ClientSize.Height);
            //panel.Location = new Point(ClientSize.Width / 2 - panelFundo.Size.Width / 2 + 100, ClientSize.Height / 2 - panelFundo.Size.Height / 2 + 100);
            // doarsangue.TopLevel = false; 
            // panelFundo.Controls.Add(doarsangue);
            //doarsangue.Show();
            carregaTela(new Sangue());

           
        }

        private void BtnVacinacao_Click(object sender, EventArgs e)
        {
            carregaTela(new Vacinação());
        }
    }
}
