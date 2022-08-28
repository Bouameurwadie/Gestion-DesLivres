namespace AdoNet_V3
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNom = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtnbrpage = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtprix = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtAuteur = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_RECHERCHER = new System.Windows.Forms.Button();
            this.btn_Suppression = new System.Windows.Forms.Button();
            this.btn_Modification = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Auteur = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nbrPage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Prix = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label6 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(22, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID";
            // 
            // txtID
            // 
            this.txtID.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtID.Location = new System.Drawing.Point(144, 35);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(100, 23);
            this.txtID.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(22, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 24);
            this.label2.TabIndex = 0;
            this.label2.Text = "Nom";
            // 
            // txtNom
            // 
            this.txtNom.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNom.Location = new System.Drawing.Point(144, 90);
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(138, 23);
            this.txtNom.TabIndex = 1;
            this.txtNom.Tag = "ED";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(315, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(130, 24);
            this.label3.TabIndex = 0;
            this.label3.Text = "N° De Page";
            // 
            // txtnbrpage
            // 
            this.txtnbrpage.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnbrpage.Location = new System.Drawing.Point(461, 28);
            this.txtnbrpage.Name = "txtnbrpage";
            this.txtnbrpage.Size = new System.Drawing.Size(100, 23);
            this.txtnbrpage.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(339, 89);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 24);
            this.label4.TabIndex = 0;
            this.label4.Text = "Prix";
            // 
            // txtprix
            // 
            this.txtprix.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtprix.Location = new System.Drawing.Point(461, 89);
            this.txtprix.Name = "txtprix";
            this.txtprix.Size = new System.Drawing.Size(100, 23);
            this.txtprix.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(22, 138);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 24);
            this.label5.TabIndex = 0;
            this.label5.Text = "Auteur";
            // 
            // txtAuteur
            // 
            this.txtAuteur.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAuteur.Location = new System.Drawing.Point(144, 136);
            this.txtAuteur.Name = "txtAuteur";
            this.txtAuteur.Size = new System.Drawing.Size(138, 23);
            this.txtAuteur.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtAuteur);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtprix);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtnbrpage);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtNom);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtID);
            this.groupBox1.Location = new System.Drawing.Point(119, 79);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(708, 195);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.btn_RECHERCHER);
            this.groupBox2.Controls.Add(this.btn_Suppression);
            this.groupBox2.Controls.Add(this.btn_Modification);
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Location = new System.Drawing.Point(633, 289);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(241, 217);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            // 
            // btn_RECHERCHER
            // 
            this.btn_RECHERCHER.Location = new System.Drawing.Point(12, 122);
            this.btn_RECHERCHER.Name = "btn_RECHERCHER";
            this.btn_RECHERCHER.Size = new System.Drawing.Size(226, 28);
            this.btn_RECHERCHER.TabIndex = 0;
            this.btn_RECHERCHER.Text = "RECHERCHER PAR ID";
            this.btn_RECHERCHER.UseVisualStyleBackColor = true;
            this.btn_RECHERCHER.Click += new System.EventHandler(this.btn_RECHERCHER_Click);
            // 
            // btn_Suppression
            // 
            this.btn_Suppression.Location = new System.Drawing.Point(12, 88);
            this.btn_Suppression.Name = "btn_Suppression";
            this.btn_Suppression.Size = new System.Drawing.Size(226, 28);
            this.btn_Suppression.TabIndex = 0;
            this.btn_Suppression.Text = "Suppression";
            this.btn_Suppression.UseVisualStyleBackColor = true;
            this.btn_Suppression.Click += new System.EventHandler(this.btn_Suppression_Click);
            // 
            // btn_Modification
            // 
            this.btn_Modification.Location = new System.Drawing.Point(12, 54);
            this.btn_Modification.Name = "btn_Modification";
            this.btn_Modification.Size = new System.Drawing.Size(226, 28);
            this.btn_Modification.TabIndex = 0;
            this.btn_Modification.Text = "Modification";
            this.btn_Modification.UseVisualStyleBackColor = true;
            this.btn_Modification.Click += new System.EventHandler(this.btn_Modification_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 19);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(226, 29);
            this.button2.TabIndex = 0;
            this.button2.Text = "Ajoute";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // dgv
            // 
            this.dgv.AllowUserToAddRows = false;
            this.dgv.AllowUserToDeleteRows = false;
            this.dgv.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Nom,
            this.Auteur,
            this.nbrPage,
            this.Prix});
            this.dgv.Location = new System.Drawing.Point(30, 289);
            this.dgv.Name = "dgv";
            this.dgv.ReadOnly = true;
            this.dgv.Size = new System.Drawing.Size(543, 217);
            this.dgv.TabIndex = 4;
            this.dgv.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_CellClick);
            this.dgv.Click += new System.EventHandler(this.dgv_Click);
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            // 
            // Nom
            // 
            this.Nom.HeaderText = "Nom";
            this.Nom.Name = "Nom";
            this.Nom.ReadOnly = true;
            // 
            // Auteur
            // 
            this.Auteur.HeaderText = "Auteur";
            this.Auteur.Name = "Auteur";
            this.Auteur.ReadOnly = true;
            // 
            // nbrPage
            // 
            this.nbrPage.HeaderText = "N° Des Pages";
            this.nbrPage.Name = "nbrPage";
            this.nbrPage.ReadOnly = true;
            // 
            // Prix
            // 
            this.Prix.HeaderText = "Prix";
            this.Prix.Name = "Prix";
            this.Prix.ReadOnly = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(293, 26);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(298, 38);
            this.label6.TabIndex = 5;
            this.label6.Text = "Gestion Des Livres";
            // 
            // button1
            // 
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.Location = new System.Drawing.Point(44, 156);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(160, 44);
            this.button1.TabIndex = 6;
            this.button1.Text = "Export To Pdf";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(913, 518);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dgv);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Gestion Des Livres";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNom;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtnbrpage;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtprix;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtAuteur;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btn_RECHERCHER;
        private System.Windows.Forms.Button btn_Suppression;
        private System.Windows.Forms.Button btn_Modification;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nom;
        private System.Windows.Forms.DataGridViewTextBoxColumn Auteur;
        private System.Windows.Forms.DataGridViewTextBoxColumn nbrPage;
        private System.Windows.Forms.DataGridViewTextBoxColumn Prix;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button1;
    }
}

