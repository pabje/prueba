using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using webs;
using webservices;

namespace websprincipal
{
    public partial class altadedirecciones : Form
    {
        public altadedirecciones()
        {
            InitializeComponent();
        }

        private void TextBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void TableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Altadedirecciones_Load(object sender, EventArgs e)
        {

        }

        private void TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            webBrowser1.Navigate(txtaddireccion.Text);
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            logica lo = new logica();
            lo.altadirecciones(txtadcodigo.Text, txtaddireccion.Text, txtaddescripcion.Text, mskadfecha.Text);
            txtadcodigo.Text = "";
            txtaddescripcion.Text = "";
            txtaddireccion.Text = "";
            mskadfecha.Text = "";            
        }
    }
}
