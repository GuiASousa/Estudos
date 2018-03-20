using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aula_1
{
    public partial class main : Form
    {
        public main()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(txtbox.Text == "Batatas")
                MessageBox.Show("O texto não foi alterado: "+txtbox.Text, "Warning");
            else
                MessageBox.Show("Você mudou para: "+txtbox.Text, "Warning");
        }
    }
}
