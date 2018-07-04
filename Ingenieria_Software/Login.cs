using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OracleClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ingenieria_Software.Entidades;
using System.Windows.Forms;

namespace Ingenieria_Software
{
    
        public partial class Login : Form
    {
        Dictionary<string, string> datos_login = new Dictionary<string, string>();

        public Login()
        {
            InitializeComponent();
            

        }
        

        private void button1_Click(object sender, EventArgs e)
        {
            datos_login = DAOOntour.DAO.Login(txtUser.Text, txtPass.Text);
            if (txtUser.Text == "admin")
            {
                ControladorEntidades.AlmacenarApoderados(DAOOntour.DAO.Obtener_apoderados());

                EjecutivoUI.Inicio inicio = new EjecutivoUI.Inicio();
                inicio.Show();
                this.Hide();
                return;
            }
            if (datos_login is null)
            {
                
                    MessageBox.Show("ERROR: Verifique Usuario o Contraseña");
            }
            else {
                MessageBox.Show("Conectado");
                // ControladorEntidades.AlmacenarApoderados(DAOOntour.DAO.Obtener_apoderados());
                ControladorEntidades.SesionUsuario(datos_login);
                EjecutivoUI.Inicio inicio = new EjecutivoUI.Inicio();
                inicio.Show();
                this.Hide();

            }

          

            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void linkLabel5_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Recuperar_Contraseña contraseña = new Recuperar_Contraseña();
            contraseña.Show();
            this.Hide();
        }
    }
}
