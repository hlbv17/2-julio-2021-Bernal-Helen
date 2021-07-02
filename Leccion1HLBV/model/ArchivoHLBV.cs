using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Leccion1HLBV.model
{
    class ArchivoHLBV
    {
        private string extension;
        private string nombre;
        private int capacidad;

        public string Extension { get => extension; set => extension = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public int Capacidad { get => capacidad; set => capacidad = value; }

        public ArchivoHLBV()
        {
            this.extension = "";
            this.nombre = "";
            this.capacidad = 0;
        }

        public ArchivoHLBV(string nombre,string extension, int capacidad)
        {
            Nombre = nombre;
            Extension = extension;
            Capacidad = capacidad;
        }

        public override string ToString()
        {
            return "Nombre del archivo: "+nombre+" Extensión: "+extension+ " Capacidad: "+capacidad;
        }

        public virtual double CalcularMegas(int capacidad)
        {
            return capacidad/1000;
        }
    }
}
