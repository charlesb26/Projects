
namespace WindowsForms_Calculadora
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
            this.txt_resultado = new System.Windows.Forms.TextBox();
            this.btnSom = new System.Windows.Forms.Button();
            this.btn9 = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.btn7 = new System.Windows.Forms.Button();
            this.btnSub = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btnMult = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn1 = new System.Windows.Forms.Button();
            this.btnDiv = new System.Windows.Forms.Button();
            this.btnPonto = new System.Windows.Forms.Button();
            this.btn0 = new System.Windows.Forms.Button();
            this.btnCE = new System.Windows.Forms.Button();
            this.btnC = new System.Windows.Forms.Button();
            this.btnIgual = new System.Windows.Forms.Button();
            this.lbl_operacao = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txt_resultado
            // 
            this.txt_resultado.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_resultado.Location = new System.Drawing.Point(12, 49);
            this.txt_resultado.Name = "txt_resultado";
            this.txt_resultado.Size = new System.Drawing.Size(309, 20);
            this.txt_resultado.TabIndex = 0;
            this.txt_resultado.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnSom
            // 
            this.btnSom.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnSom.Location = new System.Drawing.Point(198, 107);
            this.btnSom.Name = "btnSom";
            this.btnSom.Size = new System.Drawing.Size(52, 51);
            this.btnSom.TabIndex = 13;
            this.btnSom.Text = "+";
            this.btnSom.UseVisualStyleBackColor = true;
            this.btnSom.Click += new System.EventHandler(this.btnSom_Click);
            // 
            // btn9
            // 
            this.btn9.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn9.Location = new System.Drawing.Point(140, 107);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(52, 51);
            this.btn9.TabIndex = 12;
            this.btn9.Text = "9";
            this.btn9.UseVisualStyleBackColor = true;
            this.btn9.Click += new System.EventHandler(this.btn9_Click);
            // 
            // btn8
            // 
            this.btn8.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn8.Location = new System.Drawing.Point(82, 107);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(52, 51);
            this.btn8.TabIndex = 11;
            this.btn8.Text = "8";
            this.btn8.UseVisualStyleBackColor = true;
            this.btn8.Click += new System.EventHandler(this.btn8_Click);
            // 
            // btn7
            // 
            this.btn7.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn7.Location = new System.Drawing.Point(24, 107);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(52, 51);
            this.btn7.TabIndex = 10;
            this.btn7.Text = "7";
            this.btn7.UseVisualStyleBackColor = true;
            this.btn7.Click += new System.EventHandler(this.btn7_Click);
            // 
            // btnSub
            // 
            this.btnSub.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnSub.Location = new System.Drawing.Point(198, 164);
            this.btnSub.Name = "btnSub";
            this.btnSub.Size = new System.Drawing.Size(52, 51);
            this.btnSub.TabIndex = 17;
            this.btnSub.Text = "-";
            this.btnSub.UseVisualStyleBackColor = true;
            this.btnSub.Click += new System.EventHandler(this.btnSub_Click);
            // 
            // btn6
            // 
            this.btn6.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn6.Location = new System.Drawing.Point(140, 164);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(52, 51);
            this.btn6.TabIndex = 16;
            this.btn6.Text = "6";
            this.btn6.UseVisualStyleBackColor = true;
            this.btn6.Click += new System.EventHandler(this.btn6_Click);
            // 
            // btn5
            // 
            this.btn5.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn5.Location = new System.Drawing.Point(82, 164);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(52, 51);
            this.btn5.TabIndex = 15;
            this.btn5.Text = "5";
            this.btn5.UseVisualStyleBackColor = true;
            this.btn5.Click += new System.EventHandler(this.btn5_Click);
            // 
            // btn4
            // 
            this.btn4.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn4.Location = new System.Drawing.Point(24, 164);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(52, 51);
            this.btn4.TabIndex = 14;
            this.btn4.Text = "4";
            this.btn4.UseVisualStyleBackColor = true;
            this.btn4.Click += new System.EventHandler(this.btn4_Click);
            // 
            // btnMult
            // 
            this.btnMult.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnMult.Location = new System.Drawing.Point(198, 221);
            this.btnMult.Name = "btnMult";
            this.btnMult.Size = new System.Drawing.Size(52, 51);
            this.btnMult.TabIndex = 21;
            this.btnMult.Text = "*";
            this.btnMult.UseVisualStyleBackColor = true;
            this.btnMult.Click += new System.EventHandler(this.btnMult_Click);
            // 
            // btn3
            // 
            this.btn3.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn3.Location = new System.Drawing.Point(140, 221);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(52, 51);
            this.btn3.TabIndex = 20;
            this.btn3.Text = "3";
            this.btn3.UseVisualStyleBackColor = true;
            this.btn3.Click += new System.EventHandler(this.btn3_Click);
            // 
            // btn2
            // 
            this.btn2.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn2.Location = new System.Drawing.Point(82, 221);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(52, 51);
            this.btn2.TabIndex = 19;
            this.btn2.Text = "2";
            this.btn2.UseVisualStyleBackColor = true;
            this.btn2.Click += new System.EventHandler(this.btn2_Click);
            // 
            // btn1
            // 
            this.btn1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn1.Location = new System.Drawing.Point(24, 221);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(52, 51);
            this.btn1.TabIndex = 18;
            this.btn1.Text = "1";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.btn1_Click);
            // 
            // btnDiv
            // 
            this.btnDiv.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnDiv.Location = new System.Drawing.Point(198, 278);
            this.btnDiv.Name = "btnDiv";
            this.btnDiv.Size = new System.Drawing.Size(52, 51);
            this.btnDiv.TabIndex = 25;
            this.btnDiv.Text = "/";
            this.btnDiv.UseVisualStyleBackColor = true;
            this.btnDiv.Click += new System.EventHandler(this.btnDiv_Click);
            // 
            // btnPonto
            // 
            this.btnPonto.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnPonto.Location = new System.Drawing.Point(140, 278);
            this.btnPonto.Name = "btnPonto";
            this.btnPonto.Size = new System.Drawing.Size(52, 51);
            this.btnPonto.TabIndex = 24;
            this.btnPonto.Text = ".";
            this.btnPonto.UseVisualStyleBackColor = true;
            this.btnPonto.Click += new System.EventHandler(this.btnPonto_Click);
            // 
            // btn0
            // 
            this.btn0.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn0.Location = new System.Drawing.Point(24, 278);
            this.btn0.Name = "btn0";
            this.btn0.Size = new System.Drawing.Size(110, 51);
            this.btn0.TabIndex = 22;
            this.btn0.Text = "0";
            this.btn0.UseVisualStyleBackColor = true;
            this.btn0.Click += new System.EventHandler(this.btn0_Click);
            // 
            // btnCE
            // 
            this.btnCE.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnCE.Location = new System.Drawing.Point(256, 107);
            this.btnCE.Name = "btnCE";
            this.btnCE.Size = new System.Drawing.Size(52, 51);
            this.btnCE.TabIndex = 26;
            this.btnCE.Text = "CE";
            this.btnCE.UseVisualStyleBackColor = true;
            this.btnCE.Click += new System.EventHandler(this.btnCE_Click);
            // 
            // btnC
            // 
            this.btnC.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnC.Location = new System.Drawing.Point(256, 164);
            this.btnC.Name = "btnC";
            this.btnC.Size = new System.Drawing.Size(52, 51);
            this.btnC.TabIndex = 27;
            this.btnC.Text = "C";
            this.btnC.UseVisualStyleBackColor = true;
            this.btnC.Click += new System.EventHandler(this.btnC_Click);
            // 
            // btnIgual
            // 
            this.btnIgual.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnIgual.Location = new System.Drawing.Point(256, 221);
            this.btnIgual.Name = "btnIgual";
            this.btnIgual.Size = new System.Drawing.Size(52, 108);
            this.btnIgual.TabIndex = 28;
            this.btnIgual.Text = "=";
            this.btnIgual.UseVisualStyleBackColor = true;
            this.btnIgual.Click += new System.EventHandler(this.btnIgual_Click);
            // 
            // lbl_operacao
            // 
            this.lbl_operacao.AutoSize = true;
            this.lbl_operacao.Location = new System.Drawing.Point(21, 52);
            this.lbl_operacao.Name = "lbl_operacao";
            this.lbl_operacao.Size = new System.Drawing.Size(0, 13);
            this.lbl_operacao.TabIndex = 30;
            this.lbl_operacao.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(333, 350);
            this.Controls.Add(this.lbl_operacao);
            this.Controls.Add(this.btnIgual);
            this.Controls.Add(this.btnC);
            this.Controls.Add(this.btnCE);
            this.Controls.Add(this.btnDiv);
            this.Controls.Add(this.btnPonto);
            this.Controls.Add(this.btn0);
            this.Controls.Add(this.btnMult);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.btnSub);
            this.Controls.Add(this.btn6);
            this.Controls.Add(this.btn5);
            this.Controls.Add(this.btn4);
            this.Controls.Add(this.btnSom);
            this.Controls.Add(this.btn9);
            this.Controls.Add(this.btn8);
            this.Controls.Add(this.btn7);
            this.Controls.Add(this.txt_resultado);
            this.Controls.Add(this.btn1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_resultado;
        private System.Windows.Forms.Button btnSom;
        private System.Windows.Forms.Button btn9;
        private System.Windows.Forms.Button btn8;
        private System.Windows.Forms.Button btn7;
        private System.Windows.Forms.Button btnSub;
        private System.Windows.Forms.Button btn6;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btnMult;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btnDiv;
        private System.Windows.Forms.Button btnPonto;
        private System.Windows.Forms.Button btn0;
        private System.Windows.Forms.Button btnCE;
        private System.Windows.Forms.Button btnC;
        private System.Windows.Forms.Button btnIgual;
        private System.Windows.Forms.Label lbl_operacao;
    }
}

