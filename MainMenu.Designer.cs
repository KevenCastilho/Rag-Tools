
namespace RagTools
{
    partial class MainMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenu));
            this.label1 = new System.Windows.Forms.Label();
            this.btnOnline = new System.Windows.Forms.Button();
            this.btnOffline = new System.Windows.Forms.Button();
            this.btnInstall = new System.Windows.Forms.Button();
            this.btnCredito = new System.Windows.Forms.Button();
            this.btnAbout = new System.Windows.Forms.Button();
            this.txtCreditos = new System.Windows.Forms.Label();
            this.btnSair = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Helvetica Rounded", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(99)))), ((int)(((byte)(132)))));
            this.label1.Location = new System.Drawing.Point(49, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 34);
            this.label1.TabIndex = 0;
            this.label1.Text = "RagTools";
            // 
            // btnOnline
            // 
            this.btnOnline.BackColor = System.Drawing.Color.Transparent;
            this.btnOnline.BackgroundImage = global::RagTools.Properties.Resources.BTN_1;
            this.btnOnline.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnOnline.FlatAppearance.BorderSize = 0;
            this.btnOnline.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOnline.Font = new System.Drawing.Font("Helvetica", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOnline.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(99)))), ((int)(((byte)(132)))));
            this.btnOnline.Location = new System.Drawing.Point(11, 79);
            this.btnOnline.Name = "btnOnline";
            this.btnOnline.Size = new System.Drawing.Size(221, 20);
            this.btnOnline.TabIndex = 2;
            this.btnOnline.Text = "Ferramentas Online";
            this.btnOnline.UseVisualStyleBackColor = false;
            this.btnOnline.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnOffline
            // 
            this.btnOffline.BackColor = System.Drawing.Color.Transparent;
            this.btnOffline.BackgroundImage = global::RagTools.Properties.Resources.BTN_1;
            this.btnOffline.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnOffline.FlatAppearance.BorderSize = 0;
            this.btnOffline.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOffline.Font = new System.Drawing.Font("Helvetica", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOffline.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(99)))), ((int)(((byte)(132)))));
            this.btnOffline.Location = new System.Drawing.Point(11, 114);
            this.btnOffline.Name = "btnOffline";
            this.btnOffline.Size = new System.Drawing.Size(221, 20);
            this.btnOffline.TabIndex = 3;
            this.btnOffline.Text = "Ferramentas Offline";
            this.btnOffline.UseVisualStyleBackColor = false;
            this.btnOffline.Click += new System.EventHandler(this.btnOffline_Click);
            // 
            // btnInstall
            // 
            this.btnInstall.BackColor = System.Drawing.Color.Transparent;
            this.btnInstall.BackgroundImage = global::RagTools.Properties.Resources.BTN_1;
            this.btnInstall.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnInstall.FlatAppearance.BorderSize = 0;
            this.btnInstall.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInstall.Font = new System.Drawing.Font("Helvetica", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInstall.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(99)))), ((int)(((byte)(132)))));
            this.btnInstall.Location = new System.Drawing.Point(11, 152);
            this.btnInstall.Name = "btnInstall";
            this.btnInstall.Size = new System.Drawing.Size(221, 20);
            this.btnInstall.TabIndex = 4;
            this.btnInstall.Text = "Instaladores";
            this.btnInstall.UseVisualStyleBackColor = false;
            // 
            // btnCredito
            // 
            this.btnCredito.BackColor = System.Drawing.Color.Transparent;
            this.btnCredito.BackgroundImage = global::RagTools.Properties.Resources.BTN_1;
            this.btnCredito.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCredito.FlatAppearance.BorderSize = 0;
            this.btnCredito.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCredito.Font = new System.Drawing.Font("Helvetica", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCredito.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(99)))), ((int)(((byte)(132)))));
            this.btnCredito.Location = new System.Drawing.Point(11, 187);
            this.btnCredito.Name = "btnCredito";
            this.btnCredito.Size = new System.Drawing.Size(221, 20);
            this.btnCredito.TabIndex = 5;
            this.btnCredito.Text = "Créditos";
            this.btnCredito.UseVisualStyleBackColor = false;
            this.btnCredito.Click += new System.EventHandler(this.btnCredito_Click);
            // 
            // btnAbout
            // 
            this.btnAbout.BackColor = System.Drawing.Color.Transparent;
            this.btnAbout.BackgroundImage = global::RagTools.Properties.Resources.BTN_1;
            this.btnAbout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAbout.FlatAppearance.BorderSize = 0;
            this.btnAbout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAbout.Font = new System.Drawing.Font("Helvetica", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAbout.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(99)))), ((int)(((byte)(132)))));
            this.btnAbout.Location = new System.Drawing.Point(11, 226);
            this.btnAbout.Name = "btnAbout";
            this.btnAbout.Size = new System.Drawing.Size(221, 20);
            this.btnAbout.TabIndex = 6;
            this.btnAbout.Text = "Sobre";
            this.btnAbout.UseVisualStyleBackColor = false;
            this.btnAbout.Click += new System.EventHandler(this.btnAbout_Click);
            // 
            // txtCreditos
            // 
            this.txtCreditos.AutoSize = true;
            this.txtCreditos.BackColor = System.Drawing.Color.Transparent;
            this.txtCreditos.ForeColor = System.Drawing.Color.Azure;
            this.txtCreditos.Location = new System.Drawing.Point(12, 461);
            this.txtCreditos.Name = "txtCreditos";
            this.txtCreditos.Size = new System.Drawing.Size(117, 13);
            this.txtCreditos.TabIndex = 7;
            this.txtCreditos.Text = "Keven Castilho © 2021";
            this.txtCreditos.Click += new System.EventHandler(this.label2_Click);
            // 
            // btnSair
            // 
            this.btnSair.BackColor = System.Drawing.Color.Transparent;
            this.btnSair.BackgroundImage = global::RagTools.Properties.Resources.BTN_1;
            this.btnSair.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSair.FlatAppearance.BorderSize = 0;
            this.btnSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSair.Font = new System.Drawing.Font("Helvetica", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(99)))), ((int)(((byte)(132)))));
            this.btnSair.Location = new System.Drawing.Point(11, 397);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(221, 20);
            this.btnSair.TabIndex = 8;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = false;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::RagTools.Properties.Resources.kafra_bg;
            this.ClientSize = new System.Drawing.Size(506, 483);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.txtCreditos);
            this.Controls.Add(this.btnAbout);
            this.Controls.Add(this.btnCredito);
            this.Controls.Add(this.btnInstall);
            this.Controls.Add(this.btnOffline);
            this.Controls.Add(this.btnOnline);
            this.Controls.Add(this.label1);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(522, 522);
            this.MinimumSize = new System.Drawing.Size(522, 522);
            this.Name = "MainMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RagTools - Main Menu";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnOnline;
        private System.Windows.Forms.Button btnOffline;
        private System.Windows.Forms.Button btnInstall;
        private System.Windows.Forms.Button btnCredito;
        private System.Windows.Forms.Button btnAbout;
        private System.Windows.Forms.Label txtCreditos;
        private System.Windows.Forms.Button btnSair;
    }
}

