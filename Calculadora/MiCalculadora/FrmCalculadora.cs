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
    public partial class FrmCalculadora : Form
    {
        Calculadora myCalculadora = new Calculadora();
        //Numero myNumero1 = new Numero();
        //Numero myNumero2 = new Numero();

        public FrmCalculadora()
        {
            InitializeComponent();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            
            string message = "Desea salir del Formulario ?";
            string caption = "Salida";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result;

            // Muestra el Mensaje

            result = MessageBox.Show(message, caption, buttons);

            if (result == System.Windows.Forms.DialogResult.Yes)
            {

                // Cierra el formulatio
                //Application.Exit();
                Close();                
            }
        }

        private void FrmCalculadora_Load(object sender, EventArgs e)
        {
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;   
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void btnOperar_Click(object sender, EventArgs e)
        {
            //Validar que solo permita ingresar datos numéricos
            double AsignarNum1;
            if (!Double.TryParse(txtNumero1.Text,out AsignarNum1))
            {
                errorProvider.SetError(txtNumero1,"Debe ingresar un número");
                MessageBox.Show("Debe ingresar un número TexBox 1");
                txtNumero1.Focus();
                return;
            }
            errorProvider.SetError(txtNumero1, "");

            //Validar que solo permita ingresar datos numéricos
            double AsignarNum2;
            if (!Double.TryParse(txtNumero2.Text, out AsignarNum2))
            {
                errorProvider.SetError(txtNumero2, "Debe ingresar un número");
                MessageBox.Show("Debe ingresar un número TexBox 2");
                txtNumero2.Focus();
                return;
            }
            errorProvider.SetError(txtNumero1, "");

            double esperandoResultado = ResultadoOperar();
            lblResultado.Text =  esperandoResultado.ToString();
        }

        private void errorProvider1(TextBox txtNumero1, string p)
        {
            throw new NotImplementedException();
        }

        private void btnConvertirABinario_Click(object sender, EventArgs e)
        {
            lblResultado.Text = LlamarABinario();            
        }

        private void btnConvertirADecimal_Click(object sender, EventArgs e)
        {
            lblResultado.Text = LlamarADecimal();
        }
       
    }
}
