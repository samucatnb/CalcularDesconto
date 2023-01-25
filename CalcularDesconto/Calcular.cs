namespace CalcularDesconto
{
	public partial class Calcular : Form
	{
		public Calcular()
		{
			InitializeComponent();
			mkbPDinheiro.Text= "5,00";
			mkbPCDebito.Text = "2,00";
		}


		private void Enter_Campos_Valor(object sender, EventArgs e)
		{
			MaskedTextBox obj = (MaskedTextBox)sender;
			obj.ConfigurarMaskedTextBox();
			obj.SelectAll();
		}

		private void mkbTotalVenda_Validating(object sender, System.ComponentModel.CancelEventArgs e)
		{
			MaskedTextBox obj = (MaskedTextBox)sender;
			obj.GetToStringFormatadoExt();

			CalcularDesconto();

			mkbTotalRecebido.Text = GetSomaRecebimentos();
			mkbTotalPerc.Text = GetSomaPercentual();
			mkbTotalDesconto.Text = GetSomaDescontos();
		}

		private void CalcularDesconto()
		{
			mkbVDescDinheiro.Text = (mkbVDinheiro.GetToDecimalEx() * 
									(mkbPDinheiro.GetToDecimalEx() / 100)).ToString();
			mkbVDescDinheiro.GetToStringFormatadoExt();

			mkbVDescCredito.Text = (mkbVCCredito.GetToDecimalEx() *
									(mkbPCCredito.GetToDecimalEx() / 100)).ToString();
			mkbVDescCredito.GetToStringFormatadoExt();

			mkbVDescDebito.Text = (mkbVCDebito.GetToDecimalEx() *
									(mkbPCDebito.GetToDecimalEx() / 100)).ToString();
			mkbVDescDebito.GetToStringFormatadoExt();
		}

		private string GetSomaRecebimentos()
		{
			decimal total = 0;
			total = mkbVDinheiro.GetToDecimalEx() + 
					mkbVCCredito.GetToDecimalEx() +
					mkbVCDebito.GetToDecimalEx();
			return total.ToString();
		}

		private string GetSomaPercentual()
		{
			decimal total = 0;
			total = mkbPDinheiro.GetToDecimalEx() +
					mkbPCCredito.GetToDecimalEx() +
					mkbPCDebito.GetToDecimalEx();
			return total.ToString();
		}
		private string GetSomaDescontos()
		{
			decimal total = 0;
			total = mkbVDescDinheiro.GetToDecimalEx() +
					mkbVDescCredito.GetToDecimalEx() +
					mkbVDescDebito.GetToDecimalEx();
			return total.ToString();
		}

	}
}