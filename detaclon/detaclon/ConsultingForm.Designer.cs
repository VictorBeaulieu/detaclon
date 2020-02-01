namespace detaclon
{
    partial class ConsultingForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConsultingForm));
            this.btn_exit = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.affichageToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.optionToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.deconnectionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.affichageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.magasinToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rayonToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.produitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_exit
            // 
            this.btn_exit.Location = new System.Drawing.Point(713, 415);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(75, 23);
            this.btn_exit.TabIndex = 1;
            this.btn_exit.Text = "Quitter";
            this.btn_exit.UseVisualStyleBackColor = true;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.affichageToolStripMenuItem1,
            this.optionToolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // affichageToolStripMenuItem1
            // 
            this.affichageToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.magasinToolStripMenuItem,
            this.rayonToolStripMenuItem,
            this.produitToolStripMenuItem});
            this.affichageToolStripMenuItem1.Name = "affichageToolStripMenuItem1";
            this.affichageToolStripMenuItem1.Size = new System.Drawing.Size(70, 20);
            this.affichageToolStripMenuItem1.Text = "Affichage";
            // 
            // optionToolStripMenuItem1
            // 
            this.optionToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deconnectionToolStripMenuItem});
            this.optionToolStripMenuItem1.Name = "optionToolStripMenuItem1";
            this.optionToolStripMenuItem1.Size = new System.Drawing.Size(56, 20);
            this.optionToolStripMenuItem1.Text = "Option";
            // 
            // deconnectionToolStripMenuItem
            // 
            this.deconnectionToolStripMenuItem.Image = global::detaclon.Properties.Resources.logout;
            this.deconnectionToolStripMenuItem.Name = "deconnectionToolStripMenuItem";
            this.deconnectionToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.deconnectionToolStripMenuItem.Text = "Déconnexion";
            this.deconnectionToolStripMenuItem.Click += new System.EventHandler(this.deconnectionToolStripMenuItem_Click);
            // 
            // affichageToolStripMenuItem
            // 
            this.affichageToolStripMenuItem.Name = "affichageToolStripMenuItem";
            this.affichageToolStripMenuItem.Size = new System.Drawing.Size(70, 20);
            this.affichageToolStripMenuItem.Text = "Affichage";
            // 
            // optionToolStripMenuItem
            // 
            this.optionToolStripMenuItem.Name = "optionToolStripMenuItem";
            this.optionToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.optionToolStripMenuItem.Text = "Option";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.toolStripMenuItem1.Text = "Déconnexion";
            // 
            // magasinToolStripMenuItem
            // 
            this.magasinToolStripMenuItem.Image = global::detaclon.Properties.Resources.store;
            this.magasinToolStripMenuItem.Name = "magasinToolStripMenuItem";
            this.magasinToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.magasinToolStripMenuItem.Text = "Magasin";
            // 
            // rayonToolStripMenuItem
            // 
            this.rayonToolStripMenuItem.Image = global::detaclon.Properties.Resources.aisle;
            this.rayonToolStripMenuItem.Name = "rayonToolStripMenuItem";
            this.rayonToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.rayonToolStripMenuItem.Text = "Rayon";
            // 
            // produitToolStripMenuItem
            // 
            this.produitToolStripMenuItem.Image = global::detaclon.Properties.Resources.product;
            this.produitToolStripMenuItem.Name = "produitToolStripMenuItem";
            this.produitToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.produitToolStripMenuItem.Text = "Produit";
            // 
            // ConsultingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "ConsultingForm";
            this.Text = "Detaclon";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem affichageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem optionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem affichageToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem optionToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem deconnectionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem magasinToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rayonToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem produitToolStripMenuItem;
    }
}