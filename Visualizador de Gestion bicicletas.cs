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
    public partial class Visualizador_de_Gestion_bicicletas : Form
    {
        public Visualizador_de_Gestion_bicicletas()
        {
            InitializeComponent();
        }

        private void Visualizador_de_Gestion_bicicletas_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dBProyectoFinalJaune22DataSet6.Cliente' Puede moverla o quitarla según sea necesario.
            this.clienteTableAdapter.Fill(this.dBProyectoFinalJaune22DataSet6.Cliente);
            // TODO: esta línea de código carga datos en la tabla 'dBProyectoFinalJaune22DataSet3.Bicicleta' Puede moverla o quitarla según sea necesario.
            //this.bicicletaTableAdapter.Fill(this.dBProyectoFinalJaune22DataSet3.Bicicleta);

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

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }
    }
}
