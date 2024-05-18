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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();

            // CUANDO EL FORMULARIO FMRLOGIN SE CIERRE SE GENERA EL EVENTO FORMCLOSED, EL METODO SE VA A EJECUTAR AUTOMATICAMENTE CADA VEZ QUE SE CIERRE EL PROGRAMA.
            this.FormClosed += frmLogin_FormClosed;
        }

        //ESTE METODO LO QUE HACE ES UN CONTROLADOR DE EVENTO, CUANDO SE PRECIONA LA X PARA CERRAR EL PROGRAMA SE GENERA EL METODO FORMCLOSED QUE ES PARA CERRAR COMPLETAMENTE EL PROGRAMA
        private void frmLogin_FormClosed(object sender, FormClosedEventArgs e)
        {
            // Cuando el formulario frmLogin se cierra, cierra la aplicación
            Application.Exit();
        }

        private void btnIngresoLog_Click(object sender, EventArgs e)
        {
            frmMenu frmMenu = new frmMenu();
            frmMenu.Show();

            this.Hide();
        }
    }
}
