using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace examenu6
{
    public partial class frmEditar : Form
    {
        MProducto Pr;
        public frmEditar(MProducto zxz)
        {
            InitializeComponent();
            Pr = zxz;
            //Ini();
        }
        public void Ini()
        {
            this.txtNombre.Text = Pr.Nombre;
            this.txtDescripcion.Text = Pr.Descripcion;
            this.txtPrecio.Text = Pr.precio.ToString();
            this.txtStock.Text = Pr.Strock.ToString();

        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            ProductoDAO PD = new ProductoDAO();
            try
            {
                PD.Editar(Pr.Clave.ToString(), txtNombre.Text, txtDescripcion.Text, double.Parse(txtPrecio.Text), int.Parse(txtStock.Text));

            }
            catch (Exception)
            {

            }
            
            Form1 main = new Form1();
            this.Close();
            
        }

        private void frmEditar_FormClosing(object sender, FormClosingEventArgs e)
        {
            Form1 main = new Form1();
            main.Show();
        }

        private void frmEditar_Load(object sender, EventArgs e)
        {
            Ini();
        }
    }
}
