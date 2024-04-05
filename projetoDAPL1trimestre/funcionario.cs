using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projetoDAPL {
	public class Funcionario {
		private string nome;
		private string email;
		private string senha;

		public Funcionario(string nome, string email, string senha) {
			this.nome = nome;
			this.email = email;
			this.senha = senha;
		}

		public string getNome() {
			return nome;
		}
		public void setNome(string name) {
			nome = name;
		}

		public string getEmail() {
			return email;
		}
		public void setEmail(string line) {
			email = line;
		}

		public string getSenha() {
			return senha;
		}
		public void setsenha(string line) {
			senha = line;
		}
	}
}
