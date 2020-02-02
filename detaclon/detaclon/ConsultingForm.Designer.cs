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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConsultingForm));
            this.btn_exit = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.affichageToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.optionToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.affichageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.detaclonProductDataSet = new detaclon.detaclonProductDataSet();
            this.detaclonProductDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btn_add_product = new System.Windows.Forms.Button();
            this.btn_add_store = new System.Windows.Forms.Button();
            this.btn_add_aisle = new System.Windows.Forms.Button();
            this.btn_del_product = new System.Windows.Forms.Button();
            this.btn_del_aisle = new System.Windows.Forms.Button();
            this.btn_del_store = new System.Windows.Forms.Button();
            this.magasinToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rayonToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.produitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.utilisateurToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deconnectionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_del_user = new System.Windows.Forms.Button();
            this.btn_add_user = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.detaclonProductDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.detaclonProductDataSetBindingSource)).BeginInit();
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
            this.utilisateurToolStripMenuItem,
            this.deconnectionToolStripMenuItem});
            this.optionToolStripMenuItem1.Name = "optionToolStripMenuItem1";
            this.optionToolStripMenuItem1.Size = new System.Drawing.Size(56, 20);
            this.optionToolStripMenuItem1.Text = "Option";
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
            // dataGridView
            // 
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(12, 27);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.Size = new System.Drawing.Size(695, 411);
            this.dataGridView.TabIndex = 4;
            // 
            // detaclonProductDataSet
            // 
            this.detaclonProductDataSet.DataSetName = "detaclonProductDataSet";
            this.detaclonProductDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // detaclonProductDataSetBindingSource
            // 
            this.detaclonProductDataSetBindingSource.DataSource = this.detaclonProductDataSet;
            this.detaclonProductDataSetBindingSource.Position = 0;
            // 
            // btn_add_product
            // 
            this.btn_add_product.Location = new System.Drawing.Point(713, 27);
            this.btn_add_product.Name = "btn_add_product";
            this.btn_add_product.Size = new System.Drawing.Size(75, 39);
            this.btn_add_product.TabIndex = 6;
            this.btn_add_product.Text = "Ajouter un produit";
            this.btn_add_product.UseVisualStyleBackColor = true;
            this.btn_add_product.Click += new System.EventHandler(this.btn_add_product_Click);
            // 
            // btn_add_store
            // 
            this.btn_add_store.Location = new System.Drawing.Point(713, 27);
            this.btn_add_store.Name = "btn_add_store";
            this.btn_add_store.Size = new System.Drawing.Size(75, 39);
            this.btn_add_store.TabIndex = 7;
            this.btn_add_store.Text = "Ajouter un magasin";
            this.btn_add_store.UseVisualStyleBackColor = true;
            this.btn_add_store.Click += new System.EventHandler(this.btn_add_store_Click);
            // 
            // btn_add_aisle
            // 
            this.btn_add_aisle.Location = new System.Drawing.Point(713, 27);
            this.btn_add_aisle.Name = "btn_add_aisle";
            this.btn_add_aisle.Size = new System.Drawing.Size(75, 39);
            this.btn_add_aisle.TabIndex = 8;
            this.btn_add_aisle.Text = "Ajouter un rayon";
            this.btn_add_aisle.UseVisualStyleBackColor = true;
            this.btn_add_aisle.Click += new System.EventHandler(this.btn_add_aisle_Click);
            // 
            // btn_del_product
            // 
            this.btn_del_product.Location = new System.Drawing.Point(713, 72);
            this.btn_del_product.Name = "btn_del_product";
            this.btn_del_product.Size = new System.Drawing.Size(75, 39);
            this.btn_del_product.TabIndex = 9;
            this.btn_del_product.Text = "Supprimer un produit";
            this.btn_del_product.UseVisualStyleBackColor = true;
            this.btn_del_product.Click += new System.EventHandler(this.btn_del_product_Click);
            // 
            // btn_del_aisle
            // 
            this.btn_del_aisle.Location = new System.Drawing.Point(713, 72);
            this.btn_del_aisle.Name = "btn_del_aisle";
            this.btn_del_aisle.Size = new System.Drawing.Size(75, 39);
            this.btn_del_aisle.TabIndex = 10;
            this.btn_del_aisle.Text = "Supprimer un rayon";
            this.btn_del_aisle.UseVisualStyleBackColor = true;
            this.btn_del_aisle.Click += new System.EventHandler(this.btn_del_aisle_Click);
            // 
            // btn_del_store
            // 
            this.btn_del_store.Location = new System.Drawing.Point(713, 72);
            this.btn_del_store.Name = "btn_del_store";
            this.btn_del_store.Size = new System.Drawing.Size(75, 39);
            this.btn_del_store.TabIndex = 11;
            this.btn_del_store.Text = "Supprimer un magasin";
            this.btn_del_store.UseVisualStyleBackColor = true;
            this.btn_del_store.Click += new System.EventHandler(this.btn_del_store_Click);
            // 
            // magasinToolStripMenuItem
            // 
            this.magasinToolStripMenuItem.Image = global::detaclon.Properties.Resources.store;
            this.magasinToolStripMenuItem.Name = "magasinToolStripMenuItem";
            this.magasinToolStripMenuItem.Size = new System.Drawing.Size(119, 22);
            this.magasinToolStripMenuItem.Text = "Magasin";
            this.magasinToolStripMenuItem.Click += new System.EventHandler(this.magasinToolStripMenuItem_Click);
            // 
            // rayonToolStripMenuItem
            // 
            this.rayonToolStripMenuItem.Image = global::detaclon.Properties.Resources.aisle;
            this.rayonToolStripMenuItem.Name = "rayonToolStripMenuItem";
            this.rayonToolStripMenuItem.Size = new System.Drawing.Size(119, 22);
            this.rayonToolStripMenuItem.Text = "Rayon";
            this.rayonToolStripMenuItem.Click += new System.EventHandler(this.rayonToolStripMenuItem_Click);
            // 
            // produitToolStripMenuItem
            // 
            this.produitToolStripMenuItem.Image = global::detaclon.Properties.Resources.product;
            this.produitToolStripMenuItem.Name = "produitToolStripMenuItem";
            this.produitToolStripMenuItem.Size = new System.Drawing.Size(119, 22);
            this.produitToolStripMenuItem.Text = "Produit";
            this.produitToolStripMenuItem.Click += new System.EventHandler(this.produitToolStripMenuItem_Click);
            // 
            // utilisateurToolStripMenuItem
            // 
            this.utilisateurToolStripMenuItem.Image = global::detaclon.Properties.Resources.user;
            this.utilisateurToolStripMenuItem.Name = "utilisateurToolStripMenuItem";
            this.utilisateurToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.utilisateurToolStripMenuItem.Text = "Utilisateur";
            this.utilisateurToolStripMenuItem.Click += new System.EventHandler(this.utilisateurToolStripMenuItem_Click);
            // 
            // deconnectionToolStripMenuItem
            // 
            this.deconnectionToolStripMenuItem.Image = global::detaclon.Properties.Resources.logout;
            this.deconnectionToolStripMenuItem.Name = "deconnectionToolStripMenuItem";
            this.deconnectionToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.deconnectionToolStripMenuItem.Text = "Déconnexion";
            this.deconnectionToolStripMenuItem.Click += new System.EventHandler(this.deconnectionToolStripMenuItem_Click);
            // 
            // btn_del_user
            // 
            this.btn_del_user.Location = new System.Drawing.Point(713, 72);
            this.btn_del_user.Name = "btn_del_user";
            this.btn_del_user.Size = new System.Drawing.Size(75, 39);
            this.btn_del_user.TabIndex = 13;
            this.btn_del_user.Text = "Supprimer un utilisateur";
            this.btn_del_user.UseVisualStyleBackColor = true;
            // 
            // btn_add_user
            // 
            this.btn_add_user.Location = new System.Drawing.Point(713, 27);
            this.btn_add_user.Name = "btn_add_user";
            this.btn_add_user.Size = new System.Drawing.Size(75, 39);
            this.btn_add_user.TabIndex = 12;
            this.btn_add_user.Text = "Ajouter un utilisateur";
            this.btn_add_user.UseVisualStyleBackColor = true;
            // 
            // ConsultingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_del_user);
            this.Controls.Add(this.btn_add_user);
            this.Controls.Add(this.btn_del_store);
            this.Controls.Add(this.btn_del_aisle);
            this.Controls.Add(this.btn_del_product);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.btn_add_store);
            this.Controls.Add(this.btn_add_product);
            this.Controls.Add(this.btn_add_aisle);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "ConsultingForm";
            this.Text = "Detaclon";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.detaclonProductDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.detaclonProductDataSetBindingSource)).EndInit();
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
        private System.Windows.Forms.DataGridView dataGridView;
        private detaclonProductDataSet detaclonProductDataSet;
        private System.Windows.Forms.BindingSource detaclonProductDataSetBindingSource;
        private System.Windows.Forms.Button btn_add_product;
        private System.Windows.Forms.Button btn_add_store;
        private System.Windows.Forms.Button btn_add_aisle;
        private System.Windows.Forms.Button btn_del_product;
        private System.Windows.Forms.Button btn_del_aisle;
        private System.Windows.Forms.Button btn_del_store;
        private System.Windows.Forms.ToolStripMenuItem utilisateurToolStripMenuItem;
        private System.Windows.Forms.Button btn_del_user;
        private System.Windows.Forms.Button btn_add_user;
    }
}