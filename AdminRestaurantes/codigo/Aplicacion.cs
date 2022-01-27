using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace AdminRestaurantes.codigo
{
    public class Aplicacion //Esta clase la hacemos publica, ya que necesita ser mas visible, para poder pedir por parametro una aplicacion
    {
        String nombreCadenaRestaurante;

        List<Restaurante> restuarantes;

        public Aplicacion()
        {
            restuarantes = new List<Restaurante>();
        }

        public String getCadena()
        {
            return nombreCadenaRestaurante;
        }

        public List<Restaurante> getListaRestaurante()
        {
            return restuarantes;
        }

        public void agregarRestaurante(Restaurante restaurante)
        {
            restuarantes.Add(restaurante);
        }
    }
}
