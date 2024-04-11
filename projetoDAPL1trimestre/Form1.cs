using System;
using System.Linq;
using System.Windows.Forms;
using System.IO;

namespace projetoDAPL {
	public partial class Form1 : Form {
		Funcionario funcionario;
		public Form1() {
			InitializeComponent();
		}

		private void loginbutton_Click(object sender, EventArgs e) {
			string nomefunc = nome.Text;
			string emailfunc = email.Text;
			string senhafunc = senha.Text.GetHashCode().ToString();
			if (string.IsNullOrWhiteSpace(nomefunc) || string.IsNullOrWhiteSpace(emailfunc) || string.IsNullOrWhiteSpace(senhafunc)) {
				MessageBox.Show("A caixa de nome, email ou senha está vazia");
				return;
			}
			funcionario = new Funcionario(nomefunc, emailfunc, senhafunc);
			string path = @"funcionario.txt";
			string lineToCheck = "Nome: " + nomefunc + " Email: " + emailfunc + " Senha: " + senhafunc;
			try {
				if (!File.Exists(path)) {
					File.Create(path);
				}

				if (!File.ReadLines(path).Any(line => line == lineToCheck)) {
					File.AppendAllLines(path, new string[] { lineToCheck });
					MessageBox.Show("Registro criado com sucesso.");
				}
				
				this.Hide();
				Form2 form2 = new Form2();
				form2.Show();
			} catch (Exception ex) {
				MessageBox.Show(ex.Message);
			}
		}

		public Funcionario GetFuncionario() {
			return funcionario;
		}

		private void button1_Click(object sender, EventArgs e)
		{
			this.Hide();
			new Form4().Show();
		}
	}
}
