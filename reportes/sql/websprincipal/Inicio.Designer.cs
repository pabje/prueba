namespace websprincipal
{
    partial class Inicio
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.inicioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.altaDeDireccionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modificaciónDeDireccionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bajaDeDireccionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.navegadorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.inicioToolStripMenuItem,
            this.altaDeDireccionesToolStripMenuItem,
            this.modificaciónDeDireccionesToolStripMenuItem,
            this.bajaDeDireccionesToolStripMenuItem,
            this.navegadorToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // inicioToolStripMenuItem
            // 
            this.inicioToolStripMenuItem.Name = "inicioToolStripMenuItem";
            this.inicioToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.inicioToolStripMenuItem.Text = "Inicio";
            // 
            // altaDeDireccionesToolStripMenuItem
            // 
            this.altaDeDireccionesToolStripMenuItem.Name = "altaDeDireccionesToolStripMenuItem";
            this.altaDeDireccionesToolStripMenuItem.Size = new System.Drawing.Size(119, 20);
            this.altaDeDireccionesToolStripMenuItem.Text = "Alta de direcciones";
            this.altaDeDireccionesToolStripMenuItem.Click += new System.EventHandler(this.AltaDeDireccionesToolStripMenuItem_Click);
            // 
            // modificaciónDeDireccionesToolStripMenuItem
            // 
            this.modificaciónDeDireccionesToolStripMenuItem.Name = "modificaciónDeDireccionesToolStripMenuItem";
            this.modificaciónDeDireccionesToolStripMenuItem.Size = new System.Drawing.Size(145, 20);
            this.modificaciónDeDireccionesToolStripMenuItem.Text = "Consulta de direcciones";
            this.modificaciónDeDireccionesToolStripMenuItem.Click += new System.EventHandler(this.ModificaciónDeDireccionesToolStripMenuItem_Click);
            // 
            // bajaDeDireccionesToolStripMenuItem
            // 
            this.bajaDeDireccionesToolStripMenuItem.Name = "bajaDeDireccionesToolStripMenuItem";
            this.bajaDeDireccionesToolStripMenuItem.Size = new System.Drawing.Size(120, 20);
            this.bajaDeDireccionesToolStripMenuItem.Text = "Baja de direcciones";
            // 
            // navegadorToolStripMenuItem
            // 
            this.navegadorToolStripMenuItem.Name = "navegadorToolStripMenuItem";
            this.navegadorToolStripMenuItem.Size = new System.Drawing.Size(77, 20);
            this.navegadorToolStripMenuItem.Text = "Navegador";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Impact", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(257, 145);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(271, 117);
            this.label1.TabIndex = 1;
            this.label1.Text = "WEBS";
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.statusStrip1.Location = new System.Drawing.Point(0, 428);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(800, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            this.statusStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.StatusStrip1_ItemClicked);
            // 
            // Inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Inicio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inicio";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem inicioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem altaDeDireccionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modificaciónDeDireccionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bajaDeDireccionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem navegadorToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.StatusStrip statusStrip1;
    }
}