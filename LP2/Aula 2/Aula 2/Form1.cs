using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aula_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Label_name_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void btn_listar_Click(object sender, EventArgs e)
        {
            string msg = "", show = "";
            //msg = "Dados digitados:\n" + txt_nome.Text;
            if (chk_lp1.Checked == true)
            {
                msg += chk_lp1.Text + " - ";
            }
            if (chk_lp2.Checked == true)
            {
                msg += chk_lp2.Text + " - ";
            }
            if (chk_ed.Checked == true)
            {
                msg += chk_ed.Text;
            }

            show = "Pessoa: " + txt_nome.Text;
            show += "\nCursos: " + msg;
 
            MessageBox.Show(show);
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
