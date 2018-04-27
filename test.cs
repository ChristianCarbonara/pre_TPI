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

/// <summary>
/// 
/// </summary>
namespace WindowsFormsApp1
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
            valueBox = textBox1.Text;
            label1.Text = textBox1.Text + "," + textBox2.Text;
            label2.Text = "Nombre chiffre: " + Convert.ToString(textBox1.TextLength);
            
            label3.Text = "Premier chiffre: " + valueBox.Substring(0,1);
            
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