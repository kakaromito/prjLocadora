
namespace prjLocadora
{
    partial class frmProdutoras
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
            this.txtCodprod = new System.Windows.Forms.TextBox();
            this.txtCod = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnUltimo = new System.Windows.Forms.Button();
            this.btnProximo = new System.Windows.Forms.Button();
            this.btnAnterior = new System.Windows.Forms.Button();
            this.btnPrimeiro = new System.Windows.Forms.Button();
            this.txtEmailprod = new System.Windows.Forms.TextBox();
            this.txtTelprod = new System.Windows.Forms.TextBox();
            this.txtEmailProdutora = new System.Windows.Forms.Label();
            this.txtTelefoneProdutora = new System.Windows.Forms.Label();
            this.txtProd = new System.Windows.Forms.TextBox();
            this.txtProdutora = new System.Windows.Forms.Label();
            this.btnNovo = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtCodprod
            // 
            this.txtCodprod.Location = new System.Drawing.Point(244, 65);
            this.txtCodprod.Name = "txtCodprod";
            this.txtCodprod.Size = new System.Drawing.Size(56, 26);
            this.txtCodprod.TabIndex = 0;
            this.txtCodprod.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtCod
            // 
            this.txtCod.AutoSize = true;
            this.txtCod.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCod.ForeColor = System.Drawing.Color.White;
            this.txtCod.Location = new System.Drawing.Point(73, 68);
            this.txtCod.Name = "txtCod";
            this.txtCod.Size = new System.Drawing.Size(149, 20);
            this.txtCod.TabIndex = 1;
            this.txtCod.Text = "Código Produtora";
            this.txtCod.Click += new System.EventHandler(this.label1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.MediumAquamarine;
            this.groupBox1.Controls.Add(this.btnUltimo);
            this.groupBox1.Controls.Add(this.btnProximo);
            this.groupBox1.Controls.Add(this.btnAnterior);
            this.groupBox1.Controls.Add(this.btnPrimeiro);
            this.groupBox1.Controls.Add(this.txtEmailprod);
            this.groupBox1.Controls.Add(this.txtTelprod);
            this.groupBox1.Controls.Add(this.txtEmailProdutora);
            this.groupBox1.Controls.Add(this.txtTelefoneProdutora);
            this.groupBox1.Controls.Add(this.txtProd);
            this.groupBox1.Controls.Add(this.txtCod);
            this.groupBox1.Controls.Add(this.txtProdutora);
            this.groupBox1.Controls.Add(this.txtCodprod);
            this.groupBox1.Location = new System.Drawing.Point(21, 46);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(758, 365);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // btnUltimo
            // 
            this.btnUltimo.BackColor = System.Drawing.Color.DarkCyan;
            this.btnUltimo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUltimo.ForeColor = System.Drawing.Color.White;
            this.btnUltimo.Location = new System.Drawing.Point(496, 279);
            this.btnUltimo.Name = "btnUltimo";
            this.btnUltimo.Size = new System.Drawing.Size(75, 42);
            this.btnUltimo.TabIndex = 3;
            this.btnUltimo.Text = ">>";
            this.btnUltimo.UseVisualStyleBackColor = false;
            this.btnUltimo.Click += new System.EventHandler(this.btnUltimo_Click);
            // 
            // btnProximo
            // 
            this.btnProximo.BackColor = System.Drawing.Color.DarkCyan;
            this.btnProximo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProximo.ForeColor = System.Drawing.Color.White;
            this.btnProximo.Location = new System.Drawing.Point(392, 279);
            this.btnProximo.Name = "btnProximo";
            this.btnProximo.Size = new System.Drawing.Size(75, 42);
            this.btnProximo.TabIndex = 10;
            this.btnProximo.Text = ">";
            this.btnProximo.UseVisualStyleBackColor = false;
            this.btnProximo.Click += new System.EventHandler(this.btnProximo_Click);
            // 
            // btnAnterior
            // 
            this.btnAnterior.BackColor = System.Drawing.Color.DarkCyan;
            this.btnAnterior.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnterior.ForeColor = System.Drawing.Color.White;
            this.btnAnterior.Location = new System.Drawing.Point(291, 279);
            this.btnAnterior.Name = "btnAnterior";
            this.btnAnterior.Size = new System.Drawing.Size(75, 42);
            this.btnAnterior.TabIndex = 9;
            this.btnAnterior.Text = "<";
            this.btnAnterior.UseVisualStyleBackColor = false;
            this.btnAnterior.Click += new System.EventHandler(this.btnAnterior_Click);
            // 
            // btnPrimeiro
            // 
            this.btnPrimeiro.BackColor = System.Drawing.Color.DarkCyan;
            this.btnPrimeiro.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrimeiro.ForeColor = System.Drawing.Color.White;
            this.btnPrimeiro.Location = new System.Drawing.Point(174, 279);
            this.btnPrimeiro.Name = "btnPrimeiro";
            this.btnPrimeiro.Size = new System.Drawing.Size(75, 42);
            this.btnPrimeiro.TabIndex = 8;
            this.btnPrimeiro.Text = "<<";
            this.btnPrimeiro.UseVisualStyleBackColor = false;
            this.btnPrimeiro.Click += new System.EventHandler(this.btnPrimeiro_Click);
            // 
            // txtEmailprod
            // 
            this.txtEmailprod.Location = new System.Drawing.Point(244, 229);
            this.txtEmailprod.Name = "txtEmailprod";
            this.txtEmailprod.Size = new System.Drawing.Size(287, 26);
            this.txtEmailprod.TabIndex = 7;
            // 
            // txtTelprod
            // 
            this.txtTelprod.Location = new System.Drawing.Point(244, 164);
            this.txtTelprod.Name = "txtTelprod";
            this.txtTelprod.Size = new System.Drawing.Size(152, 26);
            this.txtTelprod.TabIndex = 6;
            this.txtTelprod.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // txtEmailProdutora
            // 
            this.txtEmailProdutora.AutoSize = true;
            this.txtEmailProdutora.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmailProdutora.ForeColor = System.Drawing.Color.White;
            this.txtEmailProdutora.Location = new System.Drawing.Point(73, 229);
            this.txtEmailProdutora.Name = "txtEmailProdutora";
            this.txtEmailProdutora.Size = new System.Drawing.Size(143, 20);
            this.txtEmailProdutora.TabIndex = 5;
            this.txtEmailProdutora.Text = "E-mail Produtora";
            // 
            // txtTelefoneProdutora
            // 
            this.txtTelefoneProdutora.AutoSize = true;
            this.txtTelefoneProdutora.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTelefoneProdutora.ForeColor = System.Drawing.Color.White;
            this.txtTelefoneProdutora.Location = new System.Drawing.Point(73, 167);
            this.txtTelefoneProdutora.Name = "txtTelefoneProdutora";
            this.txtTelefoneProdutora.Size = new System.Drawing.Size(163, 20);
            this.txtTelefoneProdutora.TabIndex = 4;
            this.txtTelefoneProdutora.Text = "Telefone Produtora";
            // 
            // txtProd
            // 
            this.txtProd.Location = new System.Drawing.Point(244, 111);
            this.txtProd.Name = "txtProd";
            this.txtProd.Size = new System.Drawing.Size(358, 26);
            this.txtProd.TabIndex = 3;
            // 
            // txtProdutora
            // 
            this.txtProdutora.AutoSize = true;
            this.txtProdutora.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProdutora.ForeColor = System.Drawing.Color.White;
            this.txtProdutora.Location = new System.Drawing.Point(73, 111);
            this.txtProdutora.Name = "txtProdutora";
            this.txtProdutora.Size = new System.Drawing.Size(88, 20);
            this.txtProdutora.TabIndex = 2;
            this.txtProdutora.Text = "Produtora";
            // 
            // btnNovo
            // 
            this.btnNovo.Location = new System.Drawing.Point(107, 12);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(75, 28);
            this.btnNovo.TabIndex = 11;
            this.btnNovo.Text = "Novo";
            this.btnNovo.UseVisualStyleBackColor = true;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(211, 12);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 28);
            this.btnSalvar.TabIndex = 12;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(325, 12);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(75, 28);
            this.btnExcluir.TabIndex = 13;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnAlterar
            // 
            this.btnAlterar.Location = new System.Drawing.Point(434, 12);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(75, 28);
            this.btnAlterar.TabIndex = 14;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.UseVisualStyleBackColor = true;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // frmProdutoras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkCyan;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.btnNovo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmProdutoras";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Produtoras";
            this.Load += new System.EventHandler(this.frmProdutoras_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtCodprod;
        private System.Windows.Forms.Label txtCod;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtProd;
        private System.Windows.Forms.Label txtProdutora;
        private System.Windows.Forms.Button btnUltimo;
        private System.Windows.Forms.Button btnProximo;
        private System.Windows.Forms.Button btnAnterior;
        private System.Windows.Forms.Button btnPrimeiro;
        private System.Windows.Forms.TextBox txtEmailprod;
        private System.Windows.Forms.TextBox txtTelprod;
        private System.Windows.Forms.Label txtEmailProdutora;
        private System.Windows.Forms.Label txtTelefoneProdutora;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnAlterar;
    }
}