using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Archivos49
{
    public class Sistema
    {
        public void MenuPrincipal()
        {
            Validador.Bienvenida();

            Console.Clear();
            /* Creo variable de tipo Archivo */
            TextWriter archivo;

            /* La inicializo y la instancio. Digo que se va a llamar en la pc un archivo con este nombre "HolaMundo.txt" */
            archivo = new StreamWriter("HolaMundo.txt");

            string mensaje = Validador.ValidarStringNoVacio("\n Ingrese el texto que será guardado");

            archivo.WriteLine(mensaje);

            archivo.Close();

            TextReader leerArchivo;
            leerArchivo = new StreamReader("HolaMundo.txt");

            Console.WriteLine("\n Usted guardo el archivo " + "\n *" + leerArchivo.ReadToEnd() + "*");

            leerArchivo.Close();

            Validador.Despedida();

            
            
        }

        public void Iniciar()
        {
            MenuPrincipal();
        }
    }
}
