using AdminRestaurantes.codigo;
using AdminRestaurantes.vista;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdminRestaurantes
{
    public partial class GUI_Principal : Form
    {
        //Intefaz
        GUI_Primera primera;
        GUI_Segund segunda;
        GUI_VentanaP vent;

        //Codigo
        Aplicacion aplicacion;
        public GUI_Principal()
        {
            InitializeComponent();

            aplicacion = new Aplicacion();

            primera = new GUI_Primera(aplicacion,this);
            segunda = new GUI_Segund();
            vent = new GUI_VentanaP();


            abrirVentana(vent);

        }

        public void ventanaParametro(Aplicacion pAplicacion)
        {

            segunda = new GUI_Segund(aplicacion);

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Aplicacion creada por Jorge");
        }

        private void btn_Primero_Click(object sender, EventArgs e)
        {
            abrirVentana(primera);
           
        }

        private void abrirVentana(Object ventana)
        {
            if(this.panel_Principal.Controls.Count > 0)
            {
                this.panel_Principal.Controls.RemoveAt(0);
            }

            Form fh = ventana as Form;

            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;

            this.panel_Principal.Controls.Add(fh);

            this.panel_Principal.Tag = fh;

            fh.Show();
        }

        private void btnSegunda_Click(object sender, EventArgs e)
        {
            abrirVentana(segunda);
        }

        private void btn_volver_Click(object sender, EventArgs e)
        {
            abrirVentana(vent);
        }
    }

    //<>
}
