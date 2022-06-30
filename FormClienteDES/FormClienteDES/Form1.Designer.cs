namespace FormClienteDES
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tb_tel = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tb_telresidencial = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tb_cpf = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_rg = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_nome = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_codigo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.rd_ndizer = new System.Windows.Forms.RadioButton();
            this.rd_fem = new System.Windows.Forms.RadioButton();
            this.rd_masc = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tb_cidade = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.tb_bairro = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.tb_numero = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.tb_logradouro = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tb_cep = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.cb_const = new System.Windows.Forms.CheckBox();
            this.cb_email = new System.Windows.Forms.CheckBox();
            this.tb_emailconst = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.tb_email = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.pcbfoto = new System.Windows.Forms.PictureBox();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbfoto)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tb_tel);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.tb_telresidencial);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.tb_cpf);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.tb_rg);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.tb_nome);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.tb_codigo);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(421, 137);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dados Pessoais";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // tb_tel
            // 
            this.tb_tel.Location = new System.Drawing.Point(257, 104);
            this.tb_tel.Name = "tb_tel";
            this.tb_tel.Size = new System.Drawing.Size(155, 20);
            this.tb_tel.TabIndex = 11;
            this.tb_tel.Tag = "codigo";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(226, 107);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(25, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Tel:";
            // 
            // tb_telresidencial
            // 
            this.tb_telresidencial.Location = new System.Drawing.Point(96, 104);
            this.tb_telresidencial.Name = "tb_telresidencial";
            this.tb_telresidencial.Size = new System.Drawing.Size(119, 20);
            this.tb_telresidencial.TabIndex = 9;
            this.tb_telresidencial.Tag = "codigo";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 107);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Tel. Residencial:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // tb_cpf
            // 
            this.tb_cpf.Location = new System.Drawing.Point(257, 78);
            this.tb_cpf.Name = "tb_cpf";
            this.tb_cpf.Size = new System.Drawing.Size(155, 20);
            this.tb_cpf.TabIndex = 7;
            this.tb_cpf.Tag = "codigo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(221, 81);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "CPF:";
            // 
            // tb_rg
            // 
            this.tb_rg.Location = new System.Drawing.Point(60, 78);
            this.tb_rg.Name = "tb_rg";
            this.tb_rg.Size = new System.Drawing.Size(155, 20);
            this.tb_rg.TabIndex = 5;
            this.tb_rg.Tag = "codigo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "RG:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // tb_nome
            // 
            this.tb_nome.Location = new System.Drawing.Point(60, 52);
            this.tb_nome.Name = "tb_nome";
            this.tb_nome.Size = new System.Drawing.Size(352, 20);
            this.tb_nome.TabIndex = 3;
            this.tb_nome.Tag = "codigo";
            this.tb_nome.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nome:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // tb_codigo
            // 
            this.tb_codigo.Location = new System.Drawing.Point(60, 26);
            this.tb_codigo.Name = "tb_codigo";
            this.tb_codigo.Size = new System.Drawing.Size(155, 20);
            this.tb_codigo.TabIndex = 1;
            this.tb_codigo.Tag = "codigo";
            this.tb_codigo.TextChanged += new System.EventHandler(this.tb_codigo_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Código:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.rd_ndizer);
            this.groupBox4.Controls.Add(this.rd_fem);
            this.groupBox4.Controls.Add(this.rd_masc);
            this.groupBox4.Location = new System.Drawing.Point(13, 156);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(421, 44);
            this.groupBox4.TabIndex = 13;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Sexo";
            // 
            // rd_ndizer
            // 
            this.rd_ndizer.AutoSize = true;
            this.rd_ndizer.Location = new System.Drawing.Point(164, 19);
            this.rd_ndizer.Name = "rd_ndizer";
            this.rd_ndizer.Size = new System.Drawing.Size(101, 17);
            this.rd_ndizer.TabIndex = 2;
            this.rd_ndizer.TabStop = true;
            this.rd_ndizer.Text = "Prefiro não dizer";
            this.rd_ndizer.UseVisualStyleBackColor = true;
            // 
            // rd_fem
            // 
            this.rd_fem.AutoSize = true;
            this.rd_fem.Location = new System.Drawing.Point(96, 19);
            this.rd_fem.Name = "rd_fem";
            this.rd_fem.Size = new System.Drawing.Size(67, 17);
            this.rd_fem.TabIndex = 1;
            this.rd_fem.TabStop = true;
            this.rd_fem.Text = "Feminino";
            this.rd_fem.UseVisualStyleBackColor = true;
            // 
            // rd_masc
            // 
            this.rd_masc.AutoSize = true;
            this.rd_masc.Location = new System.Drawing.Point(17, 19);
            this.rd_masc.Name = "rd_masc";
            this.rd_masc.Size = new System.Drawing.Size(73, 17);
            this.rd_masc.TabIndex = 0;
            this.rd_masc.TabStop = true;
            this.rd_masc.Text = "Masculino";
            this.rd_masc.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tb_cidade);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.tb_bairro);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.tb_numero);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.tb_logradouro);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.tb_cep);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Location = new System.Drawing.Point(13, 207);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(775, 84);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Endereço";
            // 
            // tb_cidade
            // 
            this.tb_cidade.Location = new System.Drawing.Point(546, 45);
            this.tb_cidade.Name = "tb_cidade";
            this.tb_cidade.Size = new System.Drawing.Size(215, 20);
            this.tb_cidade.TabIndex = 11;
            this.tb_cidade.Tag = "codigo";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(497, 48);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(43, 13);
            this.label11.TabIndex = 10;
            this.label11.Text = "Cidade:";
            // 
            // tb_bairro
            // 
            this.tb_bairro.Location = new System.Drawing.Point(191, 45);
            this.tb_bairro.Name = "tb_bairro";
            this.tb_bairro.Size = new System.Drawing.Size(297, 20);
            this.tb_bairro.TabIndex = 9;
            this.tb_bairro.Tag = "codigo";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(148, 48);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(37, 13);
            this.label10.TabIndex = 8;
            this.label10.Text = "Bairro:";
            // 
            // tb_numero
            // 
            this.tb_numero.Location = new System.Drawing.Point(60, 45);
            this.tb_numero.Name = "tb_numero";
            this.tb_numero.Size = new System.Drawing.Size(77, 20);
            this.tb_numero.TabIndex = 7;
            this.tb_numero.Tag = "codigo";
            this.tb_numero.TextChanged += new System.EventHandler(this.textBox9_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(7, 48);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(47, 13);
            this.label9.TabIndex = 6;
            this.label9.Text = "Número:";
            // 
            // tb_logradouro
            // 
            this.tb_logradouro.Location = new System.Drawing.Point(298, 19);
            this.tb_logradouro.Name = "tb_logradouro";
            this.tb_logradouro.Size = new System.Drawing.Size(463, 20);
            this.tb_logradouro.TabIndex = 5;
            this.tb_logradouro.Tag = "codigo";
            this.tb_logradouro.TextChanged += new System.EventHandler(this.textBox8_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(228, 22);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(64, 13);
            this.label8.TabIndex = 4;
            this.label8.Text = "Logradouro:";
            // 
            // tb_cep
            // 
            this.tb_cep.Location = new System.Drawing.Point(60, 19);
            this.tb_cep.Name = "tb_cep";
            this.tb_cep.Size = new System.Drawing.Size(155, 20);
            this.tb_cep.TabIndex = 3;
            this.tb_cep.Tag = "codigo";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(23, 22);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(31, 13);
            this.label7.TabIndex = 2;
            this.label7.Text = "CEP:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.cb_const);
            this.groupBox3.Controls.Add(this.cb_email);
            this.groupBox3.Controls.Add(this.tb_emailconst);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.tb_email);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Location = new System.Drawing.Point(13, 297);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(775, 78);
            this.groupBox3.TabIndex = 15;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Dados Extras";
            // 
            // cb_const
            // 
            this.cb_const.AutoSize = true;
            this.cb_const.Location = new System.Drawing.Point(659, 47);
            this.cb_const.Name = "cb_const";
            this.cb_const.Size = new System.Drawing.Size(91, 17);
            this.cb_const.TabIndex = 9;
            this.cb_const.Text = "constitucional";
            this.cb_const.UseVisualStyleBackColor = true;
            this.cb_const.CheckedChanged += new System.EventHandler(this.cb_const_CheckedChanged);
            // 
            // cb_email
            // 
            this.cb_email.AutoSize = true;
            this.cb_email.Location = new System.Drawing.Point(659, 20);
            this.cb_email.Name = "cb_email";
            this.cb_email.Size = new System.Drawing.Size(54, 17);
            this.cb_email.TabIndex = 8;
            this.cb_email.Text = "E-mail";
            this.cb_email.UseVisualStyleBackColor = true;
            this.cb_email.CheckedChanged += new System.EventHandler(this.cb_email_CheckedChanged);
            // 
            // tb_emailconst
            // 
            this.tb_emailconst.Location = new System.Drawing.Point(128, 45);
            this.tb_emailconst.Name = "tb_emailconst";
            this.tb_emailconst.Size = new System.Drawing.Size(524, 20);
            this.tb_emailconst.TabIndex = 7;
            this.tb_emailconst.Tag = "codigo";
            this.tb_emailconst.TextChanged += new System.EventHandler(this.textBox13_TextChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(16, 48);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(106, 13);
            this.label13.TabIndex = 6;
            this.label13.Text = "E-mail constitucional:";
            // 
            // tb_email
            // 
            this.tb_email.Location = new System.Drawing.Point(60, 19);
            this.tb_email.Name = "tb_email";
            this.tb_email.Size = new System.Drawing.Size(592, 20);
            this.tb_email.TabIndex = 5;
            this.tb_email.Tag = "codigo";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(16, 22);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(38, 13);
            this.label12.TabIndex = 4;
            this.label12.Text = "E-mail:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(13, 405);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(122, 33);
            this.button1.TabIndex = 16;
            this.button1.Text = "Incluir";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(142, 405);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(122, 33);
            this.button2.TabIndex = 17;
            this.button2.Text = "Alterar";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(270, 405);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(122, 33);
            this.button3.TabIndex = 18;
            this.button3.Text = "Consultar";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(398, 405);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(122, 33);
            this.button4.TabIndex = 19;
            this.button4.Text = "Excluir";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(526, 405);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(122, 33);
            this.button5.TabIndex = 20;
            this.button5.Text = "Limpar";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(654, 405);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(122, 33);
            this.button6.TabIndex = 21;
            this.button6.Text = "Sair";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // pcbfoto
            // 
            this.pcbfoto.Location = new System.Drawing.Point(441, 14);
            this.pcbfoto.Name = "pcbfoto";
            this.pcbfoto.Size = new System.Drawing.Size(347, 137);
            this.pcbfoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbfoto.TabIndex = 22;
            this.pcbfoto.TabStop = false;
            this.pcbfoto.Click += new System.EventHandler(this.pcbfoto_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(441, 156);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(169, 44);
            this.button7.TabIndex = 23;
            this.button7.Text = "Carregar imagem";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(619, 157);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(169, 44);
            this.button8.TabIndex = 24;
            this.button8.Text = "Limpar Imagem";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(793, 450);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.pcbfoto);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbfoto)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_nome;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_codigo;
        private System.Windows.Forms.TextBox tb_rg;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_tel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tb_telresidencial;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tb_cpf;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.RadioButton rd_ndizer;
        private System.Windows.Forms.RadioButton rd_fem;
        private System.Windows.Forms.RadioButton rd_masc;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox tb_cidade;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox tb_bairro;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox tb_numero;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tb_logradouro;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tb_cep;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox tb_emailconst;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox tb_email;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.CheckBox cb_const;
        private System.Windows.Forms.CheckBox cb_email;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.PictureBox pcbfoto;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
    }
}

