using Entidades;

namespace Test
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Que tipo de documento desea ingresar? Libro (L) o Mapa (M)");
                string? tipoDeDocumento = Console.ReadLine();

                string titulo = IngresoDatos.String("Ingrese el título del documento");
                int anio = IngresoDatos.Int("Ingrese el Año del documento");
                string autor = IngresoDatos.String("Ingrese el autor del documento");
                string barcode = IngresoDatos.String("Ingrese el Barcode");


                if (tipoDeDocumento == "L" || tipoDeDocumento == "l")
                {

                    string numNormalizado = IngresoDatos.String("Ingrese el numero normalizado");
                    int numPaginas = IngresoDatos.Int("Ingrese el número de páginas del libro");

                    Entidades.Libro libro1 = new Entidades.Libro(anio, autor, barcode, numNormalizado, titulo, numPaginas);
                    string texto = libro1.ToString();
                    Console.WriteLine(texto);
                }
                else if (tipoDeDocumento == "M" || tipoDeDocumento== "m")
                {

                    int alto = IngresoDatos.Int("Ingrese el alto del mapa"); ;
                    int ancho = IngresoDatos.Int("Ingrese el ancho del mapa");

                    Entidades.Mapa mapa1 = new Entidades.Mapa(anio, autor, barcode, "", titulo, alto, ancho);
                    string texto = mapa1.ToString();
                    Console.WriteLine(texto);

                } 
                else
                {
                    Console.WriteLine("Vuelve a ingresar el tipo de documento");
                }
            }
        }
    }
}
