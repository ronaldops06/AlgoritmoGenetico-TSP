namespace AlgoritmoGeneticoTSP
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
            this.components = new System.ComponentModel.Container();
            this.zedMedia = new ZedGraph.ZedGraphControl();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbMenorDistancia = new System.Windows.Forms.Label();
            this.lbMenor = new System.Windows.Forms.Label();
            this.lbEvolucoes = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnExecutar = new System.Windows.Forms.Button();
            this.btnCriarPop = new System.Windows.Forms.Button();
            this.gbMutacao = new System.Windows.Forms.GroupBox();
            this.rbGenesPop = new System.Windows.Forms.RadioButton();
            this.rbPopGeral = new System.Windows.Forms.RadioButton();
            this.rbNovoIndividuo = new System.Windows.Forms.RadioButton();
            this.txtQtdeTorneio = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtQtdeElitismo = new System.Windows.Forms.TextBox();
            this.chElitismo = new System.Windows.Forms.CheckBox();
            this.txtEvolucao = new System.Windows.Forms.TextBox();
            this.txtTaxaMutacao = new System.Windows.Forms.TextBox();
            this.txtTaxaCrossover = new System.Windows.Forms.TextBox();
            this.txtTamPop = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lbQtdeCidades = new System.Windows.Forms.Label();
            this.lbComplex = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lbMaiorDistancia = new System.Windows.Forms.Label();
            this.lbMaior = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.gbMutacao.SuspendLayout();
            this.SuspendLayout();
            // 
            // zedMedia
            // 
            this.zedMedia.Location = new System.Drawing.Point(12, 314);
            this.zedMedia.Name = "zedMedia";
            this.zedMedia.ScrollGrace = 0D;
            this.zedMedia.ScrollMaxX = 0D;
            this.zedMedia.ScrollMaxY = 0D;
            this.zedMedia.ScrollMaxY2 = 0D;
            this.zedMedia.ScrollMinX = 0D;
            this.zedMedia.ScrollMinY = 0D;
            this.zedMedia.ScrollMinY2 = 0D;
            this.zedMedia.Size = new System.Drawing.Size(426, 218);
            this.zedMedia.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.panel1.Controls.Add(this.lbMaiorDistancia);
            this.panel1.Controls.Add(this.lbMaior);
            this.panel1.Controls.Add(this.lbMenorDistancia);
            this.panel1.Controls.Add(this.zedMedia);
            this.panel1.Controls.Add(this.lbMenor);
            this.panel1.Controls.Add(this.lbEvolucoes);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.btnLimpar);
            this.panel1.Controls.Add(this.btnExecutar);
            this.panel1.Controls.Add(this.btnCriarPop);
            this.panel1.Controls.Add(this.gbMutacao);
            this.panel1.Controls.Add(this.txtQtdeTorneio);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.txtQtdeElitismo);
            this.panel1.Controls.Add(this.chElitismo);
            this.panel1.Controls.Add(this.txtEvolucao);
            this.panel1.Controls.Add(this.txtTaxaMutacao);
            this.panel1.Controls.Add(this.txtTaxaCrossover);
            this.panel1.Controls.Add(this.txtTamPop);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(450, 535);
            this.panel1.TabIndex = 1;
            // 
            // lbMenorDistancia
            // 
            this.lbMenorDistancia.AutoSize = true;
            this.lbMenorDistancia.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMenorDistancia.Location = new System.Drawing.Point(150, 284);
            this.lbMenorDistancia.Name = "lbMenorDistancia";
            this.lbMenorDistancia.Size = new System.Drawing.Size(29, 20);
            this.lbMenorDistancia.TabIndex = 18;
            this.lbMenorDistancia.Text = "00";
            // 
            // lbMenor
            // 
            this.lbMenor.AutoSize = true;
            this.lbMenor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMenor.Location = new System.Drawing.Point(8, 284);
            this.lbMenor.Name = "lbMenor";
            this.lbMenor.Size = new System.Drawing.Size(144, 20);
            this.lbMenor.TabIndex = 17;
            this.lbMenor.Text = "Menor Distância:";
            // 
            // lbEvolucoes
            // 
            this.lbEvolucoes.AutoSize = true;
            this.lbEvolucoes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEvolucoes.Location = new System.Drawing.Point(149, 260);
            this.lbEvolucoes.Name = "lbEvolucoes";
            this.lbEvolucoes.Size = new System.Drawing.Size(29, 20);
            this.lbEvolucoes.TabIndex = 16;
            this.lbEvolucoes.Text = "00";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(55, 259);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(96, 20);
            this.label6.TabIndex = 15;
            this.label6.Text = "Evoluções:";
            // 
            // btnLimpar
            // 
            this.btnLimpar.Enabled = false;
            this.btnLimpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpar.Location = new System.Drawing.Point(277, 196);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(161, 50);
            this.btnLimpar.TabIndex = 14;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnExecutar
            // 
            this.btnExecutar.Enabled = false;
            this.btnExecutar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExecutar.Location = new System.Drawing.Point(277, 140);
            this.btnExecutar.Name = "btnExecutar";
            this.btnExecutar.Size = new System.Drawing.Size(161, 50);
            this.btnExecutar.TabIndex = 13;
            this.btnExecutar.Text = "Executar/Continuar";
            this.btnExecutar.UseVisualStyleBackColor = true;
            this.btnExecutar.Click += new System.EventHandler(this.btnExecutar_Click);
            // 
            // btnCriarPop
            // 
            this.btnCriarPop.Enabled = false;
            this.btnCriarPop.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCriarPop.Location = new System.Drawing.Point(277, 84);
            this.btnCriarPop.Name = "btnCriarPop";
            this.btnCriarPop.Size = new System.Drawing.Size(161, 50);
            this.btnCriarPop.TabIndex = 2;
            this.btnCriarPop.Text = "Criar População";
            this.btnCriarPop.UseVisualStyleBackColor = true;
            this.btnCriarPop.Click += new System.EventHandler(this.btnCriarPop_Click);
            // 
            // gbMutacao
            // 
            this.gbMutacao.Controls.Add(this.rbGenesPop);
            this.gbMutacao.Controls.Add(this.rbPopGeral);
            this.gbMutacao.Controls.Add(this.rbNovoIndividuo);
            this.gbMutacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbMutacao.Location = new System.Drawing.Point(17, 138);
            this.gbMutacao.Name = "gbMutacao";
            this.gbMutacao.Size = new System.Drawing.Size(240, 108);
            this.gbMutacao.TabIndex = 12;
            this.gbMutacao.TabStop = false;
            this.gbMutacao.Text = "Mutação";
            // 
            // rbGenesPop
            // 
            this.rbGenesPop.AutoSize = true;
            this.rbGenesPop.Enabled = false;
            this.rbGenesPop.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbGenesPop.Location = new System.Drawing.Point(20, 74);
            this.rbGenesPop.Name = "rbGenesPop";
            this.rbGenesPop.Size = new System.Drawing.Size(154, 24);
            this.rbGenesPop.TabIndex = 2;
            this.rbGenesPop.Text = "Genes População";
            this.rbGenesPop.UseVisualStyleBackColor = true;
            // 
            // rbPopGeral
            // 
            this.rbPopGeral.AutoSize = true;
            this.rbPopGeral.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbPopGeral.Location = new System.Drawing.Point(20, 48);
            this.rbPopGeral.Name = "rbPopGeral";
            this.rbPopGeral.Size = new System.Drawing.Size(145, 24);
            this.rbPopGeral.TabIndex = 1;
            this.rbPopGeral.Text = "População Geral";
            this.rbPopGeral.UseVisualStyleBackColor = true;
            // 
            // rbNovoIndividuo
            // 
            this.rbNovoIndividuo.AutoSize = true;
            this.rbNovoIndividuo.Checked = true;
            this.rbNovoIndividuo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbNovoIndividuo.Location = new System.Drawing.Point(20, 22);
            this.rbNovoIndividuo.Name = "rbNovoIndividuo";
            this.rbNovoIndividuo.Size = new System.Drawing.Size(130, 24);
            this.rbNovoIndividuo.TabIndex = 0;
            this.rbNovoIndividuo.TabStop = true;
            this.rbNovoIndividuo.Text = "Novo Indivíduo";
            this.rbNovoIndividuo.UseVisualStyleBackColor = true;
            // 
            // txtQtdeTorneio
            // 
            this.txtQtdeTorneio.Location = new System.Drawing.Point(391, 51);
            this.txtQtdeTorneio.Name = "txtQtdeTorneio";
            this.txtQtdeTorneio.Size = new System.Drawing.Size(32, 20);
            this.txtQtdeTorneio.TabIndex = 11;
            this.txtQtdeTorneio.Text = "4";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(324, 51);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 20);
            this.label5.TabIndex = 10;
            this.label5.Text = "Torneio:";
            // 
            // txtQtdeElitismo
            // 
            this.txtQtdeElitismo.Location = new System.Drawing.Point(391, 24);
            this.txtQtdeElitismo.Name = "txtQtdeElitismo";
            this.txtQtdeElitismo.Size = new System.Drawing.Size(32, 20);
            this.txtQtdeElitismo.TabIndex = 9;
            this.txtQtdeElitismo.Text = "2";
            // 
            // chElitismo
            // 
            this.chElitismo.AutoSize = true;
            this.chElitismo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)), true);
            this.chElitismo.Location = new System.Drawing.Point(303, 22);
            this.chElitismo.Name = "chElitismo";
            this.chElitismo.Size = new System.Drawing.Size(83, 24);
            this.chElitismo.TabIndex = 8;
            this.chElitismo.Text = "Elitismo";
            this.chElitismo.UseVisualStyleBackColor = true;
            // 
            // txtEvolucao
            // 
            this.txtEvolucao.Location = new System.Drawing.Point(157, 101);
            this.txtEvolucao.Name = "txtEvolucao";
            this.txtEvolucao.Size = new System.Drawing.Size(100, 20);
            this.txtEvolucao.TabIndex = 7;
            this.txtEvolucao.Text = "100";
            // 
            // txtTaxaMutacao
            // 
            this.txtTaxaMutacao.Location = new System.Drawing.Point(157, 74);
            this.txtTaxaMutacao.Name = "txtTaxaMutacao";
            this.txtTaxaMutacao.Size = new System.Drawing.Size(100, 20);
            this.txtTaxaMutacao.TabIndex = 6;
            this.txtTaxaMutacao.Text = "0,001";
            // 
            // txtTaxaCrossover
            // 
            this.txtTaxaCrossover.Location = new System.Drawing.Point(157, 47);
            this.txtTaxaCrossover.Name = "txtTaxaCrossover";
            this.txtTaxaCrossover.Size = new System.Drawing.Size(100, 20);
            this.txtTaxaCrossover.TabIndex = 5;
            this.txtTaxaCrossover.Text = "0,6";
            // 
            // txtTamPop
            // 
            this.txtTamPop.Location = new System.Drawing.Point(157, 21);
            this.txtTamPop.Name = "txtTamPop";
            this.txtTamPop.Size = new System.Drawing.Size(100, 20);
            this.txtTamPop.TabIndex = 4;
            this.txtTamPop.Text = "50";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(71, 101);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Evoluções:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(21, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(135, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Taxa de Mutação:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(144, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Taxa de Crossover:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(44, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tamanho Pop:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(456, 5);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(180, 20);
            this.label7.TabIndex = 2;
            this.label7.Text = "Quantidade de Cidades:";
            // 
            // lbQtdeCidades
            // 
            this.lbQtdeCidades.AutoSize = true;
            this.lbQtdeCidades.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbQtdeCidades.Location = new System.Drawing.Point(634, 5);
            this.lbQtdeCidades.Name = "lbQtdeCidades";
            this.lbQtdeCidades.Size = new System.Drawing.Size(19, 20);
            this.lbQtdeCidades.TabIndex = 3;
            this.lbQtdeCidades.Text = "--";
            this.lbQtdeCidades.UseMnemonic = false;
            // 
            // lbComplex
            // 
            this.lbComplex.AutoSize = true;
            this.lbComplex.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbComplex.Location = new System.Drawing.Point(554, 482);
            this.lbComplex.Name = "lbComplex";
            this.lbComplex.Size = new System.Drawing.Size(16, 17);
            this.lbComplex.TabIndex = 5;
            this.lbComplex.Text = "0";
            this.lbComplex.UseMnemonic = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(456, 481);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(100, 17);
            this.label9.TabIndex = 4;
            this.label9.Text = "Complexidade:";
            // 
            // lbMaiorDistancia
            // 
            this.lbMaiorDistancia.AutoSize = true;
            this.lbMaiorDistancia.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMaiorDistancia.Location = new System.Drawing.Point(369, 284);
            this.lbMaiorDistancia.Name = "lbMaiorDistancia";
            this.lbMaiorDistancia.Size = new System.Drawing.Size(29, 20);
            this.lbMaiorDistancia.TabIndex = 20;
            this.lbMaiorDistancia.Text = "00";
            // 
            // lbMaior
            // 
            this.lbMaior.AutoSize = true;
            this.lbMaior.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMaior.Location = new System.Drawing.Point(227, 284);
            this.lbMaior.Name = "lbMaior";
            this.lbMaior.Size = new System.Drawing.Size(138, 20);
            this.lbMaior.TabIndex = 19;
            this.lbMaior.Text = "Maior Distância:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1249, 535);
            this.Controls.Add(this.lbComplex);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.lbQtdeCidades);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.gbMutacao.ResumeLayout(false);
            this.gbMutacao.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ZedGraph.ZedGraphControl zedMedia;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox gbMutacao;
        private System.Windows.Forms.RadioButton rbGenesPop;
        private System.Windows.Forms.RadioButton rbPopGeral;
        private System.Windows.Forms.RadioButton rbNovoIndividuo;
        private System.Windows.Forms.TextBox txtQtdeTorneio;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtQtdeElitismo;
        private System.Windows.Forms.CheckBox chElitismo;
        private System.Windows.Forms.TextBox txtEvolucao;
        private System.Windows.Forms.TextBox txtTaxaMutacao;
        private System.Windows.Forms.TextBox txtTaxaCrossover;
        private System.Windows.Forms.TextBox txtTamPop;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbMenorDistancia;
        private System.Windows.Forms.Label lbMenor;
        private System.Windows.Forms.Label lbEvolucoes;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnExecutar;
        private System.Windows.Forms.Button btnCriarPop;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lbQtdeCidades;
        private System.Windows.Forms.Label lbComplex;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lbMaiorDistancia;
        private System.Windows.Forms.Label lbMaior;
    }
}

