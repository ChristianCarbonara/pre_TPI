// Decryptage » qui décrypte une image pour y récupérer le texte caché
/******************************************************************************
** PROGRAMME  Decryptage.cs                                                  **
**                                                                           **
** Lieu      : ETML - section informatique                                   **
** Auteur    : Christian Carbonara                                           **
** Date      : 02.06.2015                                                    **
**                                                                           **
** Modifications                                                             **
**   Auteur  : Christian Carbonara                                           **
**   Version : 1.0                                                           **
**   Date    : 26.06.2015                                                    **
**   Raisons : Amélioration des commentaires et création de nouveaux         **
**             commentaires.                                                 **
**                                                                           **
******************************************************************************/

/******************************************************************************
** DESCRIPTION                                                               **
** Décrypte  l'image sélectionnée par l'utilisateur pour récupérer le texte  **
** caché à l'intérieur de celle-ci.                                          **
**                                                                           **
******************************************************************************/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace X_P_DemoMot_carbonarch_Decryptage
{
    public partial class fntDecryptage : Form
    {
        //////////////////////////////////Déclaration des variables globales//////////////////////////////////
        private Bitmap g_BTMIMGUSER;                                        // Permet d'utiliser les bits de l'image
        private OpenFileDialog g_OFDCHERCHEIMG = new OpenFileDialog();      // Définie une fenêtre pour choisir une image

        //////////////////////////////////////////////////////////////////////////////////////////////////////

        // *****************************************************************************************
        // Nom:     fntDecryptage
        // But:     Ouvrir la fenêtre de démarrage.
        // Param:   -
        // Retour:  -
        // *****************************************************************************************
        public fntDecryptage()
        {
            InitializeComponent();

            // Change la couleur de l'item "oui" dans affichage en vert
            tolStpMnuItmAffAdresseO.BackColor = Color.LightGreen;
        }

        // *****************************************************************************************
        // Nom:     btnChoixImage_Click
        // But:     Bouton avec lequel l'utilisateur va choisir l'image qu'il veut décrypter.
        // Param:   -
        // Retour:  -
        // *****************************************************************************************
        private void btnChoixImage_Click(object sender, EventArgs e)
        {
            // Définie la valeur de la barre de progression
            pgsBarDecrypt.Value = 0;

            // Assure que les images sont en bmp, si ce n'est pas le cas il ne les affiches pas
            g_OFDCHERCHEIMG.Filter = "image files (*.bmp)|*.bmp";

            // Affiche la fenêtre d'exploration
            g_OFDCHERCHEIMG.ShowDialog();

            // Vérifie si l'utilisateur a choisi une image
            // Si ce n'est pas le cas le programme ne continue pas
            if (g_OFDCHERCHEIMG.FileName == "")
            {

            }

            // Si c'est le cas le programme continue
            // Il prend en compte l'image, débloque le bouton de décryptage pour laisser 
            // l'utilisateur décrypter l'image et affiche l'adresse de l'image à décrypter
            else
            {
                // Affiche à l'utilisateur l'adresse de l'image choisie
                lblAdresseImg.Text = g_OFDCHERCHEIMG.FileName;

                g_BTMIMGUSER = new Bitmap(g_OFDCHERCHEIMG.FileName);        // Définie les bits de l'image

                // Change le teste du décryptage
                lblTextResult.Text = "";

                // Permet à l'utilisateur de décrypter l'image
                btnDecrypt.Enabled = true;
            }
        }

        // *****************************************************************************************
        // Nom:     intRenvoieBits
        // But:     Permet de trouver le caractère caché en ASCII.
        // Param:   type int => intN
        // Retour:  intResult
        // *****************************************************************************************
        private static int intRenvoieBits(int intN)
        {
            //////////////////////////////////Déclaration des variables//////////////////////////////////
            int intResult = 0;                                         // Permet de définir en ASCII le caractère caché

            /////////////////////////////////////////////////////////////////////////////////////////////

            // Boucle pour récupérer en ASCII le cractère caché sur 8 bits par modulo
            for (int intI = 0; intI < 8; intI++)
            {
                // Détermine la valeur du caractère en ASCII par modulo
                intResult = intResult * 2 + intN % 2;

                // Divise par 2 pour continuer à calculer par modulo
                intN /= 2;
            }

            // Renvoie la valeur du caractère en ASCII
            return intResult;
        }

        // *****************************************************************************************
        // Nom:     btnDecrypt_Click
        // But:     Décrypte l'image pour y récupérer le texte caché à l'intérieur de celle-ci et
        //          afficher le résultat du décryptage à l'utilisateur.
        // Param:   -
        // Retour:  -
        // *****************************************************************************************
        private void btnDecrypt_Click(object sender, EventArgs e)
        {
            //////////////////////////////////Déclaration des variables//////////////////////////////////
            int intColorIndex = 0;                                     // Détermine la couleur à décrypter et le nombre bits utilisés
            int intValCaracASCII = 0;                                  // Permet de trouver les caractères cachés dans l'image en ASCII
            char chrCarac;                                             // Permet de convertir la valeur ASCII en caractère
            string strExtraireText = "";                               // Détermine le texte récupéré depuis l'image
            Color clrPixel;                                            // Détermine les couleurs de l'image

            /////////////////////////////////////////////////////////////////////////////////////////////

            // Boucle pour ne pas dépasser la hauteur de l'image
            for (int intHeight = 0; intHeight < g_BTMIMGUSER.Height; intHeight++)
            {
                // Définie les valeurs de la barre de décryptage
                // Définie la valeur minimum de la barre de progression du décryptage
                pgsBarDecrypt.Minimum = 0;

                // Définie la valeur maximum de la barre de progression du décryptage
                pgsBarDecrypt.Maximum = g_BTMIMGUSER.Height;

                // Définie la valeur de progression du décryptage
                pgsBarDecrypt.Value = intHeight;
                
                // Condition pour permettre au programme d'être plus rapide
                // La limite de caractère maximal au cryptage est de 64, donc le programme n'a pas besoin d'aller plus loin
                if (strExtraireText.Length < 65)
                {
                    // Boucle pour ne pas dépasser la largeur de l'image
                    for (int intWidth = 0; intWidth < g_BTMIMGUSER.Width; intWidth++)
                    {
                        // Définie quel pixel de l'image doit être pris en compte
                        clrPixel = g_BTMIMGUSER.GetPixel(intWidth, intHeight);

                        // Permet de prendre en compte 3 couleurs dans un pixel
                        for (short shtColor = 0; shtColor < 3; shtColor++)
                        {
                            // Définie quelle couleur du pixel doit être prise en compte
                            switch (intColorIndex % 3)
                            {
                                // Si la couleur à prendre en compte est "0"
                                // La valeur du caractère en ASCII se fera par modulo avec la couleur rouge
                                case 0:
                                    {
                                        // Calcule la valeur du caractère en ASCII par modulo
                                        intValCaracASCII = intValCaracASCII * 2 + clrPixel.R % 2;
                                    } break;

                                // Si la couleur à prendre en compte est "1"
                                // La valeur du caractère en ASCII se fera par modulo avec la couleur vert
                                case 1:
                                    {
                                        // Calcule la valeur du caractère en ASCII par modulo
                                        intValCaracASCII = intValCaracASCII * 2 + clrPixel.G % 2;
                                    } break;

                                // Si la couleur à prendre en compte est "2"
                                // La valeur du caractère en ASCII se fera par modulo avec la couleur bleu
                                case 2:
                                    {
                                        // Calcule la valeur du caractère en ASCII par modulo
                                        intValCaracASCII = intValCaracASCII * 2 + clrPixel.B % 2;
                                    } break;
                            }

                            // Augmente la valeur de l'index des pixels
                            intColorIndex++;

                            // Assure que le caractère à décoder est sur 8 bits
                            // Si c'est le cas le caractère actuel sera ajouté au texte de résultat
                            if (intColorIndex % 8 == 0)
                            {
                                // Renvoie la valeur du caractère en ASCII
                                intValCaracASCII = intRenvoieBits(intValCaracASCII);

                                // Convertit la valeur ASCII du caractère en caractère
                                chrCarac = (char)intValCaracASCII;

                                // Ajoute le caractère décrypté au texte qui sera affiché à l'utilisateur
                                strExtraireText += chrCarac.ToString();
                            }
                        }
                    }
                }
            }

            // Envoie un message Windows à l'utilisateur pour lui indiquer que le décryptement à fonctionné et lui afficher le texte décrypter
            MessageBox.Show("L'image a bien été décryptée, voici le texte décrypté :\n" + strExtraireText, 
                "Décryptage réussi", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Affiche le texte décrypté à l'utilisateur
            lblTextResult.Text = strExtraireText;
        }

        // *****************************************************************************************
        // Nom:     tolStpMnuItmQuitter_Click
        // But:     Ferme le programme.
        // Param:   -
        // Retour:  -
        // *****************************************************************************************
        private void tolStpMnuItmQuitter_Click(object sender, EventArgs e)
        {
            Close();
        }

        // *****************************************************************************************
        // Nom:     tolStpMnuItmRelancer_Click
        // But:     Permet d'ouvrir dans une nouvelle fenêtre le programme et de fermer l'ancien 
        //          programme, pour permettre à l'utilisateur de relancer le programme.
        // Param:   -
        // Retour:  -
        // *****************************************************************************************
        private void tolStpMnuItmRelancer_Click(object sender, EventArgs e)
        {
            // Ouvre le programme dans une nouvelle fenêtre Windows
            System.Diagnostics.Process.Start(Application.ExecutablePath);

            // Ferme l'ancien programme
            Close();
        }

        // *****************************************************************************************
        // Nom:     tolStpMnuItmAffAdresseO_Click
        // But:     Permet d'afficher l'adresse de l'image choisie pour être décryptée.
        // Param:   -
        // Retour:  -
        // *****************************************************************************************
        private void tolStpMnuItmAffAdresseO_Click(object sender, EventArgs e)
        {
            // Change la couleur de l'item "oui" en vert
            tolStpMnuItmAffAdresseO.BackColor = Color.LightGreen;

            // Change la couleur de l'item "non" avec la couleur par défaut
            tolStpMnuItmAffAdresseN.BackColor = Control.DefaultBackColor;

            // Affiche l'adresse de l'image à crypter
            lblAdresseImg.Visible = true;
        }

        // *****************************************************************************************
        // Nom:     tolStpMnuItmAffAdresseN_Click
        // But:     Permet de cacher l'adresse de l'image choisie pour être décryptée.
        // Param:   -
        // Retour:  -
        // *****************************************************************************************
        private void tolStpMnuItmAffAdresseN_Click(object sender, EventArgs e)
        {
            // Change la couleur de l'item "non" en rouge
            tolStpMnuItmAffAdresseN.BackColor = Color.Red;

            // Change la couleur de l'item "oui" avec la couleur par défaut
            tolStpMnuItmAffAdresseO.BackColor = Control.DefaultBackColor;

            // Cache l'adresse de l'image à crypter
            lblAdresseImg.Visible = false;
        }

        // *****************************************************************************************
        // Nom:     tolStpMnuItmAideAdresseImg_Click
        // But:     Affiche une aide à l'utilisateur si l'adresse de l'image à décrypter n'est 
        //          pas visible, lui indiquant les étapes pour le voir.
        // Param:   -
        // Retour:  -
        // *****************************************************************************************
        private void tolStpMnuItmAideAdresseImg_Click(object sender, EventArgs e)
        {
            // Message affiché à l'utilisateur pour lui permettre de voir l'adresse de l'image à décrypter
            MessageBox.Show("L'adresse de l'image à décrypter n'est pas totalement visible ?\n" +
                "\n1. Il est possible que l'adresse de l'image soit trop grande pour être totalement affichée, " +
                "si c'est le cas, veuillez suivre ces étapes :\n" +
                "\n- Allez sous << " + tolStpDrpDwnBtnOpt.Text + " >> qui se trouve dans la barre d'outils en haut à gauche du programme." +
                "\n- Pour finir, cliquez sur << " + tolStpMnuItmOptEmplImgADecrypt + " >> pour affiche l'adresse de l'image à décrypter.",
                "Adresse de l'image non visible ?", MessageBoxButtons.OK, MessageBoxIcon.Question);
        }

        // *****************************************************************************************
        // Nom:     tolStpMnuItmOptEmplImgADecrypt_Click
        // But:     Affiche à l'utilisateur, dans un message box, l'adresse de l'image à décrypter.
        // Param:   -
        // Retour:  -
        // *****************************************************************************************
        private void tolStpMnuItmOptEmplImgADecrypt_Click(object sender, EventArgs e)
        {
            // Si aucune image n'a été choisie
            // Un message s'affiche indiquant à l'utilisateur qu'aucune image n'a été choisie et d'en choisir une
            if (g_OFDCHERCHEIMG.FileName == "")
            {
                MessageBox.Show("Aucune image n'a été choisie.", "Attention !", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            // Si une image a été choisie
            // Un message s'affiche indiquant à l'utilisateur l'adresse de l'image à décrypter
            else
            {
                MessageBox.Show("L'image à décrypter se trouve à cette adresse :\n" + g_OFDCHERCHEIMG.FileName,
                    "Adresse de l'image à décrypter", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        // *****************************************************************************************
        // Nom:     tolStpMnuItmAideDecrypt_Click
        // But:     Affiche les étapes à suivre pour utiliser le programme.
        // Param:   -
        // Retour:  -
        // *****************************************************************************************
        private void tolStpMnuItmAideDecrypt_Click(object sender, EventArgs e)
        {
            // Un message box apparait à l'écran pour décrire les étapes à suivre pour utiliser le programme
            MessageBox.Show("1. Comment décrypter une image ?\n" +
                "\n- Choisir une image à décrypter en cliquant sur le bouton << " + btnChoixImg.Text + " >>." +
                "\n- Pour finir il faut cliquer sur << " + btnDecrypt.Text + " >> pour décrypter l'image afin" +
                " de récupérer le texte qui est caché dans celle-ci.\n" +
                "\n\n2. Image introuvable lors du choix d'image à décrypter ?\n" +
                "\n- L'image à décrypter doit être en bitmap (.bmp), si ce n'est pas le cas le programme ne le prendra pas en compte." +
                "\n- Vérifier l'adresse de l'image à décrypter.",
                "Comment utiliser le programme de décryptage ?", MessageBoxButtons.OK, MessageBoxIcon.Question);
        }

        // *****************************************************************************************
        // Nom:     tolStpMnuItmAideTxtDecrypt_Click
        // But:     Affiche une aide à l'utilisateur si le texte décrypté pas visible, lui 
        //          indiquant les étapes pour le voir.
        // Param:   -
        // Retour:  -
        // *****************************************************************************************
        private void tolStpMnuItmAideTxtDecrypt_Click(object sender, EventArgs e)
        {
            // Un message box apparait à l'écran pour décrire les étapes à suivre pour afficher le texte décrypté
            MessageBox.Show("Le texte décrypté n'est pas totalement visible ?\n" +
                "\n1. Il est possible que le texte décrypté soit trop grand pour être totalement affiché, " +
                "si c'est le cas, veuillez suivre ces étapes :\n\n" +
                "- Allez sous << " + tolStpDrpDwnBtnOpt.Text + " >> qui se trouve dans la barre d'outils en haut à gauche du programme." +
                "\n- Pour finir, cliquez sur << " + tolStpMnuItmOptTxtDecrypt.Text + " >> pour affiche le texte décrypté.",
                "Texte décrypté non visible ?", MessageBoxButtons.OK, MessageBoxIcon.Question);
        }

        // *****************************************************************************************
        // Nom:     tolStpMnuItmOptEmplImg_Click
        // But:     Affiche à l'utilisateur, dans un message box, le texte décrypté.
        // Param:   -
        // Retour:  -
        // *****************************************************************************************
        private void tolStpMnuItmOptTxtDecrypt_Click(object sender, EventArgs e)
        {
            // Si aucun texte n'a été décrypté
            // Un message s'affiche indiquant à l'utilisateur de choisir une image et de la décrypter
            if (lblTextResult.Text == "")
            {
                MessageBox.Show("Aucune image n'a été décryptée.", "Attention !", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            // Si un texte a été décrypté
            // Un message s'affiche indiquant à l'utilisateur le texte décrypté
            else
            {
                MessageBox.Show("Voici le message décrypté depuis l'image :\n" + lblTextResult.Text, 
                    "Message décrypté", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
