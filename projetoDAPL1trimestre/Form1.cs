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
			if (string.IsNullOrWhiteSpace(nomefunc) || string.IsNullOrWhiteSpace(senhafunc)) {
				MessageBox.Show("A caixa de nome, email ou senha está vazia");
				return;
			}
			string path = @"funcionarios.txt";
			try {
				if (loginFuncionario(path, nomefunc, emailfunc, senhafunc)) {
					this.Hide();
					funcionario = new Funcionario(nomefunc, emailfunc, senhafunc);
					Form2 form2 = new Form2();
					form2.Show();
				}
			} catch (Exception ex) {
				MessageBox.Show(ex.Message);
			}
		}

		public Funcionario GetFuncionario() {
			return funcionario;
		}

		public bool loginFuncionario(string path, string nome, string email, string senha) {
			if (!File.Exists(path)) {
				File.Create(path).Close();
			}

			bool usuarioexiste = false;
			bool senhacorreta = false;
			foreach (string line in File.ReadLines(path)) {
				if (line.StartsWith("Nome: " + nome)) {
					usuarioexiste = true;
					string senhasalva = line.Split(new string[] { "Senha: " }, StringSplitOptions.None)[1];
					if (senhasalva == senha) {
						senhacorreta = true;
					}
					break;
				}
			}

			if (!usuarioexiste) {
				if (string.IsNullOrWhiteSpace(email)) {
					MessageBox.Show("A caixa de email está vazia, insira um email para criar sua conta");
					return false;
				}
				string linha = $"Nome: {nome} Email: {email} Senha: {senha}";
				File.AppendAllLines(path, new string[] { linha });
				MessageBox.Show("Registro criado com sucesso.");
			} else if (usuarioexiste && !senhacorreta) {
				MessageBox.Show("Senha incorreta.");
				return false;
			}
			return true;
		}

		private void button1_Click(object sender, EventArgs e)
		{
			this.Hide();
			new Form4().Show();
		}
	}
}
