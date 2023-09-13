namespace Design_novo_pi_Serasa
{
    partial class Form1
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
            if (disposing && (components != null))
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panelCima = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.labelCima = new System.Windows.Forms.Label();
            this.panelEsquerdo = new System.Windows.Forms.Panel();
            this.Consulta = new System.Windows.Forms.Button();
            this.Vacinacao = new System.Windows.Forms.Button();
            this.Coletaexame = new System.Windows.Forms.Button();
            this.Doarsangue = new System.Windows.Forms.Button();
            this.painelMeio = new System.Windows.Forms.Panel();
            this.panelCima.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelEsquerdo.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelCima
            // 
            this.panelCima.BackColor = System.Drawing.Color.Navy;
            this.panelCima.Controls.Add(this.pictureBox1);
            this.panelCima.Controls.Add(this.labelCima);
            this.panelCima.Location = new System.Drawing.Point(1, -3);
            this.panelCima.Name = "panelCima";
            this.panelCima.Size = new System.Drawing.Size(799, 115);
            this.panelCima.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(511, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(285, 118);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // labelCima
            // 
            this.labelCima.AutoSize = true;
            this.labelCima.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelCima.ForeColor = System.Drawing.Color.White;
            this.labelCima.Location = new System.Drawing.Point(41, 31);
            this.labelCima.Name = "labelCima";
            this.labelCima.Size = new System.Drawing.Size(342, 50);
            this.labelCima.TabIndex = 0;
            this.labelCima.Text = "Opções de Serviço";
            // 
            // panelEsquerdo
            // 
            this.panelEsquerdo.BackColor = System.Drawing.Color.Navy;
            this.panelEsquerdo.Controls.Add(this.Consulta);
            this.panelEsquerdo.Controls.Add(this.Vacinacao);
            this.panelEsquerdo.Controls.Add(this.Coletaexame);
            this.panelEsquerdo.Controls.Add(this.Doarsangue);
            this.panelEsquerdo.Location = new System.Drawing.Point(1, 108);
            this.panelEsquerdo.Name = "panelEsquerdo";
            this.panelEsquerdo.Size = new System.Drawing.Size(209, 349);
            this.panelEsquerdo.TabIndex = 1;
            // 
            // Consulta
            // 
            this.Consulta.BackColor = System.Drawing.Color.SteelBlue;
            this.Consulta.ForeColor = System.Drawing.Color.White;
            this.Consulta.Location = new System.Drawing.Point(41, 287);
            this.Consulta.Name = "Consulta";
            this.Consulta.Size = new System.Drawing.Size(93, 43);
            this.Consulta.TabIndex = 0;
            this.Consulta.Text = "Consulta";
            this.Consulta.UseVisualStyleBackColor = false;
            // 
            // Vacinacao
            // 
            this.Vacinacao.BackColor = System.Drawing.Color.SteelBlue;
            this.Vacinacao.ForeColor = System.Drawing.Color.White;
            this.Vacinacao.Location = new System.Drawing.Point(41, 205);
            this.Vacinacao.Name = "Vacinacao";
            this.Vacinacao.Size = new System.Drawing.Size(93, 43);
            this.Vacinacao.TabIndex = 0;
            this.Vacinacao.Text = "Vacinação";
            this.Vacinacao.UseVisualStyleBackColor = false;
            // 
            // Coletaexame
            // 
            this.Coletaexame.BackColor = System.Drawing.Color.SteelBlue;
            this.Coletaexame.ForeColor = System.Drawing.Color.White;
            this.Coletaexame.Location = new System.Drawing.Point(41, 115);
            this.Coletaexame.Name = "Coletaexame";
            this.Coletaexame.Size = new System.Drawing.Size(93, 43);
            this.Coletaexame.TabIndex = 0;
            this.Coletaexame.Text = "Coletar Exame";
            this.Coletaexame.UseVisualStyleBackColor = false;
            // 
            // Doarsangue
            // 
            this.Doarsangue.BackColor = System.Drawing.Color.SteelBlue;
            this.Doarsangue.ForeColor = System.Drawing.Color.White;
            this.Doarsangue.Location = new System.Drawing.Point(41, 26);
            this.Doarsangue.Name = "Doarsangue";
            this.Doarsangue.Size = new System.Drawing.Size(93, 43);
            this.Doarsangue.TabIndex = 0;
            this.Doarsangue.Text = "Doar Sangue";
            this.Doarsangue.UseVisualStyleBackColor = false;
            this.Doarsangue.Click += new System.EventHandler(this.Doarsangue_Click);
            // 
            // painelMeio
            // 
            this.painelMeio.BackColor = System.Drawing.Color.White;
            this.painelMeio.Location = new System.Drawing.Point(242, 118);
            this.painelMeio.Name = "painelMeio";
            this.painelMeio.Size = new System.Drawing.Size(800, 500);
            this.painelMeio.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(155)))), ((int)(((byte)(245)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.painelMeio);
            this.Controls.Add(this.panelEsquerdo);
            this.Controls.Add(this.panelCima);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelCima.ResumeLayout(false);
            this.panelCima.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelEsquerdo.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panelCima;
        private Panel panelEsquerdo;
        private Label labelCima;
        public  Panel painelMeio;
        private Button Consulta;
        private Button Vacinacao;
        private Button Coletaexame;
        private Button Doarsangue;
        private PictureBox pictureBox1;
    }
}