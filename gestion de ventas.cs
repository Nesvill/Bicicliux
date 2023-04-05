using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROYECTOFINALBICICLIUX
{
    public partial class gestion_de_ventas : Form
    {
        public gestion_de_ventas()
        {
            InitializeComponent();
        }

        private void gestion_de_ventas_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dBProyectoFinalJauneIDataSet.BPago' Puede moverla o quitarla según sea necesario.
            this.bPagoTableAdapter.Fill(this.dBProyectoFinalJauneIDataSet.BPago);
            // TODO: esta línea de código carga datos en la tabla 'dBProyectoFinalJauneIDataSet.Cliente' Puede moverla o quitarla según sea necesario.
            this.clienteTableAdapter.Fill(this.dBProyectoFinalJauneIDataSet.Cliente);
            // TODO: esta línea de código carga datos en la tabla 'dBProyectoFinalJauneIDataSet.BEfectivo' Puede moverla o quitarla según sea necesario.
            this.bEfectivoTableAdapter.Fill(this.dBProyectoFinalJauneIDataSet.BEfectivo);
            // TODO: esta línea de código carga datos en la tabla 'dBProyectoFinalJaune22DataSet.Cliente' Puede moverla o quitarla según sea necesario.
            //this.clienteTableAdapter.Fill(this.dBProyectoFinalJaune22DataSet.Cliente);
            // TODO: esta línea de código carga datos en la tabla 'dBProyectoFinalJauneIDataSet.Cliente' Puede moverla o quitarla según sea necesario.
            this.clienteTableAdapter.Fill(this.dBProyectoFinalJauneIDataSet.Cliente);

        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            this.Hide();
            form1.Show();

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            DialogResult s = MessageBox.Show("SEGURO QUE QUIERES SALIR??", "SALIENDO DEL PROGRAMA", MessageBoxButtons.YesNo);

            if (s == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
