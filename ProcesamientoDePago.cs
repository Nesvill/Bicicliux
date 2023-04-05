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
    public partial class ProcesamientoDePago : Form
    {
        public ProcesamientoDePago()
        {
            InitializeComponent();
        }

        private void ProcesamientoDePago_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dBProyectoFinalJaune22DataSet2.BPago' Puede moverla o quitarla según sea necesario.
            this.bPagoTableAdapter.Fill(this.dBProyectoFinalJaune22DataSet2.BPago);

        }

        private void bPagoDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {

            DialogResult s = MessageBox.Show("SEGURO QUE QUIERES SALIR??", "SALIENDO DEL PROGRAMA", MessageBoxButtons.YesNo);

            if (s == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {

            Form1 form1 = new Form1();
            this.Hide();
            form1.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click_1(object sender, EventArgs e)
        {

        }
    }
}
