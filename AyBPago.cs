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
    public partial class AyBPago : Form
    {
        public AyBPago()
        {
            InitializeComponent();
        }

        private void AyBPago_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dBProyectoFinalJaune22DataSet4.BPago' Puede moverla o quitarla según sea necesario.
            this.bPagoTableAdapter.Fill(this.dBProyectoFinalJaune22DataSet4.BPago);

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            int clavePago, hraRenta;
            decimal precioRenta;
            string metodo;
            clavePago = int.Parse(cveTxt.Text);
            precioRenta = decimal.Parse(precioCvetxt.Text);
            hraRenta = int.Parse(hraTxt.Text);
            metodo = tipoMCbx.Text;
            this.bPagoTableAdapter.Insert(clavePago,precioRenta ,hraRenta, metodo);
            //hraRenta, precioRenta, clavePago, metodo
            MessageBox.Show("Registro Guardado Exitosamente");
            bPagoDataGridView.Refresh();
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            int clavePago, hraRenta;
            decimal precioRenta;
            string metodo;
            clavePago = int.Parse(cveTxt.Text);         
            precioRenta = decimal.Parse(precioCvetxt.Text);
            hraRenta = int.Parse(hraTxt.Text);
            metodo = tipoMCbx.Text;
            this.bPagoTableAdapter.Delete(clavePago, precioRenta,hraRenta, metodo);
            MessageBox.Show("Registro Eliminado Exitosamente");
            bPagoDataGridView.Refresh();
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
