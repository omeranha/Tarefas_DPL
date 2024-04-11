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
			string[] lines = File.ReadAllLines("funcionario.txt");
			for (int i = 0; i < lines.Length; i++) {
				var line = lines[i];
				if (line.StartsWith("Nome: " + nomefunc)) {
					string[] parts = line.Split(new string[] { "Senha: " }, StringSplitOptions.None);
					if (parts.Length > 1) {
						parts[1] = novasenha.Text.GetHashCode().ToString();
						lines[i] = string.Join("Senha: ", parts);
					}
				}
			}
			MessageBox.Show("Senha alterada com sucesso.");
			File.WriteAllLines("funcionario.txt", lines);
			this.Close();
			new Form1().Show();
		}
	}
}
