namespace M5_Ex2
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.encarregadinho = new System.Windows.Forms.TextBox();
            this.cczinho = new System.Windows.Forms.TextBox();
            this.nascimentinho = new System.Windows.Forms.TextBox();
            this.telemovelzinho = new System.Windows.Forms.TextBox();
            this.moradinha = new System.Windows.Forms.TextBox();
            this.nomezinho = new System.Windows.Forms.TextBox();
            this.mediazinha = new System.Windows.Forms.TextBox();
            this.numerozinho = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.t_numaluno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.t_nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.t_morada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.t_ntel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.t_nasci = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.t_cc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.t_nomee = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox1.Location = new System.Drawing.Point(216, 88);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(258, 119);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "MENU INICIAL ";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.Location = new System.Drawing.Point(38, 63);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(184, 33);
            this.button1.TabIndex = 1;
            this.button1.Text = "Confirmar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "INTRODUZIR NOVOS DADOS",
            "",
            "MOSTRAR DADOS",
            "",
            "GUARDAR FICHEIRO E SAIR"});
            this.comboBox1.Location = new System.Drawing.Point(38, 32);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.comboBox1.Size = new System.Drawing.Size(184, 21);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.Text = "ARQUIVOS";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button4);
            this.groupBox2.Controls.Add(this.button3);
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.encarregadinho);
            this.groupBox2.Controls.Add(this.cczinho);
            this.groupBox2.Controls.Add(this.nascimentinho);
            this.groupBox2.Controls.Add(this.telemovelzinho);
            this.groupBox2.Controls.Add(this.moradinha);
            this.groupBox2.Controls.Add(this.nomezinho);
            this.groupBox2.Controls.Add(this.mediazinha);
            this.groupBox2.Controls.Add(this.numerozinho);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox2.Location = new System.Drawing.Point(91, 57);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(582, 329);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "INTRODUZIR DADOS";
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button4.Location = new System.Drawing.Point(240, 275);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(68, 26);
            this.button4.TabIndex = 19;
            this.button4.Text = "VOLTAR";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button3.Location = new System.Drawing.Point(323, 262);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(179, 50);
            this.button3.TabIndex = 17;
            this.button3.Text = "REGISTRAR DADOS";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button2.Location = new System.Drawing.Point(67, 262);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(163, 50);
            this.button2.TabIndex = 16;
            this.button2.Text = "LIMPAR DADOS";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // encarregadinho
            // 
            this.encarregadinho.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.encarregadinho.Location = new System.Drawing.Point(294, 194);
            this.encarregadinho.Multiline = true;
            this.encarregadinho.Name = "encarregadinho";
            this.encarregadinho.Size = new System.Drawing.Size(240, 20);
            this.encarregadinho.TabIndex = 15;
            // 
            // cczinho
            // 
            this.cczinho.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cczinho.Location = new System.Drawing.Point(294, 168);
            this.cczinho.Multiline = true;
            this.cczinho.Name = "cczinho";
            this.cczinho.Size = new System.Drawing.Size(240, 20);
            this.cczinho.TabIndex = 14;
            // 
            // nascimentinho
            // 
            this.nascimentinho.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nascimentinho.Location = new System.Drawing.Point(294, 142);
            this.nascimentinho.Multiline = true;
            this.nascimentinho.Name = "nascimentinho";
            this.nascimentinho.Size = new System.Drawing.Size(240, 20);
            this.nascimentinho.TabIndex = 13;
            // 
            // telemovelzinho
            // 
            this.telemovelzinho.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.telemovelzinho.Location = new System.Drawing.Point(294, 116);
            this.telemovelzinho.Multiline = true;
            this.telemovelzinho.Name = "telemovelzinho";
            this.telemovelzinho.Size = new System.Drawing.Size(240, 20);
            this.telemovelzinho.TabIndex = 12;
            this.telemovelzinho.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // moradinha
            // 
            this.moradinha.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.moradinha.Location = new System.Drawing.Point(294, 90);
            this.moradinha.Multiline = true;
            this.moradinha.Name = "moradinha";
            this.moradinha.Size = new System.Drawing.Size(240, 20);
            this.moradinha.TabIndex = 11;
            this.moradinha.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // nomezinho
            // 
            this.nomezinho.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nomezinho.Location = new System.Drawing.Point(294, 64);
            this.nomezinho.Multiline = true;
            this.nomezinho.Name = "nomezinho";
            this.nomezinho.Size = new System.Drawing.Size(240, 20);
            this.nomezinho.TabIndex = 10;
            // 
            // mediazinha
            // 
            this.mediazinha.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mediazinha.Location = new System.Drawing.Point(294, 220);
            this.mediazinha.Multiline = true;
            this.mediazinha.Name = "mediazinha";
            this.mediazinha.Size = new System.Drawing.Size(240, 20);
            this.mediazinha.TabIndex = 9;
            // 
            // numerozinho
            // 
            this.numerozinho.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numerozinho.Location = new System.Drawing.Point(294, 37);
            this.numerozinho.Multiline = true;
            this.numerozinho.Name = "numerozinho";
            this.numerozinho.Size = new System.Drawing.Size(240, 20);
            this.numerozinho.TabIndex = 8;
            this.numerozinho.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(80, 220);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(128, 20);
            this.label8.TabIndex = 7;
            this.label8.Text = "Média do 9º ano ";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 194);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(267, 20);
            this.label7.TabIndex = 6;
            this.label7.Text = "Nome de Encarregado de Educação";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(80, 168);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(113, 20);
            this.label6.TabIndex = 5;
            this.label6.Text = "Número de CC";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(64, 142);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(148, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Ano de Nascimento";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(63, 116);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(158, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Número de telemóvel";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(108, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Morada";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(108, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nome";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(78, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Número de aluno";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.button6);
            this.groupBox3.Controls.Add(this.button5);
            this.groupBox3.Controls.Add(this.dataGridView1);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.ForeColor = System.Drawing.SystemColors.Control;
            this.groupBox3.Location = new System.Drawing.Point(26, 22);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(925, 403);
            this.groupBox3.TabIndex = 18;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "DADOS";
            this.groupBox3.Enter += new System.EventHandler(this.groupBox3_Enter);
            // 
            // button6
            // 
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button6.Location = new System.Drawing.Point(101, 25);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(105, 26);
            this.button6.TabIndex = 21;
            this.button6.Text = "Alterar";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button5.Location = new System.Drawing.Point(6, 25);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(68, 26);
            this.button5.TabIndex = 20;
            this.button5.Text = "VOLTAR";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.t_numaluno,
            this.t_nome,
            this.t_morada,
            this.t_ntel,
            this.t_nasci,
            this.t_cc,
            this.t_nomee,
            this.Column1});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.Location = new System.Drawing.Point(14, 57);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(896, 330);
            this.dataGridView1.TabIndex = 0;
            // 
            // t_numaluno
            // 
            this.t_numaluno.HeaderText = "Nº Aluno";
            this.t_numaluno.Name = "t_numaluno";
            this.t_numaluno.ReadOnly = true;
            // 
            // t_nome
            // 
            this.t_nome.HeaderText = "Nome";
            this.t_nome.Name = "t_nome";
            this.t_nome.ReadOnly = true;
            // 
            // t_morada
            // 
            this.t_morada.HeaderText = "Morada";
            this.t_morada.Name = "t_morada";
            this.t_morada.ReadOnly = true;
            // 
            // t_ntel
            // 
            this.t_ntel.HeaderText = "Telemóvel";
            this.t_ntel.Name = "t_ntel";
            this.t_ntel.ReadOnly = true;
            // 
            // t_nasci
            // 
            this.t_nasci.HeaderText = "Nascimento";
            this.t_nasci.Name = "t_nasci";
            this.t_nasci.ReadOnly = true;
            // 
            // t_cc
            // 
            this.t_cc.FillWeight = 10F;
            this.t_cc.HeaderText = "CC";
            this.t_cc.Name = "t_cc";
            this.t_cc.ReadOnly = true;
            // 
            // t_nomee
            // 
            this.t_nomee.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.t_nomee.FillWeight = 120F;
            this.t_nomee.HeaderText = "Nome do Encarregado";
            this.t_nomee.Name = "t_nomee";
            this.t_nomee.ReadOnly = true;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Média 9º Ano";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(992, 501);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox numerozinho;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox telemovelzinho;
        private System.Windows.Forms.TextBox moradinha;
        private System.Windows.Forms.TextBox nomezinho;
        private System.Windows.Forms.TextBox mediazinha;
        private System.Windows.Forms.TextBox encarregadinho;
        private System.Windows.Forms.TextBox cczinho;
        private System.Windows.Forms.TextBox nascimentinho;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.DataGridViewTextBoxColumn t_numaluno;
        private System.Windows.Forms.DataGridViewTextBoxColumn t_nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn t_morada;
        private System.Windows.Forms.DataGridViewTextBoxColumn t_ntel;
        private System.Windows.Forms.DataGridViewTextBoxColumn t_nasci;
        private System.Windows.Forms.DataGridViewTextBoxColumn t_cc;
        private System.Windows.Forms.DataGridViewTextBoxColumn t_nomee;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
    }
}

