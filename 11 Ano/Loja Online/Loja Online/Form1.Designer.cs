﻿namespace Loja_Online
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.btnMas = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.button4 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.button3 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.btnRelogios = new System.Windows.Forms.Button();
            this.btnAneis = new System.Windows.Forms.Button();
            this.btnColares = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(502, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(246, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "JOALHARIA  GOMES";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnMas
            // 
            this.btnMas.FlatAppearance.BorderSize = 0;
            this.btnMas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnMas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMas.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMas.Location = new System.Drawing.Point(0, 0);
            this.btnMas.Name = "btnMas";
            this.btnMas.Size = new System.Drawing.Size(174, 63);
            this.btnMas.TabIndex = 2;
            this.btnMas.Text = "HOMEM";
            this.btnMas.UseVisualStyleBackColor = true;
            this.btnMas.Visible = false;
            this.btnMas.Click += new System.EventHandler(this.btnMas_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Silver;
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.button7);
            this.panel1.Controls.Add(this.btnMas);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1241, 61);
            this.panel1.TabIndex = 9;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "RelogioFem.png");
            // 
            // panel2
            // 
            this.panel2.AutoSize = true;
            this.panel2.Controls.Add(this.button4);
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.btnRelogios);
            this.panel2.Controls.Add(this.btnAneis);
            this.panel2.Controls.Add(this.btnColares);
            this.panel2.Location = new System.Drawing.Point(30, 137);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1389, 352);
            this.panel2.TabIndex = 10;
            // 
            // button4
            // 
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(1014, 232);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(118, 23);
            this.button4.TabIndex = 13;
            this.button4.Text = "Adicionar";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button2
            // 
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(614, 232);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(118, 23);
            this.button2.TabIndex = 12;
            this.button2.Text = "Adicionar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(212, 232);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(118, 23);
            this.button1.TabIndex = 11;
            this.button1.Text = "Adicionar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button3
            // 
            this.button3.BackgroundImage = global::Loja_Online.Properties.Resources.Carrinho_Final;
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(1082, 3);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(55, 57);
            this.button3.TabIndex = 9;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button7
            // 
            this.button7.BackgroundImage = global::Loja_Online.Properties.Resources.Carrinho21;
            this.button7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button7.FlatAppearance.BorderSize = 0;
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.Location = new System.Drawing.Point(1159, 3);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(55, 57);
            this.button7.TabIndex = 8;
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // btnRelogios
            // 
            this.btnRelogios.BackColor = System.Drawing.Color.White;
            this.btnRelogios.BackgroundImage = global::Loja_Online.Properties.Resources.Relógio_2_0;
            this.btnRelogios.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRelogios.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRelogios.Location = new System.Drawing.Point(9, 12);
            this.btnRelogios.Name = "btnRelogios";
            this.btnRelogios.Size = new System.Drawing.Size(370, 330);
            this.btnRelogios.TabIndex = 5;
            this.btnRelogios.UseVisualStyleBackColor = false;
            this.btnRelogios.Click += new System.EventHandler(this.btnRelogios_Click);
            // 
            // btnAneis
            // 
            this.btnAneis.BackColor = System.Drawing.Color.White;
            this.btnAneis.BackgroundImage = global::Loja_Online.Properties.Resources.Anel_2_0;
            this.btnAneis.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAneis.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAneis.Location = new System.Drawing.Point(814, 12);
            this.btnAneis.Name = "btnAneis";
            this.btnAneis.Size = new System.Drawing.Size(370, 330);
            this.btnAneis.TabIndex = 7;
            this.btnAneis.UseVisualStyleBackColor = false;
            this.btnAneis.Click += new System.EventHandler(this.btnAneis_Click);
            // 
            // btnColares
            // 
            this.btnColares.BackColor = System.Drawing.Color.White;
            this.btnColares.BackgroundImage = global::Loja_Online.Properties.Resources.Colar_2_0;
            this.btnColares.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnColares.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnColares.Location = new System.Drawing.Point(409, 12);
            this.btnColares.Name = "btnColares";
            this.btnColares.Size = new System.Drawing.Size(370, 330);
            this.btnColares.TabIndex = 6;
            this.btnColares.UseVisualStyleBackColor = false;
            this.btnColares.Click += new System.EventHandler(this.btnColares_Click);
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1241, 556);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnMas;
        private System.Windows.Forms.Button btnRelogios;
        private System.Windows.Forms.Button btnColares;
        private System.Windows.Forms.Button btnAneis;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Panel panel2;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}
