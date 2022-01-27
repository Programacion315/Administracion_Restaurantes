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
    public partial class GUI_AgregarRestaurante : Form
    {
        Aplicacion aplicacion;

        GUI_Primera primera;
        public GUI_AgregarRestaurante(Aplicacion pAplicacion, GUI_Primera pPrimera)
        {
            InitializeComponent();
            aplicacion = pAplicacion;
            primera = pPrimera;
        }

        private void btn_Agregar_Click(object sender, EventArgs e)
        {
            String direccion = txt_Direccion.Text;

            List<String> menu = new List<String>();

            if(checkBox_Papas.Checked == true)
            {
                menu.Add("Papas");
            }

            if(checkBox_Palomitas.Checked == true)
            {
                menu.Add("Palomitas");
            }

            if(checkBox_Hamburguesa.Checked == true)
            {
                menu.Add("Hamburguesa");
            }

            if(checkBox_Helado.Checked == true)
            {
                menu.Add("Helado");
            }

            if (!txt_AgregarNuevo.Text.Equals(""))
            {
                menu.Add(txt_AgregarNuevo.Text);
            }

            int capacidad = Int32.Parse(txt_Capacidad.Text);

            Restaurante restaurante = new Restaurante(direccion,menu,capacidad);

            aplicacion.agregarRestaurante(restaurante);

            MessageBox.Show("Agregada con exito!!!");


            primera.llenarComboBox();

            limpiarCampos();

            primera.cambiarGuiSegunda();
            

        }

        private void limpiarCampos()
        {
            txt_Direccion.Text = "";
            txt_Capacidad.Text = "";
            checkBox_Papas.Checked = false;
            //Completar el resto
            txt_AgregarNuevo.Text = "";

        }
    }
}

//<>
