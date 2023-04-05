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
    public partial class GestionRenta : Form
    {
        public GestionRenta()
        {
            InitializeComponent();
        }

        private void GestionRenta_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dBProyectoFinalJaune22DataSet7.Bicicleta' Puede moverla o quitarla según sea necesario.
            this.bicicletaTableAdapter.Fill(this.dBProyectoFinalJaune22DataSet7.Bicicleta);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            BicicletasT bicicletasT = new BicicletasT();
            this.Hide();
            bicicletasT.Show();
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
