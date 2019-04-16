namespace TelasTCC
{
    partial class frmModFinanceiro
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnVendasCard = new System.Windows.Forms.Button();
            this.btnPeriodo = new System.Windows.Forms.Button();
            this.btnCaixa = new System.Windows.Forms.Button();
            this.btnPagamento = new System.Windows.Forms.Button();
            this.gbCaixa = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cbDia = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.lblRecCartao = new System.Windows.Forms.Label();
            this.lblRecDinheiro = new System.Windows.Forms.Label();
            this.lblDinheiro = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblCartao = new System.Windows.Forms.Label();
            this.dataGridPagamento = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            this.gbCaixa.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridPagamento)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnVendasCard);
            this.groupBox1.Controls.Add(this.btnPeriodo);
            this.groupBox1.Controls.Add(this.btnCaixa);
            this.groupBox1.Controls.Add(this.btnPagamento);
            this.groupBox1.Location = new System.Drawing.Point(21, 34);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(221, 263);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // btnVendasCard
            // 
            this.btnVendasCard.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.btnVendasCard.Location = new System.Drawing.Point(5, 204);
            this.btnVendasCard.Name = "btnVendasCard";
            this.btnVendasCard.Size = new System.Drawing.Size(210, 50);
            this.btnVendasCard.TabIndex = 4;
            this.btnVendasCard.Text = "Mostrar vendas cartão";
            this.btnVendasCard.UseVisualStyleBackColor = true;
            this.btnVendasCard.Click += new System.EventHandler(this.btnVendasCard_Click);
            // 
            // btnPeriodo
            // 
            this.btnPeriodo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.btnPeriodo.Location = new System.Drawing.Point(6, 140);
            this.btnPeriodo.Name = "btnPeriodo";
            this.btnPeriodo.Size = new System.Drawing.Size(210, 50);
            this.btnPeriodo.TabIndex = 3;
            this.btnPeriodo.Text = "Vendas do período";
            this.btnPeriodo.UseVisualStyleBackColor = true;
            // 
            // btnCaixa
            // 
            this.btnCaixa.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.btnCaixa.Location = new System.Drawing.Point(6, 78);
            this.btnCaixa.Name = "btnCaixa";
            this.btnCaixa.Size = new System.Drawing.Size(210, 50);
            this.btnCaixa.TabIndex = 2;
            this.btnCaixa.Text = "Fluxo de Caixa";
            this.btnCaixa.UseVisualStyleBackColor = true;
            this.btnCaixa.Click += new System.EventHandler(this.btnCaixa_Click);
            // 
            // btnPagamento
            // 
            this.btnPagamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.btnPagamento.Location = new System.Drawing.Point(6, 19);
            this.btnPagamento.Name = "btnPagamento";
            this.btnPagamento.Size = new System.Drawing.Size(210, 50);
            this.btnPagamento.TabIndex = 1;
            this.btnPagamento.Text = "Folha de Pagamento";
            this.btnPagamento.UseVisualStyleBackColor = true;
            this.btnPagamento.Click += new System.EventHandler(this.btnPagamento_Click);
            // 
            // gbCaixa
            // 
            this.gbCaixa.Controls.Add(this.groupBox2);
            this.gbCaixa.Controls.Add(this.lblRecCartao);
            this.gbCaixa.Controls.Add(this.lblRecDinheiro);
            this.gbCaixa.Controls.Add(this.lblDinheiro);
            this.gbCaixa.Controls.Add(this.lblTotal);
            this.gbCaixa.Controls.Add(this.lblCartao);
            this.gbCaixa.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbCaixa.Location = new System.Drawing.Point(248, 29);
            this.gbCaixa.Name = "gbCaixa";
            this.gbCaixa.Size = new System.Drawing.Size(531, 268);
            this.gbCaixa.TabIndex = 3;
            this.gbCaixa.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cbDia);
            this.groupBox2.Controls.Add(this.checkBox2);
            this.groupBox2.Controls.Add(this.checkBox3);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(33, 204);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(219, 56);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Período";
            // 
            // cbDia
            // 
            this.cbDia.AutoSize = true;
            this.cbDia.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cbDia.Location = new System.Drawing.Point(26, 25);
            this.cbDia.Name = "cbDia";
            this.cbDia.Size = new System.Drawing.Size(52, 24);
            this.cbDia.TabIndex = 3;
            this.cbDia.Text = "Dia";
            this.cbDia.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.checkBox2.Location = new System.Drawing.Point(84, 25);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(58, 24);
            this.checkBox2.TabIndex = 4;
            this.checkBox2.Text = "Mês";
            this.checkBox2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.checkBox3.Location = new System.Drawing.Point(148, 25);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(57, 24);
            this.checkBox3.TabIndex = 5;
            this.checkBox3.Text = "Ano";
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // lblRecCartao
            // 
            this.lblRecCartao.AutoSize = true;
            this.lblRecCartao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblRecCartao.Location = new System.Drawing.Point(29, 55);
            this.lblRecCartao.Name = "lblRecCartao";
            this.lblRecCartao.Size = new System.Drawing.Size(474, 20);
            this.lblRecCartao.TabIndex = 10;
            this.lblRecCartao.Text = "Recebido em cartão:   (VALOR TOTAL RECEBIDO EM CARTÃO)";
            // 
            // lblRecDinheiro
            // 
            this.lblRecDinheiro.AutoSize = true;
            this.lblRecDinheiro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblRecDinheiro.Location = new System.Drawing.Point(29, 113);
            this.lblRecDinheiro.Name = "lblRecDinheiro";
            this.lblRecDinheiro.Size = new System.Drawing.Size(491, 20);
            this.lblRecDinheiro.TabIndex = 9;
            this.lblRecDinheiro.Text = "Recebido em dinheiro: (VALOR TOTAL RECEBIDO EM DINHEIRO)";
            // 
            // lblDinheiro
            // 
            this.lblDinheiro.AutoSize = true;
            this.lblDinheiro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblDinheiro.Location = new System.Drawing.Point(29, 84);
            this.lblDinheiro.Name = "lblDinheiro";
            this.lblDinheiro.Size = new System.Drawing.Size(496, 20);
            this.lblDinheiro.TabIndex = 7;
            this.lblDinheiro.Text = "Vendas em dinheiro:    (QUANTIDADE DE VENDAS EM DINHEIRO)";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblTotal.Location = new System.Drawing.Point(29, 162);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(461, 20);
            this.lblTotal.TabIndex = 6;
            this.lblTotal.Text = "Total de vendas:           (DO DIA / DO MÊS / DO ANO) + (TOTAL)";
            // 
            // lblCartao
            // 
            this.lblCartao.AutoSize = true;
            this.lblCartao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblCartao.Location = new System.Drawing.Point(29, 25);
            this.lblCartao.Name = "lblCartao";
            this.lblCartao.Size = new System.Drawing.Size(479, 20);
            this.lblCartao.TabIndex = 1;
            this.lblCartao.Text = "Vendas em cartão:      (QUANTIDADE DE VENDAS EM CARTÃO)";
            // 
            // dataGridPagamento
            // 
            this.dataGridPagamento.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridPagamento.Enabled = false;
            this.dataGridPagamento.Location = new System.Drawing.Point(21, 303);
            this.dataGridPagamento.Name = "dataGridPagamento";
            this.dataGridPagamento.Size = new System.Drawing.Size(758, 166);
            this.dataGridPagamento.TabIndex = 4;
            // 
            // frmModFinanceiro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 481);
            this.Controls.Add(this.dataGridPagamento);
            this.Controls.Add(this.gbCaixa);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmModFinanceiro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Módulo Financeiro";
            this.Load += new System.EventHandler(this.frmFinanceiro_Load);
            this.groupBox1.ResumeLayout(false);
            this.gbCaixa.ResumeLayout(false);
            this.gbCaixa.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridPagamento)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnCaixa;
        private System.Windows.Forms.Button btnPagamento;
        private System.Windows.Forms.GroupBox gbCaixa;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox cbDia;
        private System.Windows.Forms.Label lblCartao;
        private System.Windows.Forms.Label lblRecDinheiro;
        private System.Windows.Forms.Label lblDinheiro;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.DataGridView dataGridPagamento;
        private System.Windows.Forms.Label lblRecCartao;
        private System.Windows.Forms.Button btnVendasCard;
        private System.Windows.Forms.Button btnPeriodo;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}