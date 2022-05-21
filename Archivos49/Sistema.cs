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
            /* Creo variable de tipo Archivo */
            TextWriter archivo;

            /* La inicializo y la instancio. Digo que se va a llamar en la pc un archivo con este nombre "HolaMundo.txt" */
            archivo = new StreamWriter("HolaMundo.txt");

            string mensaje = Validador.ValidarStringNoVacio("Ingrese el texto que será guardado");

            archivo.WriteLine(mensaje);

            archivo.Close();

            Console.WriteLine("Se guardado el archivo " + "*" + mensaje + "*");
            
        }

        public void Iniciar()
        {
            MenuPrincipal();
        }
    }
}
