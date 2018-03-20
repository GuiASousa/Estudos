using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExercAV1
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
            Lista[0] = "Solteiro";
            Lista[1] = "Casado";
            Lista[2] = "Outros";
            cmb_estciv.Items.AddRange(Lista);

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton3_CheckedChanged_1(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btn_masc_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nome = "", msgm = "", sexo = "", estado = "", esco = "", idio = "";
            int v=1;
            nome = txt_cand.Text;
            if (rd_masc.Checked == false && rd_fem.Checked == false)
            {
                MessageBox.Show("Nada selecionado em sexo", "Erro");
                v = 0;
            }
            else
            {
                if (rd_masc.Checked == true)
                    sexo = rd_masc.Text;
                else
                    sexo = rd_fem.Text;
            }
            if (rd_sup.Checked == false && rd_pos.Checked == false)
            {
                MessageBox.Show("Nada selecionado em escolaridade", "Erro");
                v = 0;
            }
            else
            {
                if (rd_sup.Checked == true)
                    esco += rd_sup.Text;
                else
                    esco += rd_pos.Text;
            }
            if(chk_ing.Checked == false && chk_esp.Checked == false)
            {
                idio = "Nenhum";
            }
            else
            {
                if (chk_ing.Checked == true)
                    idio += chk_ing.Text;
                if (chk_esp.Checked == true)
                {
                    if (chk_ing.Checked == true)
                        idio += ", " + chk_esp.Text;
                    else
                        idio = chk_esp.Text;
                }
            }
            estado = cmb_estciv.Text;
            msgm = "Nome: " + nome + "\nEstado Civil: " + estado + "\nSexo: " + sexo + "\nEscolaridade: " + esco + "\nIdioma: " + idio;
            if(v==1)
                MessageBox.Show(msgm , "Digitado / Selecionado");
        }
    }
}
