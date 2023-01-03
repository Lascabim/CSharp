namespace M5
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.gbox = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.painelDados = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.adress = new System.Windows.Forms.TextBox();
            this.phone = new System.Windows.Forms.TextBox();
            this.cv = new System.Windows.Forms.TextBox();
            this.cellphone = new System.Windows.Forms.TextBox();
            this.name = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.ShowData = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.nomezinho = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.moradinha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefonezinho = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telemovelzinho = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.civilzinho = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbox.SuspendLayout();
            this.painelDados.SuspendLayout();
            this.ShowData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // gbox
            // 
            this.gbox.Controls.Add(this.label1);
            this.gbox.Controls.Add(this.button3);
            this.gbox.Controls.Add(this.button2);
            this.gbox.Controls.Add(this.button1);
            this.gbox.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.gbox.Location = new System.Drawing.Point(106, 71);
            this.gbox.Name = "gbox";
            this.gbox.Size = new System.Drawing.Size(500, 300);
            this.gbox.TabIndex = 0;
            this.gbox.TabStop = false;
            this.gbox.Text = "MENU";
            // 
            // button1
            // 
            this.button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.Location = new System.Drawing.Point(27, 215);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(443, 71);
            this.button1.TabIndex = 1;
            this.button1.Text = "SAIR | FECHAR";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button2.Location = new System.Drawing.Point(28, 135);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(443, 71);
            this.button2.TabIndex = 2;
            this.button2.Text = "MOSTRAR DADOS";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button3.Location = new System.Drawing.Point(28, 54);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(443, 71);
            this.button3.TabIndex = 3;
            this.button3.Text = "INTRODUZIR DADOS";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(178, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "ESCOLHE UMA OPÇÃO";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // painelDados
            // 
            this.painelDados.Controls.Add(this.button6);
            this.painelDados.Controls.Add(this.button5);
            this.painelDados.Controls.Add(this.button4);
            this.painelDados.Controls.Add(this.name);
            this.painelDados.Controls.Add(this.cellphone);
            this.painelDados.Controls.Add(this.cv);
            this.painelDados.Controls.Add(this.phone);
            this.painelDados.Controls.Add(this.adress);
            this.painelDados.Controls.Add(this.label6);
            this.painelDados.Controls.Add(this.label5);
            this.painelDados.Controls.Add(this.label4);
            this.painelDados.Controls.Add(this.label3);
            this.painelDados.Controls.Add(this.label2);
            this.painelDados.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.painelDados.Location = new System.Drawing.Point(39, 56);
            this.painelDados.Name = "painelDados";
            this.painelDados.Size = new System.Drawing.Size(641, 332);
            this.painelDados.TabIndex = 1;
            this.painelDados.TabStop = false;
            this.painelDados.Text = "INTRODUÇÃO DE DADOS";
            this.painelDados.Enter += new System.EventHandler(this.painelDados_Enter);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(112, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 18);
            this.label2.TabIndex = 0;
            this.label2.Text = "NOME";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(91, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 18);
            this.label3.TabIndex = 1;
            this.label3.Text = "MORADA";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(75, 144);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 18);
            this.label4.TabIndex = 2;
            this.label4.Text = "TELEFONE";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(64, 175);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 18);
            this.label5.TabIndex = 3;
            this.label5.Text = "TELEMOVEL";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(51, 207);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(119, 18);
            this.label6.TabIndex = 4;
            this.label6.Text = "ESTADO CIVIL";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // adress
            // 
            this.adress.Location = new System.Drawing.Point(189, 112);
            this.adress.Name = "adress";
            this.adress.Size = new System.Drawing.Size(106, 20);
            this.adress.TabIndex = 5;
            this.adress.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // phone
            // 
            this.phone.Location = new System.Drawing.Point(189, 175);
            this.phone.Name = "phone";
            this.phone.Size = new System.Drawing.Size(106, 20);
            this.phone.TabIndex = 6;
            // 
            // cv
            // 
            this.cv.Location = new System.Drawing.Point(189, 208);
            this.cv.Name = "cv";
            this.cv.Size = new System.Drawing.Size(106, 20);
            this.cv.TabIndex = 7;
            // 
            // cellphone
            // 
            this.cellphone.Location = new System.Drawing.Point(189, 142);
            this.cellphone.Name = "cellphone";
            this.cellphone.Size = new System.Drawing.Size(106, 20);
            this.cellphone.TabIndex = 8;
            // 
            // name
            // 
            this.name.Location = new System.Drawing.Point(189, 81);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(106, 20);
            this.name.TabIndex = 9;
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button4.Location = new System.Drawing.Point(351, 93);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(233, 79);
            this.button4.TabIndex = 10;
            this.button4.Text = "REGISTRAR DADOS";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button5.Location = new System.Drawing.Point(351, 193);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(233, 28);
            this.button5.TabIndex = 11;
            this.button5.Text = "LIMPAR DADOS";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // ShowData
            // 
            this.ShowData.Controls.Add(this.button7);
            this.ShowData.Controls.Add(this.dataGridView1);
            this.ShowData.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.ShowData.Location = new System.Drawing.Point(39, 56);
            this.ShowData.Name = "ShowData";
            this.ShowData.Size = new System.Drawing.Size(641, 332);
            this.ShowData.TabIndex = 12;
            this.ShowData.TabStop = false;
            this.ShowData.Text = "     VER DADOS    ";
            this.ShowData.Enter += new System.EventHandler(this.ShowData_Enter);
            // 
            // dataGridView1
            // 
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nomezinho,
            this.moradinha,
            this.telefonezinho,
            this.telemovelzinho,
            this.civilzinho});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dataGridView1.Location = new System.Drawing.Point(15, 48);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(612, 267);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // button6
            // 
            this.button6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button6.Location = new System.Drawing.Point(15, 19);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(114, 23);
            this.button6.TabIndex = 12;
            this.button6.Text = "VOLTAR ATRÁS";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button7.Location = new System.Drawing.Point(6, 15);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(114, 23);
            this.button7.TabIndex = 13;
            this.button7.Text = "VOLTAR ATRÁS";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // nomezinho
            // 
            this.nomezinho.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nomezinho.HeaderText = "Nome";
            this.nomezinho.Name = "nomezinho";
            this.nomezinho.ReadOnly = true;
            // 
            // moradinha
            // 
            this.moradinha.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.moradinha.HeaderText = "Morada";
            this.moradinha.Name = "moradinha";
            this.moradinha.ReadOnly = true;
            // 
            // telefonezinho
            // 
            this.telefonezinho.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.telefonezinho.HeaderText = "Telefone";
            this.telefonezinho.Name = "telefonezinho";
            this.telefonezinho.ReadOnly = true;
            // 
            // telemovelzinho
            // 
            this.telemovelzinho.HeaderText = "Telemóvel";
            this.telemovelzinho.Name = "telemovelzinho";
            this.telemovelzinho.ReadOnly = true;
            // 
            // civilzinho
            // 
            this.civilzinho.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.civilzinho.HeaderText = "Estado Civil";
            this.civilzinho.Name = "civilzinho";
            this.civilzinho.ReadOnly = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(728, 450);
            this.Controls.Add(this.ShowData);
            this.Controls.Add(this.gbox);
            this.Controls.Add(this.painelDados);
            this.Name = "Form1";
            this.Text = "Form1";
            this.gbox.ResumeLayout(false);
            this.gbox.PerformLayout();
            this.painelDados.ResumeLayout(false);
            this.painelDados.PerformLayout();
            this.ShowData.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox painelDados;
        private System.Windows.Forms.TextBox adress;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.TextBox cellphone;
        private System.Windows.Forms.TextBox cv;
        private System.Windows.Forms.TextBox phone;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.GroupBox ShowData;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomezinho;
        private System.Windows.Forms.DataGridViewTextBoxColumn moradinha;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefonezinho;
        private System.Windows.Forms.DataGridViewTextBoxColumn telemovelzinho;
        private System.Windows.Forms.DataGridViewTextBoxColumn civilzinho;
    }
}

