﻿	namespace projetoDAPL
{
	partial class Form2
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
			this.label1 = new System.Windows.Forms.Label();
			this.exit = new System.Windows.Forms.Button();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.entrada = new System.Windows.Forms.TextBox();
			this.saida = new System.Windows.Forms.TextBox();
			this.enviardia = new System.Windows.Forms.Button();
			this.diasemana = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Amiri", 27F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
			this.label1.Location = new System.Drawing.Point(262, 12);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(219, 100);
			this.label1.TabIndex = 0;
			this.label1.Text = "Bem vindo,";
			// 
			// exit
			// 
			this.exit.Location = new System.Drawing.Point(713, 12);
			this.exit.Name = "exit";
			this.exit.Size = new System.Drawing.Size(75, 23);
			this.exit.TabIndex = 3;
			this.exit.Text = "sair";
			this.exit.UseVisualStyleBackColor = true;
			this.exit.Click += new System.EventHandler(this.exit_Click);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Amiri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(232, 187);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(145, 45);
			this.label3.TabIndex = 4;
			this.label3.Text = "Horário de Entrada";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Amiri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(444, 187);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(129, 45);
			this.label4.TabIndex = 5;
			this.label4.Text = "Horário de Saída";
			// 
			// label5
			// 
			this.label5.Font = new System.Drawing.Font("Amiri", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(355, 366);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(153, 45);
			this.label5.TabIndex = 6;
			this.label5.Text = "Exemplo de uso: 7:52";
			// 
			// entrada
			// 
			this.entrada.Location = new System.Drawing.Point(251, 224);
			this.entrada.Name = "entrada";
			this.entrada.Size = new System.Drawing.Size(100, 20);
			this.entrada.TabIndex = 7;
			// 
			// saida
			// 
			this.saida.Location = new System.Drawing.Point(452, 224);
			this.saida.Name = "saida";
			this.saida.Size = new System.Drawing.Size(100, 20);
			this.saida.TabIndex = 8;
			// 
			// enviardia
			// 
			this.enviardia.Location = new System.Drawing.Point(377, 291);
			this.enviardia.Name = "enviardia";
			this.enviardia.Size = new System.Drawing.Size(89, 36);
			this.enviardia.TabIndex = 9;
			this.enviardia.Text = "Enviar";
			this.enviardia.UseVisualStyleBackColor = true;
			this.enviardia.Click += new System.EventHandler(this.enviardia_Click);
			// 
			// diasemana
			// 
			this.diasemana.AutoSize = true;
			this.diasemana.Font = new System.Drawing.Font("Amiri", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.diasemana.Location = new System.Drawing.Point(349, 135);
			this.diasemana.Name = "diasemana";
			this.diasemana.Size = new System.Drawing.Size(133, 52);
			this.diasemana.TabIndex = 10;
			this.diasemana.Text = "segunda-feira";
			// 
			// label2
			// 
			this.label2.BackColor = System.Drawing.Color.Transparent;
			this.label2.Font = new System.Drawing.Font("Amiri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(250, 82);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(361, 53);
			this.label2.TabIndex = 11;
			this.label2.Text = "Insira seus horários de entrada e saída:";
			// 
			// Form2
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.CadetBlue;
			this.ClientSize = new System.Drawing.Size(800, 420);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.diasemana);
			this.Controls.Add(this.enviardia);
			this.Controls.Add(this.saida);
			this.Controls.Add(this.entrada);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.exit);
			this.Controls.Add(this.label1);
			this.Name = "Form2";
			this.Text = "Página de entrada";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button exit;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox entrada;
		private System.Windows.Forms.TextBox saida;
		private System.Windows.Forms.Button enviardia;
		private System.Windows.Forms.Label diasemana;
		private System.Windows.Forms.Label label2;
	}
}