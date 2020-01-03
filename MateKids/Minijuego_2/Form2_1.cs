using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MateKids.Minijuego_2
{
    public partial class Form2_1 : Form
    {
        int error = 0, intento, nventana, puntaje;
        int[] numeros;

        private void SiguienteDivision_Click(object sender, EventArgs e)
        {

            if (nventana == 5 || intento == 0)
            {
                Minijuego2 Ventana = new Minijuego2();
                this.Close();
                Ventana.Show();
            }
            else
            {

                ventanaSiguiente(nventana);

            }

        }
        private void ventanaSiguiente(int num)
        {
            if (numeros[num] == 1)
            {
                Form2_1 Ventana = new Form2_1(numeros, intento, nventana, puntaje);
                Ventana.ShowDialog();
                this.Close();

            }
            if (numeros[num] == 2)
            {
                Form2_2 Ventana = new Form2_2(numeros, intento, nventana, puntaje);

                Ventana.ShowDialog();
                this.Close();

            }
            if (numeros[num] == 3)
            {
                Form2_3 Ventana = new Form2_3(numeros, intento, nventana, puntaje);

                Ventana.ShowDialog();
                this.Close();

            }
            if (numeros[num] == 4)
            {
                Form2_4 Ventana = new Form2_4(numeros, intento, nventana, puntaje);

                Ventana.ShowDialog();
                this.Close();

            }
            if (numeros[num] == 5)
            {
                Form2_5 Ventana = new Form2_5(numeros, intento, nventana, puntaje);

                Ventana.ShowDialog();
                this.Close();

            }
            if (numeros[num] == 6)
            {
                Form2_6 Ventana = new Form2_6(numeros, intento, nventana, puntaje);

                Ventana.ShowDialog();
                this.Close();

            }
            if (numeros[num] == 7)
            {
                Form2_7 Ventana = new Form2_7(numeros, intento, nventana, puntaje);

                Ventana.ShowDialog();
                this.Close();

            }
            if (numeros[num] == 8)
            {
                Form2_8 Ventana = new Form2_8(numeros, intento, nventana, puntaje);

                Ventana.ShowDialog();
                this.Close();

            }
            if (numeros[num] == 9)
            {
                Form2_9 Ventana = new Form2_9(numeros, intento, nventana, puntaje);

                Ventana.ShowDialog();
                this.Close();

            }
            if (numeros[num] == 10)
            {
                Form2_10 Ventana = new Form2_10(numeros, intento, nventana, puntaje);

                Ventana.ShowDialog();
                this.Close();

            }
        }
        private void Form2_1_Load(object sender, EventArgs e)
        {
            lblintentos.Text = "" + intento;
            lblpuntaje.Text = "" + puntaje;
        }

        private void TerminarDivision_Click(object sender, EventArgs e)
        {
            int casilleros = 0;
            // if (intento!=0 && nventana!=5)
            if ((mtm_prod1_1.Text != "") && (mtm_prod1_2.Text != "") && (mtm_prod1_3.Text != "") && (mtm_prod1_4.Text != "") && (mtm_prod2_1.Text != "") && (mtm_prod2_2.Text != "") && (mtm_prod2_3.Text != "") && (mtm_res_1.Text != "") && (mtm_res_2.Text != "") && (mtm_res_3.Text != "") && (mtm_res_4.Text != ""))
            {


                if (mtm_res_1.Text == "2")
                {
                    mtm_res_1.Enabled = false;
                    //puntaje++;
                    casilleros++;

                }
                else
                {
                    mtm_res_1.ForeColor = Color.Red;
                    error++;
                }

                if (mtm_res_2.Text == "2")
                {
                    mtm_res_2.Enabled = false;
                    //puntaje++;
                    casilleros++;
                }
                else
                {
                    mtm_res_2.ForeColor = Color.Red;
                    error++;
                }

                if (mtm_res_3.Text == "0")
                {
                    mtm_res_3.Enabled = false;
                    //puntaje++;
                    casilleros++;

                }
                else
                {
                    mtm_res_3.ForeColor = Color.Red;
                    error++;
                }

                if (mtm_res_4.Text == "9")
                {
                    mtm_res_4.Enabled = false;
                    //puntaje++;
                    casilleros++;
                }
                else
                {
                    mtm_res_4.ForeColor = Color.Red;
                    error++;
                }

                if (mtm_prod2_1.Text == "4")
                {
                    mtm_prod2_1.Enabled = false;
                    //puntaje++;
                    casilleros++;
                }
                else
                {
                    mtm_prod2_1.ForeColor = Color.Red;
                    error++;
                }

                if (mtm_prod2_2.Text == "9")
                {
                    mtm_prod2_2.Enabled = false;
                    //puntaje++;
                    casilleros++;
                }
                else
                {
                    mtm_prod2_2.ForeColor = Color.Red;
                    error++;
                }

                if (mtm_prod2_3.Text == "6")
                {
                    mtm_prod2_3.Enabled = false;
                    //puntaje++;
                    casilleros++;
                }
                else
                {
                    mtm_prod2_3.ForeColor = Color.Red;
                    error++;
                }

                if (mtm_prod1_1.Text == "2")
                {
                    mtm_prod1_1.Enabled = false;
                    //puntaje++;
                    casilleros++;
                }
                else
                {
                    mtm_prod1_1.ForeColor = Color.Red;
                    error++;
                }

                if (mtm_prod1_2.Text == "8")
                {
                    mtm_prod1_2.Enabled = false;
                    //puntaje++;
                    casilleros++;
                }
                else
                {
                    mtm_prod1_2.ForeColor = Color.Red;
                    error++;
                }

                if (mtm_prod1_3.Text == "0")
                {
                    mtm_prod1_3.Enabled = false;
                    //puntaje++;
                    casilleros++;
                }
                else
                {
                    mtm_prod1_3.ForeColor = Color.Red;
                    error++;
                }

                if (mtm_prod1_4.Text == "2")
                {
                    mtm_prod1_4.Enabled = false;
                    //puntaje++;
                    casilleros++;
                }
                else
                {
                    mtm_prod1_4.ForeColor = Color.Red;
                    error++;
                }
                if (error == 0)
                {
                    MessageBox.Show("Felicidades lo haz hecho muy bien");
                    TerminarDivision.Enabled = false;
                    SiguienteDivision.Visible = true;
                    nventana++;
                    puntaje = puntaje + casilleros;
                    lblpuntaje.Text = "" + puntaje;
                    if (intento == 3 && nventana == 5)
                    {
                        SiguienteDivision.Text = "Terminar Juego";
                        MessageBox.Show("FELICITACIONES\n,Lo haz resuelto a la primera");
                        lblpuntaje.Text = "" + (puntaje + 5);
                    }

                }
                else
                {
                    intento--;
                    lblintentos.Text = "" + intento;
                    if (intento == 0)
                    {
                        puntaje = puntaje + casilleros;
                        lblpuntaje.Text = "" + puntaje;
                        //casilleros=;
                        MessageBox.Show("Te haz quedado sin intentos :C");
                    }
                    else
                    {
                        if (error == 1)
                        {
                            MessageBox.Show("Intentalo de nuevo \nTienes: " + error + " error");
                        }
                        else
                        {
                            MessageBox.Show("Intentalo de nuevo \nTienes: " + error + " errores");
                        }
                    }


                }
                if (nventana == 5)
                {

                    if (intento == 2)
                    {
                        MessageBox.Show("MUY BIEN\n, Haz resuelto todas las divisiones.");
                    }

                    if (intento == 1)
                    {
                        MessageBox.Show("Podemos hacerlo mejor\n, Intentalo de nuevo.");
                    }

                    SiguienteDivision.Text = "Terminar Juego";
                    SiguienteDivision.Visible = true;
                }
                if (intento == 0)
                {
                    TerminarDivision.Enabled = false;
                    MessageBox.Show("Intentalo de nuevo \n, Esta vez terminaremos todos los ejercicios  ;D");
                    SiguienteDivision.Text = "Terminar Juego";
                    SiguienteDivision.Visible = true;
                }
                error = 0;
            }
            else
            {
                MessageBox.Show("No te olvides de llenar todos los casilleros");
            }
        }

        public Form2_1(int[] numeros, int intento, int nventana, int puntaje)
        {
            InitializeComponent();
            this.numeros = numeros;
            this.intento = intento;
            this.nventana = nventana;
            this.puntaje = puntaje;
        }
    }
}
