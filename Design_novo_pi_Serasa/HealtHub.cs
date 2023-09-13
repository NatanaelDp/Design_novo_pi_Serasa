namespace Design_novo_pi_Serasa
{
    public partial class HealtHub : Form
    {
        public HealtHub()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;

            int deslocamentoVertical = 200; // Ajuste esse valor para o deslocamento desejado
            lblBemvindo.Location = new Point(ClientSize.Width / 2 - lblBemvindo.Size.Width / 2, deslocamentoVertical);



            //lblBemvindo.Location = new Point(ClientSize.Width / 2 - lblBemvindo.Size.Width / 2);
            painelMeio.Location = new Point(ClientSize.Width / 2 - painelMeio.Size.Width / 2, ClientSize.Height / 2 - painelMeio.Size.Height / 2);





        }
    }
}