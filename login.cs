﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tcc_senai
{
	public partial class login : Form
	{
		public login()
		{
			InitializeComponent();
		}

		private void btnlogin_Click(object sender, EventArgs e)
		{
			try
			{
				Cliente cliente = new Cliente();
				if (cliente.RegistroRepetido(txtcpf.Text, txtemail.Text, txtSenha.Text) == true)
				{
					cliente.Inserir(txtnome.Text, txtcpf.Text, txtemail.Text, txtSenha.Text);
					MessageBox.Show("Cadastro feito com sucesso!", "Inserir", MessageBoxButtons.OK, MessageBoxIcon.Information);
					List<Cliente> clientes = cliente.listacliente();
					this.Hide();
					salario salario = new salario();
					salario.Show();
				}
				else
				{
					MessageBox.Show("cadastro não existe existe!", "Repetido", MessageBoxButtons.OK, MessageBoxIcon.Information);
					return;
				}
			}
			catch (Exception er)
			{
				MessageBox.Show(er.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void btnfechar_Click(object sender, EventArgs e)
		{
			this.Hide();
			cadastrodesign cadastrodesign = new cadastrodesign();
			cadastrodesign.Show();
		}
	}
}
