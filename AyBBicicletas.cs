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
    public partial class AyBBicicletas : Form
    {
        public AyBBicicletas()
        {
            InitializeComponent();
        }

        private void AyBBicicletas_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dBProyectoFinalJaune22DataSet5.Cliente' Puede moverla o quitarla según sea necesario.
            this.clienteTableAdapter.Fill(this.dBProyectoFinalJaune22DataSet5.Cliente);
            // TODO: esta línea de código carga datos en la tabla 'dBProyectoFinalJaune22DataSet5.BicicletaXs' Puede moverla o quitarla según sea necesario.
            this.bicicletaXsTableAdapter.Fill(this.dBProyectoFinalJaune22DataSet5.BicicletaXs);
            // TODO: esta línea de código carga datos en la tabla 'dBProyectoFinalJaune22DataSet5.Bicicleta' Puede moverla o quitarla según sea necesario.
            this.bicicletaTableAdapter.Fill(this.dBProyectoFinalJaune22DataSet5.Bicicleta);

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            int idCliente, edad;
            string nomCliente, tipoBici, tipoMetodo;
            idCliente = int.Parse(idClienteTxt.Text);
            edad = int.Parse(edadTxt.Text);
            nomCliente = nomTxt.Text;
            tipoMetodo = tipoMCbx.Text;
            tipoBici = BiciCBX.Text;
            this.clienteTableAdapter.Insert(idCliente,nomCliente,edad,tipoMetodo, tipoBici);
            MessageBox.Show("Registro Guardado Exitosamente");
            clienteDataGridView.Refresh();
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            int idCliente, edad;
            string nomCliente, tipoBici, tipoMetodo;
            idCliente = int.Parse(idClienteTxt.Text);
            edad = int.Parse(edadTxt.Text);
            nomCliente = nomTxt.Text;
            tipoMetodo = tipoMCbx.Text;
            tipoBici = BiciCBX.Text;
            this.clienteTableAdapter.Delete(idCliente, nomCliente, edad, tipoMetodo, tipoBici);
            MessageBox.Show("Registro Eliminado Exitosamente");
            clienteDataGridView.Refresh();
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
