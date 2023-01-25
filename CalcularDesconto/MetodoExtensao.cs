using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalcularDesconto
{
	public static class MetodoExtensao
	{
		public static void ConfigurarMaskedTextBox(this MaskedTextBox obj)
		{
			obj.PromptChar = ' ';
			obj.TextAlign = HorizontalAlignment.Right;
			obj.Mask = "";

		}
		/// <summary>
		/// Metodo de Extensão converte valor da propriedade Text para Decimal
		/// </summary>
		/// <param name="obj"></param>
		/// <returns></returns>
		public static decimal GetToDecimalEx(this Control obj)
		{
			try
			{
				if (ControleComPropriedadeText(obj))
				{
					decimal.TryParse(obj.Text, out decimal valorConvertido);
					return valorConvertido;
				}
				else
					return 0;
			}
			catch
			{

				throw;
			}
		}

		/// <summary>
		/// Metodo de Extensão: Formata propriedade Text e devolve string com valor decimal formatado 
		/// </summary>
		/// <param name="value"></param>
		/// <returns></returns>
		public static string GetToStringFormatadoExt(this Control obj, short numeroCasasDecimais = 2)
		{
			decimal value = GetToDecimalEx(obj);
			//utilizando CultureInfo garantimos que a formatação será a mesma em qualquer maquina.
			obj.Text = value.ToString("N" + numeroCasasDecimais, new CultureInfo("pt-BR"));
			return obj.Text;
		}

		private static bool ControleComPropriedadeText(Control obj)
		{

			if ((obj is Button button) ||
			   (obj is Label label) ||
			   (obj is GroupBox group) ||
			   (obj is MaskedTextBox mtb) ||
			   (obj is TextBox txt))
				return true;
			else
				return false;

		}


	}
}
