using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aventura_Espacial
{
    public partial class Reparar : Form
    {
        public Reparar()
        {
            InitializeComponent();
            // Al abrir la ventana, le mostramos al usuario cuánto daño tiene desde el  
            //almacén central

            lblDanoActual.Text = "Daño Crítico Actual: " + Inicio.danoAcumulado.ToString();
        }

        private void regresar_Click(object sender, EventArgs e)
        {
            this.Close(); // Cierra la ventana de reparación y vuelve a la ventana anterior (Inicio)
        }

        private void reparacion_Click(object sender, EventArgs e)
        {
            // Modifica directamente el almacén central devolviendo el daño a 0
            Inicio.danoAcumulado = 0;

            // Actualiza la interfaz visual para que el usuario vea que funcionó
            lblDanoActual.Text = "Daño Crítico Actual: 0 (Sistemas Estables)";
            MessageBox.Show("🔧 ¡Sistemas reparados con éxito!");
        }
    }
}
