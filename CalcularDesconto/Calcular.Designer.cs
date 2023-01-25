namespace CalcularDesconto
{
	partial class Calcular
	{
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Calcular));
			this.panel2 = new System.Windows.Forms.Panel();
			this.label1 = new System.Windows.Forms.Label();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.label2 = new System.Windows.Forms.Label();
			this.mkbTotalVenda = new System.Windows.Forms.MaskedTextBox();
			this.panel3 = new System.Windows.Forms.Panel();
			this.mkbPCCredito = new System.Windows.Forms.MaskedTextBox();
			this.mkbVDescCredito = new System.Windows.Forms.MaskedTextBox();
			this.mkbVCCredito = new System.Windows.Forms.MaskedTextBox();
			this.mkbPCDebito = new System.Windows.Forms.MaskedTextBox();
			this.mkbVDescDebito = new System.Windows.Forms.MaskedTextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.mkbVCDebito = new System.Windows.Forms.MaskedTextBox();
			this.mkbPDinheiro = new System.Windows.Forms.MaskedTextBox();
			this.mkbVDescDinheiro = new System.Windows.Forms.MaskedTextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.mkbVDinheiro = new System.Windows.Forms.MaskedTextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.panel4 = new System.Windows.Forms.Panel();
			this.label11 = new System.Windows.Forms.Label();
			this.mkbTotalRecebido = new System.Windows.Forms.MaskedTextBox();
			this.mkbTotalDesconto = new System.Windows.Forms.MaskedTextBox();
			this.mkbTotalPerc = new System.Windows.Forms.MaskedTextBox();
			this.panel1 = new System.Windows.Forms.Panel();
			this.panel2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.panel3.SuspendLayout();
			this.panel4.SuspendLayout();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel2
			// 
			this.panel2.BackColor = System.Drawing.Color.YellowGreen;
			this.panel2.Controls.Add(this.label1);
			this.panel2.Controls.Add(this.pictureBox1);
			this.panel2.Controls.Add(this.label2);
			this.panel2.Controls.Add(this.mkbTotalVenda);
			this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel2.Location = new System.Drawing.Point(0, 0);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(603, 81);
			this.panel2.TabIndex = 0;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.label1.Location = new System.Drawing.Point(149, 22);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(172, 25);
			this.label1.TabIndex = 3;
			this.label1.Text = "Calcular Desconto";
			// 
			// pictureBox1
			// 
			this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Left;
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(0, 0);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(118, 81);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 2;
			this.pictureBox1.TabStop = false;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.label2.ForeColor = System.Drawing.Color.MediumBlue;
			this.label2.Location = new System.Drawing.Point(408, 7);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(167, 21);
			this.label2.TabIndex = 3;
			this.label2.Text = "Valor Total da Venda";
			// 
			// mkbTotalVenda
			// 
			this.mkbTotalVenda.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.IncludePromptAndLiterals;
			this.mkbTotalVenda.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.mkbTotalVenda.Location = new System.Drawing.Point(392, 35);
			this.mkbTotalVenda.Name = "mkbTotalVenda";
			this.mkbTotalVenda.Size = new System.Drawing.Size(183, 29);
			this.mkbTotalVenda.SkipLiterals = false;
			this.mkbTotalVenda.TabIndex = 1;
			this.mkbTotalVenda.Enter += new System.EventHandler(this.Enter_Campos_Valor);
			this.mkbTotalVenda.Validating += new System.ComponentModel.CancelEventHandler(this.mkbTotalVenda_Validating);
			// 
			// panel3
			// 
			this.panel3.BackColor = System.Drawing.Color.LightGray;
			this.panel3.Controls.Add(this.mkbPCCredito);
			this.panel3.Controls.Add(this.mkbVDescCredito);
			this.panel3.Controls.Add(this.mkbVCCredito);
			this.panel3.Controls.Add(this.mkbPCDebito);
			this.panel3.Controls.Add(this.mkbVDescDebito);
			this.panel3.Controls.Add(this.label5);
			this.panel3.Controls.Add(this.mkbVCDebito);
			this.panel3.Controls.Add(this.mkbPDinheiro);
			this.panel3.Controls.Add(this.mkbVDescDinheiro);
			this.panel3.Controls.Add(this.label4);
			this.panel3.Controls.Add(this.mkbVDinheiro);
			this.panel3.Controls.Add(this.label3);
			this.panel3.Controls.Add(this.label8);
			this.panel3.Controls.Add(this.label7);
			this.panel3.Controls.Add(this.label6);
			this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel3.Location = new System.Drawing.Point(0, 81);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(603, 241);
			this.panel3.TabIndex = 1;
			// 
			// mkbPCCredito
			// 
			this.mkbPCCredito.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.IncludePromptAndLiterals;
			this.mkbPCCredito.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.mkbPCCredito.Location = new System.Drawing.Point(316, 137);
			this.mkbPCCredito.Name = "mkbPCCredito";
			this.mkbPCCredito.Size = new System.Drawing.Size(92, 29);
			this.mkbPCCredito.SkipLiterals = false;
			this.mkbPCCredito.TabIndex = 9;
			this.mkbPCCredito.Enter += new System.EventHandler(this.Enter_Campos_Valor);
			this.mkbPCCredito.Validating += new System.ComponentModel.CancelEventHandler(this.mkbTotalVenda_Validating);
			// 
			// mkbVDescCredito
			// 
			this.mkbVDescCredito.BackColor = System.Drawing.Color.Moccasin;
			this.mkbVDescCredito.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.IncludePromptAndLiterals;
			this.mkbVDescCredito.Enabled = false;
			this.mkbVDescCredito.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.mkbVDescCredito.Location = new System.Drawing.Point(444, 137);
			this.mkbVDescCredito.Name = "mkbVDescCredito";
			this.mkbVDescCredito.Size = new System.Drawing.Size(142, 29);
			this.mkbVDescCredito.SkipLiterals = false;
			this.mkbVDescCredito.TabIndex = 10;
			this.mkbVDescCredito.Validating += new System.ComponentModel.CancelEventHandler(this.mkbTotalVenda_Validating);
			// 
			// mkbVCCredito
			// 
			this.mkbVCCredito.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.IncludePromptAndLiterals;
			this.mkbVCCredito.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.mkbVCCredito.Location = new System.Drawing.Point(144, 137);
			this.mkbVCCredito.Name = "mkbVCCredito";
			this.mkbVCCredito.Size = new System.Drawing.Size(142, 29);
			this.mkbVCCredito.SkipLiterals = false;
			this.mkbVCCredito.TabIndex = 8;
			this.mkbVCCredito.Enter += new System.EventHandler(this.Enter_Campos_Valor);
			this.mkbVCCredito.Validating += new System.ComponentModel.CancelEventHandler(this.mkbTotalVenda_Validating);
			// 
			// mkbPCDebito
			// 
			this.mkbPCDebito.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.IncludePromptAndLiterals;
			this.mkbPCDebito.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.mkbPCDebito.Location = new System.Drawing.Point(316, 99);
			this.mkbPCDebito.Name = "mkbPCDebito";
			this.mkbPCDebito.Size = new System.Drawing.Size(92, 29);
			this.mkbPCDebito.SkipLiterals = false;
			this.mkbPCDebito.TabIndex = 6;
			this.mkbPCDebito.Enter += new System.EventHandler(this.Enter_Campos_Valor);
			this.mkbPCDebito.Validating += new System.ComponentModel.CancelEventHandler(this.mkbTotalVenda_Validating);
			// 
			// mkbVDescDebito
			// 
			this.mkbVDescDebito.BackColor = System.Drawing.Color.Moccasin;
			this.mkbVDescDebito.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.IncludePromptAndLiterals;
			this.mkbVDescDebito.Enabled = false;
			this.mkbVDescDebito.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.mkbVDescDebito.Location = new System.Drawing.Point(444, 99);
			this.mkbVDescDebito.Name = "mkbVDescDebito";
			this.mkbVDescDebito.Size = new System.Drawing.Size(142, 29);
			this.mkbVDescDebito.SkipLiterals = false;
			this.mkbVDescDebito.TabIndex = 7;
			this.mkbVDescDebito.Validating += new System.ComponentModel.CancelEventHandler(this.mkbTotalVenda_Validating);
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.label5.ForeColor = System.Drawing.Color.MediumBlue;
			this.label5.Location = new System.Drawing.Point(18, 145);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(120, 21);
			this.label5.TabIndex = 5;
			this.label5.Text = "Cartão Crédito";
			// 
			// mkbVCDebito
			// 
			this.mkbVCDebito.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.IncludePromptAndLiterals;
			this.mkbVCDebito.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.mkbVCDebito.Location = new System.Drawing.Point(144, 99);
			this.mkbVCDebito.Name = "mkbVCDebito";
			this.mkbVCDebito.Size = new System.Drawing.Size(142, 29);
			this.mkbVCDebito.SkipLiterals = false;
			this.mkbVCDebito.TabIndex = 5;
			this.mkbVCDebito.Enter += new System.EventHandler(this.Enter_Campos_Valor);
			this.mkbVCDebito.Validating += new System.ComponentModel.CancelEventHandler(this.mkbTotalVenda_Validating);
			// 
			// mkbPDinheiro
			// 
			this.mkbPDinheiro.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.IncludePromptAndLiterals;
			this.mkbPDinheiro.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.mkbPDinheiro.Location = new System.Drawing.Point(316, 61);
			this.mkbPDinheiro.Name = "mkbPDinheiro";
			this.mkbPDinheiro.Size = new System.Drawing.Size(92, 29);
			this.mkbPDinheiro.SkipLiterals = false;
			this.mkbPDinheiro.TabIndex = 3;
			this.mkbPDinheiro.Enter += new System.EventHandler(this.Enter_Campos_Valor);
			this.mkbPDinheiro.Validating += new System.ComponentModel.CancelEventHandler(this.mkbTotalVenda_Validating);
			// 
			// mkbVDescDinheiro
			// 
			this.mkbVDescDinheiro.BackColor = System.Drawing.Color.Moccasin;
			this.mkbVDescDinheiro.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.IncludePromptAndLiterals;
			this.mkbVDescDinheiro.Enabled = false;
			this.mkbVDescDinheiro.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.mkbVDescDinheiro.Location = new System.Drawing.Point(444, 61);
			this.mkbVDescDinheiro.Name = "mkbVDescDinheiro";
			this.mkbVDescDinheiro.Size = new System.Drawing.Size(142, 29);
			this.mkbVDescDinheiro.SkipLiterals = false;
			this.mkbVDescDinheiro.TabIndex = 4;
			this.mkbVDescDinheiro.Validating += new System.ComponentModel.CancelEventHandler(this.mkbTotalVenda_Validating);
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.label4.ForeColor = System.Drawing.Color.MediumBlue;
			this.label4.Location = new System.Drawing.Point(18, 106);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(116, 21);
			this.label4.TabIndex = 6;
			this.label4.Text = "Cartão Débito";
			// 
			// mkbVDinheiro
			// 
			this.mkbVDinheiro.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.IncludePromptAndLiterals;
			this.mkbVDinheiro.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.mkbVDinheiro.Location = new System.Drawing.Point(144, 61);
			this.mkbVDinheiro.Name = "mkbVDinheiro";
			this.mkbVDinheiro.Size = new System.Drawing.Size(142, 29);
			this.mkbVDinheiro.SkipLiterals = false;
			this.mkbVDinheiro.TabIndex = 2;
			this.mkbVDinheiro.Enter += new System.EventHandler(this.Enter_Campos_Valor);
			this.mkbVDinheiro.Validating += new System.ComponentModel.CancelEventHandler(this.mkbTotalVenda_Validating);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.label3.ForeColor = System.Drawing.Color.MediumBlue;
			this.label3.Location = new System.Drawing.Point(18, 69);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(77, 21);
			this.label3.TabIndex = 7;
			this.label3.Text = "Dinheiro";
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.label8.Location = new System.Drawing.Point(460, 26);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(126, 21);
			this.label8.TabIndex = 3;
			this.label8.Text = "Valor Desconto";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.label7.Location = new System.Drawing.Point(318, 26);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(92, 21);
			this.label7.TabIndex = 3;
			this.label7.Text = "Percentual";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.label6.Location = new System.Drawing.Point(19, 26);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(186, 21);
			this.label6.TabIndex = 3;
			this.label6.Text = "Forma de Recebimento";
			// 
			// panel4
			// 
			this.panel4.BackColor = System.Drawing.Color.YellowGreen;
			this.panel4.Controls.Add(this.label11);
			this.panel4.Controls.Add(this.mkbTotalRecebido);
			this.panel4.Controls.Add(this.mkbTotalDesconto);
			this.panel4.Controls.Add(this.mkbTotalPerc);
			this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.panel4.Location = new System.Drawing.Point(0, 271);
			this.panel4.Name = "panel4";
			this.panel4.Size = new System.Drawing.Size(603, 51);
			this.panel4.TabIndex = 2;
			// 
			// label11
			// 
			this.label11.AutoSize = true;
			this.label11.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.label11.Location = new System.Drawing.Point(19, 12);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(56, 21);
			this.label11.TabIndex = 3;
			this.label11.Text = "TOTAL";
			// 
			// mkbTotalRecebido
			// 
			this.mkbTotalRecebido.BackColor = System.Drawing.Color.WhiteSmoke;
			this.mkbTotalRecebido.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.IncludePromptAndLiterals;
			this.mkbTotalRecebido.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.mkbTotalRecebido.Location = new System.Drawing.Point(146, 6);
			this.mkbTotalRecebido.Name = "mkbTotalRecebido";
			this.mkbTotalRecebido.Size = new System.Drawing.Size(142, 32);
			this.mkbTotalRecebido.SkipLiterals = false;
			this.mkbTotalRecebido.TabIndex = 3;
			this.mkbTotalRecebido.Validating += new System.ComponentModel.CancelEventHandler(this.mkbTotalVenda_Validating);
			// 
			// mkbTotalDesconto
			// 
			this.mkbTotalDesconto.BackColor = System.Drawing.Color.Moccasin;
			this.mkbTotalDesconto.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.IncludePromptAndLiterals;
			this.mkbTotalDesconto.Enabled = false;
			this.mkbTotalDesconto.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.mkbTotalDesconto.Location = new System.Drawing.Point(446, 6);
			this.mkbTotalDesconto.Name = "mkbTotalDesconto";
			this.mkbTotalDesconto.Size = new System.Drawing.Size(142, 32);
			this.mkbTotalDesconto.SkipLiterals = false;
			this.mkbTotalDesconto.TabIndex = 5;
			this.mkbTotalDesconto.Validating += new System.ComponentModel.CancelEventHandler(this.mkbTotalVenda_Validating);
			// 
			// mkbTotalPerc
			// 
			this.mkbTotalPerc.BackColor = System.Drawing.Color.WhiteSmoke;
			this.mkbTotalPerc.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.IncludePromptAndLiterals;
			this.mkbTotalPerc.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.mkbTotalPerc.Location = new System.Drawing.Point(318, 6);
			this.mkbTotalPerc.Name = "mkbTotalPerc";
			this.mkbTotalPerc.Size = new System.Drawing.Size(92, 32);
			this.mkbTotalPerc.SkipLiterals = false;
			this.mkbTotalPerc.TabIndex = 4;
			this.mkbTotalPerc.Validating += new System.ComponentModel.CancelEventHandler(this.mkbTotalVenda_Validating);
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.panel4);
			this.panel1.Controls.Add(this.panel3);
			this.panel1.Controls.Add(this.panel2);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(603, 322);
			this.panel1.TabIndex = 0;
			// 
			// Calcular
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(603, 322);
			this.Controls.Add(this.panel1);
			this.Name = "Calcular";
			this.Text = "Calcular Desconto";
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.panel3.ResumeLayout(false);
			this.panel3.PerformLayout();
			this.panel4.ResumeLayout(false);
			this.panel4.PerformLayout();
			this.panel1.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private Panel panel2;
		private Label label1;
		private PictureBox pictureBox1;
		private Label label2;
		private MaskedTextBox mkbTotalVenda;
		private Panel panel3;
		private MaskedTextBox mkbPCCredito;
		private MaskedTextBox mkbVDescCredito;
		private MaskedTextBox mkbVCCredito;
		private MaskedTextBox mkbPCDebito;
		private MaskedTextBox mkbVDescDebito;
		private Label label5;
		private MaskedTextBox mkbVCDebito;
		private MaskedTextBox mkbPDinheiro;
		private MaskedTextBox mkbVDescDinheiro;
		private Label label4;
		private MaskedTextBox mkbVDinheiro;
		private Label label3;
		private Label label8;
		private Label label7;
		private Label label6;
		private Panel panel4;
		private Label label11;
		private MaskedTextBox mkbTotalRecebido;
		private MaskedTextBox mkbTotalDesconto;
		private MaskedTextBox mkbTotalPerc;
		private Panel panel1;
	}
}