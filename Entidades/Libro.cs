using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Libro : Documento
    {
        //Atributos 

        int numPaginas;

        //Propiedades

        protected string ISBN { get => NumNormalizado; }
        protected int NumPaginas { get => numPaginas; }

        //Constructor con herencia de la clase padre Documento
        public Libro (int anio, string autor, string barcode, string numNormalizado, string titulo, int numPaginas)
        :base (anio, autor, barcode, numNormalizado, titulo)
        {
            this.numPaginas = numPaginas;
        }

        public override string ToString()
        {
            StringBuilder texto = new StringBuilder();
            texto.Append(base.ToString()); // Datos heredados de Documento
            texto.AppendLine($"ISBN: {NumNormalizado}");
            texto.AppendLine($"Cód. de barras: {Barcode}");
            texto.AppendLine($"Número de páginas: {numPaginas}");

            return texto.ToString();
        }



    }
}
