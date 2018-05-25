/// ETML
/// Auteur : Christian Carbonara
/// Date   : 00.00.0000
/// Description : ...

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Text.RegularExpressions;

/// <summary>
/// 
/// </summary>
namespace PRE_TPI
{
    /// <summary>
    /// 
    /// </summary>
    public partial class fnt : Form
    {
        /// <summary>
        /// 
        /// </summary>
        string valueBox;
        string valueBox2;
        int test = 0;
        Regex rgx = new Regex("^[0-1]+$");

        public fnt()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            button1.Text = "Convertir";
            label2.Text = "Nombre chiffre : -";
            label3.Text = "Premier chiffre : -";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            label2.Text = "Nombre chiffre: " + Convert.ToString(textBox1.TextLength);
            valueBox = textBox1.Text;
            valueBox2 = textBox2.Text;
            bool good = false;
            bool result = int.TryParse(valueBox, out test);
            if (rgx.IsMatch(valueBox) && rgx.IsMatch(valueBox2))
            {
                /*for (int check = 0; check < textBox1.TextLength; check++)
                {
                    if (Convert.ToInt64(valueBox.Substring(check, 1)) == 0 || Convert.ToInt64(valueBox.Substring(check, 1)) == 1)
                    {
                        good = true;
                    }
                    else
                    {
                        check += 99;
                        good = false;
                    }
                }

                if (good == true)
                {*/
                    if (textBox1.TextLength != 8 || textBox2.TextLength != 8)
                    {
                        label1.Text = "Veuillez entrer uniquement 8 chiffre";
                    }
                    else
                    {

                        label1.Text = textBox1.Text + "," + textBox2.Text;

                        label3.Text = "Premier chiffre: " + valueBox.Substring(0, 1);
                        label5.Text = "Deuxième chiffre: " + valueBox.Substring(1, 1);
                    }
                //}
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            textBox1.BackColor = Color.DeepPink;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            textBox2.BackColor = Color.MediumSpringGreen;
        }
        
    }
}