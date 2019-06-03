/*
 * Created by SharpDevelop.
 * User: Nelson Abreu
 * Date: 11/4/2007
 * Time: 10:32 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */

using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Windows.Forms;
using System.Text;

namespace Parcial1_JohnsielCastanos
{
    /// <summary>
    /// Description of NumericTextBox.
    /// </summary>
    [ToolboxBitmap(typeof(System.Windows.Forms.TextBox))]
    public class NumericTextBox : System.Windows.Forms.TextBox
    {
        private System.ComponentModel.Container components = null;
        private int precision = 0;
        private bool usarNegativos = true;
        private bool usarComas = false;
        private char sepDecimales = '.';
        private int cantidadDigitos = 50;
        public NumericTextBox()
        {
            InitializeComponent();
            this.TextAlign = HorizontalAlignment.Right;
            this.MaxLength = cantidadDigitos;
            this.KeyPress += new KeyPressEventHandler(NumericTextBox_KeyPress);
            this.LostFocus += new EventHandler(NumericTextBox_LostFocus);
            this.GotFocus += new EventHandler(NumericTextBox_GotFocus);
        }

        /// <summary> 
        /// Método requerido para soporte del designer. 
        /// No modificar los contenidos de este método
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();

        }

        /// <summary>
        /// Libera los recursos utilizados
        /// </summary>
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (components != null)
                {
                    components.Dispose();
                }
            }
            base.Dispose(disposing);
        }

        /// <summary>
        /// Especifica cuantos dígitos se aceptarán después del punto.
        /// </summary>
#if NETCFDESIGNTIME
  		[System.ComponentModel.Browsable(true)]
		[System.ComponentModel.Category("Numeric settings")]
		[System.ComponentModel.Description("La cantidad de digitos después del punto.")]
#endif
        /// <summary>
        ///  Permite indicar la cantidad de posiciones después del punto.
        /// </summary>
        public int Precision
        {
            get { return precision; }
            set
            {
                //Precision no puede ser negativa.
                if (value < 0)
                {
                    MessageBox.Show("La precisión no puede ser negativa.!", "Numeric TextBox", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                /*if ( value < this.NumericScaleOnFocus ) 
                {
                    this.NumericScaleOnFocus = value;
                }*/

                precision = value;
            } //set
        }
#if NETCFDESIGNTIME
  			[System.ComponentModel.Browsable(true)]
			[System.ComponentModel.Category("Numeric settings")]
			[System.ComponentModel.Description("Si permitirá introducir números negativos o no.")]
#endif
        public bool PermitirNumerosNegativos
        {
            set { usarNegativos = value; }
            get { return usarNegativos; }
        }
#if NETCFDESIGNTIME
			[System.ComponentModel.Browsable(true)]
			[System.ComponentModel.Category("Numeric settings")]
			[System.ComponentModel.Description("Permite el uso del separador de miles.")]
#endif
        public bool SeparadorMiles
        {
            get { return usarComas; }
            set { usarComas = value; }
        }

        private void NumericTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            string keyCharsPermitidos = "0123456789";
            string textoDigitado = this.Text.Trim().Replace(",", "");
            string decimales = string.Empty;

            if (precision > 0 && textoDigitado.IndexOf(".") < 0)
            {
                keyCharsPermitidos += this.sepDecimales.ToString();
            }
            if (PermitirNumerosNegativos && textoDigitado.IndexOf("-") < 0)
                keyCharsPermitidos += "-";

            //----
            // para verificar que no digiten mas digitos despues del punto que lo especificado
            // en el precision.
            //----------------------
            if (textoDigitado.IndexOf(sepDecimales) >= 0)
            {
                decimales = textoDigitado.Substring(textoDigitado.IndexOf(sepDecimales) + 1);
            }

            if (PermitirNumerosNegativos && e.KeyChar == '-' && this.SelectionStart > 0)
            {
                e.Handled = true;
                return;
            }
            if (decimales.Length == precision && (Keys)e.KeyChar != Keys.Back && this.SelectionStart > textoDigitado.IndexOf(sepDecimales) && precision > 0)
            {
                e.Handled = true;
                return;
            }
            if (keyCharsPermitidos.IndexOf(e.KeyChar) < 0 && (Keys)e.KeyChar != Keys.Back)
            {
                e.Handled = true;
                return;
            }
        }

        private void NumericTextBox_LostFocus(object sender, EventArgs e)
        {
            /*double valor = 0;
            StringBuilder zeros = new StringBuilder();
            string separador = string.Empty;
            if (this.SeparadorMiles)
                separador =",";
            for(int i=0; i< precision; i++)
            {
                zeros.Append("0");
            }
			
            if(IsNumeric(this.Text.Trim()))
            {
                valor = Convert.ToDouble(this.Text.Trim());
                this.Text = valor.ToString("#"+separador+"##0."+zeros.ToString()+";-#"+separador+"##0."+zeros.ToString()+";0."+zeros.ToString());
            }
            else
                this.Text = string.Empty;*/
            this.Text = GetTextFormatted();
        }

        protected string GetTextFormatted()
        {

            double valor = 0;
            StringBuilder zeros = new StringBuilder();
            string separador = string.Empty;
            if (this.SeparadorMiles)
                separador = ",";
            for (int i = 0; i < precision; i++)
            {
                zeros.Append("0");
            }

            if (IsNumeric(this.Text.Trim()))
            {
                valor = Convert.ToDouble(this.Text.Trim());
                return valor.ToString("#" + separador + "##0." + zeros.ToString() + ";-#" + separador + "##0." + zeros.ToString() + ";0." + zeros.ToString());
            }
            return string.Empty;
        }

        public string FormattedText
        {
            get { return GetTextFormatted(); }
        }

        private void NumericTextBox_GotFocus(object sender, EventArgs e)
        {
            this.Text = this.Text.Replace(",", "");
        }

        private bool IsNumeric(object Expression)
        {
            bool isNum;
            double retNum;

            isNum = Double.TryParse(Convert.ToString(Expression), System.Globalization.NumberStyles.Any, System.Globalization.NumberFormatInfo.InvariantInfo, out retNum);
            return isNum;
        }

    }
}
