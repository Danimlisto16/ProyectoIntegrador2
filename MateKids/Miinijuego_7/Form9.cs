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
    public partial class Form9 : Form
    {
        int error = 0, intento, nventana, puntaje;

        int[] numeros;

        private void SiguienteDivision_Click(object sender, EventArgs e)
        {
            if (nventana == 5 || intento == 0)
            {
                Minijuego7 Ventana = new Minijuego7();
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
                Form_1 Ventana = new Form_1(numeros, intento, nventana, puntaje);
                Ventana.ShowDialog();
                this.Close();

            }
            if (numeros[num] == 2)
            {
                Form_2 Ventana = new Form_2(numeros, intento, nventana, puntaje);

                Ventana.ShowDialog();
                this.Close();

            }
            if (numeros[num] == 3)
            {
                Form3 Ventana = new Form3(numeros, intento, nventana, puntaje);

                Ventana.ShowDialog();
                this.Close();

            }
            if (numeros[num] == 4)
            {
                Form4 Ventana = new Form4(numeros, intento, nventana, puntaje);

                Ventana.ShowDialog();
                this.Close();

            }
            if (numeros[num] == 5)
            {
                Form5 Ventana = new Form5(numeros, intento, nventana, puntaje);

                Ventana.ShowDialog();
                this.Close();

            }
            if (numeros[num] == 6)
            {
                Form6 Ventana = new Form6(numeros, intento, nventana, puntaje);

                Ventana.ShowDialog();
                this.Close();

            }
            if (numeros[num] == 7)
            {
                Form7 Ventana = new Form7(numeros, intento, nventana, puntaje);

                Ventana.ShowDialog();
                this.Close();

            }
            if (numeros[num] == 8)
            {
                Form8 Ventana = new Form8(numeros, intento, nventana, puntaje);

                Ventana.ShowDialog();
                this.Close();

            }
            if (numeros[num] == 9)
            {
                Form9 Ventana = new Form9(numeros, intento, nventana, puntaje);

                Ventana.ShowDialog();
                this.Close();

            }
            if (numeros[num] == 10)
            {
                Form10 Ventana = new Form10(numeros, intento, nventana, puntaje);

                Ventana.ShowDialog();
                this.Close();

            }
        }
        private void Form9_Load(object sender, EventArgs e)
        {
            lblintentos.Text = "" + intento;
            lblpuntaje.Text = "" + puntaje;
        }
        public Form9(int[] numeros, int intento, int nventana, int puntaje)
        {
            InitializeComponent();
            this.numeros = numeros;
            this.intento = intento;
            this.nventana = nventana;
            this.puntaje = puntaje;
        }

        private void TerminarDivision_Click(object sender, EventArgs e)
        {
            int casilleros = 0;
            if ((mtb_div0.Text != "") && (mtb_div1.Text != "") && (mtb_div2.Text != "") && (mtb_div4.Text != "") && (mtb_div5.Text != "") && (mtb_div7.Text != "") && (mtb_div8.Text != "") && (mtb_div9.Text != "") && (mtb_res1.Text != "") && (mtb_res2.Text != ""))
            {


                if (mtb_res1.Text == "6")
                {
                    mtb_res1.Enabled = false;
                    //puntaje++;
                    casilleros++;
                }
                else
                {
                    mtb_res1.ForeColor = Color.Red;
                    error++;
                }

                if (mtb_res2.Text == "1")
                {
                    mtb_res2.Enabled = false;
                    //puntaje++;
                    casilleros++;
                }
                else
                {
                    mtb_res2.ForeColor = Color.Red;
                    error++;
                }

                if (mtb_div0.Text == "1")
                {
                    mtb_div0.Enabled = false;
                    //puntaje++;
                    casilleros++;
                }
                else
                {
                    mtb_div0.ForeColor = Color.Red;
                    error++;
                }

                if (mtb_div1.Text == "9")
                {
                    mtb_div1.Enabled = false;
                    //puntaje++;
                    casilleros++;
                }
                else
                {
                    mtb_div1.ForeColor = Color.Red;
                    error++;
                }

                if (mtb_div2.Text == "8")
                {
                    mtb_div2.Enabled = false;
                    //puntaje++;
                    casilleros++;
                }
                else
                {
                    mtb_div2.ForeColor = Color.Red;
                    error++;
                }



                if (mtb_div4.Text == "3")
                {
                    mtb_div4.Enabled = false;
                    //puntaje++;
                    casilleros++;
                }
                else
                {
                    mtb_div4.ForeColor = Color.Red;
                    error++;
                }

                if (mtb_div5.Text == "3")
                {
                    mtb_div5.Enabled = false;
                    //puntaje++;
                    casilleros++;
                }
                else
                {
                    mtb_div5.ForeColor = Color.Red;
                    error++;
                }


                if (mtb_div7.Text == "3")
                {
                    mtb_div7.Enabled = false;
                    //puntaje++;
                    casilleros++;
                }
                else
                {
                    mtb_div7.ForeColor = Color.Red;
                    error++;
                }

                if (mtb_div8.Text == "3")
                {
                    mtb_div8.Enabled = false;
                    //puntaje++;
                    casilleros++;
                }
                else
                {
                    mtb_div8.ForeColor = Color.Red;
                    error++;
                }

                if (mtb_div9.Text == "0")
                {
                    mtb_div9.Enabled = false;
                    //puntaje++;
                    casilleros++;
                }
                else
                {
                    mtb_div9.ForeColor = Color.Red;
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

    }
}
