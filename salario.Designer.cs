namespace Tcc_senai
{
	partial class salario
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
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
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.lblsobra = new System.Windows.Forms.Label();
			this.dgvsalario = new System.Windows.Forms.DataGridView();
			this.btnInserir = new System.Windows.Forms.Button();
			this.txtgasto = new System.Windows.Forms.TextBox();
			this.txtsalario = new System.Windows.Forms.TextBox();
			this.lblGastos = new System.Windows.Forms.Label();
			this.lblSalario = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.dgvsalario)).BeginInit();
			this.SuspendLayout();
			// 
			// lblsobra
			// 
			this.lblsobra.AutoSize = true;
			this.lblsobra.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblsobra.Location = new System.Drawing.Point(410, 62);
			this.lblsobra.Name = "lblsobra";
			this.lblsobra.Size = new System.Drawing.Size(0, 29);
			this.lblsobra.TabIndex = 16;
			// 
			// dgvsalario
			// 
			this.dgvsalario.AllowUserToAddRows = false;
			this.dgvsalario.AllowUserToDeleteRows = false;
			this.dgvsalario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvsalario.Location = new System.Drawing.Point(220, 132);
			this.dgvsalario.Name = "dgvsalario";
			this.dgvsalario.ReadOnly = true;
			this.dgvsalario.Size = new System.Drawing.Size(419, 233);
			this.dgvsalario.TabIndex = 15;
			this.dgvsalario.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvsalario_CellClick);
			// 
			// btnInserir
			// 
			this.btnInserir.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.btnInserir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnInserir.Location = new System.Drawing.Point(30, 255);
			this.btnInserir.Name = "btnInserir";
			this.btnInserir.Size = new System.Drawing.Size(169, 110);
			this.btnInserir.TabIndex = 14;
			this.btnInserir.Text = "Inserir";
			this.btnInserir.UseVisualStyleBackColor = false;
			this.btnInserir.Click += new System.EventHandler(this.btnInserir_Click);
			// 
			// txtgasto
			// 
			this.txtgasto.Location = new System.Drawing.Point(30, 178);
			this.txtgasto.Name = "txtgasto";
			this.txtgasto.Size = new System.Drawing.Size(169, 20);
			this.txtgasto.TabIndex = 13;
			// 
			// txtsalario
			// 
			this.txtsalario.Location = new System.Drawing.Point(30, 86);
			this.txtsalario.Name = "txtsalario";
			this.txtsalario.Size = new System.Drawing.Size(169, 20);
			this.txtsalario.TabIndex = 12;
			// 
			// lblGastos
			// 
			this.lblGastos.AutoSize = true;
			this.lblGastos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblGastos.Location = new System.Drawing.Point(27, 144);
			this.lblGastos.Name = "lblGastos";
			this.lblGastos.Size = new System.Drawing.Size(48, 16);
			this.lblGastos.TabIndex = 11;
			this.lblGastos.Text = "Gasto";
			// 
			// lblSalario
			// 
			this.lblSalario.AutoSize = true;
			this.lblSalario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblSalario.Location = new System.Drawing.Point(27, 62);
			this.lblSalario.Name = "lblSalario";
			this.lblSalario.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.lblSalario.Size = new System.Drawing.Size(57, 16);
			this.lblSalario.TabIndex = 17;
			this.lblSalario.Text = "Salario";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(410, 33);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(90, 29);
			this.label1.TabIndex = 18;
			this.label1.Text = "Sobra: ";
			this.label1.Click += new System.EventHandler(this.label1_Click);
			// 
			// salario
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 405);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.lblSalario);
			this.Controls.Add(this.lblsobra);
			this.Controls.Add(this.dgvsalario);
			this.Controls.Add(this.btnInserir);
			this.Controls.Add(this.txtgasto);
			this.Controls.Add(this.txtsalario);
			this.Controls.Add(this.lblGastos);
			this.Name = "salario";
			this.Text = "salario";
			this.Load += new System.EventHandler(this.salario_Load);
			((System.ComponentModel.ISupportInitialize)(this.dgvsalario)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label lblsobra;
		private System.Windows.Forms.DataGridView dgvsalario;
		private System.Windows.Forms.Button btnInserir;
		private System.Windows.Forms.TextBox txtgasto;
		private System.Windows.Forms.TextBox txtsalario;
		private System.Windows.Forms.Label lblGastos;
		private System.Windows.Forms.Label lblSalario;
		private System.Windows.Forms.Label label1;
	}
}