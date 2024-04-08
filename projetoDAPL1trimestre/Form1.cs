using System;
using System.Windows.Forms;

namespace projetoDAPL {
	public partial class Form1 : Form {
		Funcionario funcionario;
		public Form1() {
			InitializeComponent();
		}
		private void loginbutton_Click(object sender, EventArgs e) {
			string nomefunc = nome.Text;
			string emailfunc = email.Text;
			string senhafunc = senha.Text;
			if (string.IsNullOrWhiteSpace(nomefunc) || string.IsNullOrWhiteSpace(emailfunc) || string.IsNullOrWhiteSpace(senhafunc)) {
				MessageBox.Show("A caixa de nome, email ou senha está vazia");
				return;
			}
			funcionario = new Funcionario(nomefunc, emailfunc, senhafunc);
			this.Hide();
			Form2 form2 = new Form2();
			form2.Show();
		}

		public Funcionario GetFuncionario() {
			return funcionario;
		}
	}
}
