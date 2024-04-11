using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace projetoDAPL
{
	public partial class Form3 : Form
	{
		private const double minimoHoras = 41;
		private const double porHora = 1412 / (minimoHoras * 4); // 8.63

		public Form3() {
			InitializeComponent();
			Funcionario funcionario = Application.OpenForms.OfType<Form1>().Single().GetFuncionario();
			label2.Text += funcionario.getNome();
			double horasSemanais = 0;
			List<Dia> dias = Application.OpenForms.OfType<Form2>().Single().GetDias();
			foreach (Dia dia in dias) {
				horasSemanais += dia.getTotalDia();
			}
			horastotais.Text += horasSemanais * 4;

			double horasExtras = horasSemanais - minimoHoras;
			double horasFaltantes = 0;
			if (horasExtras < 0) {
				horasFaltantes = Math.Abs(horasExtras);
				horasExtras = 0;
			}

			double salarioSemanal = (minimoHoras * porHora) + (horasExtras * 4) - (horasFaltantes * porHora);
			semanais.Text += horasSemanais;
			semanal.Text += salarioSemanal.ToString("F2");
			if (horasExtras > 0) {
				horas.Text += "extras: " + horasExtras;
			} else{
				horas.Text += "faltantes: " + (horasFaltantes * 4);
			}
			salario.Text += "R$" + (salarioSemanal * 4).ToString("F2");
		}
	}
}
