using Leccion1HLBV.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Leccion1HLBV.control
{
    class AdmArchivoAudioHLBV
    {
        ValidacionHLBV v = new ValidacionHLBV();
        List<ArchivoAudioHLBV> lista = new List<ArchivoAudioHLBV>();
        

        internal bool EsCorrecto(string nombre, string extension, string capacidad, string tiempo)
        {
            bool x = true;
            if (String.IsNullOrEmpty(nombre) && String.IsNullOrEmpty(extension) && String.IsNullOrEmpty(capacidad)
                && String.IsNullOrEmpty(tiempo) && v.EsEntero(capacidad) && v.EsEntero(tiempo))
            {
                x = true;
            }
            return x;
        }

        internal int IndexExtensionEncontrada(string extension)
        {
            int n = 0;
            n = lista.FindIndex(x => x.Extension == extension);
            return n;
        }

        internal void Mayor(Label lblMayor)
        {
            int num = 0,n;
            n = lista.Max(x => x.Capacidad);
            num = lista.FindIndex(x => x.Capacidad == n);
            lblMayor.Text = lista[num].ToString();
        }

        internal void Menor(Label lblMenor)
        {
            int num = 0, n;
            n = lista.Min(x => x.Capacidad);
            num = lista.FindIndex(x => x.Capacidad == n);
            lblMenor.Text = lista[num].ToString();
        }

        internal void TotalExtension(Label lblTotalMp3, Label lblTotalAu, Label lblTotalWav)
        {
            int a = 0, b = 0, c = 0;
            foreach(ArchivoHLBV ar in lista)
            {
                if (ar.Extension.Equals("mp3"))
                {
                    a++;
                }else if(ar.Extension.Equals("au"))
                {
                    b++;
                }else if(ar.Extension.Equals("wav"))
                {
                    c++;
                }
                
            }
            lblTotalMp3.Text = a + "";
            lblTotalAu.Text = b + "";
            lblTotalWav.Text = c + "";
        }

        internal void CalcularMb(Label lblMegas)
        {
            double n = 0.0;
            //int iCapacidad = v.AEntero(capacidad);
            ArchivoAudioHLBV aa = null;
            foreach (ArchivoHLBV a in lista)
            {
                aa = (ArchivoAudioHLBV)a;  //downcasting
                n = aa.CalcularMegas();
            }
            lblMegas.Text = n + "";
        }

        internal void Guardar(string nombre, string extension, string capacidad, string tiempo)
        {
            int iCapacidad = v.AEntero(capacidad), iTiempo = v.AEntero(tiempo);
            ArchivoAudioHLBV aa = null;
            aa = new ArchivoAudioHLBV(iTiempo, nombre, extension, iCapacidad);
            aa.CalcularMegas();
            lista.Add(aa);
        }

        internal void LlenarGrid(DataGridView dgvArchivo, Label lblTotal)
        {
            int i = 1;
            ArchivoAudioHLBV aa = null;
            foreach (ArchivoHLBV a in lista)
            {
                aa = (ArchivoAudioHLBV)a;
                dgvArchivo.Rows.Add(i, a.Nombre, a.Extension, a.Capacidad, aa.Tiempo);
                i++;
            }
            lblTotal.Text = (i - 1) + "";
        }


    }
}
