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
    public partial class GUI_Venta : Form
    {
        GUI_AgregarCliente cliente;

        Restaurante restauranteT; //Tambien va ser el que se selecciono por comboBox

        public GUI_Venta(Restaurante pRestaurante) //Le pido que para poder crear una ventana venta 
                            //Necesita pasarle un parametro. Le pasaremos el restaurante, que la persona
                            //Oprimio en el combo box.
        {

            InitializeComponent();
            
            restauranteT = pRestaurante;

            //Apenas yo me cree una ventana venta, me realice este metodo.
            llenarDataGrid();

            MessageBox.Show("Hola");

        }

        private void btn_AgregarCliente_Click(object sender, EventArgs e)
        {
            cliente = new GUI_AgregarCliente(restauranteT, this);
            cliente.Show();
        }

        public void llenarComboBox()
        {
            //cb_Clientes

            cb_Clientes.Items.Clear();

            foreach(Cliente cliente in restauranteT.getListaClientes())
            {
                cb_Clientes.Items.Add(cliente.getNombre());
            }
        }

        public void llenarDataGrid()
        {

            foreach(String producto in restauranteT.getListaMenu())
            {
                dgv_Menu.Rows.Add(producto);
            }
        }

        
    }
}
