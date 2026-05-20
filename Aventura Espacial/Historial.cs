using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aventura_Espacial
{
    public partial class Historial : Form
    {
        public Historial()
        {
            InitializeComponent();
        }

        private void Historial_Load(object sender, EventArgs e)
        {

        }

        private void regresar_Click(object sender, EventArgs e)
        {
            this.Close(); 
        }

        private void listBoxHistorial_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnVerHistorialInterno_Click(object sender, EventArgs e)
        {
            // Se limpia el listBox para evitar duplicados cada vez que se presione el botón
            listBoxHistorial.Items.Clear();

            // Definimos la ruta del archivo de texto que contiene el historial de misiones
            string rutaArchivo = "historial.txt";

            // Se valida si el archivo físico existe en la computadora
            if (!File.Exists(rutaArchivo))
            {
                MessageBox.Show("El historial está vacío", "Bitácora Vacía", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            try
            {
                // Archivo en modo lectura
                using (StreamReader sr = new StreamReader(rutaArchivo))
                {
                    string lineaLeida;

                    // Bucle while para leer línea por línea el archivo hasta el final
                    while ((lineaLeida = sr.ReadLine()) != null)
                    {
                        listBoxHistorial.Items.Add(lineaLeida);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al leer el historial: " + ex.Message, "Error Crítico de Archivo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            string rutaArchivo = "historial.txt";
            
            DialogResult respuesta = MessageBox.Show("¿Estás seguro de que deseas eliminar de forma permanente todo el historial de exploración?",
                "⚠️ ADVERTENCIA", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (respuesta == DialogResult.Yes)
            {
                    if (File.Exists(rutaArchivo))
                    {
                        File.Delete(rutaArchivo);
                    }

                    listBoxHistorial.Items.Clear();

                    MessageBox.Show("¡Historial borrado con éxito!", "Bitácora Limpia", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
        }
    }
}
