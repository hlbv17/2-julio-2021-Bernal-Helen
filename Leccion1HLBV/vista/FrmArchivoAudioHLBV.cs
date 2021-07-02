using Leccion1HLBV.control;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Leccion1HLBV
{
    public partial class FrmArchivoAudioHLBV : Form
    {

        AdmArchivoAudioHLBV admAA = new AdmArchivoAudioHLBV();
        ValidacionHLBV v = new ValidacionHLBV();

        public FrmArchivoAudioHLBV()
        {
            InitializeComponent();
        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            char c = e.KeyChar;
            if (char.IsDigit(c) && c != ' ' && (e.KeyChar != Convert.ToChar(Keys.Back)))
            {
                e.Handled = true;
                return;
            }
        }

        private void txtCapacidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            char c = e.KeyChar;
            if (char.IsLetter(c) && c != ' ' && (e.KeyChar != Convert.ToChar(Keys.Back)))
            {
                e.Handled = true;
                return;
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text.Trim(), extension = cmbTipo.Text, capacidad = txtCapacidad.Text,
                tiempo = txtTiempo.Text;
            int iTiempo = v.AEntero(tiempo);
            if (admAA.EsCorrecto(nombre, extension, capacidad, tiempo))
            {
                lblMayor.Text = "";
                lblMenor.Text = "";
                admAA.Guardar(nombre, extension, capacidad, tiempo);
                admAA.CalcularMb(capacidad, lblMegas);
                admAA.LlenarGrid(dgvArchivo, lblTotal);
                admAA.TotalExtension(lblTotalMp3, lblTotalAu, lblTotalWav);
                admAA.Mayor(lblMayor);
                admAA.Menor(lblMenor);
            }
        }
    }
}
