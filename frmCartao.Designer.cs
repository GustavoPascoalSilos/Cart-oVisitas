namespace CartãoVisitas
{
    partial class frmCartao
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
            lblNome = new Label();
            lblIdade = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            lblTelefone = new Label();
            lblEmail = new Label();
            lblEndereco = new Label();
            pictureBox4 = new PictureBox();
            btnGerar = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            SuspendLayout();
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Font = new Font("Arial Narrow", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            lblNome.Location = new Point(27, 33);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(84, 33);
            lblNome.TabIndex = 0;
            lblNome.Text = "NOME";
            // 
            // lblIdade
            // 
            lblIdade.AutoSize = true;
            lblIdade.Font = new Font("Arial Narrow", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            lblIdade.Location = new Point(24, 84);
            lblIdade.Name = "lblIdade";
            lblIdade.Size = new Size(85, 33);
            lblIdade.TabIndex = 1;
            lblIdade.Text = "IDADE";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Narrow", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(56, 84);
            label1.Name = "label1";
            label1.Size = new Size(80, 33);
            label1.TabIndex = 2;
            label1.Text = "ANOS";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.telefone;
            pictureBox1.Location = new Point(27, 220);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(97, 63);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.email;
            pictureBox2.Location = new Point(27, 306);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(97, 62);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 4;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.endereço;
            pictureBox3.Location = new Point(27, 385);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(97, 62);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 5;
            pictureBox3.TabStop = false;
            // 
            // lblTelefone
            // 
            lblTelefone.AutoSize = true;
            lblTelefone.Font = new Font("Arial Narrow", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            lblTelefone.Location = new Point(146, 242);
            lblTelefone.Name = "lblTelefone";
            lblTelefone.Size = new Size(136, 33);
            lblTelefone.TabIndex = 6;
            lblTelefone.Text = "TELEFONE";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Font = new Font("Arial Narrow", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            lblEmail.Location = new Point(146, 323);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(83, 33);
            lblEmail.TabIndex = 7;
            lblEmail.Text = "EMAIL";
            // 
            // lblEndereco
            // 
            lblEndereco.AutoSize = true;
            lblEndereco.Font = new Font("Arial Narrow", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            lblEndereco.Location = new Point(146, 409);
            lblEndereco.Name = "lblEndereco";
            lblEndereco.Size = new Size(146, 33);
            lblEndereco.TabIndex = 8;
            lblEndereco.Text = "ENDEREÇO";
            // 
            // pictureBox4
            // 
            pictureBox4.Image = Properties.Resources.logo;
            pictureBox4.Location = new Point(557, -1);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(249, 174);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 9;
            pictureBox4.TabStop = false;
            // 
            // btnGerar
            // 
            btnGerar.Location = new Point(712, 418);
            btnGerar.Name = "btnGerar";
            btnGerar.Size = new Size(94, 29);
            btnGerar.TabIndex = 10;
            btnGerar.Text = "GERAR";
            btnGerar.UseVisualStyleBackColor = true;
            btnGerar.Click += btnGerar_Click;
            // 
            // frmCartao
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.HotTrack;
            ClientSize = new Size(806, 450);
            Controls.Add(btnGerar);
            Controls.Add(pictureBox4);
            Controls.Add(lblEndereco);
            Controls.Add(lblEmail);
            Controls.Add(lblTelefone);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Controls.Add(lblIdade);
            Controls.Add(lblNome);
            Name = "frmCartao";
            Text = "frmCartao";
            Load += frmCartao_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNome;
        private Label lblIdade;
        private Label label1;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private Label lblTelefone;
        private Label lblEmail;
        private Label lblEndereco;
        private PictureBox pictureBox4;
        private Button btnGerar;
    }
}