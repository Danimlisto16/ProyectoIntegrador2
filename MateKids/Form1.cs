using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace MateKids
{
    public partial class frmMateKids : MetroFramework.Forms.MetroForm

    {
        public frmMateKids()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


        private void pbxIcono_multiplicax_MouseEnter(object sender, EventArgs e)
        {
            pbxIcono_multiplicax.Size = new System.Drawing.Size(170, 148);

        }

        private void pbxIcono_multiplicax_MouseLeave(object sender, EventArgs e)
        {
            pbxIcono_multiplicax.Size = new System.Drawing.Size(155, 133);
        }

        private void agrandarIconosJuego()
        {
            foreach ( PictureBox icono in metroPanel1.Controls)
            {
                d
            }
        }

    }
}
