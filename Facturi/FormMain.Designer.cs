
namespace Facturi
{
    partial class MainForm
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
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.parteneriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adaugarePartenerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.facturiToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.facturaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.rapoarteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip2
            // 
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.parteneriToolStripMenuItem,
            this.facturiToolStripMenuItem1,
            this.rapoarteToolStripMenuItem});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(654, 24);
            this.menuStrip2.TabIndex = 0;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // parteneriToolStripMenuItem
            // 
            this.parteneriToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.adaugarePartenerToolStripMenuItem});
            this.parteneriToolStripMenuItem.Name = "parteneriToolStripMenuItem";
            this.parteneriToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.parteneriToolStripMenuItem.Text = "Parteneri";
            // 
            // adaugarePartenerToolStripMenuItem
            // 
            this.adaugarePartenerToolStripMenuItem.Name = "adaugarePartenerToolStripMenuItem";
            this.adaugarePartenerToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.adaugarePartenerToolStripMenuItem.Text = "Gestionare Parteneri";
            this.adaugarePartenerToolStripMenuItem.Click += new System.EventHandler(this.adaugarePartenerToolStripMenuItem_Click);
            // 
            // facturiToolStripMenuItem1
            // 
            this.facturiToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.facturaToolStripMenuItem,
            this.toolStripMenuItem4});
            this.facturiToolStripMenuItem1.Name = "facturiToolStripMenuItem1";
            this.facturiToolStripMenuItem1.Size = new System.Drawing.Size(55, 20);
            this.facturiToolStripMenuItem1.Text = "Facturi";
            // 
            // facturaToolStripMenuItem
            // 
            this.facturaToolStripMenuItem.Name = "facturaToolStripMenuItem";
            this.facturaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.facturaToolStripMenuItem.Text = "Factura";
            this.facturaToolStripMenuItem.Click += new System.EventHandler(this.facturaToolStripMenuItem_Click);
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(180, 22);
            this.toolStripMenuItem4.Text = "Registru facturi";
            this.toolStripMenuItem4.Click += new System.EventHandler(this.toolStripMenuItem4_Click);
            // 
            // rapoarteToolStripMenuItem
            // 
            this.rapoarteToolStripMenuItem.Name = "rapoarteToolStripMenuItem";
            this.rapoarteToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.rapoarteToolStripMenuItem.Text = "Rapoarte";
            this.rapoarteToolStripMenuItem.Click += new System.EventHandler(this.rapoarteToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.ClientSize = new System.Drawing.Size(654, 392);
            this.Controls.Add(this.menuStrip2);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip2;
            this.Name = "MainForm";
            this.Text = "Pagina Principala";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem adaugareFacturaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registruFacturiToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem parteneriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem adaugarePartenerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem facturiToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem facturaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem rapoarteToolStripMenuItem;
    }
}

