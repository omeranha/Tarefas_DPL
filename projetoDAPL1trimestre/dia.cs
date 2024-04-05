using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projetoDAPL
{
	public class Dia
	{
		private string diasemana;
		private DateTime horarioEntrada;
		private DateTime horarioSaida;
		private double totalDia;

		public Dia(string dia, DateTime entrada, DateTime saida, double totalDia)
		{
			this.diasemana = dia;
			this.horarioEntrada = entrada;
			this.horarioSaida = saida;
			this.totalDia = totalDia;
		}

		public string getDiaSemana()
		{
			return diasemana;
		}
		public DateTime getHorarioEntrada()
		{
			return horarioEntrada;
		}
		public DateTime getHorarioSaida()
		{
			return horarioSaida;
		}

		public double getTotalDia()
		{
			return totalDia;
		}
		public void setHorarios(DateTime entrada, DateTime saida, int total)
		{
			horarioEntrada = entrada;
			horarioSaida = saida;
			totalDia = total;
		}
	}
}
