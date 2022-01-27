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
    public partial class GUI_Primera : Form
    {

        GUI_AgregarRestaurante restaurante;
        GUI_Venta venta;

        Aplicacion aplicacion;

        GUI_Principal principal;

        public GUI_Primera(Aplicacion pAplicacion, GUI_Principal pPrincipal)
        {
            InitializeComponent();
            
            

            aplicacion = pAplicacion;

            llenarComboBox();

            principal = pPrincipal;

            
        }

        public void cambiarGuiSegunda()
        {
            principal.ventanaParametro(aplicacion);
        }

        private void btn_AgregarRestuarante_Click(object sender, EventArgs e)
        {
            restaurante = new GUI_AgregarRestaurante(aplicacion,this);
            restaurante.Show();
        }

        private void btn_GeneraVenta_Click(object sender, EventArgs e)
        {
            venta = new GUI_Venta(restauranteSeleccionadoPorCombobox());
            venta.Show();
            

        }

        public Restaurante restauranteSeleccionadoPorCombobox()
        {
            Restaurante restauranteUno = null;

            foreach (Restaurante restaurante in aplicacion.getListaRestaurante())
            {
                if (cb_Restuarantes.Text.Equals(restaurante.getDireccion()))
                {
                    return restaurante;
                }
            }

            return restauranteUno;

        }

        public void llenarComboBox()
        {
            //cb_Restuarantes

            cb_Restuarantes.Items.Clear();

            foreach (Restaurante restaurante in aplicacion.getListaRestaurante())
            {
                cb_Restuarantes.Items.Add(restaurante.getDireccion());
            }

        }

        private void cb_Restuarantes_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (Restaurante restaurante in aplicacion.getListaRestaurante())
            {
                if (cb_Restuarantes.Text.Equals(restaurante.getDireccion()))
                {
                    lbl_Direccion.Text = restaurante.getDireccion();
                    lbl_Capacidad.Text = restaurante.getCapacidad() + "";


                    foreach (String menu in restaurante.getListaMenu())
                    {
                        cb_Menu.Items.Clear();
                        cb_Menu.Items.Add(menu);
                    }
                }
                

            }



            //llenarComboBoxMenu();
        }

        private void btn_Entrar_Click(object sender, EventArgs e)
        {
            foreach(Restaurante restaurante in aplicacion.getListaRestaurante())
                //Recorre la lista de restaurantes en mi aplicacion
            {
                if (cb_Restuarantes.Text.Equals(restaurante.getDireccion()))
                    //Le pregunta a cada restaurante, segun en la iteracion de donde vaya,
                    //Si es igual a la opcion que oprimimos en el combo box

                    //Y si es igual
                {

                    if(restaurante.getCapacidad() == 0)
                    {
                        MessageBox.Show("No hay ninguna persona en el restaurante");
                    }
                    else
                    {
                        restaurante.entroPersona();

                        lbl_Capacidad.Text = restaurante.getCapacidad() + "";

                    }

                    
                }
            }
        }

        private void btn_Salir_Click(object sender, EventArgs e)
        {
            foreach (Restaurante restaurante in aplicacion.getListaRestaurante())
            //Recorre la lista de restaurantes en mi aplicacion
            {
                if (cb_Restuarantes.Text.Equals(restaurante.getDireccion()))
                //Le pregunta a cada restaurante, segun en la iteracion de donde vaya,
                //Si es igual a la opcion que oprimimos en el combo box

                //Y si es igual 
                {

                    //Si la capacidad es igual a la capacidad con la que empezo
                    restaurante.salirPersona();
                }
            }
        }

        private void llenarComboBoxMenu() //No se usa
        {
            foreach (Restaurante restaurante in aplicacion.getListaRestaurante())
            
            {
                if (cb_Restuarantes.Text.Equals(restaurante.getDireccion()))
               
                {
                    foreach(String menu in restaurante.getListaMenu())
                    {
                        cb_Menu.Items.Add(menu);
                    }
                }
            }

        }
    }
}
