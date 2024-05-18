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

        private void btnVolverInicio_Click(object sender, EventArgs e)
        {
            cargarVentana(new frmInicioLogo());
        }
    }
}
