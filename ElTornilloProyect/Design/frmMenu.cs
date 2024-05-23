using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Design
{
    public partial class frmMenu : Form
    {

        

        public frmMenu()
        {
            InitializeComponent();

            // CUANDO EL FORMULARIO FMRLOGIN SE CIERRE SE GENERA EL EVENTO FORMCLOSED, EL METODO SE VA A EJECUTAR AUTOMATICAMENTE CADA VEZ QUE SE CIERRE EL PROGRAMA.
            this.FormClosed += frmMenu_FormClosed;
            
        }

        //SE USA LOS GETTERS PARA OBTENER LAS PROPIEDADES DE LOS BOTONES Y PODER MANIPULARLAS DESDE OTRA CLASE
        public Button btnAgAdmin {
            get { return this.btnAgregarAdmin; }
        }

        public Button btnAgVende
        {
            get { return this.btnAgregarVendedor; }
        }
        public Button btnAgProduc
        {
            get { return this.btnAgregarProduct; }
        }

        public Button btnModifiProduc
        {
            get { return this.btnModificarProduct; }
        }
        public Button btnCrearInforme
        {
            get { return this.btnInformes; }
        }
        public Button btnVerRegistVenta
        {
            get { return this.btnRegistroVentas; }
        }

        //ESTE METODO LO QUE HACE ES UN CONTROLADOR DE EVENTO, CUANDO SE PRECIONA LA X PARA CERRAR EL PROGRAMA SE GENERA EL METODO FORMCLOSED QUE ES PARA CERRAR COMPLETAMENTE EL PROGRAMA
        private void frmMenu_FormClosed(object sender, FormClosedEventArgs e)
        {
            // Cuando el formulario frmLogin se cierra, cierra la aplicación
            Application.Exit();
        }

        //ESTE METODO SE ENCARGA DE PONER EL FORM DENTRO DE EL PANEL, TAMBIEN CENTRARLO Y DESACTIVARLE LOS CONTROLES, NO PODER AGREAGAR MAS DE UNA VENTANA
        public void cargarVentana(object Form) {

            if (this.panelPrincipal.Controls.Count > 0) {
                this.panelPrincipal.Controls.RemoveAt(0);
                Form formP = Form as Form;

                // Deshabilitar bordes y controles del formulario
                formP.FormBorderStyle = FormBorderStyle.None;
                formP.ControlBox = false;
                formP.MaximizeBox = false;
                formP.MinimizeBox = false;

                
                formP.TopLevel = false;
                formP.Dock = DockStyle.Fill;
                this.panelPrincipal.Controls.Add(formP);
                //this.panelPrincipal.Tag = formP;
                formP.Show();
            }

        }

        private void btnAgregarAdmin_Click(object sender, EventArgs e)
        {
            cargarVentana(new frmAgregarAdmin());
        }

        private void btnCerrarSession_Click(object sender, EventArgs e)
        {
            frmLogin frmLogin = new frmLogin();
            frmLogin.Show();

            this.Hide();
            
        }

    }
}
