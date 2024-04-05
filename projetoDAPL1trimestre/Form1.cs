using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
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
			if (string.IsNullOrEmpty(nomefunc) && string.IsNullOrEmpty(emailfunc) && string.IsNullOrEmpty(senhafunc)) {
				MessageBox.Show("A caixa de nome, email ou senha está vazia");
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
