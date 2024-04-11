namespace projetoDAPL
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
			this.titulo = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.nome = new System.Windows.Forms.TextBox();
			this.email = new System.Windows.Forms.TextBox();
			this.senha = new System.Windows.Forms.TextBox();
			this.loginbutton = new System.Windows.Forms.Button();
			this.button1 = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// titulo
			// 
			this.titulo.AutoSize = true;
			this.titulo.Font = new System.Drawing.Font("Amiri", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.titulo.Location = new System.Drawing.Point(245, -6);
			this.titulo.Name = "titulo";
			this.titulo.Size = new System.Drawing.Size(306, 88);
			this.titulo.TabIndex = 0;
			this.titulo.Text = "Registrar funcionário";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Amiri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(339, 57);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(72, 52);
			this.label1.TabIndex = 1;
			this.label1.Text = "Nome:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Amiri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(341, 121);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(70, 52);
			this.label2.TabIndex = 2;
			this.label2.Text = "Email:";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Amiri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(340, 187);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(71, 52);
			this.label3.TabIndex = 3;
			this.label3.Text = "Senha:";
			// 
			// nome
			// 
			this.nome.Location = new System.Drawing.Point(297, 97);
			this.nome.Name = "nome";
			this.nome.Size = new System.Drawing.Size(165, 21);
			this.nome.TabIndex = 4;
			// 
			// email
			// 
			this.email.Location = new System.Drawing.Point(297, 163);
			this.email.Name = "email";
			this.email.Size = new System.Drawing.Size(165, 21);
			this.email.TabIndex = 5;
			// 
			// senha
			// 
			this.senha.Location = new System.Drawing.Point(297, 228);
			this.senha.Name = "senha";
			this.senha.Size = new System.Drawing.Size(165, 21);
			this.senha.TabIndex = 6;
			// 
			// loginbutton
			// 
			this.loginbutton.Font = new System.Drawing.Font("David Libre", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.loginbutton.Location = new System.Drawing.Point(350, 273);
			this.loginbutton.Name = "loginbutton";
			this.loginbutton.Size = new System.Drawing.Size(50, 26);
			this.loginbutton.TabIndex = 7;
			this.loginbutton.Text = "Entrar";
			this.loginbutton.UseVisualStyleBackColor = true;
			this.loginbutton.Click += new System.EventHandler(this.loginbutton_Click);
			// 
			// button1
			// 
			this.button1.Font = new System.Drawing.Font("David CLM", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
			this.button1.Location = new System.Drawing.Point(339, 305);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(81, 39);
			this.button1.TabIndex = 8;
			this.button1.Text = "Esqueceu sua senha";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.CadetBlue;
			this.ClientSize = new System.Drawing.Size(800, 423);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.loginbutton);
			this.Controls.Add(this.senha);
			this.Controls.Add(this.email);
			this.Controls.Add(this.nome);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.titulo);
			this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
			this.Name = "Form1";
			this.Text = "Registro de funcionario";
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titulo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox nome;
        private System.Windows.Forms.TextBox email;
        private System.Windows.Forms.TextBox senha;
        private System.Windows.Forms.Button loginbutton;
		private System.Windows.Forms.Button button1;
	}
}

