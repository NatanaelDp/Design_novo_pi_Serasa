namespace Design_novo_pi_Serasa
{
    partial class Vacinação
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnTomarVacina = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnTomarVacina);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Location = new System.Drawing.Point(193, 88);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(358, 241);
            this.panel1.TabIndex = 0;
            // 
            // btnTomarVacina
            // 
            this.btnTomarVacina.Location = new System.Drawing.Point(114, 57);
            this.btnTomarVacina.Name = "btnTomarVacina";
            this.btnTomarVacina.Size = new System.Drawing.Size(148, 46);
            this.btnTomarVacina.TabIndex = 0;
            this.btnTomarVacina.Text = "Tomar Vacina";
            this.btnTomarVacina.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(114, 146);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(148, 46);
            this.button1.TabIndex = 0;
            this.button1.Text = "Cancelar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Vacinação
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DodgerBlue;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Name = "Vacinação";
            this.Text = "Form2";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Button btnTomarVacina;
        private Button button1;
    }
}