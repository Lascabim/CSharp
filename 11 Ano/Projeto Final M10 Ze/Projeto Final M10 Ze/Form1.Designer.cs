namespace Projeto_Final_M10_Ze
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.bRecibos = new System.Windows.Forms.Button();
            this.bAdmin = new System.Windows.Forms.Button();
            this.bInscricoes = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::Projeto_Final_M10_Ze.Properties.Resources.Logo1;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(-3, 22);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(805, 285);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // bRecibos
            // 
            this.bRecibos.BackColor = System.Drawing.Color.DimGray;
            this.bRecibos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bRecibos.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bRecibos.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.bRecibos.Location = new System.Drawing.Point(314, 356);
            this.bRecibos.Name = "bRecibos";
            this.bRecibos.Size = new System.Drawing.Size(165, 59);
            this.bRecibos.TabIndex = 2;
            this.bRecibos.Text = "RECIBOS";
            this.bRecibos.UseVisualStyleBackColor = false;
            this.bRecibos.Click += new System.EventHandler(this.bRecibos_Click);
            // 
            // bAdmin
            // 
            this.bAdmin.BackColor = System.Drawing.Color.DimGray;
            this.bAdmin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bAdmin.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bAdmin.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.bAdmin.Location = new System.Drawing.Point(609, 356);
            this.bAdmin.Name = "bAdmin";
            this.bAdmin.Size = new System.Drawing.Size(165, 59);
            this.bAdmin.TabIndex = 3;
            this.bAdmin.Text = "ADMINISTRAÇÃO";
            this.bAdmin.UseVisualStyleBackColor = false;
            this.bAdmin.Click += new System.EventHandler(this.bAdmin_Click);
            // 
            // bInscricoes
            // 
            this.bInscricoes.BackColor = System.Drawing.Color.DimGray;
            this.bInscricoes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bInscricoes.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bInscricoes.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.bInscricoes.Location = new System.Drawing.Point(27, 356);
            this.bInscricoes.Name = "bInscricoes";
            this.bInscricoes.Size = new System.Drawing.Size(165, 59);
            this.bInscricoes.TabIndex = 4;
            this.bInscricoes.Text = "INSCRIÇÕES";
            this.bInscricoes.UseVisualStyleBackColor = false;
            this.bInscricoes.Click += new System.EventHandler(this.bInscricoes_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bInscricoes);
            this.Controls.Add(this.bAdmin);
            this.Controls.Add(this.bRecibos);
            this.Controls.Add(this.pictureBox1);
            this.DoubleBuffered = true;
            this.Name = "Form1";
            this.Text = "Dojang";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button bRecibos;
        private System.Windows.Forms.Button bAdmin;
        private System.Windows.Forms.Button bInscricoes;
    }
}

