using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace examenu6
{
    public partial class frmAgregarProducto : Form
    {
        String fallo = "No se puede ingresar este producto porque:\n";
        public frmAgregarProducto()
        {
            InitializeComponent();
        }

        private void BtnAceptar_Click(object sender, EventArgs e)
        {
            if (comprovar())
            {
                new ProductoDAO().Agregar(new MProducto(0, txtNombre.Text, txtDescripcion.Text, double.Parse(txtPrecio.Text), int.Parse(txtStock.Text)));
                this.Close();
            }
            
        }

        private Boolean comprovar(){
            String Nombre="[A-Z|a-z]+";
            String Precio = "[0-9]+([.][0-9]+)?";
            String Numero = "[0-9]+";
            String tempfallo = fallo;

            if (!Regex.IsMatch(txtNombre.Text,Nombre))
            {
                fallo = fallo+" el nombre no es valido, ";
            }
            if (!Regex.IsMatch(txtPrecio.Text, Precio))
            {
                fallo = fallo + " el Precio no es valido, ";
            }
            if (!Regex.IsMatch(txtStock.Text, Numero))
            {
                fallo = fallo + " el Stock no es valido, ";
            }

            if (tempfallo.Equals(fallo))
            {
                fallo = tempfallo;
                return true;
            }
            else {
                MessageBox.Show(fallo);
                fallo = tempfallo;
                return false;
            }
            
        }

        private void FrmAgregarProducto_FormClosing(object sender, FormClosingEventArgs e)
        {
            Form1 main = new Form1();
            main.Show();
        }
    }
}
