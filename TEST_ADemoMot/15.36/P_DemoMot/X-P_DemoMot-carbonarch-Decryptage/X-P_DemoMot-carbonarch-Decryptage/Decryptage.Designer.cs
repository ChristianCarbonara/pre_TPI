namespace X_P_DemoMot_carbonarch_Decryptage
{
    partial class fntDecryptage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fntDecryptage));
            this.btnChoixImg = new System.Windows.Forms.Button();
            this.btnDecrypt = new System.Windows.Forms.Button();
            this.lblTextResult = new System.Windows.Forms.Label();
            this.pgsBarDecrypt = new System.Windows.Forms.ProgressBar();
            this.lblAdresseImg = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblTxtDecryptTitre = new System.Windows.Forms.Label();
            this.tolStpOutils = new System.Windows.Forms.ToolStrip();
            this.tolStpDrpDwnBtnOpt = new System.Windows.Forms.ToolStripDropDownButton();
            this.tolStpMnuItmOptEmplImgADecrypt = new System.Windows.Forms.ToolStripMenuItem();
            this.tolStpMnuItmOptTxtDecrypt = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tolStpMnuItmOptRelancer = new System.Windows.Forms.ToolStripMenuItem();
            this.tolStpMnuItmOptQuitter = new System.Windows.Forms.ToolStripMenuItem();
            this.tolStpDrpDwnBtnAff = new System.Windows.Forms.ToolStripDropDownButton();
            this.tolStpMnuItmAffAdresse = new System.Windows.Forms.ToolStripMenuItem();
            this.tolStpMnuItmAffAdresseO = new System.Windows.Forms.ToolStripMenuItem();
            this.tolStpMnuItmAffAdresseN = new System.Windows.Forms.ToolStripMenuItem();
            this.tolStpDrpDwnBtnAide = new System.Windows.Forms.ToolStripDropDownButton();
            this.tolStpMnuItmAideDecrypt = new System.Windows.Forms.ToolStripMenuItem();
            this.tolStpMnuItmAideAdresseImg = new System.Windows.Forms.ToolStripMenuItem();
            this.tolStpMnuItmAideTxtDecrypt = new System.Windows.Forms.ToolStripMenuItem();
            this.tolStpOutils.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnChoixImg
            // 
            this.btnChoixImg.AutoSize = true;
            this.btnChoixImg.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChoixImg.Location = new System.Drawing.Point(7, 63);
            this.btnChoixImg.Name = "btnChoixImg";
            this.btnChoixImg.Size = new System.Drawing.Size(162, 25);
            this.btnChoixImg.TabIndex = 0;
            this.btnChoixImg.Text = "Choisir l\'image à décrypter";
            this.btnChoixImg.UseVisualStyleBackColor = true;
            this.btnChoixImg.Click += new System.EventHandler(this.btnChoixImage_Click);
            // 
            // btnDecrypt
            // 
            this.btnDecrypt.AutoSize = true;
            this.btnDecrypt.Enabled = false;
            this.btnDecrypt.Location = new System.Drawing.Point(7, 136);
            this.btnDecrypt.Name = "btnDecrypt";
            this.btnDecrypt.Size = new System.Drawing.Size(98, 23);
            this.btnDecrypt.TabIndex = 1;
            this.btnDecrypt.Text = "Décrypter l\'image";
            this.btnDecrypt.UseVisualStyleBackColor = true;
            this.btnDecrypt.Click += new System.EventHandler(this.btnDecrypt_Click);
            // 
            // lblTextResult
            // 
            this.lblTextResult.BackColor = System.Drawing.Color.Transparent;
            this.lblTextResult.Location = new System.Drawing.Point(12, 191);
            this.lblTextResult.Name = "lblTextResult";
            this.lblTextResult.Size = new System.Drawing.Size(338, 29);
            this.lblTextResult.TabIndex = 3;
            // 
            // pgsBarDecrypt
            // 
            this.pgsBarDecrypt.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pgsBarDecrypt.Location = new System.Drawing.Point(111, 136);
            this.pgsBarDecrypt.Name = "pgsBarDecrypt";
            this.pgsBarDecrypt.Size = new System.Drawing.Size(231, 23);
            this.pgsBarDecrypt.TabIndex = 5;
            // 
            // lblAdresseImg
            // 
            this.lblAdresseImg.BackColor = System.Drawing.Color.Transparent;
            this.lblAdresseImg.Location = new System.Drawing.Point(12, 91);
            this.lblAdresseImg.Name = "lblAdresseImg";
            this.lblAdresseImg.Size = new System.Drawing.Size(332, 27);
            this.lblAdresseImg.TabIndex = 6;
            this.lblAdresseImg.Text = "Aucune image n\'a été choisie.";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.Font = new System.Drawing.Font("Lucida Calligraphy", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lblTitle.Location = new System.Drawing.Point(20, 29);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(323, 20);
            this.lblTitle.TabIndex = 7;
            this.lblTitle.Text = "Programme de décryptage d\'images";
            // 
            // lblTxtDecryptTitre
            // 
            this.lblTxtDecryptTitre.AutoSize = true;
            this.lblTxtDecryptTitre.BackColor = System.Drawing.Color.Transparent;
            this.lblTxtDecryptTitre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTxtDecryptTitre.Location = new System.Drawing.Point(12, 176);
            this.lblTxtDecryptTitre.Name = "lblTxtDecryptTitre";
            this.lblTxtDecryptTitre.Size = new System.Drawing.Size(85, 15);
            this.lblTxtDecryptTitre.TabIndex = 8;
            this.lblTxtDecryptTitre.Text = "Text décrypté :";
            // 
            // tolStpOutils
            // 
            this.tolStpOutils.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.tolStpOutils.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tolStpDrpDwnBtnOpt,
            this.tolStpDrpDwnBtnAff,
            this.tolStpDrpDwnBtnAide});
            this.tolStpOutils.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.tolStpOutils.Location = new System.Drawing.Point(0, 0);
            this.tolStpOutils.Name = "tolStpOutils";
            this.tolStpOutils.Size = new System.Drawing.Size(365, 25);
            this.tolStpOutils.TabIndex = 10;
            // 
            // tolStpDrpDwnBtnOpt
            // 
            this.tolStpDrpDwnBtnOpt.AutoToolTip = false;
            this.tolStpDrpDwnBtnOpt.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tolStpDrpDwnBtnOpt.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tolStpMnuItmOptEmplImgADecrypt,
            this.tolStpMnuItmOptTxtDecrypt,
            this.toolStripSeparator1,
            this.tolStpMnuItmOptRelancer,
            this.tolStpMnuItmOptQuitter});
            this.tolStpDrpDwnBtnOpt.Image = ((System.Drawing.Image)(resources.GetObject("tolStpDrpDwnBtnOpt.Image")));
            this.tolStpDrpDwnBtnOpt.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tolStpDrpDwnBtnOpt.Name = "tolStpDrpDwnBtnOpt";
            this.tolStpDrpDwnBtnOpt.Size = new System.Drawing.Size(57, 22);
            this.tolStpDrpDwnBtnOpt.Text = "Option";
            // 
            // tolStpMnuItmOptEmplImgADecrypt
            // 
            this.tolStpMnuItmOptEmplImgADecrypt.Name = "tolStpMnuItmOptEmplImgADecrypt";
            this.tolStpMnuItmOptEmplImgADecrypt.Size = new System.Drawing.Size(267, 22);
            this.tolStpMnuItmOptEmplImgADecrypt.Text = "Emplacement de l\'image à décrypter";
            this.tolStpMnuItmOptEmplImgADecrypt.Click += new System.EventHandler(this.tolStpMnuItmOptEmplImgADecrypt_Click);
            // 
            // tolStpMnuItmOptTxtDecrypt
            // 
            this.tolStpMnuItmOptTxtDecrypt.Name = "tolStpMnuItmOptTxtDecrypt";
            this.tolStpMnuItmOptTxtDecrypt.Size = new System.Drawing.Size(267, 22);
            this.tolStpMnuItmOptTxtDecrypt.Text = "Texte décrypté";
            this.tolStpMnuItmOptTxtDecrypt.Click += new System.EventHandler(this.tolStpMnuItmOptTxtDecrypt_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(264, 6);
            // 
            // tolStpMnuItmOptRelancer
            // 
            this.tolStpMnuItmOptRelancer.Name = "tolStpMnuItmOptRelancer";
            this.tolStpMnuItmOptRelancer.Size = new System.Drawing.Size(267, 22);
            this.tolStpMnuItmOptRelancer.Text = "Relancer";
            this.tolStpMnuItmOptRelancer.Click += new System.EventHandler(this.tolStpMnuItmRelancer_Click);
            // 
            // tolStpMnuItmOptQuitter
            // 
            this.tolStpMnuItmOptQuitter.Name = "tolStpMnuItmOptQuitter";
            this.tolStpMnuItmOptQuitter.Size = new System.Drawing.Size(267, 22);
            this.tolStpMnuItmOptQuitter.Text = "Quitter";
            this.tolStpMnuItmOptQuitter.Click += new System.EventHandler(this.tolStpMnuItmQuitter_Click);
            // 
            // tolStpDrpDwnBtnAff
            // 
            this.tolStpDrpDwnBtnAff.AutoToolTip = false;
            this.tolStpDrpDwnBtnAff.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tolStpDrpDwnBtnAff.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tolStpMnuItmAffAdresse});
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
            // tolStpDrpDwnBtnAide
            // 
            this.tolStpDrpDwnBtnAide.AutoToolTip = false;
            this.tolStpDrpDwnBtnAide.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tolStpDrpDwnBtnAide.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tolStpMnuItmAideDecrypt,
            this.tolStpMnuItmAideAdresseImg,
            this.tolStpMnuItmAideTxtDecrypt});
            this.tolStpDrpDwnBtnAide.Image = ((System.Drawing.Image)(resources.GetObject("tolStpDrpDwnBtnAide.Image")));
            this.tolStpDrpDwnBtnAide.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tolStpDrpDwnBtnAide.Name = "tolStpDrpDwnBtnAide";
            this.tolStpDrpDwnBtnAide.Size = new System.Drawing.Size(25, 22);
            this.tolStpDrpDwnBtnAide.Text = "?";
            // 
            // tolStpMnuItmAideDecrypt
            // 
            this.tolStpMnuItmAideDecrypt.Name = "tolStpMnuItmAideDecrypt";
            this.tolStpMnuItmAideDecrypt.Size = new System.Drawing.Size(326, 22);
            this.tolStpMnuItmAideDecrypt.Text = "Comment utiliser le programme";
            this.tolStpMnuItmAideDecrypt.Click += new System.EventHandler(this.tolStpMnuItmAideDecrypt_Click);
            // 
            // tolStpMnuItmAideAdresseImg
            // 
            this.tolStpMnuItmAideAdresseImg.Name = "tolStpMnuItmAideAdresseImg";
            this.tolStpMnuItmAideAdresseImg.Size = new System.Drawing.Size(326, 22);
            this.tolStpMnuItmAideAdresseImg.Text = "L\'adresse de l\'image n\'est pas totalement visible";
            this.tolStpMnuItmAideAdresseImg.Click += new System.EventHandler(this.tolStpMnuItmAideAdresseImg_Click);
            // 
            // tolStpMnuItmAideTxtDecrypt
            // 
            this.tolStpMnuItmAideTxtDecrypt.Name = "tolStpMnuItmAideTxtDecrypt";
            this.tolStpMnuItmAideTxtDecrypt.Size = new System.Drawing.Size(326, 22);
            this.tolStpMnuItmAideTxtDecrypt.Text = "Le texte décrypté n\'est pas totalement visible";
            this.tolStpMnuItmAideTxtDecrypt.Click += new System.EventHandler(this.tolStpMnuItmAideTxtDecrypt_Click);
            // 
            // fntDecryptage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImage = global::X_P_DemoMot_carbonarch_Decryptage.Properties.Resources.fondFntDecryptage;
            this.ClientSize = new System.Drawing.Size(365, 229);
            this.Controls.Add(this.lblAdresseImg);
            this.Controls.Add(this.lblTextResult);
            this.Controls.Add(this.tolStpOutils);
            this.Controls.Add(this.lblTxtDecryptTitre);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.pgsBarDecrypt);
            this.Controls.Add(this.btnDecrypt);
            this.Controls.Add(this.btnChoixImg);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(381, 267);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(381, 267);
            this.Name = "fntDecryptage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Décryptage d\'image";
            this.tolStpOutils.ResumeLayout(false);
            this.tolStpOutils.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnChoixImg;
        private System.Windows.Forms.Button btnDecrypt;
        private System.Windows.Forms.Label lblTextResult;
        private System.Windows.Forms.ProgressBar pgsBarDecrypt;
        private System.Windows.Forms.Label lblAdresseImg;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblTxtDecryptTitre;
        private System.Windows.Forms.ToolStrip tolStpOutils;
        private System.Windows.Forms.ToolStripDropDownButton tolStpDrpDwnBtnOpt;
        private System.Windows.Forms.ToolStripMenuItem tolStpMnuItmOptQuitter;
        private System.Windows.Forms.ToolStripMenuItem tolStpMnuItmOptRelancer;
        private System.Windows.Forms.ToolStripDropDownButton tolStpDrpDwnBtnAff;
        private System.Windows.Forms.ToolStripMenuItem tolStpMnuItmAffAdresse;
        private System.Windows.Forms.ToolStripMenuItem tolStpMnuItmAffAdresseO;
        private System.Windows.Forms.ToolStripMenuItem tolStpMnuItmAffAdresseN;
        private System.Windows.Forms.ToolStripDropDownButton tolStpDrpDwnBtnAide;
        private System.Windows.Forms.ToolStripMenuItem tolStpMnuItmAideDecrypt;
        private System.Windows.Forms.ToolStripMenuItem tolStpMnuItmAideAdresseImg;
        private System.Windows.Forms.ToolStripMenuItem tolStpMnuItmAideTxtDecrypt;
        private System.Windows.Forms.ToolStripMenuItem tolStpMnuItmOptEmplImgADecrypt;
        private System.Windows.Forms.ToolStripMenuItem tolStpMnuItmOptTxtDecrypt;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
    }
}

