using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExerciciosCapitulo3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnExercicio1_Click(object sender, EventArgs e)
        {
            int idadeOtavio = 21;
            int idadeDani = 21;
            int idadeDuda = 20;

            float media = (idadeDani + idadeOtavio + idadeDani) / 3;

            MessageBox.Show("Média idades: " + media);

        }

        private void btnExercicio2_Click(object sender, EventArgs e)
        {
            //código não compila
            int pi = (int)3.14;

            MessageBox.Show(pi.ToString());
        }

        private void btnExercicio3_Click(object sender, EventArgs e)
        {
            double pi = 3.14;
            int piQuebrado = (int)pi;

            MessageBox.Show("piQuebrado	= " + piQuebrado);
        }
    }
}
