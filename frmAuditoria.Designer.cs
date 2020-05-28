namespace examenu6
{
    partial class frmAuditoria
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgvAuditoria = new System.Windows.Forms.DataGridView();
            this.Tabla = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ValorAnterior = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valornuevo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Usuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAuditoria)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvAuditoria
            // 
            this.dgvAuditoria.AllowUserToAddRows = false;
            this.dgvAuditoria.AllowUserToDeleteRows = false;
            this.dgvAuditoria.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAuditoria.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Tabla,
            this.Fecha,
            this.Tipo,
            this.ValorAnterior,
            this.valornuevo,
            this.Usuario});
            this.dgvAuditoria.Location = new System.Drawing.Point(13, 13);
            this.dgvAuditoria.Name = "dgvAuditoria";
            this.dgvAuditoria.ReadOnly = true;
            this.dgvAuditoria.Size = new System.Drawing.Size(727, 284);
            this.dgvAuditoria.TabIndex = 0;
            // 
            // Tabla
            // 
            this.Tabla.HeaderText = "Tabla";
            this.Tabla.Name = "Tabla";
            this.Tabla.ReadOnly = true;
            // 
            // Fecha
            // 
            this.Fecha.HeaderText = "Fecha";
            this.Fecha.Name = "Fecha";
            this.Fecha.ReadOnly = true;
            // 
            // Tipo
            // 
            this.Tipo.HeaderText = "Tipo";
            this.Tipo.Name = "Tipo";
            this.Tipo.ReadOnly = true;
            // 
            // ValorAnterior
            // 
            this.ValorAnterior.HeaderText = "Valor Anterior";
            this.ValorAnterior.Name = "ValorAnterior";
            this.ValorAnterior.ReadOnly = true;
            // 
            // valornuevo
            // 
            this.valornuevo.HeaderText = "Valor Nuevo";
            this.valornuevo.Name = "valornuevo";
            this.valornuevo.ReadOnly = true;
            // 
            // Usuario
            // 
            this.Usuario.HeaderText = "Usuario";
            this.Usuario.Name = "Usuario";
            this.Usuario.ReadOnly = true;
            // 
            // frmAuditoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(752, 309);
            this.Controls.Add(this.dgvAuditoria);
            this.Name = "frmAuditoria";
            this.Text = "frmAuditoria";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmAuditoria_FormClosing);
            this.Load += new System.EventHandler(this.FrmAuditoria_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAuditoria)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvAuditoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tabla;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ValorAnterior;
        private System.Windows.Forms.DataGridViewTextBoxColumn valornuevo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Usuario;
    }
}