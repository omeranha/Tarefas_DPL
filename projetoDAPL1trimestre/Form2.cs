using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Globalization;

namespace projetoDAPL
{
	public partial class Form2 : Form
	{
		List<Dia> dias = new List<Dia>();
		int index = 0;
		public Form2() {
			InitializeComponent();
			var funcionario = Application.OpenForms.OfType<Form1>().FirstOrDefault()?.GetFuncionario();
			label1.Text += funcionario?.getNome();
			string[] nomes = { "segunda-feira", "terça-feira", "quarta-feira", "quinta-feira", "sexta-feira" };
			foreach (string nome in nomes) {
				DateTime horarioEntrada = new DateTime();
				DateTime horarioSaida = new DateTime();
				dias.Add(new Dia(nome, horarioEntrada, horarioSaida, 0));
			}
		}

		private void exit_Click(object sender, EventArgs e) {
			this.Close();
			new Form1().Show();
		}

		private void enviardia_Click(object sender, EventArgs e) {
			DateTime horarioEntrada = DateTime.ParseExact(entrada.Text, "H:mm", CultureInfo.InvariantCulture);
			DateTime horarioSaida = DateTime.ParseExact(saida.Text, "H:mm", CultureInfo.InvariantCulture);
			Dia dia = dias.ElementAt(index);
			dia.setHorarios(horarioEntrada, horarioSaida, horarioSaida.Subtract(horarioEntrada).Hours);
			if (index == dias.Count - 1) {
				MessageBox.Show("Registro concluido");
				new Form3().Show();
				return;
			}
			diasemana.Text = dias.ElementAt(++index).getDiaSemana();
		}

		public List<Dia> GetDias() {
			return dias;
		}
	}
}
