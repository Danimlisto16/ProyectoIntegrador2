using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MateKids.Miinijuego_7
{
    public partial class Minijuego7 : Form
    {
        int intento = 3, nventana = 0, puntaje = 0;
        int[] numeros = new int[5];
        public Minijuego7()
        {
            InitializeComponent();
        }
        private void iniciar_minijuego_Click(object sender, EventArgs e)
        {

            ventanasAleatorias();
            ventanaSiguiente();
        }
        private void ventanasAleatorias()
        {
            Random r = new Random();

            for (int i = 0; i < 5; i++)
            {
                numeros[i] = r.Next(1, 11);

                if (i > 0)    // a partir del segundo numero que genera empezara a comparar que no se repita
                {
                    for (int x = 0; x < 50; x++)  //comprobara que no se repita por 50 veces
                    {

                        for (int j = 0; j < i; j++)
                        {
                            if (numeros[i] == numeros[j])
                            {
                                numeros[i] = r.Next(1, 11);
                            }
                        }
                    }
                }

            }

        }

        private void ventanaSiguiente()
        {
            if (numeros[0] == 1)
            {
                Form_1 Ventana = new Form_1(numeros, intento, nventana, puntaje);
                Ventana.ShowDialog();
                this.Hide();

            }
            if (numeros[0] == 2)
            {
                Form_2 Ventana = new Form_2(numeros, intento, nventana, puntaje);

                Ventana.ShowDialog();
                this.Hide();

            }
            if (numeros[0] == 3)
            {
                Form3 Ventana = new Form3(numeros, intento, nventana, puntaje);

                Ventana.ShowDialog();
                this.Hide();

            }
            if (numeros[0] == 4)
            {
                Form4 Ventana = new Form4(numeros, intento, nventana, puntaje);

                Ventana.ShowDialog();
                this.Hide();

            }
            if (numeros[0] == 5)
            {
                Form5 Ventana = new Form5(numeros, intento, nventana, puntaje);

                Ventana.ShowDialog();
                this.Hide();

            }
            if (numeros[0] == 6)
            {
                Form6 Ventana = new Form6(numeros, intento, nventana, puntaje);

                Ventana.ShowDialog();
                this.Hide();

            }
            if (numeros[0] == 7)
            {
                Form7 Ventana = new Form7(numeros, intento, nventana, puntaje);

                Ventana.ShowDialog();
                this.Hide();

            }
            if (numeros[0] == 8)
            {
                Form8 Ventana = new Form8(numeros, intento, nventana, puntaje);

                Ventana.ShowDialog();
                this.Hide();

            }
            if (numeros[0] == 9)
            {
                Form9 Ventana = new Form9(numeros, intento, nventana, puntaje);

                Ventana.ShowDialog();
                this.Hide();

            }
            if (numeros[0] == 10)
            {
                Form10 Ventana = new Form10(numeros, intento, nventana, puntaje);

                Ventana.ShowDialog();
                this.Hide();

            }
        }
    }
}
