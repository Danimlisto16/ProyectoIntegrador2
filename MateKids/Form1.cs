using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Diagnostics;
using System.Threading.Tasks;
using System.Windows.Forms;
using MateKids.Minijuego_1;
using MateKids.Minijuego_6;
using MateKids.Miinijuego_7;
using MateKids.Minijuego_2;

namespace MateKids
{
    public partial class MenuSeleccion : MetroFramework.Forms.MetroForm

    {
        public MenuSeleccion()
        {
            InitializeComponent();
        }

        private void iniciar_minijuego( )
        {
            #region
                string minijuego_1 = "C://Users//wwwda//Desktop//ISOW//ISOW_4_C//PrograVisual//U2//juegoMultiplica//bin//Debug//juegoMultiplicar.exe";
            #endregion
            // Process.Start(minijuego_1);
            Minijuego1 minijuego = new Minijuego1();
            minijuego.ShowDialog();

        }

        private void pbxIcono_multiplicax_MouseEnter(object sender, EventArgs e)
        {
            icono_minijuego_1.Size = new System.Drawing.Size(170, 148);
        }

        private void pbxIcono_multiplicax_MouseLeave(object sender, EventArgs e)
        {
            icono_minijuego_1.Size = new System.Drawing.Size(155, 133);
        }

        private void icono_minijuego_1_Click(object sender, EventArgs e)
        {
            iniciar_minijuego();
        }

        private void icono_minijuego_2_Click(object sender, EventArgs e)
        {
            Minijuego2 minijuego = new Minijuego2();
            minijuego.ShowDialog();
        }

        private void icono_minijuego_6_MouseEnter(object sender, EventArgs e)
        {
            icono_minijuego_6.Size = new System.Drawing.Size(170, 148);
        }

        private void icono_minijuego_6_MouseLeave(object sender, EventArgs e)
        {
            icono_minijuego_6.Size = new System.Drawing.Size(155, 133);
        }

        private void icono_minijuego_6_Click(object sender, EventArgs e)
        {
            Minijuego6 minijuego = new Minijuego6();
            minijuego.ShowDialog();
        }

        private void icono_minijuego_7_MouseLeave(object sender, EventArgs e)
        {
            icono_minijuego_7.Size = new System.Drawing.Size(155, 133);
        }

        private void icono_minijuego_7_MouseEnter(object sender, EventArgs e)
        {
            icono_minijuego_7.Size = new System.Drawing.Size(170, 148);
        }

        private void icono_minijuego_7_Click(object sender, EventArgs e)
        {
            Minijuego7 minijuego = new Minijuego7();
            minijuego.ShowDialog();
        }

        private void icono_minijuego_2_MouseEnter(object sender, EventArgs e)
        {
            icono_minijuego_2.Size = new System.Drawing.Size(170, 148);
        }

        private void icono_minijuego_2_MouseLeave(object sender, EventArgs e)
        {
            icono_minijuego_2.Size = new System.Drawing.Size(155, 133);
        }
    }
}
