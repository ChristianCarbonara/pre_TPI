namespace X_P_DemoMot_carbonarch_Cryptage
{
    partial class fntCryptage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fntCryptage));
            this.btnCrypt = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblAdresseImg = new System.Windows.Forms.Label();
            this.txtBoxUser = new System.Windows.Forms.TextBox();
            this.lblTextCrypt = new System.Windows.Forms.Label();
            this.btnSaveImg = new System.Windows.Forms.Button();
            this.lblSaveImg = new System.Windows.Forms.Label();
            this.tolStpBarOutils = new System.Windows.Forms.ToolStrip();
            this.tolStpDrpDwnBtnOpt = new System.Windows.Forms.ToolStripDropDownButton();
            this.tolStpMnuItmOptEmplImgACrypt = new System.Windows.Forms.ToolStripMenuItem();
            this.tolStpMnuItmOptEmplImgEnr = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tolStpMnuItmOptRelancer = new System.Windows.Forms.ToolStripMenuItem();
            this.tolStpMnuItmOptQuitter = new System.Windows.Forms.ToolStripMenuItem();
            this.tolStpDrpDwnBtnAff = new System.Windows.Forms.ToolStripDropDownButton();
            this.tolStpMnuItmAffAdresse = new System.Windows.Forms.ToolStripMenuItem();
            this.tolStpMnuItmAffAdresseO = new System.Windows.Forms.ToolStripMenuItem();
            this.tolStpMnuItmAffAdresseN = new System.Windows.Forms.ToolStripMenuItem();
            this.tolStpMnuItmLimCarac = new System.Windows.Forms.ToolStripMenuItem();
            this.tolStpMnuItmLimCaracO = new System.Windows.Forms.ToolStripMenuItem();
            this.tolStpMnuItmLimCaracN = new System.Windows.Forms.ToolStripMenuItem();
            this.tolStpDrpDwnBtnAide = new System.Windows.Forms.ToolStripDropDownButton();
            this.tolStpMnuItmAideCrypt = new System.Windows.Forms.ToolStripMenuItem();
            this.tolStpMnuItmAideAdresseImg = new System.Windows.Forms.ToolStripMenuItem();
            this.pgsBarCrypt = new System.Windows.Forms.ProgressBar();
            this.btnChoixImg = new System.Windows.Forms.Button();
            this.lblLimCarac = new System.Windows.Forms.Label();
            this.tolStpBarOutils.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCrypt
            // 
            this.btnCrypt.AutoSize = true;
            this.btnCrypt.Enabled = false;
            this.btnCrypt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCrypt.Location = new System.Drawing.Point(170, 228);
            this.btnCrypt.Name = "btnCrypt";
            this.btnCrypt.Size = new System.Drawing.Size(171, 25);
            this.btnCrypt.TabIndex = 0;
            this.btnCrypt.Text = "Insérer le texte dans l\'image";
            this.btnCrypt.UseVisualStyleBackColor = true;
            this.btnCrypt.Click += new System.EventHandler(this.btnCrypter_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoEllipsis = true;
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.Font = new System.Drawing.Font("Lucida Calligraphy", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lblTitle.Location = new System.Drawing.Point(24, 28);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(303, 20);
            this.lblTitle.TabIndex = 2;
            this.lblTitle.Text = "Programme de cryptage d\'images";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblAdresseImg
            // 
            this.lblAdresseImg.BackColor = System.Drawing.Color.Transparent;
            this.lblAdresseImg.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdresseImg.Location = new System.Drawing.Point(12, 96);
            this.lblAdresseImg.Name = "lblAdresseImg";
            this.lblAdresseImg.Size = new System.Drawing.Size(329, 32);
            this.lblAdresseImg.TabIndex = 4;
            this.lblAdresseImg.Text = "Aucune image n\'a été séléctionnée.";
            // 
            // txtBoxUser
            // 
            this.txtBoxUser.BackColor = System.Drawing.SystemColors.Window;
            this.txtBoxUser.Enabled = false;
            this.txtBoxUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxUser.Location = new System.Drawing.Point(7, 171);
            this.txtBoxUser.Multiline = true;
            this.txtBoxUser.Name = "txtBoxUser";
            this.txtBoxUser.Size = new System.Drawing.Size(334, 51);
            this.txtBoxUser.TabIndex = 1;
            this.txtBoxUser.TextChanged += new System.EventHandler(this.txtBoxUser_TextChanged);
            // 
            // lblTextCrypt
            // 
            this.lblTextCrypt.AutoSize = true;
            this.lblTextCrypt.BackColor = System.Drawing.Color.Transparent;
            this.lblTextCrypt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTextCrypt.Location = new System.Drawing.Point(12, 153);
            this.lblTextCrypt.Name = "lblTextCrypt";
            this.lblTextCrypt.Size = new System.Drawing.Size(92, 15);
            this.lblTextCrypt.TabIndex = 10;
            this.lblTextCrypt.Text = "Texte à crypter :";
            // 
            // btnSaveImg
            // 
            this.btnSaveImg.AutoSize = true;
            this.btnSaveImg.Enabled = false;
            this.btnSaveImg.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveImg.Location = new System.Drawing.Point(7, 270);
            this.btnSaveImg.Name = "btnSaveImg";
            this.btnSaveImg.Size = new System.Drawing.Size(115, 25);
            this.btnSaveImg.TabIndex = 11;
            this.btnSaveImg.Text = "Enregistrer sous...";
            this.btnSaveImg.UseVisualStyleBackColor = true;
            this.btnSaveImg.Click += new System.EventHandler(this.btnSaveImage_Click);
            // 
            // lblSaveImg
            // 
            this.lblSaveImg.BackColor = System.Drawing.Color.Transparent;
            this.lblSaveImg.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSaveImg.Location = new System.Drawing.Point(12, 298);
            this.lblSaveImg.Name = "lblSaveImg";
            this.lblSaveImg.Size = new System.Drawing.Size(329, 35);
            this.lblSaveImg.TabIndex = 12;
            this.lblSaveImg.Text = "Aucun emplacement pour enregistrer l\'image n\'a été séléctionné.";
            // 
            // tolStpBarOutils
            // 
            this.tolStpBarOutils.BackColor = System.Drawing.SystemColors.Control;
            this.tolStpBarOutils.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.tolStpBarOutils.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tolStpDrpDwnBtnOpt,
            this.tolStpDrpDwnBtnAff,
            this.tolStpDrpDwnBtnAide});
            this.tolStpBarOutils.Location = new System.Drawing.Point(0, 0);
            this.tolStpBarOutils.Name = "tolStpBarOutils";
            this.tolStpBarOutils.Size = new System.Drawing.Size(354, 25);
            this.tolStpBarOutils.TabIndex = 15;
            // 
            // tolStpDrpDwnBtnOpt
            // 
            this.tolStpDrpDwnBtnOpt.AutoToolTip = false;
            this.tolStpDrpDwnBtnOpt.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tolStpDrpDwnBtnOpt.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tolStpMnuItmOptEmplImgACrypt,
            this.tolStpMnuItmOptEmplImgEnr,
            this.toolStripSeparator1,
            this.tolStpMnuItmOptRelancer,
            this.tolStpMnuItmOptQuitter});
            this.tolStpDrpDwnBtnOpt.Image = ((System.Drawing.Image)(resources.GetObject("tolStpDrpDwnBtnOpt.Image")));
            this.tolStpDrpDwnBtnOpt.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tolStpDrpDwnBtnOpt.Name = "tolStpDrpDwnBtnOpt";
            this.tolStpDrpDwnBtnOpt.Size = new System.Drawing.Size(57, 22);
            this.tolStpDrpDwnBtnOpt.Text = "Option";
            // 
            // tolStpMnuItmOptEmplImgACrypt
            // 
            this.tolStpMnuItmOptEmplImgACrypt.Name = "tolStpMnuItmOptEmplImgACrypt";
            this.tolStpMnuItmOptEmplImgACrypt.Size = new System.Drawing.Size(266, 22);
            this.tolStpMnuItmOptEmplImgACrypt.Text = "Emplacement de l\'image à crypter";
            this.tolStpMnuItmOptEmplImgACrypt.Click += new System.EventHandler(this.tolStpMnuItmOptEmplImgACrypt_Click);
            // 
            // tolStpMnuItmOptEmplImgEnr
            // 
            this.tolStpMnuItmOptEmplImgEnr.Name = "tolStpMnuItmOptEmplImgEnr";
            this.tolStpMnuItmOptEmplImgEnr.Size = new System.Drawing.Size(266, 22);
            this.tolStpMnuItmOptEmplImgEnr.Text = "Emplacement de l\'image enregistrée";
            this.tolStpMnuItmOptEmplImgEnr.Click += new System.EventHandler(this.tolStpMnuItmOptEmplImg_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(263, 6);
            // 
            // tolStpMnuItmOptRelancer
            // 
            this.tolStpMnuItmOptRelancer.Name = "tolStpMnuItmOptRelancer";
            this.tolStpMnuItmOptRelancer.Size = new System.Drawing.Size(266, 22);
            this.tolStpMnuItmOptRelancer.Text = "Relancer";
            this.tolStpMnuItmOptRelancer.Click += new System.EventHandler(this.tolStpMnuItmOptRelancer_Click);
            // 
            // tolStpMnuItmOptQuitter
            // 
            this.tolStpMnuItmOptQuitter.Name = "tolStpMnuItmOptQuitter";
            this.tolStpMnuItmOptQuitter.Size = new System.Drawing.Size(266, 22);
            this.tolStpMnuItmOptQuitter.Text = "Quitter";
            this.tolStpMnuItmOptQuitter.Click += new System.EventHandler(this.tolStpMnuItmOptQuitter_Click);
            // 
            // tolStpDrpDwnBtnAff
            // 
            this.tolStpDrpDwnBtnAff.AutoToolTip = false;
            this.tolStpDrpDwnBtnAff.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tolStpDrpDwnBtnAff.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tolStpMnuItmAffAdresse,
            this.tolStpMnuItmLimCarac});
            this.tolStpDrpDwnBtnAff.Image = ((System.Drawing.Image)(resources.GetObject("tolStpDrpDwnBtnAff.Image")));
            this.tolStpDrpDwnBtnAff.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tolStpDrpDwnBtnAff.Name = "tolStpDrpDwnBtnAff";
            this.tolStpDrpDwnBtnAff.Size = new System.Drawing.Size(71, 22);
            this.tolStpDrpDwnBtnAff.Text = "Affichage";
            // 
            // tolStpMnuItmAffAdresse
            // 
            this.tolStpMnuItmAffAdresse.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tolStpMnuItmAffAdresseO,
            this.tolStpMnuItmAffAdresseN});
            this.tolStpMnuItmAffAdresse.Name = "tolStpMnuItmAffAdresse";
            this.tolStpMnuItmAffAdresse.Size = new System.Drawing.Size(213, 22);
            this.tolStpMnuItmAffAdresse.Text = "Adresse de l\'image choisie";
            // 
            // tolStpMnuItmAffAdresseO
            // 
            this.tolStpMnuItmAffAdresseO.Name = "tolStpMnuItmAffAdresseO";
            this.tolStpMnuItmAffAdresseO.Size = new System.Drawing.Size(97, 22);
            this.tolStpMnuItmAffAdresseO.Text = "Oui";
            this.tolStpMnuItmAffAdresseO.Click += new System.EventHandler(this.tolStpMnuItmAffAdresseO_Click);
            // 
            // tolStpMnuItmAffAdresseN
            // 
            this.tolStpMnuItmAffAdresseN.Name = "tolStpMnuItmAffAdresseN";
            this.tolStpMnuItmAffAdresseN.Size = new System.Drawing.Size(97, 22);
            this.tolStpMnuItmAffAdresseN.Text = "Non";
            this.tolStpMnuItmAffAdresseN.Click += new System.EventHandler(this.tolStpMnuItmAffAdresseN_Click);
            // 
            // tolStpMnuItmLimCarac
            // 
            this.tolStpMnuItmLimCarac.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tolStpMnuItmLimCaracO,
            this.tolStpMnuItmLimCaracN});
            this.tolStpMnuItmLimCarac.Name = "tolStpMnuItmLimCarac";
            this.tolStpMnuItmLimCarac.Size = new System.Drawing.Size(213, 22);
            this.tolStpMnuItmLimCarac.Text = "Limite de caractères";
            // 
            // tolStpMnuItmLimCaracO
            // 
            this.tolStpMnuItmLimCaracO.Name = "tolStpMnuItmLimCaracO";
            this.tolStpMnuItmLimCaracO.Size = new System.Drawing.Size(97, 22);
            this.tolStpMnuItmLimCaracO.Text = "Oui";
            this.tolStpMnuItmLimCaracO.Click += new System.EventHandler(this.tolStpMnuItmLimCaracO_Click);
            // 
            // tolStpMnuItmLimCaracN
            // 
            this.tolStpMnuItmLimCaracN.Name = "tolStpMnuItmLimCaracN";
            this.tolStpMnuItmLimCaracN.Size = new System.Drawing.Size(97, 22);
            this.tolStpMnuItmLimCaracN.Text = "Non";
            this.tolStpMnuItmLimCaracN.Click += new System.EventHandler(this.tolStpMnuItmLimCaracN_Click);
            // 
            // tolStpDrpDwnBtnAide
            // 
            this.tolStpDrpDwnBtnAide.AutoToolTip = false;
            this.tolStpDrpDwnBtnAide.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tolStpDrpDwnBtnAide.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tolStpMnuItmAideCrypt,
            this.tolStpMnuItmAideAdresseImg});
            this.tolStpDrpDwnBtnAide.Image = ((System.Drawing.Image)(resources.GetObject("tolStpDrpDwnBtnAide.Image")));
            this.tolStpDrpDwnBtnAide.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tolStpDrpDwnBtnAide.Name = "tolStpDrpDwnBtnAide";
            this.tolStpDrpDwnBtnAide.Size = new System.Drawing.Size(25, 22);
            this.tolStpDrpDwnBtnAide.Text = "?";
            // 
            // tolStpMnuItmAideCrypt
            // 
            this.tolStpMnuItmAideCrypt.Name = "tolStpMnuItmAideCrypt";
            this.tolStpMnuItmAideCrypt.Size = new System.Drawing.Size(326, 22);
            this.tolStpMnuItmAideCrypt.Text = "Comment utiliser le programme";
            this.tolStpMnuItmAideCrypt.Click += new System.EventHandler(this.tolStpMnuItmAideCrypt_Click);
            // 
            // tolStpMnuItmAideAdresseImg
            // 
            this.tolStpMnuItmAideAdresseImg.Name = "tolStpMnuItmAideAdresseImg";
            this.tolStpMnuItmAideAdresseImg.Size = new System.Drawing.Size(326, 22);
            this.tolStpMnuItmAideAdresseImg.Text = "L\'adresse de l\'image n\'est pas totalement visible";
            this.tolStpMnuItmAideAdresseImg.Click += new System.EventHandler(this.tolStpMnuItmAideAdresseImg_Click);
            // 
            // pgsBarCrypt
            // 
            this.pgsBarCrypt.Location = new System.Drawing.Point(9, 228);
            this.pgsBarCrypt.Name = "pgsBarCrypt";
            this.pgsBarCrypt.Size = new System.Drawing.Size(155, 25);
            this.pgsBarCrypt.TabIndex = 16;
            // 
            // btnChoixImg
            // 
            this.btnChoixImg.AutoSize = true;
            this.btnChoixImg.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChoixImg.Location = new System.Drawing.Point(9, 68);
            this.btnChoixImg.Name = "btnChoixImg";
            this.btnChoixImg.Size = new System.Drawing.Size(99, 25);
            this.btnChoixImg.TabIndex = 3;
            this.btnChoixImg.Text = "Choisir l\'image";
            this.btnChoixImg.UseVisualStyleBackColor = true;
            this.btnChoixImg.Click += new System.EventHandler(this.btnChoixImage_Click);
            // 
            // lblLimCarac
            // 
            this.lblLimCarac.AutoSize = true;
            this.lblLimCarac.BackColor = System.Drawing.Color.Transparent;
            this.lblLimCarac.Location = new System.Drawing.Point(128, 155);
            this.lblLimCarac.Name = "lblLimCarac";
            this.lblLimCarac.Size = new System.Drawing.Size(213, 13);
            this.lblLimCarac.TabIndex = 17;
            this.lblLimCarac.Text = "Nombre de caractère restant disponible : 64";
            // 
            // fntCryptage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = global::X_P_DemoMot_carbonarch_Cryptage.Properties.Resources.fondFntCryptage;
            this.ClientSize = new System.Drawing.Size(354, 333);
            this.Controls.Add(this.lblLimCarac);
            this.Controls.Add(this.btnSaveImg);
            this.Controls.Add(this.lblSaveImg);
            this.Controls.Add(this.btnCrypt);
            this.Controls.Add(this.txtBoxUser);
            this.Controls.Add(this.lblAdresseImg);
            this.Controls.Add(this.btnChoixImg);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.pgsBarCrypt);
            this.Controls.Add(this.tolStpBarOutils);
            this.Controls.Add(this.lblTextCrypt);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(370, 371);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(370, 371);
            this.Name = "fntCryptage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cryptage d\'images";
            this.tolStpBarOutils.ResumeLayout(false);
            this.tolStpBarOutils.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCrypt;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblAdresseImg;
        private System.Windows.Forms.TextBox txtBoxUser;
        private System.Windows.Forms.Label lblTextCrypt;
        private System.Windows.Forms.Button btnSaveImg;
        private System.Windows.Forms.Label lblSaveImg;
        private System.Windows.Forms.ToolStripDropDownButton tolStpDrpDwnBtnOpt;
        private System.Windows.Forms.ToolStripDropDownButton tolStpDrpDwnBtnAide;
        private System.Windows.Forms.ToolStripMenuItem tolStpMnuItmAideCrypt;
        private System.Windows.Forms.ProgressBar pgsBarCrypt;
        private System.Windows.Forms.Button btnChoixImg;
        private System.Windows.Forms.ToolStripMenuItem tolStpMnuItmOptQuitter;
        private System.Windows.Forms.ToolStripMenuItem tolStpMnuItmOptRelancer;
        private System.Windows.Forms.ToolStripDropDownButton tolStpDrpDwnBtnAff;
        private System.Windows.Forms.ToolStripMenuItem tolStpMnuItmAffAdresse;
        private System.Windows.Forms.ToolStripMenuItem tolStpMnuItmAffAdresseO;
        private System.Windows.Forms.ToolStripMenuItem tolStpMnuItmAffAdresseN;
        private System.Windows.Forms.ToolStripMenuItem tolStpMnuItmLimCarac;
        private System.Windows.Forms.ToolStripMenuItem tolStpMnuItmLimCaracO;
        private System.Windows.Forms.ToolStripMenuItem tolStpMnuItmLimCaracN;
        private System.Windows.Forms.Label lblLimCarac;
        private System.Windows.Forms.ToolStrip tolStpBarOutils;
        private System.Windows.Forms.ToolStripMenuItem tolStpMnuItmOptEmplImgEnr;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem tolStpMnuItmAideAdresseImg;
        private System.Windows.Forms.ToolStripMenuItem tolStpMnuItmOptEmplImgACrypt;
    }
}

