namespace BinDec
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
            this.visor2 = new System.Windows.Forms.TextBox();
            this.visor1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.botao = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // visor2
            // 
            this.visor2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.visor2.Location = new System.Drawing.Point(195, 52);
            this.visor2.Multiline = true;
            this.visor2.Name = "visor2";
            this.visor2.ReadOnly = true;
            this.visor2.Size = new System.Drawing.Size(449, 103);
            this.visor2.TabIndex = 0;
            this.visor2.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // visor1
            // 
            this.visor1.Location = new System.Drawing.Point(24, 78);
            this.visor1.Name = "visor1";
            this.visor1.Size = new System.Drawing.Size(100, 20);
            this.visor1.TabIndex = 1;
            this.visor1.TextChanged += new System.EventHandler(this.visor1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(42, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 18);
            this.label1.TabIndex = 3;
            this.label1.Text = "Decimal";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // botao
            // 
            this.botao.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botao.Location = new System.Drawing.Point(24, 119);
            this.botao.Name = "botao";
            this.botao.Size = new System.Drawing.Size(100, 67);
            this.botao.TabIndex = 4;
            this.botao.Text = "Binário";
            this.botao.UseVisualStyleBackColor = true;
            this.botao.Click += new System.EventHandler(this.botao_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.botao);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.visor1);
            this.Controls.Add(this.visor2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox visor2;
        private System.Windows.Forms.TextBox visor1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button botao;
    }
}

