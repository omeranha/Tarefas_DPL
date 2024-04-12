using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projetoDAPL
{
	public partial class Form4 : Form
	{
		public Form4()
		{
			InitializeComponent();
		}

		private void confirmar_Click(object sender, EventArgs e)
		{
			string nomefunc = nome.Text;
			alterarSenha(nomefunc);
			this.Close();
			new Form1().Show();
		}

		private void alterarSenha(string nome) {
			string[] lines = File.ReadAllLines("funcionarios.txt");
			for (int i = 0; i < lines.Length; i++) {
				var linha = lines[i];
				if (linha.StartsWith("Nome: " + nome)) {
					string[] senha = linha.Split(new string[] { "Senha: " }, StringSplitOptions.None);
					if (senha.Length > 1) {
						senha[1] = novasenha.Text.GetHashCode().ToString();
						lines[i] = string.Join("Senha: ", senha);
					}
				}
			}
			File.WriteAllLines("funcionarios.txt", lines);
			MessageBox.Show("Senha alterada com sucesso.");
		}
	}
}
