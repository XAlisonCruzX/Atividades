namespace Aula01
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtValor1 = new System.Windows.Forms.TextBox();
            this.btnSoma = new System.Windows.Forms.Button();
            this.btnSubtracao = new System.Windows.Forms.Button();
            this.btnDivisao = new System.Windows.Forms.Button();
            this.btnMultiplicacao = new System.Windows.Forms.Button();
            this.btnRaiz = new System.Windows.Forms.Button();
            this.btnPorcent = new System.Windows.Forms.Button();
            this.btnResult = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblEquacao = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtValor1
            // 
            this.txtValor1.Location = new System.Drawing.Point(20, 48);
            this.txtValor1.Name = "txtValor1";
            this.txtValor1.Size = new System.Drawing.Size(128, 20);
            this.txtValor1.TabIndex = 2;
            this.txtValor1.Text = " ";
            // 
            // btnSoma
            // 
            this.btnSoma.Location = new System.Drawing.Point(186, 65);
            this.btnSoma.Name = "btnSoma";
            this.btnSoma.Size = new System.Drawing.Size(26, 23);
            this.btnSoma.TabIndex = 4;
            this.btnSoma.Text = "+";
            this.btnSoma.UseVisualStyleBackColor = true;
            this.btnSoma.Click += new System.EventHandler(this.btnSoma_Click);
            // 
            // btnSubtracao
            // 
            this.btnSubtracao.Location = new System.Drawing.Point(218, 65);
            this.btnSubtracao.Name = "btnSubtracao";
            this.btnSubtracao.Size = new System.Drawing.Size(27, 23);
            this.btnSubtracao.TabIndex = 5;
            this.btnSubtracao.Text = "-";
            this.btnSubtracao.UseVisualStyleBackColor = true;
            this.btnSubtracao.Click += new System.EventHandler(this.btnSubtracao_Click);
            // 
            // btnDivisao
            // 
            this.btnDivisao.Location = new System.Drawing.Point(186, 94);
            this.btnDivisao.Name = "btnDivisao";
            this.btnDivisao.Size = new System.Drawing.Size(26, 23);
            this.btnDivisao.TabIndex = 6;
            this.btnDivisao.Text = "/";
            this.btnDivisao.UseVisualStyleBackColor = true;
            this.btnDivisao.Click += new System.EventHandler(this.btnDivisao_Click);
            // 
            // btnMultiplicacao
            // 
            this.btnMultiplicacao.Location = new System.Drawing.Point(218, 94);
            this.btnMultiplicacao.Name = "btnMultiplicacao";
            this.btnMultiplicacao.Size = new System.Drawing.Size(27, 23);
            this.btnMultiplicacao.TabIndex = 7;
            this.btnMultiplicacao.Text = "*";
            this.btnMultiplicacao.UseVisualStyleBackColor = true;
            this.btnMultiplicacao.Click += new System.EventHandler(this.btnMultiplicacao_Click);
            // 
            // btnRaiz
            // 
            this.btnRaiz.Location = new System.Drawing.Point(218, 123);
            this.btnRaiz.Name = "btnRaiz";
            this.btnRaiz.Size = new System.Drawing.Size(27, 23);
            this.btnRaiz.TabIndex = 10;
            this.btnRaiz.Text = "√";
            this.btnRaiz.UseVisualStyleBackColor = true;
            this.btnRaiz.Click += new System.EventHandler(this.btnRaiz_Click);
            // 
            // btnPorcent
            // 
            this.btnPorcent.Location = new System.Drawing.Point(186, 123);
            this.btnPorcent.Name = "btnPorcent";
            this.btnPorcent.Size = new System.Drawing.Size(27, 23);
            this.btnPorcent.TabIndex = 11;
            this.btnPorcent.Text = "%";
            this.btnPorcent.UseVisualStyleBackColor = true;
            this.btnPorcent.Click += new System.EventHandler(this.btnPorcent_Click);
            // 
            // btnResult
            // 
            this.btnResult.Location = new System.Drawing.Point(73, 123);
            this.btnResult.Name = "btnResult";
            this.btnResult.Size = new System.Drawing.Size(75, 23);
            this.btnResult.TabIndex = 12;
            this.btnResult.Text = "=";
            this.btnResult.UseVisualStyleBackColor = true;
            this.btnResult.Click += new System.EventHandler(this.btnResult_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(20, 123);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(37, 23);
            this.btnClear.TabIndex = 13;
            this.btnClear.Text = "C";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Equação:";
          
            // 
            // lblEquacao
            // 
            this.lblEquacao.AutoSize = true;
            this.lblEquacao.Location = new System.Drawing.Point(76, 23);
            this.lblEquacao.Name = "lblEquacao";
            this.lblEquacao.Size = new System.Drawing.Size(0, 13);
            this.lblEquacao.TabIndex = 15;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(261, 187);
            this.Controls.Add(this.lblEquacao);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnResult);
            this.Controls.Add(this.btnPorcent);
            this.Controls.Add(this.btnRaiz);
            this.Controls.Add(this.btnMultiplicacao);
            this.Controls.Add(this.btnDivisao);
            this.Controls.Add(this.btnSubtracao);
            this.Controls.Add(this.btnSoma);
            this.Controls.Add(this.txtValor1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Calc";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtValor1;
        private System.Windows.Forms.Button btnSoma;
        private System.Windows.Forms.Button btnSubtracao;
        private System.Windows.Forms.Button btnDivisao;
        private System.Windows.Forms.Button btnMultiplicacao;
        private System.Windows.Forms.Button btnRaiz;
        private System.Windows.Forms.Button btnPorcent;
        private System.Windows.Forms.Button btnResult;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblEquacao;
    }
}

