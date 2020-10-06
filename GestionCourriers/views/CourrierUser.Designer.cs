namespace GestionCourriers.views
{
    partial class CourrierUser
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            BunifuAnimatorNS.Animation animation1 = new BunifuAnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CourrierUser));
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dgCourrier = new ns1.BunifuCustomDataGrid();
            this.imgCourrier = new System.Windows.Forms.DataGridViewImageColumn();
            this.referenceCourrier = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.libelleCourrier = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contenuCourrier = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typeCourrier = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomExpediteur = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelAjoutCour = new System.Windows.Forms.Panel();
            this.typeCour = new ns1.BunifuDropdown();
            this.label3 = new System.Windows.Forms.Label();
            this.refCourrier = new ns1.BunifuTextbox();
            this.contCourrier = new ns1.BunifuTextbox();
            this.libCourrier = new ns1.BunifuTextbox();
            this.btnSuivant = new ns1.BunifuThinButton2();
            this.panelExp = new System.Windows.Forms.Panel();
            this.nomE = new ns1.BunifuTextbox();
            this.SaveCour = new ns1.BunifuFlatButton();
            this.prenomExp = new ns1.BunifuTextbox();
            this.telExp = new ns1.BunifuTextbox();
            this.transition = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.modifCourrier = new System.Windows.Forms.Panel();
            this.txtType = new ns1.BunifuDropdown();
            this.label2 = new System.Windows.Forms.Label();
            this.txt = new System.Windows.Forms.Label();
            this.Cont = new ns1.BunifuMaterialTextbox();
            this.label1 = new System.Windows.Forms.Label();
            this.Exp = new ns1.BunifuMaterialTextbox();
            this.NomUser = new System.Windows.Forms.Label();
            this.Lib = new ns1.BunifuMaterialTextbox();
            this.bunifuThinButton21 = new ns1.BunifuThinButton2();
            this.bunifuThinButton22 = new ns1.BunifuThinButton2();
            this.btnSearch = new ns1.BunifuImageButton();
            this.ajoutCourrier = new ns1.BunifuThinButton2();
            this.searchCourrier = new ns1.BunifuTextbox();
            this.actualCourrier = new ns1.BunifuThinButton2();
            this.dataGridViewImageColumn2 = new System.Windows.Forms.DataGridViewImageColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgCourrier)).BeginInit();
            this.panelAjoutCour.SuspendLayout();
            this.panelExp.SuspendLayout();
            this.modifCourrier.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnSearch)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.HeaderText = "Image";
            this.dataGridViewImageColumn1.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            // 
            // dgCourrier
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgCourrier.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgCourrier.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgCourrier.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgCourrier.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(22)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgCourrier.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgCourrier.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgCourrier.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.imgCourrier,
            this.referenceCourrier,
            this.libelleCourrier,
            this.contenuCourrier,
            this.typeCourrier,
            this.nomExpediteur});
            this.transition.SetDecoration(this.dgCourrier, BunifuAnimatorNS.DecorationType.None);
            this.dgCourrier.DoubleBuffered = true;
            this.dgCourrier.EnableHeadersVisualStyles = false;
            this.dgCourrier.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgCourrier.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(22)))), ((int)(((byte)(224)))));
            this.dgCourrier.HeaderForeColor = System.Drawing.Color.White;
            this.dgCourrier.Location = new System.Drawing.Point(71, 21);
            this.dgCourrier.Name = "dgCourrier";
            this.dgCourrier.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgCourrier.Size = new System.Drawing.Size(689, 150);
            this.dgCourrier.TabIndex = 13;
            this.dgCourrier.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgCourrier_CellClick);
            // 
            // imgCourrier
            // 
            this.imgCourrier.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.imgCourrier.HeaderText = "Image";
            this.imgCourrier.Image = global::GestionCourriers.Properties.Resources._029_book;
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
            // contenuCourrier
            // 
            this.contenuCourrier.HeaderText = "Contenu";
            this.contenuCourrier.Name = "contenuCourrier";
            // 
            // typeCourrier
            // 
            this.typeCourrier.HeaderText = "Type";
            this.typeCourrier.Name = "typeCourrier";
            // 
            // nomExpediteur
            // 
            this.nomExpediteur.HeaderText = "Expediteur";
            this.nomExpediteur.Name = "nomExpediteur";
            // 
            // panelAjoutCour
            // 
            this.panelAjoutCour.Controls.Add(this.typeCour);
            this.panelAjoutCour.Controls.Add(this.label3);
            this.panelAjoutCour.Controls.Add(this.refCourrier);
            this.panelAjoutCour.Controls.Add(this.contCourrier);
            this.panelAjoutCour.Controls.Add(this.libCourrier);
            this.panelAjoutCour.Controls.Add(this.btnSuivant);
            this.transition.SetDecoration(this.panelAjoutCour, BunifuAnimatorNS.DecorationType.None);
            this.panelAjoutCour.Location = new System.Drawing.Point(45, 253);
            this.panelAjoutCour.Name = "panelAjoutCour";
            this.panelAjoutCour.Size = new System.Drawing.Size(733, 124);
            this.panelAjoutCour.TabIndex = 21;
            this.panelAjoutCour.Visible = false;
            // 
            // typeCour
            // 
            this.typeCour.BackColor = System.Drawing.Color.Transparent;
            this.typeCour.BorderRadius = 3;
            this.transition.SetDecoration(this.typeCour, BunifuAnimatorNS.DecorationType.None);
            this.typeCour.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(22)))), ((int)(((byte)(224)))));
            this.typeCour.Items = new string[] {
        "Entrant",
        "Interne",
        "Sortant"};
            this.typeCour.Location = new System.Drawing.Point(409, 23);
            this.typeCour.Name = "typeCour";
            this.typeCour.NomalColor = System.Drawing.Color.Transparent;
            this.typeCour.onHoverColor = System.Drawing.Color.Transparent;
            this.typeCour.selectedIndex = 0;
            this.typeCour.Size = new System.Drawing.Size(120, 35);
            this.typeCour.TabIndex = 33;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.transition.SetDecoration(this.label3, BunifuAnimatorNS.DecorationType.None);
            this.label3.Font = new System.Drawing.Font("Felix Titling", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(22)))), ((int)(((byte)(224)))));
            this.label3.Location = new System.Drawing.Point(363, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 18);
            this.label3.TabIndex = 32;
            this.label3.Text = "Type : ";
            // 
            // refCourrier
            // 
            this.refCourrier.BackColor = System.Drawing.SystemColors.ControlLight;
            this.refCourrier.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("refCourrier.BackgroundImage")));
            this.refCourrier.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.transition.SetDecoration(this.refCourrier, BunifuAnimatorNS.DecorationType.None);
            this.refCourrier.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(22)))), ((int)(((byte)(224)))));
            this.refCourrier.Icon = ((System.Drawing.Image)(resources.GetObject("refCourrier.Icon")));
            this.refCourrier.Location = new System.Drawing.Point(13, 20);
            this.refCourrier.Name = "refCourrier";
            this.refCourrier.Size = new System.Drawing.Size(109, 37);
            this.refCourrier.TabIndex = 23;
            this.refCourrier.text = "Reference";
            this.refCourrier.Enter += new System.EventHandler(this.refCourrier_Enter);
            // 
            // contCourrier
            // 
            this.contCourrier.BackColor = System.Drawing.SystemColors.ControlLight;
            this.contCourrier.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("contCourrier.BackgroundImage")));
            this.contCourrier.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.transition.SetDecoration(this.contCourrier, BunifuAnimatorNS.DecorationType.None);
            this.contCourrier.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(22)))), ((int)(((byte)(224)))));
            this.contCourrier.Icon = ((System.Drawing.Image)(resources.GetObject("contCourrier.Icon")));
            this.contCourrier.Location = new System.Drawing.Point(13, 75);
            this.contCourrier.Name = "contCourrier";
            this.contCourrier.Size = new System.Drawing.Size(523, 37);
            this.contCourrier.TabIndex = 21;
            this.contCourrier.text = "Contenu";
            this.contCourrier.Enter += new System.EventHandler(this.contCourrier_Enter);
            // 
            // libCourrier
            // 
            this.libCourrier.BackColor = System.Drawing.SystemColors.ControlLight;
            this.libCourrier.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("libCourrier.BackgroundImage")));
            this.libCourrier.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.transition.SetDecoration(this.libCourrier, BunifuAnimatorNS.DecorationType.None);
            this.libCourrier.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(22)))), ((int)(((byte)(224)))));
            this.libCourrier.Icon = ((System.Drawing.Image)(resources.GetObject("libCourrier.Icon")));
            this.libCourrier.Location = new System.Drawing.Point(149, 20);
            this.libCourrier.Name = "libCourrier";
            this.libCourrier.Size = new System.Drawing.Size(200, 37);
            this.libCourrier.TabIndex = 20;
            this.libCourrier.text = "Libelle";
            this.libCourrier.Enter += new System.EventHandler(this.libCourrier_Enter);
            // 
            // btnSuivant
            // 
            this.btnSuivant.ActiveBorderThickness = 1;
            this.btnSuivant.ActiveCornerRadius = 20;
            this.btnSuivant.ActiveFillColor = System.Drawing.Color.DarkOrange;
            this.btnSuivant.ActiveForecolor = System.Drawing.Color.Transparent;
            this.btnSuivant.ActiveLineColor = System.Drawing.Color.DarkOrange;
            this.btnSuivant.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSuivant.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnSuivant.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSuivant.BackgroundImage")));
            this.btnSuivant.ButtonText = "Suivant";
            this.btnSuivant.Cursor = System.Windows.Forms.Cursors.Hand;
            this.transition.SetDecoration(this.btnSuivant, BunifuAnimatorNS.DecorationType.None);
            this.btnSuivant.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSuivant.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnSuivant.IdleBorderThickness = 1;
            this.btnSuivant.IdleCornerRadius = 20;
            this.btnSuivant.IdleFillColor = System.Drawing.Color.Orange;
            this.btnSuivant.IdleForecolor = System.Drawing.Color.White;
            this.btnSuivant.IdleLineColor = System.Drawing.Color.Orange;
            this.btnSuivant.ImeMode = System.Windows.Forms.ImeMode.AlphaFull;
            this.btnSuivant.Location = new System.Drawing.Point(547, 65);
            this.btnSuivant.Margin = new System.Windows.Forms.Padding(5);
            this.btnSuivant.Name = "btnSuivant";
            this.btnSuivant.Size = new System.Drawing.Size(154, 41);
            this.btnSuivant.TabIndex = 10;
            this.btnSuivant.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnSuivant.Click += new System.EventHandler(this.btnSuivant_Click);
            // 
            // panelExp
            // 
            this.panelExp.Controls.Add(this.nomE);
            this.panelExp.Controls.Add(this.SaveCour);
            this.panelExp.Controls.Add(this.prenomExp);
            this.panelExp.Controls.Add(this.telExp);
            this.transition.SetDecoration(this.panelExp, BunifuAnimatorNS.DecorationType.None);
            this.panelExp.Location = new System.Drawing.Point(18, 256);
            this.panelExp.Name = "panelExp";
            this.panelExp.Size = new System.Drawing.Size(744, 124);
            this.panelExp.TabIndex = 23;
            this.panelExp.Visible = false;
            // 
            // nomE
            // 
            this.nomE.BackColor = System.Drawing.SystemColors.ControlLight;
            this.nomE.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("nomE.BackgroundImage")));
            this.nomE.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.transition.SetDecoration(this.nomE, BunifuAnimatorNS.DecorationType.None);
            this.nomE.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(22)))), ((int)(((byte)(224)))));
            this.nomE.Icon = ((System.Drawing.Image)(resources.GetObject("nomE.Icon")));
            this.nomE.Location = new System.Drawing.Point(13, 17);
            this.nomE.Name = "nomE";
            this.nomE.Size = new System.Drawing.Size(318, 37);
            this.nomE.TabIndex = 27;
            this.nomE.text = "Nom de l\'expediteur";
            this.nomE.Enter += new System.EventHandler(this.nomE_Enter);
            // 
            // SaveCour
            // 
            this.SaveCour.Activecolor = System.Drawing.Color.Transparent;
            this.SaveCour.BackColor = System.Drawing.Color.Transparent;
            this.SaveCour.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.SaveCour.BorderRadius = 0;
            this.SaveCour.ButtonText = "             Enregistrer";
            this.SaveCour.Cursor = System.Windows.Forms.Cursors.Hand;
            this.transition.SetDecoration(this.SaveCour, BunifuAnimatorNS.DecorationType.None);
            this.SaveCour.DisabledColor = System.Drawing.Color.Gray;
            this.SaveCour.ForeColor = System.Drawing.Color.Black;
            this.SaveCour.Iconcolor = System.Drawing.Color.Transparent;
            this.SaveCour.Iconimage = global::GestionCourriers.Properties.Resources._067_paper_plane1;
            this.SaveCour.Iconimage_right = null;
            this.SaveCour.Iconimage_right_Selected = null;
            this.SaveCour.Iconimage_Selected = null;
            this.SaveCour.IconMarginLeft = 0;
            this.SaveCour.IconMarginRight = 0;
            this.SaveCour.IconRightVisible = true;
            this.SaveCour.IconRightZoom = 0D;
            this.SaveCour.IconVisible = true;
            this.SaveCour.IconZoom = 50D;
            this.SaveCour.IsTab = false;
            this.SaveCour.Location = new System.Drawing.Point(410, 72);
            this.SaveCour.Name = "SaveCour";
            this.SaveCour.Normalcolor = System.Drawing.Color.Transparent;
            this.SaveCour.OnHovercolor = System.Drawing.Color.Transparent;
            this.SaveCour.OnHoverTextColor = System.Drawing.Color.White;
            this.SaveCour.selected = false;
            this.SaveCour.Size = new System.Drawing.Size(153, 37);
            this.SaveCour.TabIndex = 26;
            this.SaveCour.Text = "             Enregistrer";
            this.SaveCour.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.SaveCour.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(22)))), ((int)(((byte)(224)))));
            this.SaveCour.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveCour.Click += new System.EventHandler(this.SaveCour_Click);
            // 
            // prenomExp
            // 
            this.prenomExp.BackColor = System.Drawing.SystemColors.ControlLight;
            this.prenomExp.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("prenomExp.BackgroundImage")));
            this.prenomExp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.transition.SetDecoration(this.prenomExp, BunifuAnimatorNS.DecorationType.None);
            this.prenomExp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(22)))), ((int)(((byte)(224)))));
            this.prenomExp.Icon = ((System.Drawing.Image)(resources.GetObject("prenomExp.Icon")));
            this.prenomExp.Location = new System.Drawing.Point(410, 17);
            this.prenomExp.Name = "prenomExp";
            this.prenomExp.Size = new System.Drawing.Size(318, 37);
            this.prenomExp.TabIndex = 24;
            this.prenomExp.text = "Prenom de l\'expediteur";
            this.prenomExp.Enter += new System.EventHandler(this.prenomExp_Enter);
            // 
            // telExp
            // 
            this.telExp.BackColor = System.Drawing.SystemColors.ControlLight;
            this.telExp.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("telExp.BackgroundImage")));
            this.telExp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.transition.SetDecoration(this.telExp, BunifuAnimatorNS.DecorationType.None);
            this.telExp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(22)))), ((int)(((byte)(224)))));
            this.telExp.Icon = ((System.Drawing.Image)(resources.GetObject("telExp.Icon")));
            this.telExp.Location = new System.Drawing.Point(13, 71);
            this.telExp.Name = "telExp";
            this.telExp.Size = new System.Drawing.Size(379, 37);
            this.telExp.TabIndex = 23;
            this.telExp.text = "Telelphone";
            this.telExp.Enter += new System.EventHandler(this.telExp_Enter);
            // 
            // transition
            // 
            this.transition.AnimationType = BunifuAnimatorNS.AnimationType.HorizSlide;
            this.transition.Cursor = null;
            animation1.AnimateOnlyDifferences = true;
            animation1.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.BlindCoeff")));
            animation1.LeafCoeff = 0F;
            animation1.MaxTime = 1F;
            animation1.MinTime = 0F;
            animation1.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicCoeff")));
            animation1.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicShift")));
            animation1.MosaicSize = 0;
            animation1.Padding = new System.Windows.Forms.Padding(0);
            animation1.RotateCoeff = 0F;
            animation1.RotateLimit = 0F;
            animation1.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.ScaleCoeff")));
            animation1.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.SlideCoeff")));
            animation1.TimeCoeff = 0F;
            animation1.TransparencyCoeff = 0F;
            this.transition.DefaultAnimation = animation1;
            // 
            // modifCourrier
            // 
            this.modifCourrier.Controls.Add(this.txtType);
            this.modifCourrier.Controls.Add(this.label2);
            this.modifCourrier.Controls.Add(this.txt);
            this.modifCourrier.Controls.Add(this.Cont);
            this.modifCourrier.Controls.Add(this.label1);
            this.modifCourrier.Controls.Add(this.Exp);
            this.modifCourrier.Controls.Add(this.NomUser);
            this.modifCourrier.Controls.Add(this.Lib);
            this.modifCourrier.Controls.Add(this.bunifuThinButton21);
            this.modifCourrier.Controls.Add(this.bunifuThinButton22);
            this.transition.SetDecoration(this.modifCourrier, BunifuAnimatorNS.DecorationType.None);
            this.modifCourrier.Location = new System.Drawing.Point(71, 241);
            this.modifCourrier.Name = "modifCourrier";
            this.modifCourrier.Size = new System.Drawing.Size(691, 124);
            this.modifCourrier.TabIndex = 29;
            this.modifCourrier.Visible = false;
            // 
            // txtType
            // 
            this.txtType.BackColor = System.Drawing.Color.Transparent;
            this.txtType.BorderRadius = 3;
            this.transition.SetDecoration(this.txtType, BunifuAnimatorNS.DecorationType.None);
            this.txtType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(22)))), ((int)(((byte)(224)))));
            this.txtType.Items = new string[] {
        "",
        "Entrant",
        "Interne",
        "Sortant"};
            this.txtType.Location = new System.Drawing.Point(555, 24);
            this.txtType.Name = "txtType";
            this.txtType.NomalColor = System.Drawing.Color.Transparent;
            this.txtType.onHoverColor = System.Drawing.Color.Transparent;
            this.txtType.selectedIndex = -1;
            this.txtType.Size = new System.Drawing.Size(120, 35);
            this.txtType.TabIndex = 31;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.transition.SetDecoration(this.label2, BunifuAnimatorNS.DecorationType.None);
            this.label2.Font = new System.Drawing.Font("Felix Titling", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DimGray;
            this.label2.Location = new System.Drawing.Point(509, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 30;
            this.label2.Text = "Type : ";
            // 
            // txt
            // 
            this.txt.AutoSize = true;
            this.transition.SetDecoration(this.txt, BunifuAnimatorNS.DecorationType.None);
            this.txt.Font = new System.Drawing.Font("Felix Titling", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt.ForeColor = System.Drawing.Color.DimGray;
            this.txt.Location = new System.Drawing.Point(3, 98);
            this.txt.Name = "txt";
            this.txt.Size = new System.Drawing.Size(71, 13);
            this.txt.TabIndex = 28;
            this.txt.Text = "Contenu : ";
            // 
            // Cont
            // 
            this.Cont.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.transition.SetDecoration(this.Cont, BunifuAnimatorNS.DecorationType.None);
            this.Cont.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.Cont.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Cont.HintForeColor = System.Drawing.Color.Empty;
            this.Cont.HintText = "";
            this.Cont.isPassword = false;
            this.Cont.LineFocusedColor = System.Drawing.Color.Blue;
            this.Cont.LineIdleColor = System.Drawing.Color.Gray;
            this.Cont.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.Cont.LineThickness = 3;
            this.Cont.Location = new System.Drawing.Point(74, 69);
            this.Cont.Margin = new System.Windows.Forms.Padding(4);
            this.Cont.Name = "Cont";
            this.Cont.Size = new System.Drawing.Size(382, 44);
            this.Cont.TabIndex = 27;
            this.Cont.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.transition.SetDecoration(this.label1, BunifuAnimatorNS.DecorationType.None);
            this.label1.Font = new System.Drawing.Font("Felix Titling", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DimGray;
            this.label1.Location = new System.Drawing.Point(237, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 26;
            this.label1.Text = "Expéditeur : ";
            // 
            // Exp
            // 
            this.Exp.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.transition.SetDecoration(this.Exp, BunifuAnimatorNS.DecorationType.None);
            this.Exp.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.Exp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Exp.HintForeColor = System.Drawing.Color.Empty;
            this.Exp.HintText = "";
            this.Exp.isPassword = false;
            this.Exp.LineFocusedColor = System.Drawing.Color.Blue;
            this.Exp.LineIdleColor = System.Drawing.Color.Gray;
            this.Exp.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.Exp.LineThickness = 3;
            this.Exp.Location = new System.Drawing.Point(318, 15);
            this.Exp.Margin = new System.Windows.Forms.Padding(4);
            this.Exp.Name = "Exp";
            this.Exp.Size = new System.Drawing.Size(171, 44);
            this.Exp.TabIndex = 25;
            this.Exp.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // NomUser
            // 
            this.NomUser.AutoSize = true;
            this.transition.SetDecoration(this.NomUser, BunifuAnimatorNS.DecorationType.None);
            this.NomUser.Font = new System.Drawing.Font("Felix Titling", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NomUser.ForeColor = System.Drawing.Color.DimGray;
            this.NomUser.Location = new System.Drawing.Point(8, 40);
            this.NomUser.Name = "NomUser";
            this.NomUser.Size = new System.Drawing.Size(51, 13);
            this.NomUser.TabIndex = 24;
            this.NomUser.Text = "Libelle :";
            // 
            // Lib
            // 
            this.Lib.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.transition.SetDecoration(this.Lib, BunifuAnimatorNS.DecorationType.None);
            this.Lib.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.Lib.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Lib.HintForeColor = System.Drawing.Color.Empty;
            this.Lib.HintText = "";
            this.Lib.isPassword = false;
            this.Lib.LineFocusedColor = System.Drawing.Color.Blue;
            this.Lib.LineIdleColor = System.Drawing.Color.Gray;
            this.Lib.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.Lib.LineThickness = 3;
            this.Lib.Location = new System.Drawing.Point(61, 12);
            this.Lib.Margin = new System.Windows.Forms.Padding(4);
            this.Lib.Name = "Lib";
            this.Lib.Size = new System.Drawing.Size(157, 44);
            this.Lib.TabIndex = 23;
            this.Lib.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // bunifuThinButton21
            // 
            this.bunifuThinButton21.ActiveBorderThickness = 1;
            this.bunifuThinButton21.ActiveCornerRadius = 20;
            this.bunifuThinButton21.ActiveFillColor = System.Drawing.Color.Orange;
            this.bunifuThinButton21.ActiveForecolor = System.Drawing.Color.Transparent;
            this.bunifuThinButton21.ActiveLineColor = System.Drawing.Color.Orange;
            this.bunifuThinButton21.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuThinButton21.BackColor = System.Drawing.SystemColors.ControlLight;
            this.bunifuThinButton21.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuThinButton21.BackgroundImage")));
            this.bunifuThinButton21.ButtonText = "Modifier";
            this.bunifuThinButton21.Cursor = System.Windows.Forms.Cursors.Hand;
            this.transition.SetDecoration(this.bunifuThinButton21, BunifuAnimatorNS.DecorationType.None);
            this.bunifuThinButton21.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuThinButton21.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.bunifuThinButton21.IdleBorderThickness = 1;
            this.bunifuThinButton21.IdleCornerRadius = 20;
            this.bunifuThinButton21.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(198)))), ((int)(((byte)(25)))));
            this.bunifuThinButton21.IdleForecolor = System.Drawing.Color.White;
            this.bunifuThinButton21.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(198)))), ((int)(((byte)(25)))));
            this.bunifuThinButton21.ImeMode = System.Windows.Forms.ImeMode.AlphaFull;
            this.bunifuThinButton21.Location = new System.Drawing.Point(465, 78);
            this.bunifuThinButton21.Margin = new System.Windows.Forms.Padding(5);
            this.bunifuThinButton21.Name = "bunifuThinButton21";
            this.bunifuThinButton21.Size = new System.Drawing.Size(107, 41);
            this.bunifuThinButton21.TabIndex = 11;
            this.bunifuThinButton21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuThinButton21.Click += new System.EventHandler(this.bunifuThinButton21_Click);
            // 
            // bunifuThinButton22
            // 
            this.bunifuThinButton22.ActiveBorderThickness = 1;
            this.bunifuThinButton22.ActiveCornerRadius = 20;
            this.bunifuThinButton22.ActiveFillColor = System.Drawing.Color.Red;
            this.bunifuThinButton22.ActiveForecolor = System.Drawing.Color.Transparent;
            this.bunifuThinButton22.ActiveLineColor = System.Drawing.Color.Red;
            this.bunifuThinButton22.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuThinButton22.BackColor = System.Drawing.SystemColors.ControlLight;
            this.bunifuThinButton22.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuThinButton22.BackgroundImage")));
            this.bunifuThinButton22.ButtonText = "Supprimer";
            this.bunifuThinButton22.Cursor = System.Windows.Forms.Cursors.Hand;
            this.transition.SetDecoration(this.bunifuThinButton22, BunifuAnimatorNS.DecorationType.None);
            this.bunifuThinButton22.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuThinButton22.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.bunifuThinButton22.IdleBorderThickness = 1;
            this.bunifuThinButton22.IdleCornerRadius = 20;
            this.bunifuThinButton22.IdleFillColor = System.Drawing.Color.Tomato;
            this.bunifuThinButton22.IdleForecolor = System.Drawing.Color.White;
            this.bunifuThinButton22.IdleLineColor = System.Drawing.Color.Tomato;
            this.bunifuThinButton22.ImeMode = System.Windows.Forms.ImeMode.AlphaFull;
            this.bunifuThinButton22.Location = new System.Drawing.Point(582, 78);
            this.bunifuThinButton22.Margin = new System.Windows.Forms.Padding(5);
            this.bunifuThinButton22.Name = "bunifuThinButton22";
            this.bunifuThinButton22.Size = new System.Drawing.Size(102, 41);
            this.bunifuThinButton22.TabIndex = 10;
            this.bunifuThinButton22.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuThinButton22.Click += new System.EventHandler(this.bunifuThinButton22_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.Transparent;
            this.transition.SetDecoration(this.btnSearch, BunifuAnimatorNS.DecorationType.None);
            this.btnSearch.Image = global::GestionCourriers.Properties.Resources.search;
            this.btnSearch.ImageActive = null;
            this.btnSearch.Location = new System.Drawing.Point(307, 192);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(57, 37);
            this.btnSearch.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnSearch.TabIndex = 24;
            this.btnSearch.TabStop = false;
            this.btnSearch.Zoom = 10;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click_1);
            // 
            // ajoutCourrier
            // 
            this.ajoutCourrier.ActiveBorderThickness = 1;
            this.ajoutCourrier.ActiveCornerRadius = 20;
            this.ajoutCourrier.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(22)))), ((int)(((byte)(224)))));
            this.ajoutCourrier.ActiveForecolor = System.Drawing.Color.Transparent;
            this.ajoutCourrier.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(22)))), ((int)(((byte)(224)))));
            this.ajoutCourrier.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ajoutCourrier.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ajoutCourrier.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ajoutCourrier.BackgroundImage")));
            this.ajoutCourrier.ButtonText = "Ajouter";
            this.ajoutCourrier.Cursor = System.Windows.Forms.Cursors.Hand;
            this.transition.SetDecoration(this.ajoutCourrier, BunifuAnimatorNS.DecorationType.None);
            this.ajoutCourrier.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ajoutCourrier.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.ajoutCourrier.IdleBorderThickness = 1;
            this.ajoutCourrier.IdleCornerRadius = 20;
            this.ajoutCourrier.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(97)))), ((int)(((byte)(226)))));
            this.ajoutCourrier.IdleForecolor = System.Drawing.Color.White;
            this.ajoutCourrier.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(97)))), ((int)(((byte)(226)))));
            this.ajoutCourrier.ImeMode = System.Windows.Forms.ImeMode.AlphaFull;
            this.ajoutCourrier.Location = new System.Drawing.Point(452, 192);
            this.ajoutCourrier.Margin = new System.Windows.Forms.Padding(5);
            this.ajoutCourrier.Name = "ajoutCourrier";
            this.ajoutCourrier.Size = new System.Drawing.Size(135, 41);
            this.ajoutCourrier.TabIndex = 22;
            this.ajoutCourrier.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ajoutCourrier.Click += new System.EventHandler(this.ajoutCourrier_Click);
            // 
            // searchCourrier
            // 
            this.searchCourrier.BackColor = System.Drawing.SystemColors.ControlLight;
            this.searchCourrier.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("searchCourrier.BackgroundImage")));
            this.searchCourrier.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.transition.SetDecoration(this.searchCourrier, BunifuAnimatorNS.DecorationType.None);
            this.searchCourrier.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(22)))), ((int)(((byte)(224)))));
            this.searchCourrier.Icon = ((System.Drawing.Image)(resources.GetObject("searchCourrier.Icon")));
            this.searchCourrier.Location = new System.Drawing.Point(89, 192);
            this.searchCourrier.Name = "searchCourrier";
            this.searchCourrier.Size = new System.Drawing.Size(200, 37);
            this.searchCourrier.TabIndex = 19;
            this.searchCourrier.text = "Saisir une reference";
            this.searchCourrier.Enter += new System.EventHandler(this.searchCourrier_Enter);
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
            this.transition.SetDecoration(this.actualCourrier, BunifuAnimatorNS.DecorationType.None);
            this.actualCourrier.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.actualCourrier.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.actualCourrier.IdleBorderThickness = 1;
            this.actualCourrier.IdleCornerRadius = 20;
            this.actualCourrier.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.actualCourrier.IdleForecolor = System.Drawing.Color.White;
            this.actualCourrier.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.actualCourrier.ImeMode = System.Windows.Forms.ImeMode.AlphaFull;
            this.actualCourrier.Location = new System.Drawing.Point(597, 192);
            this.actualCourrier.Margin = new System.Windows.Forms.Padding(5);
            this.actualCourrier.Name = "actualCourrier";
            this.actualCourrier.Size = new System.Drawing.Size(135, 41);
            this.actualCourrier.TabIndex = 15;
            this.actualCourrier.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.actualCourrier.Click += new System.EventHandler(this.actualCourrier_Click);
            // 
            // dataGridViewImageColumn2
            // 
            this.dataGridViewImageColumn2.HeaderText = "Image";
            this.dataGridViewImageColumn2.Image = global::GestionCourriers.Properties.Resources._029_book;
            this.dataGridViewImageColumn2.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.dataGridViewImageColumn2.Name = "dataGridViewImageColumn2";
            // 
            // CourrierUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.ajoutCourrier);
            this.Controls.Add(this.searchCourrier);
            this.Controls.Add(this.actualCourrier);
            this.Controls.Add(this.dgCourrier);
            this.Controls.Add(this.panelExp);
            this.Controls.Add(this.panelAjoutCour);
            this.Controls.Add(this.modifCourrier);
            this.transition.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "CourrierUser";
            this.Size = new System.Drawing.Size(821, 397);
            ((System.ComponentModel.ISupportInitialize)(this.dgCourrier)).EndInit();
            this.panelAjoutCour.ResumeLayout(false);
            this.panelAjoutCour.PerformLayout();
            this.panelExp.ResumeLayout(false);
            this.modifCourrier.ResumeLayout(false);
            this.modifCourrier.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnSearch)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private ns1.BunifuThinButton2 actualCourrier;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        public ns1.BunifuCustomDataGrid dgCourrier;
        public ns1.BunifuTextbox searchCourrier;
        private System.Windows.Forms.Panel panelAjoutCour;
        public ns1.BunifuTextbox refCourrier;
        public ns1.BunifuTextbox contCourrier;
        public ns1.BunifuTextbox libCourrier;
        private ns1.BunifuThinButton2 btnSuivant;
        private ns1.BunifuThinButton2 ajoutCourrier;
        private System.Windows.Forms.Panel panelExp;
        public ns1.BunifuTextbox prenomExp;
        public ns1.BunifuTextbox telExp;
        private BunifuAnimatorNS.BunifuTransition transition;
        private ns1.BunifuFlatButton SaveCour;
        private ns1.BunifuImageButton btnSearch;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn2;
        private System.Windows.Forms.Panel modifCourrier;
        private ns1.BunifuThinButton2 bunifuThinButton21;
        private ns1.BunifuThinButton2 bunifuThinButton22;
        private ns1.BunifuMaterialTextbox Lib;
        public System.Windows.Forms.Label txt;
        private ns1.BunifuMaterialTextbox Cont;
        public System.Windows.Forms.Label label1;
        private ns1.BunifuMaterialTextbox Exp;
        public System.Windows.Forms.Label NomUser;
        public ns1.BunifuTextbox nomE;
        private System.Windows.Forms.DataGridViewImageColumn imgCourrier;
        private System.Windows.Forms.DataGridViewTextBoxColumn referenceCourrier;
        private System.Windows.Forms.DataGridViewTextBoxColumn libelleCourrier;
        private System.Windows.Forms.DataGridViewTextBoxColumn contenuCourrier;
        private System.Windows.Forms.DataGridViewTextBoxColumn typeCourrier;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomExpediteur;
        private ns1.BunifuDropdown txtType;
        public System.Windows.Forms.Label label2;
        private ns1.BunifuDropdown typeCour;
        public System.Windows.Forms.Label label3;
    }
}
