using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ubicaciones.modelo
{
    class ubicacion
    {
        private double altitude;
        private double longitude;
        private double magnitude;

        public ubicacion(double altitude, double longitude, double magnitude)
        {
            this.altitude = altitude;
            this.longitude = longitude;
            this.magnitude = magnitude;
            
        }

        public double altitude1 { get => altitude; set => altitude = value; }
        public double longitude1 { get => longitude; set => longitude = value; }
        public double magnitude1 { get => magnitude; set => magnitude = value; }


    }
}
