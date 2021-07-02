using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Leccion1HLBV.model
{
    class ArchivoAudioHLBV :  ArchivoHLBV
    {
        private int tiempo;

        public int Tiempo { get => tiempo; set => tiempo = value; }

        public ArchivoAudioHLBV() : base()
        {
            this.tiempo = 0;
        }

        public ArchivoAudioHLBV(int tiempo, string nombre, string extension, int capacidad) : base(nombre, extension, capacidad)
        {
            Tiempo = tiempo;
        }

        public override string ToString()
        {
            return base.ToString()+" Tiempo: "+tiempo;
        }

        public double CalcularHorasMin()
        {
            return 0.0;
        }

        public override double CalcularMegas(int capacidad)
        {
            return base.CalcularMegas(capacidad);   
        }
    }
}
