
namespace RagTools
{
    partial class Sprites
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
            this.btnSprites = new System.Windows.Forms.Button();
            this.btnEquip = new System.Windows.Forms.Button();
            this.btnMonstros = new System.Windows.Forms.Button();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.Navegador = new Microsoft.Web.WebView2.WinForms.WebView2();
            this.btnJobs = new System.Windows.Forms.Button();
            this.btnHomun = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Navegador)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSprites
            // 
            this.btnSprites.BackColor = System.Drawing.Color.Transparent;
            this.btnSprites.BackgroundImage = global::RagTools.Properties.Resources.BTN_1;
            this.btnSprites.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSprites.FlatAppearance.BorderSize = 0;
            this.btnSprites.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSprites.Font = new System.Drawing.Font("Helvetica", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSprites.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(99)))), ((int)(((byte)(132)))));
            this.btnSprites.Location = new System.Drawing.Point(1, 12);
            this.btnSprites.Name = "btnSprites";
            this.btnSprites.Size = new System.Drawing.Size(200, 20);
            this.btnSprites.TabIndex = 6;
            this.btnSprites.Text = "NPC\'s";
            this.btnSprites.UseVisualStyleBackColor = false;
            this.btnSprites.Click += new System.EventHandler(this.btnSprites_Click);
            // 
            // btnEquip
            // 
            this.btnEquip.BackColor = System.Drawing.Color.Transparent;
            this.btnEquip.BackgroundImage = global::RagTools.Properties.Resources.BTN_1;
            this.btnEquip.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEquip.FlatAppearance.BorderSize = 0;
            this.btnEquip.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEquip.Font = new System.Drawing.Font("Helvetica", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEquip.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(99)))), ((int)(((byte)(132)))));
            this.btnEquip.Location = new System.Drawing.Point(207, 12);
            this.btnEquip.Name = "btnEquip";
            this.btnEquip.Size = new System.Drawing.Size(200, 20);
            this.btnEquip.TabIndex = 7;
            this.btnEquip.Text = "Equipamentos p/ Cabeça";
            this.btnEquip.UseVisualStyleBackColor = false;
            this.btnEquip.Click += new System.EventHandler(this.btnEquip_Click);
            // 
            // btnMonstros
            // 
            this.btnMonstros.BackColor = System.Drawing.Color.Transparent;
            this.btnMonstros.BackgroundImage = global::RagTools.Properties.Resources.BTN_1;
            this.btnMonstros.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMonstros.FlatAppearance.BorderSize = 0;
            this.btnMonstros.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMonstros.Font = new System.Drawing.Font("Helvetica", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMonstros.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(99)))), ((int)(((byte)(132)))));
            this.btnMonstros.Location = new System.Drawing.Point(413, 12);
            this.btnMonstros.Name = "btnMonstros";
            this.btnMonstros.Size = new System.Drawing.Size(200, 20);
            this.btnMonstros.TabIndex = 8;
            this.btnMonstros.Text = "Monstros";
            this.btnMonstros.UseVisualStyleBackColor = false;
            this.btnMonstros.Click += new System.EventHandler(this.btnMonstros_Click);
            // 
            // btnVoltar
            // 
            this.btnVoltar.BackColor = System.Drawing.Color.Transparent;
            this.btnVoltar.BackgroundImage = global::RagTools.Properties.Resources.BTN_MINI_1;
            this.btnVoltar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnVoltar.FlatAppearance.BorderSize = 0;
            this.btnVoltar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVoltar.Font = new System.Drawing.Font("Helvetica", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVoltar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(99)))), ((int)(((byte)(132)))));
            this.btnVoltar.Location = new System.Drawing.Point(1031, 12);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(42, 20);
            this.btnVoltar.TabIndex = 9;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = false;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // Navegador
            // 
            this.Navegador.CreationProperties = null;
            this.Navegador.DefaultBackgroundColor = System.Drawing.Color.White;
            this.Navegador.Location = new System.Drawing.Point(1, 43);
            this.Navegador.Name = "Navegador";
            this.Navegador.Size = new System.Drawing.Size(1082, 550);
            this.Navegador.Source = new System.Uri("about:blank", System.UriKind.Absolute);
            this.Navegador.TabIndex = 10;
            this.Navegador.ZoomFactor = 1D;
            this.Navegador.Click += new System.EventHandler(this.Navegador_Click);
            // 
            // btnJobs
            // 
            this.btnJobs.BackColor = System.Drawing.Color.Transparent;
            this.btnJobs.BackgroundImage = global::RagTools.Properties.Resources.BTN_1;
            this.btnJobs.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnJobs.FlatAppearance.BorderSize = 0;
            this.btnJobs.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnJobs.Font = new System.Drawing.Font("Helvetica", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnJobs.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(99)))), ((int)(((byte)(132)))));
            this.btnJobs.Location = new System.Drawing.Point(825, 12);
            this.btnJobs.Name = "btnJobs";
            this.btnJobs.Size = new System.Drawing.Size(200, 20);
            this.btnJobs.TabIndex = 11;
            this.btnJobs.Text = "Classes";
            this.btnJobs.UseVisualStyleBackColor = false;
            this.btnJobs.Click += new System.EventHandler(this.btnJobs_Click);
            // 
            // btnHomun
            // 
            this.btnHomun.BackColor = System.Drawing.Color.Transparent;
            this.btnHomun.BackgroundImage = global::RagTools.Properties.Resources.BTN_1;
            this.btnHomun.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnHomun.FlatAppearance.BorderSize = 0;
            this.btnHomun.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHomun.Font = new System.Drawing.Font("Helvetica", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHomun.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(99)))), ((int)(((byte)(132)))));
            this.btnHomun.Location = new System.Drawing.Point(619, 12);
            this.btnHomun.Name = "btnHomun";
            this.btnHomun.Size = new System.Drawing.Size(200, 20);
            this.btnHomun.TabIndex = 12;
            this.btnHomun.Text = "Homunculus";
            this.btnHomun.UseVisualStyleBackColor = false;
            this.btnHomun.Click += new System.EventHandler(this.btnHomun_Click);
            // 
            // Sprites
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1085, 593);
            this.Controls.Add(this.btnHomun);
            this.Controls.Add(this.btnJobs);
            this.Controls.Add(this.Navegador);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.btnMonstros);
            this.Controls.Add(this.btnEquip);
            this.Controls.Add(this.btnSprites);
            this.MaximumSize = new System.Drawing.Size(1101, 632);
            this.MinimumSize = new System.Drawing.Size(1101, 632);
            this.Name = "Sprites";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RagTools - Sprites";
            this.Load += new System.EventHandler(this.Sprites_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Navegador)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnSprites;
        private System.Windows.Forms.Button btnEquip;
        private System.Windows.Forms.Button btnMonstros;
        private System.Windows.Forms.Button btnVoltar;
        private Microsoft.Web.WebView2.WinForms.WebView2 Navegador;
        private System.Windows.Forms.Button btnJobs;
        private System.Windows.Forms.Button btnHomun;
    }
}