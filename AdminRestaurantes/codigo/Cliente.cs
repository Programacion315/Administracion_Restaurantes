using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdminRestaurantes.codigo
{
    public class Cliente
    {
        private String nombre;
        private String sexo;
        private String direccion;

        public Cliente(String pNombre, String pSexo, String pDireccion)
        {
            nombre = pNombre;
            sexo = pSexo;
            direccion = pDireccion;
        }

        //Sobrecarga de constructores
        public Cliente(String pNombre, String pSexo)
        {
            nombre = pNombre;
            sexo = pSexo;
            
        }

        public String getNombre()
        {
            return nombre;
        }

        public String getSexo()
        {
            return sexo;
        }

        public String getDireccion()
        {
            return direccion;
        }
    }
}
