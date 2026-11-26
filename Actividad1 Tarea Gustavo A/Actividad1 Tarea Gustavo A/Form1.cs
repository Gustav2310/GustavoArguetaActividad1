using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Actividad1_Tarea_Gustavo_A
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            lstEstados.Items.AddRange(new string[] {
                "Aguascalientes", "Baja California", "Baja California Sur", "Campeche",
                "Chiapas", "Chihuahua", "Ciudad de México", "Coahuila", "Colima", "Durango",
                "Estado de México", "Guanajuato", "Guerrero", "Hidalgo", "Jalisco", "Michoacán",
                "Morelos", "Nayarit", "Nuevo León", "Oaxaca", "Puebla", "Querétaro",
                "Quintana Roo", "San Luis Potosí", "Sinaloa", "Sonora", "Tabasco",
                "Tamaulipas", "Tlaxcala", "Veracruz", "Yucatán", "Zacatecas"
            });
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string horario = rbMatutino.Checked ? "Matutino" : rbVespertino.Checked ? "Vespertino" : "Sin seleccionar";
            string estado = lstEstados.SelectedItem != null ? lstEstados.SelectedItem.ToString() : "Sin seleccionar";

            MessageBox.Show(
                "Nombre: " + txtNombre.Text + "\n" +
                "Fecha de nacimiento: " + txtFecha.Text + "\n" +
                "Dirección: " + txtDireccion.Text + "\n" +
                "Estado: " + estado + "\n" +
                "Horario: " + horario,
                "Expediente guardado");
        }
    }
}
