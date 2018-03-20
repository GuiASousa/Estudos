using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            String[] Lista = new String[3];
            Lista[0] = "Básico";
            Lista[1] = "Intermediário";
            Lista[2] = "Avançado";
            cmbo_niv.Items.AddRange(Lista);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string msg="",sexo="",estado="";

            if(rdio_masc.Checked == true)
                sexo = "\n" + rdio_masc.Text;
            else if (rdio_fem.Checked == true)
                sexo = "\n" + rdio_fem.Text;
            if (rdio_solt.Checked == true)
                estado = "\n" + rdio_solt.Text;
            else if (rdio_casa.Checked == true)
                estado = "\n" + rdio_casa.Text;
            else if (rdio_outros.Checked == true)
                estado = "\n" + rdio_outros.Text;
            
            msg = "Sexo: " + sexo + "\nEstado Civil: " + estado + "\nCurso: " + "\n" + cmbo_curso.Text;
            MessageBox.Show(msg, "Aviso");
        }

        private void rdio_fem_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void cmbo_curso_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
