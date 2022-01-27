using AdminRestaurantes.codigo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdminRestaurantes.vista
{
    public partial class GUI_AgregarCliente : Form
    {
        Restaurante restaurante; //Por fin llego. Es el que la persona, selecciono por combox
        GUI_Venta venta;
        
        public GUI_AgregarCliente(Restaurante pRestaurante, GUI_Venta pVenta)
        {
            InitializeComponent();
            restaurante = pRestaurante;
            venta = pVenta;
        }

        private void btn_Agregar_Click(object sender, EventArgs e)
        {
            Cliente cliente;

            String nombre = txt_Nombre.Text;

            String sexo = null; 

            if (rb_Hombre.Checked == true)
            {
                sexo = "Hombre";
            }
            else if(rb_Mujer.Checked == true)
            {
                sexo = "Mujer";
            }

            String direccion = txt_Direccion.Text;

            if (txt_Direccion.Text.Equals(""))
            {
                cliente = new Cliente(nombre, sexo);
            }
            else
            {
                cliente = new Cliente(nombre, sexo,direccion);
            }

            restaurante.aniadirCliente(cliente);

            venta.llenarComboBox();

            MessageBox.Show("Cliente añadido al restaurante " + restaurante.getDireccion());

            limpiarEspacios();
        }

        public void limpiarEspacios()
        {

        }
    }
}
