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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var lista = new ProductoDAO().GetAll();
            dgvProductos.Rows.Clear();
            for (int i=0;i<lista.Count;i++)
            {
                int fila = dgvProductos.Rows.Add();
                dgvProductos.Rows[fila].Cells[0].Value = lista[i].Nombre;
                dgvProductos.Rows[fila].Cells[1].Value = lista[i].Descripcion;
                dgvProductos.Rows[fila].Cells[2].Value = lista[i].precio;
                dgvProductos.Rows[fila].Cells[3].Value = lista[i].Strock;
            }
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmAgregarProducto frm = new frmAgregarProducto();
            frm.Show();
            
        }

        private void BtnAuditoria_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmAuditoria frm = new frmAuditoria();
            frm.Show();
        }
    }
}
