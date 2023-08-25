using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculadoraIMC
{
    public partial class Form1 : Form
    {
        //atributos
        private double peso;
        private double altura;
        private double imc;

        
        public Form1()
        {
            InitializeComponent();
        }

        //metodo para limpar os dados caso usuário digite valor inválido
        private void limparDados()
        {
            tbPeso.Text = "";
            tbAltura.Text = "";
            peso = 0;
            altura = 0;
            rbtMabaixoPeso.Checked = false;
            rbtAbaixoPeso.Checked = false;
            rbtPesoIdeal.Checked = false;
            rbtAcimaPeso.Checked = false;
            rbtObesidadeI.Checked = false;
            rbtObesidadeII.Checked = false;
            rbtObesidadeIII.Checked = false;
        }
        
        //lendo os valores digitados pelo usuário e fazendo tratamento de erro
        private void lerValoresUsuario()
        {
            try
            {
                peso = Convert.ToDouble(tbPeso.Text);
                altura = Convert.ToDouble(tbAltura.Text);
            }
            catch (Exception)
            {
                MessageBox.Show(this, "Digite apenas números!");
                limparDados();
            }
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            
            lerValoresUsuario();

            //calculo IMC
            imc = peso / (altura * altura);

            //exibindo o IMC
            gpbIMC.Text = "IMC: " + imc.ToString();


            if (imc < 17)
            {
                rbtMabaixoPeso.Checked = true;
            }
            // se não é menor que 17, não faz sentido continuar testando essa mesma condição
            else if (imc <= 18.49)
            {
                rbtAbaixoPeso.Checked = true;
            }
            else if (imc <= 24.99)
            {
                rbtPesoIdeal.Checked = true;
            }
            else if(imc <= 29.99)
            {
                rbtAcimaPeso.Checked = true;
            }
            else if(imc <= 34.99)
            {
                rbtObesidadeI.Checked = true;
            }
            else if (imc <= 39.99)
            {
                rbtObesidadeII.Checked = true;
            }
            //sem esse teste com if, somente com else, vai ficar marcando o radioButton mesmo que seja digitado uma string, pois não entrou em nenhuma das condições anteriores
            else if(imc >= 40)
            {
                rbtObesidadeIII.Checked = true;
            }
        }
    }
}
