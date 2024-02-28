using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using COMUN;
using System.Security.Cryptography;
using System.IO;

namespace Final_Programación_I_Nicolas_Luciani
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btnRegistro_Click(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "")
            { MessageBox.Show("Ingrese un nombre de usuario."); }

            else if (txtContraseña.Text == "")
            { MessageBox.Show("Ingrese una contraseña"); }

            else if (txtConfirmar.Text == "")
            { MessageBox.Show("Confirme su contraseña"); }

            else if (txtConfirmar.Text != txtContraseña.Text)//validar que ambas contraseñas sean iguales
            { MessageBox.Show("Las contraseñas no son iguales"); }

            else
            {
                string contra = txtContraseña.Text;
                Form f1 = new Form1();//volver al form de inicio de sesion
                Form1.UsuarioGlobal = txtUsuario.Text;
                Form1.ContraseñaGlobal = encriptar(contra);
                this.Hide();
                f1.Show();

                StreamWriter File = new StreamWriter("Registro.txt");//registro de usuario y contraseña en documento de texto
                File.WriteLine("Usuario: " + Form1.UsuarioGlobal);
                File.WriteLine("Contraseña: " + Form1.ContraseñaGlobal);
                File.Close();
            }
        }
        static public string encriptar(string passVista)
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
