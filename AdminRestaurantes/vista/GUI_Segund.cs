using AdminRestaurantes.codigo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdminRestaurantes.vista
{
    public partial class GUI_Segund : Form
    {
        Aplicacion aplicacion; 
        public GUI_Segund(Aplicacion pApliacacion)
        {
            InitializeComponent();
            aplicacion = pApliacacion;

            llenarComboBox();
        }

        public GUI_Segund()
        {
            InitializeComponent();

            
        }

        public void llenarComboBox()
        {
            cb_Restaurantes.Items.Clear();

            foreach (Restaurante restaurante in aplicacion.getListaRestaurante())
            {
                cb_Restaurantes.Items.Add(restaurante.getDireccion());
            }
            
        }

        private void cb_Restaurantes_SelectedIndexChanged(object sender, EventArgs e)
        {
            //cb_Restaurantes

            dgv_clientes.Rows.Clear();
           
            foreach (Restaurante restaurante in aplicacion.getListaRestaurante())
            {
                if (restaurante.getDireccion().Equals(cb_Restaurantes.Text))
                {
                    foreach(Cliente cliente in restaurante.getListaClientes())
                    {
                        dgv_clientes.Rows.Add(cliente.getNombre(), cliente.getSexo(),cliente.getDireccion());
                    }
                }
            }
        }
    }
}
