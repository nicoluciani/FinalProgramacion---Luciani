using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;
using COMUN;

namespace Final_Programación_I_Nicolas_Luciani
{
    public partial class Form1 : Form
    {
        //declaro las variables globales para el usuario y la contraseña
        static public string UsuarioGlobal;
        static public string ContraseñaGlobal;
        public Form1()
        {
            InitializeComponent();
        }


        private void btnRegistro_Click(object sender, EventArgs e)
        {//abro el formulario de registro
            Form2 f2 = new Form2();
            this.Hide();
            f2.Show();
        }

        private void btnSesion_Click(object sender, EventArgs e)
        {
             if (txtUsuario.Text == "")//validacion de nombre de usuario
            { MessageBox.Show("Ingrese un nombre de usuario."); }

            else if (txtContraseña1.Text == "")//validacion de contraseña
            { MessageBox.Show("Ingrese una contraseña"); }

            if (txtUsuario.Text == UsuarioGlobal)
            {
                string pas = Encriptar(txtContraseña1.Text); //encriptacion de la contraseña
                if (pas == ContraseñaGlobal)
                {//abro el form de armado de pc
                    Form3 f3 = new Form3();
                    this.Hide();
                    f3.Show();
                }
                else
                {
                    MessageBox.Show("Password incorrecto");//error de contraseña
                    return;
                }
            }

            else
            {
                MessageBox.Show("Usuario incorrecto");//error de usuario
            }
        }
        static public string Encriptar(string passVista)//codigo para encriptar la contraseña
        {
            string passEncriptado; 
            passEncriptado = string.Empty;
            SHA512 sha512 = SHA512.Create();

            UTF8Encoding encoding = new UTF8Encoding();

            byte[] stream = null;
            StringBuilder sb = new StringBuilder();
            stream = sha512.ComputeHash(encoding.GetBytes(passVista));

            for (int i = 0; i < stream.Length; i++)
            {
                sb.AppendFormat("{0:x1}", stream[i]);
            }

            return passEncriptado = sb.ToString();
        }
    }
}

