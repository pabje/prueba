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
    public partial class consultadedirecciones : Form
    {
        DataTable dt;
        public consultadedirecciones()
        {
            InitializeComponent();
        }

        private void Txtcdfecha_TextChanged(object sender, EventArgs e)
        {

        }
        /*
        private int verificar()
        {
            int ci = 0;
            if (txtcdcodigo.Text != "")
                ci++;
            if (txtcddireccion.Text != "")
                ci++;
            if (txtcddescripcion.Text != "")
                ci++;
            if (mskcdfechad.Text != "")
                ci++;
            if (mskcdfechah.Text != "")
                ci++;
            if (ci == 0)
                return 0;
            else if (ci == 2 && (mskcdfechad.Text == "" || mskcdfechah.Text ==""))
                return 2;
            else
                return 1;
        }
        */
        private void Button1_Click(object sender, EventArgs e)
        {
            datos da = new datos();
            string cod = txtcdcodigo.Text;
            int suc = cod.Length;
            DateTime fed, feh;
            //provisiorio busqueda por un campo
            //if (verificar() == 0)
                //MessageBox.Show("No ingreso ningun dato para la búsqueda.");
            //else
            //{
                //if (verificar() == 2)
                   // MessageBox.Show("Ingresar un solo campo para la búsqueda");
                //else
                //{
            if (txtcdcodigo.Text != "" && txtcddireccion.Text =="" && txtcddescripcion.Text == "" && mskcdfechad.MaskFull == false && mskcdfechah.MaskFull == false)
            {
                da.consultacodigo(cod,suc);
            }
            if (txtcddireccion.Text != "" && txtcdcodigo.Text == "" && txtcddescripcion.Text == "" && mskcdfechad.MaskFull == false && mskcdfechah.MaskFull == false)
            {
                da.consultadireccion(txtcddireccion.Text);
            }
            if (txtcddescripcion.Text != "" && txtcddireccion.Text == "" && txtcdcodigo.Text == "" && mskcdfechad.MaskFull == false && mskcdfechah.MaskFull ==false)
            {
                da.consultadescripcion(txtcddescripcion.Text);
            }            
            if (mskcdfechad.MaskFull == true && mskcdfechah.MaskFull ==  true && txtcddireccion.Text == "" && txtcddescripcion.Text == "" &&  txtcdcodigo.Text =="")
            {
                fed = Convert.ToDateTime(mskcdfechad.Text);
                feh = Convert.ToDateTime(mskcdfechah.Text);
                da.consultafechas(fed,feh);
            }
            if (txtcdcodigo.Text != "" && txtcddireccion.Text != "" && txtcddescripcion.Text == "" && mskcdfechad.MaskFull == false && mskcdfechah.MaskFull == false)
            {
                da.consultacoddir(cod, suc, txtcddireccion.Text);
            }
            if (txtcdcodigo.Text != "" && txtcddescripcion.Text != "" && txtcddireccion.Text == "" && mskcdfechad.MaskFull == false && mskcdfechah.MaskFull == false)
            {
                da.consultacoddes(cod, suc, txtcddescripcion.Text);
            }
            if (mskcdfechad.MaskFull == true && mskcdfechah.MaskFull == true && txtcddireccion.Text == "" && txtcddescripcion.Text == "" && txtcdcodigo.Text != "")
            {
                fed = Convert.ToDateTime(mskcdfechad.Text);
                feh = Convert.ToDateTime(mskcdfechah.Text);
                da.consultacodfec(cod,suc,fed, feh);
            }
            if (txtcddireccion.Text != "" && txtcdcodigo.Text == "" && txtcddescripcion.Text == "" && mskcdfechad.MaskFull == true && mskcdfechah.MaskFull == true)
            {
                fed = Convert.ToDateTime(mskcdfechad.Text);
                feh = Convert.ToDateTime(mskcdfechah.Text);
                da.consultadirfec(txtcddireccion.Text,fed,feh);
            }
            if (txtcddescripcion.Text != "" && txtcddireccion.Text == "" && txtcdcodigo.Text == "" && mskcdfechad.MaskFull == true && mskcdfechah.MaskFull == true)
            {
                fed = Convert.ToDateTime(mskcdfechad.Text);
                feh = Convert.ToDateTime(mskcdfechah.Text);
                da.consultadesfec(txtcddescripcion.Text,fed,feh);
            }
            if (txtcddireccion.Text != "" && txtcdcodigo.Text == "" && txtcddescripcion.Text != "" && mskcdfechad.MaskFull == false && mskcdfechah.MaskFull == false)
            {
                da.consultadirdes(txtcddireccion.Text, txtcddescripcion.Text);
            }
            if (txtcdcodigo.Text != "" && txtcddescripcion.Text != "" && txtcddireccion.Text != "" && mskcdfechad.MaskFull == false && mskcdfechah.MaskFull == false)
                da.consultacoddirdes(cod, suc, txtcddireccion.Text, txtcddescripcion.Text);
            if (txtcdcodigo.Text != "" && txtcddescripcion.Text == "" && txtcddireccion.Text != "" && mskcdfechad.MaskFull == true && mskcdfechah.MaskFull == true)
            {
                fed = Convert.ToDateTime(mskcdfechad.Text);
                feh = Convert.ToDateTime(mskcdfechah.Text);
                da.consultacoddirfec(cod, suc, txtcddireccion.Text, fed, feh);
            }
            if (txtcdcodigo.Text != "" && txtcddescripcion.Text != "" && txtcddireccion.Text == "" && mskcdfechad.MaskFull == true && mskcdfechah.MaskFull == true)
            {
                fed = Convert.ToDateTime(mskcdfechad.Text);
                feh = Convert.ToDateTime(mskcdfechah.Text);
                da.consultacoddesfec(cod, suc, txtcddescripcion.Text, fed, feh);
            }
            if (txtcdcodigo.Text == "" && txtcddescripcion.Text != "" && txtcddireccion.Text != "" && mskcdfechad.MaskFull == true && mskcdfechah.MaskFull == true)
            {
                fed = Convert.ToDateTime(mskcdfechad.Text);
                feh = Convert.ToDateTime(mskcdfechah.Text);
                da.consultadirdesfec(txtcddireccion.Text, txtcddescripcion.Text, fed, feh);
            }

            foreach (direccionesweb dw in da.dirweb)
            {
                DataRow row = dt.NewRow();
                row["CODIGO"] = dw.diw_cod;
                row["DIRECCION"] = dw.diw_dir;
                row["DESCRIPCION"] = dw.diw_des;
                row["FECHA"] = dw.diw_fec;
                dt.Rows.Add(row);
            }                     
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            string boton = "";
            boton = ((Button)sender).Text;
            logica lo = new logica();
            lo.consultadirecciones(txtcdcodigo.Text, txtcddireccion.Text, txtcddescripcion.Text, txtcdfechad.Text, txtcdfechah.Text, boton);
            
        }

        private void Txtcddireccion_TextChanged(object sender, EventArgs e)
        {

        }

        private void TableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Consultadedirecciones_Load(object sender, EventArgs e)
        {
            dt = new DataTable();
            dt.Columns.Add("CODIGO");
            dt.Columns.Add("DIRECCION");
            dt.Columns.Add("DESCRIPCION");
            dt.Columns.Add("FECHA");
            dgvdir.DataSource = dt;

            dgvdir.Columns["CODIGO"].Width = 77;
            dgvdir.Columns["DIRECCION"].Width = 227;
            dgvdir.Columns["DESCRIPCION"].Width = 227;
            dgvdir.Columns["FECHA"].Width = 77;            
            dgvdir.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvdir.ColumnHeadersDefaultCellStyle.BackColor = Color.Black;
            dgvdir.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvdir.ColumnHeadersDefaultCellStyle.Font = new Font("Tahoma", 12, FontStyle.Bold);
            dgvdir.AllowUserToAddRows = false;            
        }

        private void Dgvdir_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Mskcdfechah_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void Btncdcancelar_Click(object sender, EventArgs e)
        {
            txtcdcodigo.Text = "";
            txtcddireccion.Text = "";
            txtcddescripcion.Text = "";
            mskcdfechad.Text = "";
            mskcdfechah.Text = "";
            dt.Clear();
        }
    }
}
