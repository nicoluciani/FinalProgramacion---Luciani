using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Final_Programación_I_Nicolas_Luciani
{
    public partial class Form3 : Form
    {//declaro variables globales de precios
        static public int MotherGlobal;
        static public int RamGlobal;
        static public int MicroGlobal;
        static public int HddGlobal;
        static public int GabineteGlobal;
        static public int MonitorGlobal;
        static public int FuenteGlobal;
        static public int KitGlobal;
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {//lleno los combobox con las opciones de componentes
            cmbMother.Items.Add("Seleccione una Motherboard.");
            cmbMother.Items.Add("Mother MSI = $1400.");
            cmbMother.Items.Add("Mother AsRock = $800.");
            cmbMother.Items.Add("Mother Asus = $1200.");
            cmbMother.Items.Add("Mother Gigabyte = $1100.");
            cmbMother.SelectedItem = "Seleccione una Motherboard.";

            cmbRam.Items.Add("Seleccione una Memoria RAM.");
            cmbRam.Items.Add("RAM 2GB = $700.");
            cmbRam.Items.Add("RAM 4GB = $1050.");
            cmbRam.SelectedItem = "Seleccione una Memoria RAM.";

            cmbMicro.Items.Add("Seleccione un Microprocesador.");
            cmbMicro.Items.Add("Microprocesador Intel = $2400.");
            cmbMicro.Items.Add("Microprocesador AMD = $1800.");
            cmbMicro.SelectedItem = "Seleccione un Microprocesador.";

            cmbHdd.Items.Add("Seleccione un HDD.");
            cmbHdd.Items.Add("HDD 500GB = $900.");
            cmbHdd.Items.Add("HDD 1TB = $1200.");
            cmbHdd.SelectedItem = "Seleccione un HDD.";

            cmbGabinete.Items.Add("Seleccione un Gabinete.");
            cmbGabinete.Items.Add("Gabinete Económico = $700.");
            cmbGabinete.Items.Add("Gabinete Pro = $2500.");
            cmbGabinete.SelectedItem = "Seleccione un Gabinete.";

            cmbMonitor.Items.Add("Seleccione un Monitor.");
            cmbMonitor.Items.Add("Monitor 19” = $2900.");
            cmbMonitor.Items.Add("Monitor 22” = $3500.");
            cmbMonitor.SelectedItem = "Seleccione un Monitor.";
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            if (cmbMother.Text == "Seleccione una Motherboard.")
            { MessageBox.Show("Seleccione una Motherboard."); }

            else if (cmbRam.Text == "Seleccione una Memoria RAM.")
            { MessageBox.Show("Seleccione una Memoria RAM."); }

            else if (cmbMicro.Text == "Seleccione un Microprocesador.")
            { MessageBox.Show("Seleccione un Microprocesador."); }

            else if (cmbHdd.Text == "Seleccione un HDD.")
            { MessageBox.Show("Seleccione un HDD."); }

            else if (cmbGabinete.Text == "Seleccione un Gabinete.")
            { MessageBox.Show("Seleccione un Gabinete."); }

            else if (cmbMonitor.Text == "Seleccione un Monitor.")
            { MessageBox.Show("Seleccione un Monitor."); }

            else
            {//mensaje final que indica el costo de todo lo seleccionado
                KitGlobal = 300;
                FuenteGlobal = 500;
                MessageBox.Show("El costo total es: $" + (MotherGlobal += RamGlobal += MicroGlobal += HddGlobal += GabineteGlobal += MonitorGlobal += FuenteGlobal += KitGlobal));
            }
        }

        private void cmbMother_SelectedIndexChanged(object sender, EventArgs e)//precio dependiendo de que opcion elija
        {
            if (cmbMother.Text == "Mother MSI = $1400.")
            { MotherGlobal = 1400; }

            else if (cmbMother.Text == "Mother AsRock = $800.")
            { MotherGlobal = 800; }

            else if (cmbMother.Text == "Mother Asus = $1200.")
            { MotherGlobal = 1200; }

            else if (cmbMother.Text == "Mother Gigabyte = $1100.")
            { MotherGlobal = 1100; }
        }

        private void cmbRam_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbRam.Text == "RAM 2GB = $700.")
            { RamGlobal = 700; }

            else if (cmbRam.Text == "RAM 4GB = $1050.")
            { RamGlobal = 1050; }
        }

        private void cmbMicro_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbMicro.Text == "Microprocesador Intel = $2400.")
            { MicroGlobal = 2400; }

            else if (cmbMicro.Text == "Microprocesador AMD = $1800.")
            { MicroGlobal = 1800; }
        }

        private void cmbHdd_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbHdd.Text == "HDD 500GB = $900.")
            { HddGlobal = 900; }

            else if (cmbHdd.Text == "HDD 1TB = $1200.")
            { HddGlobal = 1200; }
        }

        private void cmbGabinete_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbGabinete.Text == "Gabinete Económico = $700.")
            { GabineteGlobal = 700; }

            else if (cmbGabinete.Text == "Gabinete Pro = $2500.")
            { GabineteGlobal = 2500; }
        }

        private void cmbMonitor_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbMonitor.Text == "Monitor 19” = $2900.")
            { MonitorGlobal = 2900; }

            else if (cmbMonitor.Text == "Monitor 22” = $3500.")
            { MonitorGlobal = 3500; }
        }
    }
}











