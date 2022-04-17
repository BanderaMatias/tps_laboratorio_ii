using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;

namespace MiCalculadora
{
    public partial class FormCalculadora : Form
    {
        public FormCalculadora()
        {
            InitializeComponent();
        }
        private void FormCalculadora_Load(object sender, EventArgs e)
        {
            Limpiar();
        }
        private void btnOperar_Click(object sender, EventArgs e)
        {
                lblResultado.Text = Operar(txtNumero1.Text, txtNumero2.Text, cmbOperadores.Text).ToString();
                lstOperaciones.Items.Add(txtNumero1.Text +" "+ cmbOperadores.Text+" "+txtNumero2.Text+" = "+lblResultado.Text);
        }
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnConvertirABinario_Click(object sender, EventArgs e)
        {
            lblResultado.Text = Operando.DecimalBinario(lblResultado.Text);
        }
        private void btnConvertirADecimal_Click(object sender, EventArgs e)
        {
            lblResultado.Text = Operando.BinarioDecimal(lblResultado.Text);
        }
        static double Operar(string numero1,string numero2,string operador)
        {
            char auxOperador;
            if (!char.TryParse(operador, out auxOperador)) auxOperador = ' ';    
            Operando n1 = new Operando(numero1);
            Operando n2 = new Operando(numero2);
            
            return Calculadora.Operar(n1,n2,auxOperador);
        }
        private void Limpiar()
        {
            cmbOperadores.Items.Clear();
            cmbOperadores.Items.Add(" ");
            cmbOperadores.Items.Add("+");
            cmbOperadores.Items.Add("-");
            cmbOperadores.Items.Add("*");
            cmbOperadores.Items.Add("/");
            txtNumero2.Text = "0";
            txtNumero1.Text = "0";
            lblResultado.Text = "0";
            
        }

        private void FormCalculadora_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult resultado = MessageBox.Show("¿Seguro que desea alir?","Salir",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if(resultado != DialogResult.Yes) e.Cancel = true;
        }

        
    }
}
