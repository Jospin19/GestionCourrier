namespace GestionCourrier
{
    partial class FormConnexion
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
            this.components = new System.ComponentModel.Container();
            BunifuAnimatorNS.Animation animation1 = new BunifuAnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormConnexion));
            BunifuAnimatorNS.Animation animation2 = new BunifuAnimatorNS.Animation();
            this.Erreur = new System.Windows.Forms.Panel();
            this.txt = new ns1.BunifuCustomLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Deplacement = new ns1.BunifuDragControl(this.components);
            this.transition = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.connexionHeader = new ns1.BunifuGradientPanel();
            this.PanelInformation = new System.Windows.Forms.Panel();
            this.Connecter = new ns1.BunifuThinButton2();
            this.Annuler = new ns1.BunifuThinButton2();
            this.Password = new ns1.BunifuMaterialTextbox();
            this.Login = new ns1.BunifuMaterialTextbox();
            this.ImgConnexion = new System.Windows.Forms.PictureBox();
            this.transitionErreur = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.Erreur.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.PanelInformation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ImgConnexion)).BeginInit();
            this.SuspendLayout();
            // 
            // Erreur
            // 
            this.Erreur.BackColor = System.Drawing.Color.Gainsboro;
            this.Erreur.Controls.Add(this.txt);
            this.Erreur.Controls.Add(this.pictureBox1);
            this.transitionErreur.SetDecoration(this.Erreur, BunifuAnimatorNS.DecorationType.None);
            this.transition.SetDecoration(this.Erreur, BunifuAnimatorNS.DecorationType.None);
            this.Erreur.Location = new System.Drawing.Point(111, 453);
            this.Erreur.Name = "Erreur";
            this.Erreur.Size = new System.Drawing.Size(401, 48);
            this.Erreur.TabIndex = 9;
            this.Erreur.Visible = false;
            // 
            // txt
            // 
            this.txt.AutoSize = true;
            this.txt.BackColor = System.Drawing.Color.Gainsboro;
            this.transition.SetDecoration(this.txt, BunifuAnimatorNS.DecorationType.None);
            this.transitionErreur.SetDecoration(this.txt, BunifuAnimatorNS.DecorationType.None);
            this.txt.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt.ForeColor = System.Drawing.Color.Tomato;
            this.txt.Location = new System.Drawing.Point(67, 16);
            this.txt.Name = "txt";
            this.txt.Size = new System.Drawing.Size(304, 18);
            this.txt.TabIndex = 4;
            this.txt.Text = "Cet utiliateur n\'existe pas. Veuillez reessayer!!";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Gainsboro;
            this.transition.SetDecoration(this.pictureBox1, BunifuAnimatorNS.DecorationType.None);
            this.transitionErreur.SetDecoration(this.pictureBox1, BunifuAnimatorNS.DecorationType.None);
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(49, 41);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // Deplacement
            // 
            this.Deplacement.Fixed = true;
            this.Deplacement.Horizontal = true;
            this.Deplacement.TargetControl = null;
            this.Deplacement.Vertical = true;
            // 
            // transition
            // 
            this.transition.AnimationType = BunifuAnimatorNS.AnimationType.Transparent;
            this.transition.Cursor = null;
            animation1.AnimateOnlyDifferences = true;
            animation1.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.BlindCoeff")));
            animation1.LeafCoeff = 0F;
            animation1.MaxTime = 1F;
            animation1.MinTime = 0F;
            animation1.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicCoeff")));
            animation1.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicShift")));
            animation1.MosaicSize = 0;
            animation1.Padding = new System.Windows.Forms.Padding(0, 0, 0, 0);
            animation1.RotateCoeff = 0F;
            animation1.RotateLimit = 0F;
            animation1.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.ScaleCoeff")));
            animation1.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.SlideCoeff")));
            animation1.TimeCoeff = 0F;
            animation1.TransparencyCoeff = 1F;
            this.transition.DefaultAnimation = animation1;
            this.transition.TimeStep = 0.04F;
            // 
            // connexionHeader
            // 
            this.connexionHeader.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("connexionHeader.BackgroundImage")));
            this.connexionHeader.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.transitionErreur.SetDecoration(this.connexionHeader, BunifuAnimatorNS.DecorationType.None);
            this.transition.SetDecoration(this.connexionHeader, BunifuAnimatorNS.DecorationType.None);
            this.connexionHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.connexionHeader.GradientBottomLeft = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(97)))), ((int)(((byte)(226)))));
            this.connexionHeader.GradientBottomRight = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(97)))), ((int)(((byte)(226)))));
            this.connexionHeader.GradientTopLeft = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(220)))), ((int)(((byte)(224)))));
            this.connexionHeader.GradientTopRight = System.Drawing.Color.White;
            this.connexionHeader.Location = new System.Drawing.Point(0, 0);
            this.connexionHeader.Name = "connexionHeader";
            this.connexionHeader.Quality = 10;
            this.connexionHeader.Size = new System.Drawing.Size(628, 196);
            this.connexionHeader.TabIndex = 10;
            // 
            // PanelInformation
            // 
            this.PanelInformation.BackColor = System.Drawing.Color.WhiteSmoke;
            this.PanelInformation.Controls.Add(this.Connecter);
            this.PanelInformation.Controls.Add(this.Annuler);
            this.PanelInformation.Controls.Add(this.Password);
            this.PanelInformation.Controls.Add(this.Login);
            this.PanelInformation.Controls.Add(this.ImgConnexion);
            this.transitionErreur.SetDecoration(this.PanelInformation, BunifuAnimatorNS.DecorationType.None);
            this.transition.SetDecoration(this.PanelInformation, BunifuAnimatorNS.DecorationType.None);
            this.PanelInformation.Location = new System.Drawing.Point(114, 67);
            this.PanelInformation.Name = "PanelInformation";
            this.PanelInformation.Size = new System.Drawing.Size(401, 375);
            this.PanelInformation.TabIndex = 11;
            // 
            // Connecter
            // 
            this.Connecter.ActiveBorderThickness = 1;
            this.Connecter.ActiveCornerRadius = 20;
            this.Connecter.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(22)))), ((int)(((byte)(224)))));
            this.Connecter.ActiveForecolor = System.Drawing.Color.Transparent;
            this.Connecter.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(22)))), ((int)(((byte)(224)))));
            this.Connecter.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Connecter.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Connecter.BackgroundImage")));
            this.Connecter.ButtonText = "Connexion";
            this.Connecter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.transitionErreur.SetDecoration(this.Connecter, BunifuAnimatorNS.DecorationType.None);
            this.transition.SetDecoration(this.Connecter, BunifuAnimatorNS.DecorationType.None);
            this.Connecter.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Connecter.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.Connecter.IdleBorderThickness = 1;
            this.Connecter.IdleCornerRadius = 20;
            this.Connecter.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(97)))), ((int)(((byte)(226)))));
            this.Connecter.IdleForecolor = System.Drawing.Color.White;
            this.Connecter.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(97)))), ((int)(((byte)(226)))));
            this.Connecter.ImeMode = System.Windows.Forms.ImeMode.AlphaFull;
            this.Connecter.Location = new System.Drawing.Point(200, 305);
            this.Connecter.Margin = new System.Windows.Forms.Padding(5);
            this.Connecter.Name = "Connecter";
            this.Connecter.Size = new System.Drawing.Size(117, 41);
            this.Connecter.TabIndex = 8;
            this.Connecter.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Connecter.Click += new System.EventHandler(this.Connecter_Click);
            // 
            // Annuler
            // 
            this.Annuler.ActiveBorderThickness = 1;
            this.Annuler.ActiveCornerRadius = 20;
            this.Annuler.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.Annuler.ActiveForecolor = System.Drawing.Color.Transparent;
            this.Annuler.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.Annuler.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Annuler.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Annuler.BackgroundImage")));
            this.Annuler.ButtonText = "Annuler";
            this.Annuler.Cursor = System.Windows.Forms.Cursors.Hand;
            this.transitionErreur.SetDecoration(this.Annuler, BunifuAnimatorNS.DecorationType.None);
            this.transition.SetDecoration(this.Annuler, BunifuAnimatorNS.DecorationType.None);
            this.Annuler.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Annuler.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.Annuler.IdleBorderThickness = 1;
            this.Annuler.IdleCornerRadius = 20;
            this.Annuler.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(109)))), ((int)(((byte)(74)))));
            this.Annuler.IdleForecolor = System.Drawing.Color.White;
            this.Annuler.IdleLineColor = System.Drawing.Color.Tomato;
            this.Annuler.ImeMode = System.Windows.Forms.ImeMode.AlphaFull;
            this.Annuler.Location = new System.Drawing.Point(58, 305);
            this.Annuler.Margin = new System.Windows.Forms.Padding(5);
            this.Annuler.Name = "Annuler";
            this.Annuler.Size = new System.Drawing.Size(117, 41);
            this.Annuler.TabIndex = 7;
            this.Annuler.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Annuler.Click += new System.EventHandler(this.Annuler_Click);
            // 
            // Password
            // 
            this.Password.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.transitionErreur.SetDecoration(this.Password, BunifuAnimatorNS.DecorationType.None);
            this.transition.SetDecoration(this.Password, BunifuAnimatorNS.DecorationType.None);
            this.Password.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.Password.ForeColor = System.Drawing.Color.DarkGray;
            this.Password.HintForeColor = System.Drawing.Color.Empty;
            this.Password.HintText = "";
            this.Password.isPassword = false;
            this.Password.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(22)))), ((int)(((byte)(224)))));
            this.Password.LineIdleColor = System.Drawing.Color.Gray;
            this.Password.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(22)))), ((int)(((byte)(224)))));
            this.Password.LineThickness = 3;
            this.Password.Location = new System.Drawing.Point(26, 223);
            this.Password.Margin = new System.Windows.Forms.Padding(4);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(348, 44);
            this.Password.TabIndex = 5;
            this.Password.Text = "Saisir le mot de passe";
            this.Password.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // Login
            // 
            this.Login.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.transitionErreur.SetDecoration(this.Login, BunifuAnimatorNS.DecorationType.None);
            this.transition.SetDecoration(this.Login, BunifuAnimatorNS.DecorationType.None);
            this.Login.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.Login.ForeColor = System.Drawing.Color.DarkGray;
            this.Login.HintForeColor = System.Drawing.Color.Empty;
            this.Login.HintText = "";
            this.Login.isPassword = false;
            this.Login.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(22)))), ((int)(((byte)(224)))));
            this.Login.LineIdleColor = System.Drawing.Color.Gray;
            this.Login.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(22)))), ((int)(((byte)(224)))));
            this.Login.LineThickness = 3;
            this.Login.Location = new System.Drawing.Point(26, 142);
            this.Login.Margin = new System.Windows.Forms.Padding(4);
            this.Login.Name = "Login";
            this.Login.Size = new System.Drawing.Size(348, 44);
            this.Login.TabIndex = 4;
            this.Login.Text = "Saisir le Login";
            this.Login.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // ImgConnexion
            // 
            this.ImgConnexion.BackColor = System.Drawing.Color.WhiteSmoke;
            this.transition.SetDecoration(this.ImgConnexion, BunifuAnimatorNS.DecorationType.None);
            this.transitionErreur.SetDecoration(this.ImgConnexion, BunifuAnimatorNS.DecorationType.None);
            this.ImgConnexion.Image = global::GestionCourrier.Properties.Resources._094_teacher;
            this.ImgConnexion.Location = new System.Drawing.Point(161, 12);
            this.ImgConnexion.Name = "ImgConnexion";
            this.ImgConnexion.Size = new System.Drawing.Size(65, 63);
            this.ImgConnexion.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ImgConnexion.TabIndex = 1;
            this.ImgConnexion.TabStop = false;
            // 
            // transitionErreur
            // 
            this.transitionErreur.AnimationType = BunifuAnimatorNS.AnimationType.VertSlide;
            this.transitionErreur.Cursor = null;
            animation2.AnimateOnlyDifferences = true;
            animation2.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.BlindCoeff")));
            animation2.LeafCoeff = 0F;
            animation2.MaxTime = 1F;
            animation2.MinTime = 0F;
            animation2.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.MosaicCoeff")));
            animation2.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation2.MosaicShift")));
            animation2.MosaicSize = 0;
            animation2.Padding = new System.Windows.Forms.Padding(0, 0, 0, 0);
            animation2.RotateCoeff = 0F;
            animation2.RotateLimit = 0F;
            animation2.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.ScaleCoeff")));
            animation2.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.SlideCoeff")));
            animation2.TimeCoeff = 0F;
            animation2.TransparencyCoeff = 0F;
            this.transitionErreur.DefaultAnimation = animation2;
            this.transitionErreur.TimeStep = 0.04F;
            // 
            // FormConnexion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(628, 509);
            this.Controls.Add(this.PanelInformation);
            this.Controls.Add(this.connexionHeader);
            this.Controls.Add(this.Erreur);
            this.transition.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.transitionErreur.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(111, 72);
            this.Name = "FormConnexion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormConnexion";
            this.Erreur.ResumeLayout(false);
            this.Erreur.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.PanelInformation.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ImgConnexion)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel Erreur;
        private ns1.BunifuCustomLabel txt;
        private System.Windows.Forms.PictureBox pictureBox1;
        private BunifuAnimatorNS.BunifuTransition transitionErreur;
        private BunifuAnimatorNS.BunifuTransition transition;
        private ns1.BunifuDragControl Deplacement;
        private ns1.BunifuGradientPanel connexionHeader;
        private System.Windows.Forms.Panel PanelInformation;
        private ns1.BunifuThinButton2 Connecter;
        private ns1.BunifuThinButton2 Annuler;
        private ns1.BunifuMaterialTextbox Password;
        private ns1.BunifuMaterialTextbox Login;
        private System.Windows.Forms.PictureBox ImgConnexion;
    }
}

