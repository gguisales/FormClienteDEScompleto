using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormClienteDES
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox13_TextChanged(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e) //botão limpar imagem    
        {
            pcbfoto.Image = null;
        }

        private void button6_Click(object sender, EventArgs e)  // botão sair
        {
            Application.Exit();
        }

        private void pcbfoto_Click(object sender, EventArgs e) // imagem
        {

        }

        private void button7_Click(object sender, EventArgs e) // botão carregar imagem
        {
            pcbfoto.Image = Properties.Resources.car_gc16599791_1280;        }

        private void button5_Click(object sender, EventArgs e) //botão limpar tudo
        {
            tb_bairro.Clear();
            tb_cep.Clear();
            tb_cidade.Clear();
            tb_codigo.Clear();
            tb_cpf.Clear();
            tb_email.Clear();
            tb_emailconst.Clear();
            tb_logradouro.Clear();
            tb_nome.Clear();
            tb_numero.Clear();
            tb_rg.Clear();
            tb_tel.Clear();
            tb_telresidencial.Clear();
            //radius
            rd_masc.Checked = false;
            rd_fem.Checked = false;
            rd_ndizer.Checked = false;
            //checkbox
            cb_const.Checked = false;
            cb_email.Checked = false;
            //image





        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void cb_email_CheckedChanged(object sender, EventArgs e)
        {
            tb_email.Focus();
        }

        private void cb_const_CheckedChanged(object sender, EventArgs e)
        {
            tb_emailconst.Focus();
        }

        private void tb_codigo_TextChanged(object sender, EventArgs e)
        {
          
        }

        private void button1_Click(object sender, EventArgs e) //botão incluir 
        {
            tb_codigo.Text = "4002";
            tb_bairro.Text = "casa da mãe joana";
            tb_cep.Text = "11750000";
            tb_cidade.Text = "perobas";
            tb_cpf.Text = "1111111";
            tb_email.Text = "flavimdopinas@gmail.com";
            tb_emailconst.Text = "flavimdopinas@etec.sp.gov";
            tb_logradouro.Text = "4555002";
            tb_nome.Text = "flavio nascimento";
            tb_numero.Text = "4002-8922";
            tb_rg.Text = "982983939-30";
            tb_tel.Text = "4002-0099";
            tb_telresidencial.Text = "3455-5555";
            //radius   
            rd_masc.Checked = true;
            //image
            pcbfoto.Image = Properties.Resources.car_gc16599791_1280;


        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show ("codigo:"+tb_codigo+"/n nome:"+tb_nome+"/n rg:"+tb_rg+"/n cpf:"+tb_cpf+ "/n tel-residencia:"+tb_telresidencial+ "/n tel:"+tb_tel+ "/n sexo:" +rd_masc+ "\n cep:" +tb_cep+"\n logradouro:" +tb_logradouro+ "\n numero:"+tb_numero+ "\n bairro:" +tb_bairro+ "\n cidade" +tb_cidade+ "\n email:"+tb_email+"\n emaisl continucional;"+tb_emailconst);
        }
    }
}
