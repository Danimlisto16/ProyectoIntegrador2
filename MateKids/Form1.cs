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
            Process.Start(minijuego_1);
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
<<<<<<< HEAD
            iniciar_minijuego();
=======
            foreach ( PictureBox icono in metroPanel1.Controls)
            {
                
            }
>>>>>>> parent of 8ae9fd0... c1
        }
    }
}
