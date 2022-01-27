using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Configuration;
using System.Text;
using System.Threading.Tasks;

namespace AdminRestaurantes.codigo
{
    public class Restaurante
    {
        String direccion;

        List<String> menu = new List<string>();

        int capacidad;

        List<Cliente> clientes = new List<Cliente>();

        public Restaurante(String pDireccion, List<String> pMenu, int pCapacidad)
        {
            direccion = pDireccion;
            menu = pMenu;
            capacidad = pCapacidad;
        }

        public String getDireccion()
        {
            return direccion;
        }

        public int getCapacidad()
        {
            return capacidad;
        }

        public List<String> getListaMenu()
        {
            return menu;
        }

        public List<Cliente> getListaClientes()
        {
            return clientes;
        }

        public void entroPersona()
        {
            capacidad--;
        }

        public void salirPersona()
        {
            capacidad++;
        }

        public void aniadirCliente(Cliente cliente)
        {
            //Se toma un cliente por parametro, y se agregar a mi lista de clientes.
            clientes.Add(cliente);
        }
    }
}
//<>