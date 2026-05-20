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
    public partial class Explorar : Form
    {
        public Explorar()
        {
            InitializeComponent();
        }
        
        private void Explorar_Load(object sender, EventArgs e)
        {
            // 1. Al abrir la ventana, calculamos el daño del planeta que toca de inmediato
            CalcularDanoAmbiente();

            // 2. Mostramos los datos actualizados en los labels que se ven en tu foto
            ActualizarLabels();
        }

        //metodo para calcular el daño

        private void CalcularDanoAmbiente()
        {
            float temperaturaActual = Inicio.planetas[Inicio.planetaActual].Temperatura;
            bool tieneOxigenoActual = Inicio.planetas[Inicio.planetaActual].TieneOxigeno;

            //daño por falta de oxigeno

            if (tieneOxigenoActual == false)
            {
                Inicio.danoAcumulado += 15f;
            }

            //daño por temperaturas extremas

            if (temperaturaActual > 100 || temperaturaActual < -50)
            {
                Inicio.danoAcumulado += 20f;
            }

            // validar si se pierde daño critico (100 o mas %)

            if (Inicio.danoAcumulado >= 100)
            {
                Planeta.Image = Properties.Resources.explosion;
                MessageBox.Show("¡¡CRÍTICO!! La nave ha colapsado por las condiciones extremas", "SISTEMA DAÑADO", MessageBoxButtons.OK, MessageBoxIcon.Error);

                // se reinician valores

                Inicio.danoAcumulado = 100f;
                
                // Le avisamos en el label de daño que la nave pasó a mejor vida
                lblDano.Text = "DESTRUIDA (100%)";
            }
        }
        private void ActualizarLabels()
        {
            if (lblDano.Text == "DESTRUIDA (100%)") return;

            lblNombrePlaneta.Text = Inicio.planetas[Inicio.planetaActual].Nombre;
            lblTemperatura.Text = Inicio.planetas[Inicio.planetaActual].Temperatura.ToString() + "°C";

            if (Inicio.planetas[Inicio.planetaActual].TieneOxigeno)
            {
                lblOxigeno.Text = "Oxigeno disponible";
            }
            else
            {
                lblOxigeno.Text = "Oxigeno no disponible ¡PELIGRO!";
            }

            //mostrando daño acumulado en el label
            lblDano.Text = Inicio.danoAcumulado + "%";

            // Se cambia la imágen del planeta dependiendo del índice global del planeta actual, que se actualiza al regresar
            switch (Inicio.planetaActual)
            {
                case 0:
                    Planeta.Image = Properties.Resources.marte;
                    break;
                case 1:
                    Planeta.Image = Properties.Resources.venus;
                    break;
                case 2:
                    Planeta.Image = Properties.Resources.jupiter;
                    break;
                case 3:
                    Planeta.Image = Properties.Resources.saturno;
                    break;
                case 4:
                    Planeta.Image = Properties.Resources.mercurio;
                    break;
                default:
                    Planeta.Image = null; // Por si ocurre un caso inesperado
                    break;
            }
        }

        private unsafe void CalcularDano(float temperatura, float* dano)
        {
            if (temperatura > 100)
            {
                *dano += 25f; //sumamos 25% directamente en la memoria 
            }
            else if (temperatura < -50)
            {
                *dano += 15f; //sumando 15% de daño
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void regresar_Click(object sender, EventArgs e)
        {
            //antes de volver, se prepara para el siguiente viaje a otro planeta
            if (lblDano.Text == "DESTRUIDA (100%)")
            {
                this.Close();
                return;
            }

            // Se capturan los datos actuales antes de mover los contadores
            string planetaNombre = Inicio.planetas[Inicio.planetaActual].Nombre;
            float temp = Inicio.planetas[Inicio.planetaActual].Temperatura;
            float danoTotal = Inicio.danoAcumulado;

            Inicio.GuardarEnBitacora(planetaNombre, temp, danoTotal);

            if (Inicio.planetaActual == 4 && Inicio.danoAcumulado > 0) //si ya se completaron todos
            {
                MessageBox.Show("¡Felicidades! Has completado la exploración");
                Inicio.planetaActual = 0;
                Inicio.danoAcumulado = 0;
            }
            else if (Inicio.danoAcumulado > 0)
            {
                //avanzamos el indice global para q cargue el siguiente planeta
                Inicio.planetaActual++;
            }

            this.Close(); //cerrando y volviendo, limpiando al form1
        }

        private void lblNombrePlaneta_Click(object sender, EventArgs e)
        {

        }

        private void lblTemperatura_Click(object sender, EventArgs e)
        {

        }

        private void lblOxigeno_Click(object sender, EventArgs e)
        {

        }

        private void lblDano_Click(object sender, EventArgs e)
        {

        }

        private void Planetas_Click(object sender, EventArgs e)
        {

        }
    }
}
