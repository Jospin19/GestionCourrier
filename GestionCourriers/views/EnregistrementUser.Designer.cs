namespace GestionCourriers.views
{
    partial class EnregistrementUser
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

        #region Code généré par le Concepteur de composants

        /// <summary> 
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas 
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EnregistrementUser));
            this.dgEnr = new ns1.BunifuCustomDataGrid();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.actualCourrier = new ns1.BunifuThinButton2();
            this.imgCourrier = new System.Windows.Forms.DataGridViewImageColumn();
            this.referenceCourrier = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.libelleCourrier = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typeCourrier = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomExpediteur = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prenomExpediteur = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgEnr)).BeginInit();
            this.SuspendLayout();
            // 
            // dgEnr
            // 
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgEnr.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgEnr.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgEnr.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgEnr.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(97)))), ((int)(((byte)(226)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgEnr.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgEnr.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgEnr.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.imgCourrier,
            this.referenceCourrier,
            this.libelleCourrier,
            this.typeCourrier,
            this.nomExpediteur,
            this.prenomExpediteur});
            this.dgEnr.DoubleBuffered = true;
            this.dgEnr.EnableHeadersVisualStyles = false;
            this.dgEnr.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgEnr.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(97)))), ((int)(((byte)(226)))));
            this.dgEnr.HeaderForeColor = System.Drawing.Color.White;
            this.dgEnr.Location = new System.Drawing.Point(102, 26);
            this.dgEnr.Name = "dgEnr";
            this.dgEnr.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgEnr.Size = new System.Drawing.Size(631, 278);
            this.dgEnr.TabIndex = 11;
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.HeaderText = "Image";
            this.dataGridViewImageColumn1.Image = global::GestionCourriers.Properties.Resources.history;
            this.dataGridViewImageColumn1.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            // 
            // actualCourrier
            // 
            this.actualCourrier.ActiveBorderThickness = 1;
            this.actualCourrier.ActiveCornerRadius = 20;
            this.actualCourrier.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.actualCourrier.ActiveForecolor = System.Drawing.Color.Transparent;
            this.actualCourrier.ActiveLineColor = System.Drawing.Color.Green;
            this.actualCourrier.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.actualCourrier.BackColor = System.Drawing.SystemColors.ControlLight;
            this.actualCourrier.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("actualCourrier.BackgroundImage")));
            this.actualCourrier.ButtonText = "Actualiser";
            this.actualCourrier.Cursor = System.Windows.Forms.Cursors.Hand;
            this.actualCourrier.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.actualCourrier.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.actualCourrier.IdleBorderThickness = 1;
            this.actualCourrier.IdleCornerRadius = 20;
            this.actualCourrier.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.actualCourrier.IdleForecolor = System.Drawing.Color.White;
            this.actualCourrier.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.actualCourrier.ImeMode = System.Windows.Forms.ImeMode.AlphaFull;
            this.actualCourrier.Location = new System.Drawing.Point(598, 329);
            this.actualCourrier.Margin = new System.Windows.Forms.Padding(5);
            this.actualCourrier.Name = "actualCourrier";
            this.actualCourrier.Size = new System.Drawing.Size(135, 41);
            this.actualCourrier.TabIndex = 12;
            this.actualCourrier.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.actualCourrier.Click += new System.EventHandler(this.actualCourrier_Click);
            // 
            // imgCourrier
            // 
            this.imgCourrier.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.imgCourrier.HeaderText = "Image";
            this.imgCourrier.Image = global::GestionCourriers.Properties.Resources.history;
            this.imgCourrier.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.imgCourrier.Name = "imgCourrier";
            // 
            // referenceCourrier
            // 
            this.referenceCourrier.HeaderText = "Reference";
            this.referenceCourrier.Name = "referenceCourrier";
            // 
            // libelleCourrier
            // 
            this.libelleCourrier.HeaderText = "Libelle";
            this.libelleCourrier.Name = "libelleCourrier";
            // 
            // typeCourrier
            // 
            this.typeCourrier.HeaderText = "Type";
            this.typeCourrier.Name = "typeCourrier";
            // 
            // nomExpediteur
            // 
            this.nomExpediteur.HeaderText = "Nom expediteur";
            this.nomExpediteur.Name = "nomExpediteur";
            // 
            // prenomExpediteur
            // 
            this.prenomExpediteur.HeaderText = "Prenom expediteur";
            this.prenomExpediteur.Name = "prenomExpediteur";
            // 
            // EnregistrementUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Controls.Add(this.dgEnr);
            this.Controls.Add(this.actualCourrier);
            this.Name = "EnregistrementUser";
            this.Size = new System.Drawing.Size(821, 397);
            ((System.ComponentModel.ISupportInitialize)(this.dgEnr)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public ns1.BunifuCustomDataGrid dgEnr;
        private ns1.BunifuThinButton2 actualCourrier;
        private System.Windows.Forms.DataGridViewImageColumn imgCourrier;
        private System.Windows.Forms.DataGridViewTextBoxColumn referenceCourrier;
        private System.Windows.Forms.DataGridViewTextBoxColumn libelleCourrier;
        private System.Windows.Forms.DataGridViewTextBoxColumn typeCourrier;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomExpediteur;
        private System.Windows.Forms.DataGridViewTextBoxColumn prenomExpediteur;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
    }
}
