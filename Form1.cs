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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pROCESAMIENTODEPAGOSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pROCESAMIENTODEPAGOSToolStripMenuItem.ForeColor = (Color.Green);
           
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void gESTIONDEVENTASToolStripMenuItem_Click(object sender, EventArgs e)
        {
            gESTIONDEVENTASToolStripMenuItem.ForeColor = (Color.Green);
        }

        private void actualizarYBorrarDatosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AyBPago ayBPago = new AyBPago();
            this.Hide();
            ayBPago.Show();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void visualizadorDeDatosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void procesamientoDePagoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            GestionRenta gestionRenta = new GestionRenta();
            this.Hide();
            gestionRenta.Show();
        }

        private void visualizadorDeDatosToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            ProcesamientoDePago procesamientoDePago = new ProcesamientoDePago();
            this.Hide();
            procesamientoDePago.Show();
        }

        private void procesamientoDePagoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Visualizador_de_Gestion_bicicletas visualizador_De_Gestion_Bicicletas = new Visualizador_de_Gestion_bicicletas();
            this.Hide();
            visualizador_De_Gestion_Bicicletas.Show();
            
        }

        private void sALIRToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult s = MessageBox.Show("SEGURO QUE QUIERES SALIR??", "SALIENDO DEL PROGRAMA", MessageBoxButtons.YesNo);

            if (s == DialogResult.Yes)
            {
                Application.Exit();
            }
            sALIRToolStripMenuItem.ForeColor = (Color.Green);

        }

        private void actualizarYBorrarDatosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            AyBBicicletas ayB = new AyBBicicletas();
            this.Hide();
            ayB.Show();
        }

        private void gESTIONDEBICICLETASToolStripMenuItem_Click(object sender, EventArgs e)
        {
            gESTIONDEBICICLETASToolStripMenuItem.ForeColor = (Color.Green);
        }

        private void aCERCADENOSTROSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            aCERCADENOSTROSToolStripMenuItem.ForeColor = (Color.Green);
        }

        private void visualizadorDeRentaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            gestion_de_ventas gestion_De_Ventas = new gestion_de_ventas();
            this.Hide();
            gestion_De_Ventas.Show();
        }

        private void teamJAUNEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Acerca_de_Nosotros acerca_De_Nosotros = new Acerca_de_Nosotros();
            this.Hide();
            acerca_De_Nosotros.Show();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
