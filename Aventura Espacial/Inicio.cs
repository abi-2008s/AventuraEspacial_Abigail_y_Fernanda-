using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Aventura_Espacial
{
    // Estructura para los planetas
    public struct Planeta
    {
        public string Nombre;
        public float Temperatura;
        public bool TieneOxigeno;

        public static Bitmap Image { get; internal set; }
    }

    public partial class Inicio : Form
    {
        public static Planeta[] planetas = new Planeta[5];
        public static float danoAcumulado = 0;
        public static int planetaActual = 0;

        public static void GuardarEnBitacora(string planeta, float temperatura, float dano)
        {
            string nombreArchivo = "historial.txt";
            try
            {
                string fecha = DateTime.Now.ToString("dd/MM/yyyy");

                string lineaLog = $"[{fecha}] Explorado: {planeta} - Temperatura: {temperatura.ToString("F1")}°C - Daño acumulado: {dano.ToString("F1")}%";

                using (StreamWriter sw = new StreamWriter(nombreArchivo, true))
                {
                    sw.WriteLine(lineaLog);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al registrar en la bitácora: " + ex.Message, "Error de Archivo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        public Inicio()
        {
            InitializeComponent();
            InicializarPlanetas(); // Se ejecuta al arrancar el programa

        }

        private void InicializarPlanetas()
        {
            planetas[0].Nombre = "Mercurio";
            planetas[0].Temperatura = 430;
            planetas[0].TieneOxigeno = true;

            planetas[1].Nombre = "Venus";
            planetas[1].Temperatura = 464;
            planetas[1].TieneOxigeno = true;

            planetas[2].Nombre = "Marte";
            planetas[2].Temperatura = -65;
            planetas[2].TieneOxigeno = false;

            planetas[3].Nombre = "Saturno";
            planetas[3].Temperatura = -178;
            planetas[3].TieneOxigeno = false;

            planetas[4].Nombre = "Júpiter";
            planetas[4].Temperatura = -110;
            planetas[4].TieneOxigeno = true;
        }


        private void Inicio_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void explorarboton_Click(object sender, EventArgs e)
        {
            Explorar ventanaExplorar = new Explorar();
            this.Hide(); // Oculta el menu principal 
            ventanaExplorar.ShowDialog();
            this.Show(); // Vuelve a mostrar el menu principal después de cerrar la ventana de explorar
        }

        private void repararboton_Click(object sender, EventArgs e)
        {
            Reparar ventanaReparar = new Reparar();
            this.Hide(); // Oculta el menu principal 
            ventanaReparar.ShowDialog();
            this.Show();
        }

        private void historialboton_Click(object sender, EventArgs e)
        {
            Historial ventanaHistorial = new Historial();
            this.Hide(); // Oculta el menu principal 
            ventanaHistorial.ShowDialog();
            this.Show();
        }

        private void Inicio_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit(); 
        }
    }
}
