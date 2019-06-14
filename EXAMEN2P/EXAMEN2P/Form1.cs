using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EXAMEN2P
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Llenar(comboBox1);
            Llenar(comboBox2);
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
        public void Llenar(ComboBox cb)
        {
            comboBox1.Items.Add("Ciencias Empresariales");

            comboBox1.Items.Add("Arquitectura E ingenieria");
            comboBox2.Items.Add("Ingenieria Industrial");
            comboBox2.Items.Add("Ingenieria de Sistemas");
            comboBox2.Items.Add("Ingenieria Produccion");
            comboBox2.Items.Add("Ingenieria Petrolera");
        }
    }
}
