using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using WCFLogicaEscenasPelis.Models;

namespace WCFLogicaEscenasPelis.Repositories
{
    
    public class RepositoryEscenas
    {
        private XDocument document;
        public RepositoryEscenas()
        {
            //para leer el contenido de nuestro assembly(DLL) necesitamos el namespace del proyecto/carpeta/documento
            string resourceName = "WCFLogicaEscenasPelis.escenaspeliculas.xml";
            Stream stream = this.GetType().Assembly.GetManifestResourceStream(resourceName);
            this.document = XDocument.Load(stream);
        }
        public List<Escena> GetEscenas()
        {
            var consulta = from datos in document.Descendants("escena")
                           select new Escena()
                           {
                               IdEscena = int.Parse(datos.Attribute("idpelicula").Value), //Pelicula es un atributo no un elemento lo indicamos asi
                               TituloEscena = datos.Element("tituloescena").Value,
                               Descripcion = datos.Element("descripcion").Value,
                               Imagen = datos.Element("imagen").Value
                           };
            return consulta.ToList();
        }
        public Escena FindEscena(int idescena)
        {
            return this.GetEscenas().FirstOrDefault(x => x.IdEscena == idescena);
        }
    }
}
