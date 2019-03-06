using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Excecoes
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void HandleException(Exception e)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Message:");
            sb.AppendLine(e.Message);
            sb.AppendLine("StackTrace:");
            sb.AppendLine(e.StackTrace);
            sb.AppendLine("TargetSite:");
            sb.AppendLine(e.TargetSite.Name);
            sb.AppendLine("Source:");
            sb.AppendLine(e.Source);

            foreach (var v in e.Data.Values)
            {
                sb.AppendLine(v.ToString());
            }

            txtException.Text = sb.ToString();


        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            try
            {
                decimal peso = Convert.ToDecimal(txtPeso.Text);
                decimal altura = Convert.ToDecimal(txtAltura.Text);
                decimal imc = peso / (altura * altura);

                txtIMC.Text = imc.ToString();
            }
            catch (FormatException ex)
            {
                MessageBox.Show("Informe valores corretos para peso / altura");
                ex.Data.Add("ValorPeso", txtPeso.Text);
                ex.Data.Add("ValorAltura", txtAltura.Text);
                HandleException(ex);
            }
            catch (OverflowException ex)
            {
                MessageBox.Show("Valor muito grande para peso / altura");
                HandleException(ex);
            }
            catch (DivideByZeroException ex)
            {
                MessageBox.Show("Altura não pode ser 0");
                HandleException(ex);
            }
            catch (ArithmeticException ex)
            {
                MessageBox.Show("Erro aritmético, por favor verifique o calculo e tente novamente");
                HandleException(ex);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Não foi possível calcular o IMC " + ex.Message);
                HandleException(ex);
                ///throw;
            }
            finally
            {
                //sempre executado
                txtAltura.Clear();
                txtPeso.Clear();
            }
        }
    }
}
