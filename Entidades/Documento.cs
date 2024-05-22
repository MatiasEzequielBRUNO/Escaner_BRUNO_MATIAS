using System.Text;

namespace Entidades
{
    public abstract class Documento
    {

        //atributos de la clase

        int anio;
        string autor;
        string barcode;
        Paso estado;
        string numNormalizado;
        string titulo;

        public enum Paso
        {
            Inicio,
            Distribuido,
            EnEscaner,
            EnRevision,
            Terminado
        }

        //Propiedades de la clase

        public string Titulo { get => titulo; }
        public int Anio { get => anio; }
        public string Autor { get => autor; }
        public string Barcode { get => barcode; }
        public Paso Estado { get => estado; }
        protected string NumNormalizado { get => numNormalizado; } //lo quiero solo disponible desde las clases derivadas

        //constructor de la clase
        protected Documento(int anio, string autor, string barcode, string numNormalizado, string titulo)
        {
            this.anio = anio;
            this.autor = autor;
            this.barcode = barcode;
            this.estado = Paso.Inicio;
            this.numNormalizado = numNormalizado;
            this.titulo = titulo;
        }

        //Este metodo avanza el estado en que se encuentra un documento, en caso de que haya terminado retorna un False y no te deja avanzar mas el estado
        public bool AvanzarEstado()
        {
            if (this.Estado == Paso.Terminado)
            {
                return false;
            }
            else
            {
                this.estado++;
                return true;
            }
        }

        public override string ToString()
        {
            StringBuilder texto = new StringBuilder();
            texto.AppendLine($"Título: {titulo}");
            texto.AppendLine($"Autor: {autor}");
            texto.AppendLine($"Año: {anio}");

            return texto.ToString();

        }
    }
}
