using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Mapa : Documento
    {
        //Atributos 
        int alto;
        int ancho;

        //Propiedad
        protected int Alto { get => alto; }
        protected int Ancho { get => ancho; }

        protected int Superficie
        {
            get
            {
                return Alto * Ancho;
            }   
        }

        //Constructor
        public Mapa(int anio, string autor, string barcode, string numNormalizado, string titulo, int alto, int ancho)
        : base(anio, autor, barcode, numNormalizado, titulo)
        {
            this.alto = alto;
            this.ancho = ancho;
        }
        public override string ToString()
        {
            StringBuilder texto = new StringBuilder();
            texto.Append(base.ToString()); // Datos heredados de Documento
            texto.AppendLine($"Cód. de barras: {Barcode}");
            texto.AppendLine($"Ancho del mapa: {ancho}");
            texto.AppendLine($"Superficie {alto} * {ancho}: {Superficie} cm2");

            return texto.ToString();
        }

    }
}
