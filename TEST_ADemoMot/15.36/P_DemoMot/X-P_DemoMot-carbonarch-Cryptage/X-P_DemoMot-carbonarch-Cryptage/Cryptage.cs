// Cryptage » qui crypte une image pour y mettre un texte invisible à l'œil
/******************************************************************************
** PROGRAMME  Cryptage.cs                                                    **
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
** Crypte l'image sélectionné par l'utilisateur pour y insérer un texte qui  **
** est invisible  à l'œil et ne peut être récupérer que par le programme de  **
** décryptage.                                                               **
**                                                                           **
******************************************************************************/

using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace X_P_DemoMot_carbonarch_Cryptage
{
    public partial class fntCryptage : Form
    {
        //////////////////////////////////Déclaration des variables globales//////////////////////////////////
        private Bitmap g_BTMIMGUSER;                                        // Permet d'utiliser les bits de l'image
        private Color g_CLRATC = Color.LightGreen;                          // Définie la couleur des items activés
        private Color g_CLRDESACT = Color.Red;                              // Définie la couleur des items désactivés
        private SaveFileDialog g_SFDSAVEIMG = new SaveFileDialog();         // Définie une fenêtre pour enregistrer l'image
        private OpenFileDialog g_OFDCHERCHEIMG = new OpenFileDialog();      // Définie une fenêtre pour choisir une image

        //////////////////////////////////////////////////////////////////////////////////////////////////////

        // *****************************************************************************************
        // Nom:     fntCryptage
        // But:     Ouvrir la fenêtre de démarrage.
        // Param:   -
        // Retour:  -
        // *****************************************************************************************
        public fntCryptage()
        {
            InitializeComponent();

            // Change la couleur de tous les items "oui" d'affichage en vert
            tolStpMnuItmAffAdresseO.BackColor = g_CLRATC;
            tolStpMnuItmLimCaracO.BackColor = g_CLRATC;
        }

        // *****************************************************************************************
        // Nom:     btnCrypter_Click
        // But:     Crypte l'image et inséré  le texte de l'utilisateur dans l'image.
        // Param:   -
        // Retour:  -
        // *****************************************************************************************
        private void btnCrypter_Click(object sender, EventArgs e)
        {
            // Vérifie si l'utilisateur à entrer le texte à insérer dans l'image
            // Si ce n'est pas le cas il envoie un message à l'utilisateur pour lui dire de définir le texte à insérer dans l'image
            if (txtBoxUser.Text == "")
            {
                // Empêche l'utilisateur d'enregistrer l'image
                btnSaveImg.Enabled = false;

                g_SFDSAVEIMG.FileName = "";                                // Définie une valeur null à l'image enregistrée

                // Change le texte de l'emplacement de l'image enregistrée
                lblSaveImg.Text = "Aucun emplacement pour enregistrer l'image n'a été séléctionné.";

                MessageBox.Show("Aucun texte n'a été définie pour insérer dans l'image.", 
                    "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            // Sinon il crypte l'image pour lui insérer le texte de l'utilisateur
            else
            {
                //////////////////////////////////Déclaration des variables//////////////////////////////////
                bool bolCacheT = true;                                     // Cache les caractères
                bool bolCacheF = false;                                    // Arrête de cacher  les caractères
                int intIndexCarac = 0;                                     // Définie quel caractère doit être pris en compte
                int intValCaracASCII = 0;                                  // Définie la valeur ASCII du caractère
                int intPxlElementIdx = 0;                                  // Définie le nombre de bits utilisés et permet de définir la couleur à modifier
                int intRed = 0;                                            // Définie la valeur de la couleur rouge
                int intGreen = 0;                                          // Définie la valeur de la couleur vert
                int intBlue = 0;                                           // Définie la valeur de la couleur bleue
                Color clrPixel;                                            // Définie la valeur des couleurs de l'image dans chaque pixel

                /////////////////////////////////////////////////////////////////////////////////////////////

                // Change le texte de l'emplacement de l'image enregistrée
                lblSaveImg.Text = "Aucun emplacement pour enregistrer l'image n'a été séléctionné.";

                g_SFDSAVEIMG.FileName = "";                                // Définie une valeur null à l'image enregistrée

                // Boucle pour ne pas dépasser la hauteur de l'image
                for (int intHeight = 0; intHeight < g_BTMIMGUSER.Height; intHeight++)
                {
                    // Définie les valeurs de la barre de cryptage
                    // Définie la valeur minimum de la barre de progression du cryptage
                    pgsBarCrypt.Minimum = 0;

                    // Définie la valeur maximum de la barre de progression du cryptage
                    pgsBarCrypt.Maximum = g_BTMIMGUSER.Height;

                    // Définie la valeur de progression du décryptage
                    pgsBarCrypt.Value = intHeight;

                    // Condition pour permettre au programme d'être plus rapide
                    // La limite de caractère maximal est de 64, donc le programme n'a pas besoin de modifier d'autre pixel
                    if (intIndexCarac < txtBoxUser.Text.Length)
                    {
                        // Boucle pour ne pas dépasser la largeur de l'image
                        for (int intWidth = 0; intWidth < g_BTMIMGUSER.Width; intWidth++)
                        {
                            // Définie quel pixel de l'image doit être pris en compte
                            clrPixel = g_BTMIMGUSER.GetPixel(intWidth, intHeight);

                            // Retire 1 bit à la couleur si elle est impaire
                            intRed = clrPixel.R - clrPixel.R % 2;
                            intGreen = clrPixel.G - clrPixel.G % 2;
                            intBlue = clrPixel.B - clrPixel.B % 2;

                            // Permet de modifier 3 couleurs dans un pixel
                            for (short shtColor = 0; shtColor < 3; shtColor++)
                            {
                                // Vérifie si chaque caractère est insérer dans l'image sur 8 bits
                                // Si c'est la cas il continue
                                if (intPxlElementIdx % 8 == 0)
                                {
                                    // Si le nombre de caractères inséré est égale ou supérieur au nombre de caractère de l'utilisateur
                                    // Il modifie la valeur de "bolCacheT" pour qu'il arrête de modifier les pixels
                                    if (intIndexCarac >= txtBoxUser.Text.Length)
                                    {
                                        // Définie une nouvelle valeur pour arrêter d'insérer des caractères
                                        bolCacheT = bolCacheF;
                                    }

                                    // Sinon il prend le prochain caractère que l'utilisateur à écrit
                                    else
                                    {
                                        // Prend la valeur ASCII du caractère suivant
                                        intValCaracASCII = txtBoxUser.Text[intIndexCarac++];
                                    }
                                }

                                // Définie quelle couleur du pixel doit être modifiée
                                switch (intPxlElementIdx % 3)
                                {
                                    // Si la couleur à modifier est "0"
                                    // La couleur rouge du pixel sera modifier par modulo pour insérer le caractère
                                    case 0:
                                        {
                                            // Vérifie si "bolCacheT" permet  de modifier la couleur rouge pour cacher le caractère
                                            if (bolCacheT == true)
                                            {
                                                // Si la valeur ASCII du caractère est impaire, La valeur de la couleur rouge augmente de 1
                                                intRed += intValCaracASCII % 2;

                                                // Divise la valeur ASCII du caractère par 2, pour pouvoir changer la valeur des couleurs
                                                intValCaracASCII /= 2;
                                            }
                                        } break;

                                    // Si la couleur à modifier est "1"
                                    // La couleur vert du pixel sera modifier par modulo pour insérer le caractère
                                    case 1:
                                        {
                                            // Vérifie si "bolCacheT" permet  de modifier la couleur vert pour cacher le caractère
                                            if (bolCacheT == true)
                                            {
                                                // Si la valeur ASCII du caractère est impaire, La valeur de la couleur vert augmente de 1
                                                intGreen += intValCaracASCII % 2;

                                                // Divise la valeur ASCII du caractère par 2, pour pouvoir changer la valeur des couleurs
                                                intValCaracASCII /= 2;
                                            }
                                        } break;

                                    // Si la couleur à modifier est "2"
                                    // La couleur bleu du pixel sera modifier par modulo pour insérer le caractère
                                    case 2:
                                        {
                                            // Vérifie si "bolCacheT" permet  de modifier la couleur bleu pour cacher le caractère
                                            if (bolCacheT == true)
                                            {
                                                // Si la valeur ASCII du caractère est impaire, La valeur de la couleur bleu augmente de 1
                                                intBlue += intValCaracASCII % 2;

                                                // Divise la valeur ASCII du caractère par 2, pour pouvoir changer la valeur des couleurs
                                                intValCaracASCII /= 2;
                                            }

                                            // Définie une nouvelle couleur au pixel de l'image
                                            g_BTMIMGUSER.SetPixel(intWidth, intHeight, Color.FromArgb(intRed, intGreen, intBlue));
                                        } break;
                                }

                                // Augmente la valeur de l'index des pixels
                                intPxlElementIdx++;
                            }
                        }
                    }
                }

                // Permet à l'utilisateur de sauvegarder l'image avec le nom qu'il aura choisi et à l'emplacement choisi
                btnSaveImg.Enabled = true;
            }
        }

        // *****************************************************************************************
        // Nom:     txtBoxUser_TextChanged
        // But:     Texte Box où l'utilisateur va entrer son texte, empêche l'utilisateur de 
        //          continuer si la limite de caractère a été dépassée.
        // Param:   -
        // Retour:  -
        // *****************************************************************************************
        private void txtBoxUser_TextChanged(object sender, EventArgs e)
        {
            // Vérifie si le nombre de caractère entré par l'utilisateur ne dépasse pas 64 caractère
            // Si ce n'est pas le cas il permet à l'utilisateur de cliquer sur le bouton de cryptage d'image
            // Indique le nombre de caractères disponible
            if (txtBoxUser.Text.Length < 65)
            {
                btnCrypt.Enabled = true;
                lblLimCarac.Text = "Nombre de caractère restant disponible : " + (64 - txtBoxUser.Text.Length);
            }

            // Si la limite est dépassée il bloque le bouton de cryptage d'image et ouvre une fenêtre
            // indiquant de combien de caractère la limite a été dépassée
            // Indique à l'utilisateur qu'il ne lui reste aucun caractère disponible
            else
            {
                lblLimCarac.Text = "Nombre de caractère restant disponible : 0";
                MessageBox.Show("Le nombre de caractères maximum a été dépassé de " +
                    (txtBoxUser.Text.Length - 64) + ".", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                // Empêche l'utilisateur de cliquer sur le bouton pour crypter
                btnCrypt.Enabled = false;
            }
        }

        // *****************************************************************************************
        // Nom:     btnChoixImage_Click
        // But:     Bouton avec lequel l'utilisateur va choisir l'image qu'il veut crypter.
        // Param:   -
        // Retour:  -
        // *****************************************************************************************
        private void btnChoixImage_Click(object sender, EventArgs e)
        {
            // Assure que les images sont en bmp, si ce n'est pas le cas il ne les affiches pas
            g_OFDCHERCHEIMG.Filter = "image files (*.bmp)|*.bmp";

            // Affiche la fenêtre d'exploration
            g_OFDCHERCHEIMG.ShowDialog();

            // Si l'utilisateur change d'image la barre de progression se met à 0
            pgsBarCrypt.Value = 0;

            // Change le texte de l'emplacement de l'image à crypter
            lblAdresseImg.Text = "Aucune image n'a été séléctionnée.";

            // Vérifie si l'utilisateur a choisi une image
            // Si ce n'est pas le cas le programme ne continue pas
            if (g_OFDCHERCHEIMG.FileName == "")
            {

            }

            // Si c'est le cas le programme continue
            // Il prend en compte l'image, débloque la texte box pour laisser l'utilisateur 
            // écrire le texte à insérer dans l'image et affiche l'adresse de l'image à crypter
            else
            {
                // Affiche à l'utilisateur l'adresse de l'image choisie
                lblAdresseImg.Text = g_OFDCHERCHEIMG.FileName;

                g_BTMIMGUSER = new Bitmap(g_OFDCHERCHEIMG.FileName);        // Définie les bits de l'image

                g_SFDSAVEIMG.FileName = "";                                 // Définie une valeur null à l'image enregistrée

                // Permet à l'utilisateur d'écrire le texte à insérer dans l'image
                txtBoxUser.Enabled = true;

                btnSaveImg.Enabled = false;
            }
        }

        // *****************************************************************************************
        // Nom:     btnSaveImage_Click
        // But:     Permet à l'utilisateur de choisir le nom de l'image, de choisir l'emplacement 
        //          où l'enregistrer de de l'enregistrer à cet emplacement.
        // Param:   -
        // Retour:  -
        // *****************************************************************************************
        private void btnSaveImage_Click(object sender, EventArgs e)
        {
            // Filtre les images pour n'afficher que les images en "bmp"
            g_SFDSAVEIMG.Filter = "Image en bmp (*.bmp)|*.bmp";

            // Titre de la fenêtre pour enregistrer l'image cryptée
            g_SFDSAVEIMG.Title = "Enregistrer sous...";

            // Nom définie par défault à l'image cryptée à enregistrer
            g_SFDSAVEIMG.FileName = "image";

            // Affiche la pour enregistrer l'image cryptée
            g_SFDSAVEIMG.ShowDialog();

            // Si aucun emplacement n'a été choisi
            // Un message s'affiche indiquant à l'utilisateur qu'aucun emplacement n'a été choisie
            if ((g_SFDSAVEIMG.FileName == "") || (g_SFDSAVEIMG.FileName == "image"))
            {
                MessageBox.Show("Aucun emplacement n'a été choisi pour enregistrer l'image.", "Attention !", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            // Si une image a été choisie
            // L'image est enregistrée à l'emplacement choisie et un message s'affiche indiquant l'emplacement de l'image enregistrée
            else
            {
                // Définie le nom de l'image, ainsi du format en "bmp"
                lblSaveImg.Text = g_SFDSAVEIMG.FileName;

                // Enregistrer l'image crypter dans l'emplacement choisi par l'utilisateur
                g_BTMIMGUSER.Save(g_SFDSAVEIMG.FileName);

                // Affiche un message indiquant à l'utilisateur l'emplacement de l'image enregistrée
                MessageBox.Show("L'image a bien été enregistrée à cet emplacement :\n" +
                    g_SFDSAVEIMG.FileName,
                    "Enregistrement réussit", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        // *****************************************************************************************
        // Nom:     tolStpMnuItmQuitter_Click
        // But:     Ferme le programme.
        // Param:   -
        // Retour:  -
        // *****************************************************************************************
        private void tolStpMnuItmOptQuitter_Click(object sender, EventArgs e)
        {
            Close();
        }

        // *****************************************************************************************
        // Nom:     tolStpMnuItmAideCrypt_Click
        // But:     Affiche les étapes à suivre pour utiliser le programme.
        // Param:   -
        // Retour:  -
        // *****************************************************************************************
        private void tolStpMnuItmAideCrypt_Click(object sender, EventArgs e)
        {
            // Un message box apparait à l'écran pour décrire les étapes à suivre pour utiliser le programme
            MessageBox.Show("1.Comment crypter une image ?\n" +
                "\n- Choisir une image à crypter en cliquant sur le bouton << " + btnChoixImg.Text + " >>." +
                "\n- Ecrire le texte à insérer dans l'image." +
                "\n- Cliquer sur le bouton << " + btnCrypt.Text + " >> pour insérer votre texte dans l'image." +
                "\n- Pour finir il faut cliquer sur << " + btnSaveImg.Text + " >> pour enregistrer l'image cryptée.\n" +
                "\n\n2. Condition pour crypter une image et pouvoir la décrypter\n" +
                "\n- Les caractère qui ne sont pas dans la table de caractère ASCII peuvent poser problème, il est donc conseillé déviter d'utiliser ces caractères."+
                "\n- L'image à crypter doit être en bitmap (.bmp), sinon le programme ne le prendra pas en compte." +
                "\n- Lors de l'enregistrement, l'image doit être en bitmap (.bmp), donc vous pouvez laisser << .bmp >> dans le nom de l'image ou l'enlever, " +
                "mais vous ne devez pas changer de format lors de l'enregistrement et après l'emnregistrement." + 
                "\n- L'image doit avoir une profondeur de couleur de 16 minimum, pour vérifier cela, faites un clique droite sur l'image, " + 
                "puis cliquez sur << Propriétés >>, cliquez ensuite sur l'onglet << Détails >>, pour finir allez sous << Images >>.",
                "Comment utiliser le programme de cryptage ?", MessageBoxButtons.OK, MessageBoxIcon.Question);
        }

        // *****************************************************************************************
        // Nom:     tolStpMnuItmOptRelancer_Click
        // But:     Permet d'ouvrir dans une nouvelle fenêtre le programme et de fermer l'ancien 
        //          programme, pour permettre à l'utilisateur de relancer le programme.
        // Param:   -
        // Retour:  -
        // *****************************************************************************************
        private void tolStpMnuItmOptRelancer_Click(object sender, EventArgs e)
        {
            // Ouvre le programme dans une nouvelle fenêtre Windows
            System.Diagnostics.Process.Start(Application.ExecutablePath);

            // Ferme l'ancien programme
            Close();
        }

        // *****************************************************************************************
        // Nom:     tolStpMnuItmAffAdresseO_Click
        // But:     Permet d'afficher l'adresse de l'image choisie pour être cryptée.
        // Param:   -
        // Retour:  -
        // *****************************************************************************************
        private void tolStpMnuItmAffAdresseO_Click(object sender, EventArgs e)
        {
            // Change la couleur de l'item "oui" en vert
            tolStpMnuItmAffAdresseO.BackColor = g_CLRATC;

            // Change la couleur de l'item "non" avec la couleur par défaut
            tolStpMnuItmAffAdresseN.BackColor = Control.DefaultBackColor;

            // Affiche l'adresse de l'image à crypter
            lblAdresseImg.Visible = true;
        }

        // *****************************************************************************************
        // Nom:     tolStpMnuItmAffAdresseN_Click
        // But:     Permet de cacher l'adresse de l'image choisie pour être cryptée.
        // Param:   -
        // Retour:  -
        // *****************************************************************************************
        private void tolStpMnuItmAffAdresseN_Click(object sender, EventArgs e)
        {
            // Change la couleur de l'item "non" en rouge
            tolStpMnuItmAffAdresseN.BackColor = g_CLRDESACT;

            // Change la couleur de l'item "oui" avec la couleur par défaut
            tolStpMnuItmAffAdresseO.BackColor = Control.DefaultBackColor;

            // Cache l'adresse de l'image à crypter
            lblAdresseImg.Visible = false;
        }

        // *****************************************************************************************
        // Nom:     tolStpMnuItmLimCaracO_Click
        // But:     Permet d'afficher le nombre de caractère restant que l'utilisateur peut encore 
        //          écrire.
        // Param:   -
        // Retour:  -
        // *****************************************************************************************
        private void tolStpMnuItmLimCaracO_Click(object sender, EventArgs e)
        {
            // Change la couleur de l'item "oui" en vert
            tolStpMnuItmLimCaracO.BackColor = g_CLRATC;

            // Change la couleur de l'item "non" avec la couleur par défaut
            tolStpMnuItmLimCaracN.BackColor = Control.DefaultBackColor;

            // Affiche la limite de caractère
            lblLimCarac.Visible = true;
        }

        // *****************************************************************************************
        // Nom:     tolStpMnuItmLimCaracN_Click
        // But:     Permet de cacher le nombre de caractère restant que l'utilisateur peut encore 
        //          écrire.
        // Param:   -
        // Retour:  -
        // *****************************************************************************************
        private void tolStpMnuItmLimCaracN_Click(object sender, EventArgs e)
        {
            // Change la couleur de l'item "non" en vert
            tolStpMnuItmLimCaracN.BackColor = g_CLRDESACT;

            // Change la couleur de l'item "oui" avec la couleur par défaut
            tolStpMnuItmLimCaracO.BackColor = Control.DefaultBackColor;

            // Cache la limite de caractère
            lblLimCarac.Visible = false;
        }

        // *****************************************************************************************
        // Nom:     tolStpMnuItmOptEmplImg_Click
        // But:     Affiche à l'utilisateur, dans un message box, l'adresse de l'image enregistée.
        // Param:   -
        // Retour:  -
        // *****************************************************************************************
        private void tolStpMnuItmOptEmplImg_Click(object sender, EventArgs e)
        {
            // Si aucune image n'a été choisie
            // Un message s'affiche indiquant à l'utilisateur de choisir une image
            if (g_SFDSAVEIMG.FileName == "")
            {
                MessageBox.Show("Aucune image n'a été enregistrée.", "Attention !", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            // Si une image a été choisie
            // Un message s'affiche indiquant à l'utilisateur l'adresse de l'image enregistrée
            else
            {
                MessageBox.Show("L'image a été enregistrée à cette adresse :\n" +
                    g_SFDSAVEIMG.FileName,
                    "Adresse de l'image cryptée", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        // *****************************************************************************************
        // Nom:     tolStpMnuItmAideAdresseImg_Click
        // But:     Affiche une aide à l'utilisateur si l'adresse de l'image à crypter ou à
        //          enregistrer n'est pas visible, lui indiquant les étapes pour les voir.
        // Param:   -
        // Retour:  -
        // *****************************************************************************************
        private void tolStpMnuItmAideAdresseImg_Click(object sender, EventArgs e)
        {
            // Message affiché à l'utilisateur pour lui permettre de voir l'adresse de l'image à crypter ou à enregistrer
            MessageBox.Show("L'adresse de l'image à crypter ou à enregistrer n'est pas totalement visible ?\n\n" +
                "1. Il est possible que l'adresse de l'image soit trop grande pour être totalement affichée, " +
                "si c'est le cas, veuillez suivre ces étapes :\n\n" +
                "- Allez sous << " + tolStpDrpDwnBtnOpt + " >> qui se trouve dans la barre d'outils en haut à gauche du programme.\n" +
                "- Pour finir, cliquez sur << " + tolStpMnuItmOptEmplImgACrypt + " >> pour affiche l'adresse de l'image à crypter, " +
                "ou sur << " + tolStpMnuItmOptEmplImgEnr + " >> pour afficher l'adresse de l'image enregistrée.\n\n" +
                "2. Si ce n'est pas le cas vérifier :\n\n" +
                "- Que vous avez choisi une image\n" +
                "- Que vous avez entré un texte à insérer dans l'image\n" +
                "- Que vous avez cliqué sur le bouton << " + btnCrypt.Text + " >>\n" +
                "- Que vous avez cliqué sur << " + btnSaveImg.Text + " >>",
                "Adresse de l'image non visible ?", MessageBoxButtons.OK, MessageBoxIcon.Question);

        }

        // *****************************************************************************************
        // Nom:     tolStpMnuItmOptEmplImgACrypt_Click
        // But:     Affiche à l'utilisateur, dans un message box, l'adresse de l'image à crypter.
        // Param:   -
        // Retour:  -
        // *****************************************************************************************
        private void tolStpMnuItmOptEmplImgACrypt_Click(object sender, EventArgs e)
        {
            // Si aucune image n'a été choisie
            // Un message s'affiche indiquant à l'utilisateur qu'aucune image n'a été choisie et d'en choisir une
            if (g_OFDCHERCHEIMG.FileName == "")
            {
                MessageBox.Show("Aucune image n'a été choisie.", "Attention !", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            // Si une image a été choisie
            // Un message s'affiche indiquant à l'utilisateur l'adresse de l'image à crypter
            else
            {
                MessageBox.Show("L'image à crypter se trouve à cette adresse :\n" +
                    g_OFDCHERCHEIMG.FileName,
                    "Adresse de l'image à crypter", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}