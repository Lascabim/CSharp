namespace WindowsFormsApplication1
{
    partial class Form2
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
            this.label1 = new System.Windows.Forms.Label();
            this.ccavalos = new System.Windows.Forms.Button();
            this.dinheiro = new System.Windows.Forms.TextBox();
            this.subornar = new System.Windows.Forms.Button();
            this.ctreinadores = new System.Windows.Forms.Button();
            this.nivel = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.habilidade = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Orçamento:";
            // 
            // ccavalos
            // 
            this.ccavalos.Location = new System.Drawing.Point(15, 105);
            this.ccavalos.Name = "ccavalos";
            this.ccavalos.Size = new System.Drawing.Size(95, 46);
            this.ccavalos.TabIndex = 1;
            this.ccavalos.Text = "Comprar Cavalo";
            this.ccavalos.UseVisualStyleBackColor = true;
            this.ccavalos.Click += new System.EventHandler(this.ccavalos_Click);
            // 
            // dinheiro
            // 
            this.dinheiro.Location = new System.Drawing.Point(95, 23);
            this.dinheiro.Name = "dinheiro";
            this.dinheiro.ReadOnly = true;
            this.dinheiro.Size = new System.Drawing.Size(100, 20);
            this.dinheiro.TabIndex = 4;
            this.dinheiro.TextChanged += new System.EventHandler(this.dinheiro_TextChanged);
            // 
            // subornar
            // 
            this.subornar.Location = new System.Drawing.Point(15, 157);
            this.subornar.Name = "subornar";
            this.subornar.Size = new System.Drawing.Size(95, 46);
            this.subornar.TabIndex = 5;
            this.subornar.Text = "Subornar Árbitros";
            this.subornar.UseVisualStyleBackColor = true;
            // 
            // ctreinadores
            // 
            this.ctreinadores.Location = new System.Drawing.Point(15, 209);
            this.ctreinadores.Name = "ctreinadores";
            this.ctreinadores.Size = new System.Drawing.Size(95, 46);
            this.ctreinadores.TabIndex = 6;
            this.ctreinadores.Text = "Comprar Treinador";
            this.ctreinadores.UseVisualStyleBackColor = true;
            // 
            // nivel
            // 
            this.nivel.Location = new System.Drawing.Point(95, 53);
            this.nivel.Name = "nivel";
            this.nivel.ReadOnly = true;
            this.nivel.Size = new System.Drawing.Size(100, 20);
            this.nivel.TabIndex = 8;
            this.nivel.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(25, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "Level:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(451, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Próxima Habilidade lvl:";
            // 
            // habilidade
            // 
            this.habilidade.Location = new System.Drawing.Point(570, 23);
            this.habilidade.Name = "habilidade";
            this.habilidade.ReadOnly = true;
            this.habilidade.Size = new System.Drawing.Size(100, 20);
            this.habilidade.TabIndex = 10;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(454, 157);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(95, 46);
            this.button1.TabIndex = 11;
            this.button1.Text = "Iniciar Corrida";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Enabled = false;
            this.label4.Location = new System.Drawing.Point(364, 122);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "chance de ganhar";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(454, 224);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(123, 31);
            this.progressBar1.TabIndex = 13;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(691, 548);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.habilidade);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.nivel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ctreinadores);
            this.Controls.Add(this.subornar);
            this.Controls.Add(this.dinheiro);
            this.Controls.Add(this.ccavalos);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "la";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ccavalos;
        private System.Windows.Forms.TextBox dinheiro;
        private System.Windows.Forms.Button subornar;
        private System.Windows.Forms.Button ctreinadores;
        private System.Windows.Forms.TextBox nivel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox habilidade;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ProgressBar progressBar1;
    }
}