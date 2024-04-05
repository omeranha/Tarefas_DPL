using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projetoDAPL
{
	public partial class Form3 : Form
	{
		public Form3() {
			InitializeComponent();
			Funcionario funcionario = Application.OpenForms.OfType<Form1>().Single().GetFuncionario();
			label2.Text += funcionario.getNome();
			double total = 0; // total semana
			List<Dia> dias = Application.OpenForms.OfType<Form2>().Single().GetDias();
			foreach (Dia dia in dias) {
				total += dia.getTotalDia();
			}
			horastotais.Text += total;
			double conta = (41 - total) * -1;
			double horasMes = total * 4;
			double salariomes = (conta * 4) * 8;
			double salarioTotal = 1412;
			semanais.Text += conta;
			semanal.Text += (conta * 4);
			if (conta > 0) {
				salarioTotal = salarioTotal + ((conta * 4) * 4);
				horas.Text += "extras: " + conta;
			} else {
				salarioTotal = 1412 + salariomes;
				conta *= -1;
				horas.Text += "faltantes: " + conta;
			}
			salario.Text += "R$" + salarioTotal;
		}
	}
}
