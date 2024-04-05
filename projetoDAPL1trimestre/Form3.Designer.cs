namespace projetoDAPL
{
	partial class Form3
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
			this.horastotais = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.horas = new System.Windows.Forms.Label();
			this.salario = new System.Windows.Forms.Label();
			this.semanais = new System.Windows.Forms.Label();
			this.semanal = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// horastotais
			// 
			this.horastotais.AutoSize = true;
			this.horastotais.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.horastotais.Location = new System.Drawing.Point(235, 51);
			this.horastotais.Name = "horastotais";
			this.horastotais.Size = new System.Drawing.Size(191, 20);
			this.horastotais.TabIndex = 0;
			this.horastotais.Text = "Horas totais trabalhadas: ";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(234, 9);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(137, 25);
			this.label2.TabIndex = 1;
			this.label2.Text = "Funcionário: ";
			// 
			// horas
			// 
			this.horas.AutoSize = true;
			this.horas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.horas.Location = new System.Drawing.Point(235, 131);
			this.horas.Name = "horas";
			this.horas.Size = new System.Drawing.Size(56, 20);
			this.horas.TabIndex = 2;
			this.horas.Text = "Horas ";
			// 
			// salario
			// 
			this.salario.AutoSize = true;
			this.salario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.salario.Location = new System.Drawing.Point(235, 203);
			this.salario.Name = "salario";
			this.salario.Size = new System.Drawing.Size(122, 20);
			this.salario.TabIndex = 3;
			this.salario.Text = "Salário do mês: ";
			// 
			// semanais
			// 
			this.semanais.AutoSize = true;
			this.semanais.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.semanais.Location = new System.Drawing.Point(235, 96);
			this.semanais.Name = "semanais";
			this.semanais.Size = new System.Drawing.Size(132, 20);
			this.semanais.TabIndex = 4;
			this.semanais.Text = "Horas semanais: ";
			// 
			// semanal
			// 
			this.semanal.AutoSize = true;
			this.semanal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.semanal.Location = new System.Drawing.Point(235, 174);
			this.semanal.Name = "semanal";
			this.semanal.Size = new System.Drawing.Size(130, 20);
			this.semanal.TabIndex = 5;
			this.semanal.Text = "Salário semanal: ";
			// 
			// Form3
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.semanal);
			this.Controls.Add(this.semanais);
			this.Controls.Add(this.salario);
			this.Controls.Add(this.horas);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.horastotais);
			this.Name = "Form3";
			this.Text = "Form3";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label horastotais;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label horas;
		private System.Windows.Forms.Label salario;
		private System.Windows.Forms.Label semanais;
		private System.Windows.Forms.Label semanal;
	}
}