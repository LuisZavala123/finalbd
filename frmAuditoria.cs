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
    public partial class frmAuditoria : Form
    {
        public frmAuditoria()
        {
            InitializeComponent();
        }

        private void FrmAuditoria_Load(object sender, EventArgs e)
        {
            var lista = new AuditoriaDAO().GetAll();
            dgvAuditoria.Rows.Clear();
            for (int i = 0; i < lista.Count; i++)
            {
                int fila = dgvAuditoria.Rows.Add();
                dgvAuditoria.Rows[fila].Cells[0].Value = lista[i].Tabla;
                dgvAuditoria.Rows[fila].Cells[1].Value = lista[i].Fecha;
                dgvAuditoria.Rows[fila].Cells[2].Value = lista[i].Tipo;
                dgvAuditoria.Rows[fila].Cells[3].Value = lista[i].Valorold;
                dgvAuditoria.Rows[fila].Cells[4].Value = lista[i].ValorNew;
                dgvAuditoria.Rows[fila].Cells[5].Value = lista[i].Usuario;
            }
        }

        private void FrmAuditoria_FormClosing(object sender, FormClosingEventArgs e)
        {
            Form1 main = new Form1();
            main.Show();
        }
    }
}
