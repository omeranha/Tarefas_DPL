namespace projetoDAPL
{
	partial class Form4
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
			this.nome = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.novasenha = new System.Windows.Forms.TextBox();
			this.confirmar = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// nome
			// 
			this.nome.Font = new System.Drawing.Font("Amiri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.nome.Location = new System.Drawing.Point(190, 96);
			this.nome.Margin = new System.Windows.Forms.Padding(3, 7, 3, 7);
			this.nome.Name = "nome";
			this.nome.Size = new System.Drawing.Size(168, 36);
			this.nome.TabIndex = 0;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Amiri", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(149, -3);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(235, 88);
			this.label1.TabIndex = 2;
			this.label1.Text = "Esqueci a senha";
			// 
			// label2
			// 
			this.label2.BackColor = System.Drawing.Color.Transparent;
			this.label2.Font = new System.Drawing.Font("Amiri", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(103, 92);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(81, 43);
			this.label2.TabIndex = 3;
			this.label2.Text = "Nome:";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.BackColor = System.Drawing.Color.CadetBlue;
			this.label4.Font = new System.Drawing.Font("Amiri", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(73, 148);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(122, 55);
			this.label4.TabIndex = 5;
			this.label4.Text = "Nova Senha:";
			// 
			// novasenha
			// 
			this.novasenha.Font = new System.Drawing.Font("Amiri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.novasenha.Location = new System.Drawing.Point(190, 153);
			this.novasenha.Margin = new System.Windows.Forms.Padding(3, 7, 3, 7);
			this.novasenha.Name = "novasenha";
			this.novasenha.Size = new System.Drawing.Size(168, 36);
			this.novasenha.TabIndex = 6;
			// 
			// confirmar
			// 
			this.confirmar.Font = new System.Drawing.Font("David CLM", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
			this.confirmar.Location = new System.Drawing.Point(233, 203);
			this.confirmar.Margin = new System.Windows.Forms.Padding(3, 7, 3, 7);
			this.confirmar.Name = "confirmar";
			this.confirmar.Size = new System.Drawing.Size(78, 28);
			this.confirmar.TabIndex = 7;
			this.confirmar.Text = "confirmar";
			this.confirmar.UseVisualStyleBackColor = true;
			this.confirmar.Click += new System.EventHandler(this.confirmar_Click);
			// 
			// Form4
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 30F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.CadetBlue;
			this.ClientSize = new System.Drawing.Size(540, 439);
			this.Controls.Add(this.confirmar);
			this.Controls.Add(this.novasenha);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.nome);
			this.Font = new System.Drawing.Font("Amiri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Margin = new System.Windows.Forms.Padding(3, 7, 3, 7);
			this.Name = "Form4";
			this.Text = "Esqueceu sua senha";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox nome;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox novasenha;
		private System.Windows.Forms.Button confirmar;
	}
}