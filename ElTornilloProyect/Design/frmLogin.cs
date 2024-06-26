﻿using System;
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

            /*LO QUE HACE ESTA PARTE DEL CODIGO, ES GUARDAR EN LA VARIABLE TOKEN Y PASS, LO INGRESADO EN LOS CAMPOS TE TEXTO EN LOGIN.
             LUEGO ESO LO CONCATENA EN UNA VARIBALE SOLA SEPARADO POR UN : YA QUE EL SWITCH NO PERMITE EVALULAR DOS VARIABLES, LO CONCATENAMOS Y PERMITIMOS QUE EL SWITCH EVALUE 
             UNA VARIABLE SOLA, PERO DOS TEXTOS A LA MISMA VEZ PARA LOS CASOS.*/

            frmMenu frmMenu = new frmMenu();

            String token = txtTokenLogin.Text;
            String pass = txtPassLogin.Text;

            String combinacion = token + ":" + pass;

            switch (combinacion) {

                case "admin:123":

                    MessageBox.Show("Ingreso correcxto, Bienvenido Admin!", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    frmMenu.Show();

                    this.Hide();

                    break;

                case "encargado:123":

                    

                    MessageBox.Show("Ingreso correcxto, Bienvenido Encargado!", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    frmMenu.Show();

                    frmMenu.btnAgAdmin.Visible = false;

                    this.Hide();

                    break;

                case "vendedor:123":

                    MessageBox.Show("Ingreso correcxto, Bienvenido Vendedor!", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    frmMenu.Show();

                    frmMenu.btnAgAdmin.Visible = false;
                    frmMenu.btnAgVende.Visible = false;
                    frmMenu.btnAgProduc.Visible = false;
                    frmMenu.btnModifiProduc.Visible = false;
                    frmMenu.btnVerRegistVenta.Visible = false;
                    frmMenu.btnCrearInforme.Visible = false;

                    this.Hide();

                    break;

                default:

                    MessageBox.Show("Campos incorrectos o vacios, VERIFIQUE!","Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    break;

            }

        }

    }
}
