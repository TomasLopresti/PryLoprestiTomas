using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PryLoprestiTomas
{
    public class clsArchivo
    {
        public string NombreArchivo = "Archivo";

        public void Grabar()
        {
            StreamWriter AD = new StreamWriter(NombreArchivo, true);
            AD.WriteLine("hola");
            AD.Close();

        }

        public void Grabar(string DatoRecibido)
        {
            StreamWriter AD = new StreamWriter(NombreArchivo, true);
            AD.WriteLine(DatoRecibido);
            AD.Close();

        }

        public void Recorrer(ComboBox lista)
        {

        }

    }
   
}
