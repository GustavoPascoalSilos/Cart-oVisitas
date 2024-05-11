namespace CartãoVisitas
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            panel1 = new Panel();
            txtNome = new TextBox();
            txtIdade = new TextBox();
            txtEmail = new TextBox();
            txtEndereco = new TextBox();
            label6 = new Label();
            btnEnviar = new Button();
            maskedTXT = new MaskedTextBox();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(14, 43);
            label1.Name = "label1";
            label1.Size = new Size(176, 31);
            label1.TabIndex = 0;
            label1.Text = "Informe o nome";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13.2000008F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(14, 130);
            label2.Name = "label2";
            label2.Size = new Size(175, 31);
            label2.TabIndex = 1;
            label2.Text = "Informe a idade";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 13.2000008F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.ButtonHighlight;
            label3.Location = new Point(14, 219);
            label3.Name = "label3";
            label3.Size = new Size(201, 31);
            label3.TabIndex = 2;
            label3.Text = "Informe o telefone";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 13.2000008F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = SystemColors.ButtonHighlight;
            label4.Location = new Point(15, 296);
            label4.Name = "label4";
            label4.Size = new Size(183, 31);
            label4.TabIndex = 3;
            label4.Text = "Informe o e-mail";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 13.2000008F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = SystemColors.ButtonHighlight;
            label5.Location = new Point(15, 379);
            label5.Name = "label5";
            label5.Size = new Size(213, 31);
            label5.TabIndex = 4;
            label5.Text = "Informe o endereço";
            // 
            // panel1
            // 
            panel1.Controls.Add(label1);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(232, 426);
            panel1.TabIndex = 5;
            // 
            // txtNome
            // 
            txtNome.Location = new Point(250, 61);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(370, 27);
            txtNome.TabIndex = 6;
            // 
            // txtIdade
            // 
            txtIdade.Location = new Point(250, 147);
            txtIdade.Name = "txtIdade";
            txtIdade.Size = new Size(370, 27);
            txtIdade.TabIndex = 7;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(250, 312);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(370, 27);
            txtEmail.TabIndex = 9;
            // 
            // txtEndereco
            // 
            txtEndereco.Location = new Point(250, 395);
            txtEndereco.Name = "txtEndereco";
            txtEndereco.Size = new Size(370, 27);
            txtEndereco.TabIndex = 10;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = SystemColors.ActiveCaptionText;
            label6.Font = new Font("Showcard Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = SystemColors.ButtonHighlight;
            label6.Location = new Point(387, 12);
            label6.Name = "label6";
            label6.Size = new Size(200, 26);
            label6.TabIndex = 11;
            label6.Text = "DADOS CADASTRAIS";
            // 
            // btnEnviar
            // 
            btnEnviar.BackColor = Color.Lime;
            btnEnviar.FlatAppearance.BorderSize = 0;
            btnEnviar.FlatStyle = FlatStyle.Flat;
            btnEnviar.Location = new Point(671, 372);
            btnEnviar.Name = "btnEnviar";
            btnEnviar.Size = new Size(94, 29);
            btnEnviar.TabIndex = 12;
            btnEnviar.Text = "ENVIAR";
            btnEnviar.UseVisualStyleBackColor = false;
            btnEnviar.Click += btnEnviar_Click;
            // 
            // maskedTXT
            // 
            maskedTXT.Location = new Point(250, 231);
            maskedTXT.Mask = "(99) 00000-0000";
            maskedTXT.Name = "maskedTXT";
            maskedTXT.Size = new Size(370, 27);
            maskedTXT.TabIndex = 13;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Desktop;
            ClientSize = new Size(800, 450);
            Controls.Add(maskedTXT);
            Controls.Add(btnEnviar);
            Controls.Add(label6);
            Controls.Add(txtEndereco);
            Controls.Add(txtEmail);
            Controls.Add(txtIdade);
            Controls.Add(txtNome);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Name = "Form1";
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Panel panel1;
        private TextBox txtNome;
        private TextBox txtIdade;
        private TextBox txtEmail;
        private TextBox txtEndereco;
        private Label label6;
        private Button btnEnviar;
        private MaskedTextBox maskedTXT;
    }
}